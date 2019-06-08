/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.INFOSiS.controller.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
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
            CallableStatement cs = con.prepareCall("{call INSERT_COURSE(?,?,?,?)}");
            cs.setString(1,course.getName());
            cs.setBoolean(2,course.getIsActive());
            cs.setString(3,course.getDescription());
            cs.setObject(4,course.getSyllabus());
            result = cs.executeUpdate();
            con.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return result;
    }
    @Override
    public void update (Course course,int id){
        try{
            DBManager dbManager = DBManager.getdbManager();
            Connection con = DriverManager.getConnection(dbManager.getUrl(), dbManager.getUser(), dbManager.getPassword());
            CallableStatement cs = con.prepareCall("{call UPDATE_COURSE(?,?,?,?)}");
            cs.setString(1,course.getName());
            cs.setBoolean(2,course.getIsActive());
            cs.setObject(3,course.getSyllabus());
            cs.setInt(4,id);
            con.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        
    }
}
