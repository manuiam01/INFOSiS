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
import pe.edu.pucp.INFOSiS.controller.dao.DAOCourseType;
import pe.edu.pucp.INFOSiS.model.bean.course.CourseType;

/**
 *
 * @author JEREMI
 */
public class MySQLCourseType implements DAOCourseType{
    
    @Override
    public int insert(CourseType coursetype){
        int result = 0;
        try{
            DBManager dbManager = DBManager.getdbManager();
            Connection con = DriverManager.getConnection(dbManager.getUrl(), dbManager.getUser(), dbManager.getPassword());
            CallableStatement cs = con.prepareCall("{call INSERT_COURSETYPE(?)}");
            cs.setString(1,coursetype.getName());
            cs.registerOutParameter("_idCourseType", java.sql.Types.INTEGER);
            result = cs.executeUpdate();
            int id = cs.getInt("_idCourseType");
            coursetype.setId(id);
            con.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return 0;
    }
    
    @Override
    public int update(CourseType coursetype){
        int result = 0;
        try{
            DBManager dbManager = DBManager.getdbManager();
            Connection con = DriverManager.getConnection(dbManager.getUrl(), dbManager.getUser(), dbManager.getPassword());
            CallableStatement cs = con.prepareCall("{call UPDATE_COURSETYPE(?,?)}");
            cs.setInt(1,coursetype.getId());
            cs.setString(2,coursetype.getName());          
            result = cs.executeUpdate();          
            con.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return result;
    }
    
    @Override
    public ArrayList<CourseType> queryAll() {
        
        ArrayList<CourseType> courses = new ArrayList<CourseType>();
        try{
            DBManager dbManager = DBManager.getdbManager();
            Connection con = DriverManager.getConnection(dbManager.getUrl(), dbManager.getUser(), dbManager.getPassword());
            CallableStatement cs = con.prepareCall("{call LIST_COURSETYPES()}");
            ResultSet rs = cs.executeQuery();
            while(rs.next()){
                CourseType c = new CourseType();
                c.setId(rs.getInt(1));
                c.setName(rs.getString(2));                          
                courses.add(c);
            }            
            con.close();
        }catch(SQLException ex){
            System.out.println(ex.getMessage());
        }
        return courses;
    }
}