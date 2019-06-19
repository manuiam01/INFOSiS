/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.INFOSiS.controller.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.Date;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.ArrayList;
import pe.edu.pucp.INFOSiS.controller.config.DBManager;
import pe.edu.pucp.INFOSiS.controller.dao.DAOInterested;
import pe.edu.pucp.INFOSiS.model.bean.HR.Intern;
import pe.edu.pucp.INFOSiS.model.bean.course.Course;
import pe.edu.pucp.INFOSiS.model.bean.course.CourseType;
import pe.edu.pucp.INFOSiS.model.bean.interested.Interested;

/**
 *
 * @author JEREMI
 */
public class MySQLInterested implements DAOInterested {
    
    public int insert(Interested interested){
        int result = 0;
        try{
            DBManager dbManager = DBManager.getdbManager();
            Connection con = DriverManager.getConnection(dbManager.getUrl(), dbManager.getUser(), dbManager.getPassword());
            CallableStatement cs = con.prepareCall("{call INSERT_INTERESTED(?,?,?,?,?,?,?,?,?)}");
            cs.setString(1,interested.getFirstName());
            cs.setString(2,interested.getPrimaryLastName());
            cs.setString(3,interested.getMiddleName());
            cs.setString(4,interested.getSecondLastName());
            cs.setString(5,interested.getGender());
            cs.setString(6,interested.getEmail());
            cs.setString(7,interested.getCellPhoneNumber());
            cs.setString(8,interested.getIdNumber());
            cs.setDate(9,(Date)interested.getRegDate());
            //cs.registerOutParameter("_idInterested", java.sql.Types.INTEGER);
            result = cs.executeUpdate();
            cs.close();
            //int id = cs.getInt("idInterested");
            //interested.setId(id);
            ArrayList<CourseType> courses = new ArrayList<CourseType>();
            courses = interested.getCourseTypes();
            String sql = "INSERT into InterestedxCourseType(idInterested,idCourseType) values (?,?);";
            for(CourseType c : courses){
                PreparedStatement ps = con.prepareStatement(sql);
                ps.setString(1,interested.getIdNumber());
                ps.setInt(2,c.getId());
                ps.execute();
            }
            con.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return result;
    }
    
    public int update(Interested interested){
        int result = 0;
        try{
            DBManager dbManager = DBManager.getdbManager();
            Connection con = DriverManager.getConnection(dbManager.getUrl(), dbManager.getUser(), dbManager.getPassword());
            //Cambio sus datos del interesado
            CallableStatement cs = con.prepareCall("{call UPDATE_INTERESTED(?,?,?,?,?,?,?)}");
            cs.setString(1,interested.getFirstName());
            cs.setString(2,interested.getPrimaryLastName());
            cs.setString(3,interested.getMiddleName());
            cs.setString(4,interested.getSecondLastName());
            cs.setString(5,interested.getEmail());
            cs.setString(6,interested.getCellPhoneNumber());
            cs.setString(7,interested.getIdNumber());
            result = cs.executeUpdate();
            
            //Borro su lista de cursos interesados antiguos
            CallableStatement cs2 = con.prepareCall("{call DELETE_INTERESTED_COURSES(?)}");
            cs2.setString(1,interested.getIdNumber());
            cs2.executeUpdate();
            ArrayList<CourseType> courses = new ArrayList<CourseType>();
            courses = interested.getCourseTypes();
            //Agrego los nuevos cursos del interesado
            String sql = "INSERT into InterestedxCourseType(idInterested,idCourse) values (?,?);";
            for(CourseType c : courses){
                PreparedStatement ps = con.prepareStatement(sql);
                ps.setString(1,interested.getIdNumber());
                ps.setInt(2,c.getId());
                ps.executeQuery();
            }
            con.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return result;
    }
    
    public int disable(Interested interested){
        int result = 0;
        try{
            DBManager dbManager = DBManager.getdbManager();
            Connection con = DriverManager.getConnection(dbManager.getUrl(), dbManager.getUser(), dbManager.getPassword());
            String sql = "UPDATE Interested set isUnsuscribed = ? where idNumber = ?;";
            PreparedStatement ps = con.prepareStatement(sql);
            ps.setInt(1,0);
            ps.setString(2,interested.getIdNumber());
            ps.executeQuery();
            con.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return 1;
    }
    
    public ArrayList<Interested> queryAll(){
        ArrayList<Interested> interested = new ArrayList<Interested>();
        try{
            DBManager dbManager = DBManager.getdbManager();
            Connection con = DriverManager.getConnection(dbManager.getUrl(), dbManager.getUser(), dbManager.getPassword());
            Statement sentence = con.createStatement();
            String query = "SELECT * FROM Interested";
            ResultSet rs = sentence.executeQuery(query);
            while(rs.next()){
                Interested inte = new Interested();
                inte.setIsUnsubscribed(rs.getBoolean("isUnsusbscribed"));
                inte.setFirstName(rs.getString("firstName"));
                inte.setMiddleName(rs.getString("middleName"));
                inte.setPrimaryLastName(rs.getString("primaryLastName"));
                inte.setSecondLastName(rs.getString("secondLastName"));
                inte.setGender(rs.getString("gender"));
                inte.setEmail(rs.getString("email"));
                inte.setEmailPUCP(rs.getString("emailPUCP"));
                inte.setCellPhoneNumber(rs.getString("cellPhoneNumber"));
                inte.setIdNumber(rs.getString("idNumber"));
                inte.setRegDate(rs.getDate("regDate"));
                if (!inte.isIsUnsubscribed()){
                    String query2 = "SELECT idCourse FROM InterestedxCourseType WHERE idInterested = ?";
                    PreparedStatement ps = con.prepareStatement(query2);
                    ps.setString(1,inte.getIdNumber());
                    ResultSet rs2 = ps.executeQuery();
                    while(rs2.next()){
                        Course crs = new Course();
                        crs.setId(rs2.getString("idCourse"));
                        String query3 = "SELECT * FROM Course WHERE idCourse= ?";
                        PreparedStatement ps2 = con.prepareStatement(query3);
                        ps2.setString(1,crs.getId());
                    }
                    interested.add(inte);
                }
            }
            con.close();
        }catch(SQLException ex){
            System.out.println(ex.getMessage());
        }    
        return interested;
    }
    
    public ArrayList<Interested> queryAllByCourseType(CourseType coursetype){
        ArrayList<Interested> interested = new ArrayList<Interested>();
        int idcoursetype = coursetype.getId();
        try{
            DBManager dbManager = DBManager.getdbManager();
            Connection con = DriverManager.getConnection(dbManager.getUrl(), dbManager.getUser(), dbManager.getPassword());
            Statement sentence = con.createStatement();
            String query = "SELECT * FROM Interested";
            ResultSet rs = sentence.executeQuery(query);
            while(rs.next()){
                Interested inte = new Interested();
                inte.setIsUnsubscribed(rs.getBoolean("isUnsusbscribed"));
                inte.setFirstName(rs.getString("firstName"));
                inte.setMiddleName(rs.getString("middleName"));
                inte.setPrimaryLastName(rs.getString("primaryLastName"));
                inte.setSecondLastName(rs.getString("secondLastName"));
                inte.setGender(rs.getString("gender"));
                inte.setEmail(rs.getString("email"));
                inte.setEmailPUCP(rs.getString("emailPUCP"));
                inte.setCellPhoneNumber(rs.getString("cellPhoneNumber"));
                inte.setIdNumber(rs.getString("idNumber"));
                inte.setRegDate(rs.getDate("regDate"));
                if (!inte.isIsUnsubscribed()){
                    String query2 = "SELECT * FROM InterestedxCourseType WHERE idNumber =?;";
                    ResultSet rs2 = sentence.executeQuery(query2);
                    while(rs.next()){
                        if(rs2.getInt("idCourseType")==idcoursetype){
                            interested.add(inte);
                            break;
                        }
                    }
                }
            }
            con.close();
        }catch(SQLException ex){
            System.out.println(ex.getMessage());
        }    
        return interested;
    }
}
