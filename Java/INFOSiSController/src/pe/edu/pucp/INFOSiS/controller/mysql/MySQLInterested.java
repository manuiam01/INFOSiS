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
    
    @Override
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
            cs.setInt(9,interested.getIdType());
            //cs.registerOutParameter("_idInterested", java.sql.Types.INTEGER);
            result = cs.executeUpdate();
            cs.close();
            //int id = cs.getInt("idInterested");
            //interested.setId(id);
            ArrayList<Course> courses = new ArrayList<Course>();
            courses = interested.getCourses();
            String sql = "INSERT into InterestedxCourseType(idInterested,idCourse) values (?,?);";
            for(Course c : courses){
                PreparedStatement ps = con.prepareStatement(sql);
                ps.setString(1,interested.getIdNumber());
                ps.setString(2,c.getId());
                ps.execute();
                ps.close();
            }
            con.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return result;
    }
    
    @Override
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
            cs.close();
            //Borro su lista de cursos interesados antiguos
            CallableStatement cs2 = con.prepareCall("{call DELETE_INTERESTED_COURSES(?)}");
            cs2.setString(1,interested.getIdNumber());
            cs2.executeUpdate();
            ArrayList<Course> courses = new ArrayList<Course>();
            courses = interested.getCourses();
            //Agrego los nuevos cursos del interesado
            String sql = "INSERT into InterestedxCourseType(idInterested,idCourse) values (?,?);";
            for(Course c : courses){
                PreparedStatement ps = con.prepareStatement(sql);
                ps.setString(1,interested.getIdNumber());
                ps.setString(2,c.getId());
                ps.executeUpdate();
                ps.close();
            }
            cs2.close();
            con.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return result;
    }
    
    @Override
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
            ps.close();
            con.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return 1;
    }
    
    @Override
    public ArrayList<Interested> queryAllInterested(){
        ArrayList<Interested> interested = new ArrayList<Interested>();
        try{
            DBManager dbManager = DBManager.getdbManager();
            Connection con = DriverManager.getConnection(dbManager.getUrl(), dbManager.getUser(), dbManager.getPassword());
            Statement sentence = con.createStatement();
            String query = "SELECT * FROM Interested";
            ResultSet rs = sentence.executeQuery(query);
            while(rs.next()){
                Interested inte = new Interested();
                inte.setIsUnsubscribed(rs.getBoolean("isUnsuscribed"));
                inte.setFirstName(rs.getString("firstName"));
                inte.setMiddleName(rs.getString("middleName"));
                inte.setPrimaryLastName(rs.getString("primaryLastName"));
                inte.setSecondLastName(rs.getString("secondLastName"));
                inte.setGender(rs.getString("gender"));
                inte.setEmail(rs.getString("email"));
                inte.setCellPhoneNumber(rs.getString("cellPhoneNumber"));
                inte.setIdNumber(rs.getString("idNumber"));
                inte.setRegDate(rs.getDate("regDate"));
                inte.setIdType(rs.getInt("idNumberType"));
                String query2 = "SELECT idCourse FROM InterestedxCourseType WHERE idInterested = ?";
                PreparedStatement ps = con.prepareStatement(query2);
                ps.setString(1,inte.getIdNumber());
                ResultSet rs2 = ps.executeQuery();
                ArrayList<Course> courses = new ArrayList<Course>();
                while(rs2.next()){
                    Course crs = new Course();
                    crs.setId(rs2.getString("idCourse"));
                    String query3 = "SELECT * FROM Course WHERE idCourse= ?";
                    PreparedStatement ps2 = con.prepareStatement(query3);
                    ps2.setString(1,crs.getId());
                    ResultSet rs3 = ps2.executeQuery();
                    while(rs3.next()){
                        crs.setDescription(rs3.getString("description"));
                        crs.setIsActive(rs3.getBoolean("isActive"));
                        crs.setName(rs3.getString("name"));
                        courses.add(crs);
                    }
                    rs3.close();
                }
                ps.close();
                rs2.close();
                inte.setCourses(courses);
                interested.add(inte);
            }
            rs.close();
            con.close();
        }catch(SQLException ex){
            System.out.println(ex.getMessage());
        }    
        return interested;
    }
    
    @Override
    public ArrayList<Interested> queryAllActiveInterested(){
        ArrayList<Interested> interested = new ArrayList<Interested>();
        try{
            DBManager dbManager = DBManager.getdbManager();
            Connection con = DriverManager.getConnection(dbManager.getUrl(), dbManager.getUser(), dbManager.getPassword());
            Statement sentence = con.createStatement();
            String query = "SELECT * FROM Interested";
            ResultSet rs = sentence.executeQuery(query);
            while(rs.next()){
                Interested inte = new Interested();
                inte.setIsUnsubscribed(rs.getBoolean("isUnsuscribed"));
                inte.setFirstName(rs.getString("firstName"));
                inte.setMiddleName(rs.getString("middleName"));
                inte.setPrimaryLastName(rs.getString("primaryLastName"));
                inte.setSecondLastName(rs.getString("secondLastName"));
                inte.setGender(rs.getString("gender"));
                inte.setEmail(rs.getString("email"));
                inte.setCellPhoneNumber(rs.getString("cellPhoneNumber"));
                inte.setIdNumber(rs.getString("idNumber"));
                inte.setRegDate(rs.getDate("regDate"));
                inte.setIdType(rs.getInt("idNumberType"));
                if (!inte.isIsUnsubscribed()){
                    String query2 = "SELECT idCourse FROM InterestedxCourseType WHERE idInterested = ?";
                    PreparedStatement ps = con.prepareStatement(query2);
                    ps.setString(1,inte.getIdNumber());
                    ResultSet rs2 = ps.executeQuery();
                    ArrayList<Course> courses = new ArrayList<Course>();
                    while(rs2.next()){
                        Course crs = new Course();
                        crs.setId(rs2.getString("idCourse"));
                        String query3 = "SELECT * FROM Course WHERE idCourse= ?";
                        PreparedStatement ps2 = con.prepareStatement(query3);
                        ps2.setString(1,crs.getId());
                        ResultSet rs3 = ps2.executeQuery();
                        while(rs3.next()){
                            crs.setDescription(rs3.getString("description"));
                            crs.setIsActive(rs3.getBoolean("isActive"));
                            crs.setName(rs3.getString("name"));
                            courses.add(crs);
                        }
                        ps.close();
                        rs3.close();
                    }
                    rs2.close();
                    inte.setCourses(courses);
                    interested.add(inte);
                }
            }
            rs.close();
            con.close();
        }catch(SQLException ex){
            System.out.println(ex.getMessage());
        }    
        return interested;
    }
    @Override
    public ArrayList<Interested> queryAllByCourseType(Course course){
        ArrayList<Interested> interested = new ArrayList<Interested>();
        String idcourse = course.getId();
        try{
            DBManager dbManager = DBManager.getdbManager();
            Connection con = DriverManager.getConnection(dbManager.getUrl(), dbManager.getUser(), dbManager.getPassword());
            Statement sentence = con.createStatement();
            String query = "SELECT * FROM Interested";
            ResultSet rs = sentence.executeQuery(query);
            while(rs.next()){
                Interested inte = new Interested();
                inte.setIsUnsubscribed(rs.getBoolean("isUnsuscribed"));
                inte.setFirstName(rs.getString("firstName"));
                inte.setMiddleName(rs.getString("middleName"));
                inte.setPrimaryLastName(rs.getString("primaryLastName"));
                inte.setSecondLastName(rs.getString("secondLastName"));
                inte.setGender(rs.getString("gender"));
                inte.setEmail(rs.getString("email"));
                inte.setCellPhoneNumber(rs.getString("cellPhoneNumber"));
                inte.setIdNumber(rs.getString("idNumber"));
                inte.setRegDate(rs.getDate("regDate"));
                inte.setIdType(rs.getInt("idNumberType"));
                if (!inte.isIsUnsubscribed()){
                    String query2 = "SELECT * FROM InterestedxCourseType WHERE idInterested = ?;";
                    PreparedStatement ps = con.prepareStatement(query2);
                    ps.setString(1,inte.getIdNumber());
                    ResultSet rs2 = ps.executeQuery();
                    ArrayList<Course> courses = new ArrayList<Course>();
                    while(rs2.next()){
                        Course crs = new Course();
                        crs.setId(rs2.getString("idCourse"));
                        String query3 = "SELECT * FROM Course WHERE idCourse= ?";
                        PreparedStatement ps2 = con.prepareStatement(query3);
                        ps2.setString(1,crs.getId());
                        ResultSet rs3 = ps2.executeQuery();
                        while(rs3.next()){
                            crs.setDescription(rs3.getString("description"));
                            crs.setIsActive(rs3.getBoolean("isActive"));
                            crs.setName(rs3.getString("name"));
                            courses.add(crs);
                        }
                        ps2.close();
                        rs3.close();
                    }
                    rs2.close();
                    inte.setCourses(courses);
                    for(Course c : courses){
                        if(c.getId().equals(idcourse)){
                            interested.add(inte);
                            break;
                        }
                    }
                    ps.close();
                }
            }
            rs.close();
            con.close();
        }catch(SQLException ex){
            System.out.println(ex.getMessage());
        }    
        return interested;
    }
    @Override
    public Interested queryInterestedById(String interestedID){
        Interested interested=new Interested();
        interested.setIdNumber("NULL");
//        interested.setCellPhoneNumber("NULL");
//        interested.setEmail("NULL");
//        interested.setFirstName("NULL");
//        interested.setMiddleName("NULL");
//        interested.setPrimaryLastName("NULL");
//        interested.setSecondLastName("NULL");
//        interested.setGender("N");
//        interested.setIdType(-1);
//        interested.setIsUnsubscribed(false);
//        SimpleDateFormat formatter = new SimpleDateFormat("dd/MM/yyyy");
//        String dateInString = "07/06/2013";
//        java.sql.Date sqlDate = java.sql.Date.valueOf(LocalDate.now());
//        interested.setRegDate(sqlDate);
        try{
            DBManager dbManager = DBManager.getdbManager();
            Connection con = DriverManager.getConnection(dbManager.getUrl(), dbManager.getUser(), dbManager.getPassword());
            Statement sentence = con.createStatement();
            String query = "SELECT * FROM Interested WHERE idNumber='"+interestedID+"'";
            ResultSet rs = sentence.executeQuery(query);
            while(rs.next()){
                interested.setIdNumber(rs.getString("idNumber"));
                interested.setIdType(rs.getInt("idNumberType"));
                interested.setFirstName(rs.getString("firstName"));
                interested.setSecondLastName(rs.getString("secondLastName"));
                interested.setMiddleName(rs.getString("middleName"));
                interested.setPrimaryLastName(rs.getString("primaryLastName"));
                interested.setIsUnsubscribed(rs.getInt("isUnsuscribed")==1);
                interested.setCellPhoneNumber(rs.getString("cellPhoneNumber"));
                interested.setEmail(rs.getString("email"));
            }
            rs.close();
            con.close();
        }
        catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        
        return interested;
    }    
    

    @Override
    public ArrayList<Interested> search_by_name(String name, String middle_name,
            String first_last_name, String second_last_name) {
        ArrayList<Interested> interesteds = new ArrayList<Interested>();
        try{
            DBManager dbManager = DBManager.getdbManager();
            Connection con = DriverManager.getConnection(dbManager.getUrl(), dbManager.getUser(), dbManager.getPassword());
            CallableStatement cs = con.prepareCall("{call SEARCH_INTERESTED_BY_NAME(?,?,?,?)}");
            cs.setString(1, name);
            cs.setString(2, middle_name);
            cs.setString(3, first_last_name);
            cs.setString(4, second_last_name);
            ResultSet rs = cs.executeQuery();
            while(rs.next()){
                Interested interested = new Interested();
                interested.setIdNumber(rs.getString("idNumber"));
                interested.setIdType(rs.getInt("idNumberType"));
                interested.setFirstName(rs.getString("firstName"));
                interested.setMiddleName(rs.getString("middleName"));
                interested.setPrimaryLastName(rs.getString("primaryLastName"));
                interested.setSecondLastName(rs.getString("secondLastName"));
                interested.setGender(rs.getString("gender"));
                interested.setEmail(rs.getString("email"));
                interested.setCellPhoneNumber(rs.getString("cellPhoneNumber"));
                interested.setIsUnsubscribed(rs.getBoolean("isUnsuscribed"));
                String query2 = "SELECT idCourse FROM InterestedxCourseType WHERE idInterested = ?";
                PreparedStatement ps = con.prepareStatement(query2);
                ps.setString(1,interested.getIdNumber());
                ResultSet rs2 = ps.executeQuery();
                ArrayList<Course> courses = new ArrayList<Course>();
                while(rs2.next()){
                    Course crs = new Course();
                    crs.setId(rs2.getString("idCourse"));
                    String query3 = "SELECT * FROM Course WHERE idCourse= ?";
                    PreparedStatement ps2 = con.prepareStatement(query3);
                    ps2.setString(1,crs.getId());
                    ResultSet rs3 = ps2.executeQuery();
                    while(rs3.next()){
                        crs.setDescription(rs3.getString("description"));
                        crs.setIsActive(rs3.getBoolean("isActive"));
                        crs.setName(rs3.getString("name"));
                        courses.add(crs);
                    }
                    rs3.close();
                }
                interested.setCourses(courses);
            }            
            con.close();
        }catch(SQLException ex){
            System.out.println(ex.getMessage());
        }        
        return interesteds;
    }

}
