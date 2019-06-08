/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.INFOSiS.controller.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.ArrayList;
import pe.edu.pucp.INFOSiS.controller.config.DBManager;
import pe.edu.pucp.INFOSiS.model.bean.course.CourseType;

/**
 *
 * @author JEREMI
 */
public class MySQLCourseType {
    
    public int insert(CourseType coursetype){
        int result = 0;
        try{
            DBManager dbManager = DBManager.getdbManager();
            Connection con = DriverManager.getConnection(dbManager.getUrl(), dbManager.getUser(), dbManager.getPassword());
            CallableStatement cs = con.prepareCall("{call INSERT_COURSETYPE(?)}");
            cs.setString(1,coursetype.getName());
            cs.registerOutParameter("_idCourseType", java.sql.Types.INTEGER);
            result = cs.executeUpdate();
            int id = cs.getInt("idCourseType");
            coursetype.setId(id);
            con.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return 0;
    }
    
    public int update(CourseType coursetype){
        try{
            DBManager dbManager = DBManager.getdbManager();
            Connection con = DriverManager.getConnection(dbManager.getUrl(), dbManager.getUser(), dbManager.getPassword());
            String sql = "UPDATE Course_Category set name = ? where idCourse_Category = ?;";
            PreparedStatement ps = con.prepareStatement(sql);
            ps.setString(1,coursetype.getName());
            ps.setInt(2,coursetype.getId());
            ps.executeQuery();
            con.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return 1;
    }
    
    public ArrayList<CourseType> queryAll() throws SQLException{
        
        ArrayList<CourseType> courses = new ArrayList<CourseType>();
        try{
            DBManager dbManager = DBManager.getdbManager();
            Connection con = DriverManager.getConnection(dbManager.getUrl(), dbManager.getUser(), dbManager.getPassword());
            Statement sentence = con.createStatement();
            String sql = "SELECT * FROM Course_Category;";
            ResultSet rs = sentence.executeQuery(sql);
            while(rs.next()){
                CourseType c = new CourseType();
                c.setId(rs.getInt("idCourse_Category"));
                c.setName(rs.getString("name"));
                courses.add(c);
            }
            con.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return courses;
    }
}