/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.INFOSiS.controller.mysql;

import java.nio.file.Files;
import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.edu.pucp.INFOSiS.controller.config.DBManager;
import pe.edu.pucp.INFOSiS.controller.dao.DAOCourse;
import pe.edu.pucp.INFOSiS.model.bean.course.Course;

/**
 *
 * @author tkuser
 */
public class MySQLCourse implements DAOCourse {
    @Override
    public int insert(Course course){
        int result = 0;
        try{
            DBManager dbManager = DBManager.getdbManager();
            Connection con = DriverManager.getConnection(dbManager.getUrl(), dbManager.getUser(), dbManager.getPassword());
            CallableStatement cs = con.prepareCall("{call INSERT_COURSE(?,?,?,?,?)}");
            cs.setString(1,course.getId());
            cs.setString(2,course.getName());
            cs.setBoolean(3,course.getIsActive());
            cs.setString(4,course.getDescription());
            cs.setBytes(5,course.getSyllabus());
            result = cs.executeUpdate();
            con.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return result;
    }
    @Override
    public int update (Course course){
        int result = 0;
        try{
            DBManager dbManager = DBManager.getdbManager();
            Connection con = DriverManager.getConnection(dbManager.getUrl(), dbManager.getUser(), dbManager.getPassword());
            CallableStatement cs = con.prepareCall("{call UPDATE_COURSE(?,?,?,?,?)}");
            cs.setString(5,course.getId());
            cs.setString(1,course.getName());
            cs.setBoolean(2,course.getIsActive());
            cs.setString(3,course.getDescription());
            cs.setBytes(4,course.getSyllabus());
            result = cs.executeUpdate();
            con.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        
        return result;
        
    }

    @Override
    public int disable(Course course) {
        int result = 0;
        try{
            course.setIsActive(false);          
            DBManager dbManager = DBManager.getdbManager();
            Connection con = DriverManager.getConnection(dbManager.getUrl(), dbManager.getUser(), dbManager.getPassword());
            CallableStatement cs = con.prepareCall("{call UPDATE_COURSE(?,?,?,?,?)}");
            cs.setString(5,course.getId());
            cs.setString(1,course.getName());
            cs.setBoolean(2,course.getIsActive());
            cs.setString(3,course.getDescription());
            cs.setBytes(4,course.getSyllabus());
            result = cs.executeUpdate();
            con.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return result;
    }

    @Override
    public ArrayList<Course> queryAll() {
        ArrayList<Course> courses = new ArrayList<>();
        try{
            DBManager dbManager = DBManager.getdbManager();
            Connection con = DriverManager.getConnection(dbManager.getUrl(), dbManager.getUser(), dbManager.getPassword());
            CallableStatement cs = con.prepareCall("{call LIST_COURSES()}");
            ResultSet rs = cs.executeQuery();
            while(rs.next()){
                Course c = new Course();
                c.setId(rs.getString(1));
                c.setName(rs.getString(2));
                c.setIsActive(rs.getBoolean(3));
                c.setDescription(rs.getString(4));
                c.setSyllabus(rs.getBytes(5));              
                courses.add(c);
            }            
            con.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return courses;
    }

    @Override
    public Course queryById(String id) {
        Course c = new Course();
        try{
            DBManager dbManager = DBManager.getdbManager();
            Connection con = DriverManager.getConnection(dbManager.getUrl(), dbManager.getUser(), dbManager.getPassword());
            CallableStatement cs = con.prepareCall("{call COURSE_BY_ID(?)}");
            cs.setString(1, id);
            ResultSet rs = cs.executeQuery();
            while(rs.next()){
                c.setId(rs.getString(1));
                c.setName(rs.getString(2));
                c.setIsActive(rs.getBoolean(3));
                c.setDescription(rs.getString(4));
                c.setSyllabus(rs.getBytes(5));                            
            }            
            con.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return c;
    }

    @Override
    public ArrayList<Course> queryByName(String name) {
        ArrayList<Course> courses = new ArrayList<>();
        try{
            DBManager dbManager = DBManager.getdbManager();
            Connection con = DriverManager.getConnection(dbManager.getUrl(), dbManager.getUser(), dbManager.getPassword());
            CallableStatement cs = con.prepareCall("{call COURSES_BY_NAME(?)}");
            cs.setString(1, name);
            ResultSet rs = cs.executeQuery();
            while(rs.next()){
                Course c = new Course();
                c.setId(rs.getString(1));
                c.setName(rs.getString(2));
                c.setIsActive(rs.getBoolean(3));
                c.setDescription(rs.getString(4));
                c.setSyllabus(rs.getBytes(5));              
                courses.add(c);
            }            
            con.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return courses;
    }
}
