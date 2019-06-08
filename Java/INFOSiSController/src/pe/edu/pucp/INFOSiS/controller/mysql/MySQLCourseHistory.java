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
import pe.edu.pucp.INFOSiS.controller.dao.DAOCourseHistory;
import pe.edu.pucp.INFOSiS.model.bean.course.CourseHistory;

/**
 *
 * @author tkuser
 */
public class MySQLCourseHistory implements DAOCourseHistory{
    @Override
    public int insert(CourseHistory courseHistory){
        int result = 0;
        try{
            DBManager dbManager = DBManager.getdbManager();
            Connection con = DriverManager.getConnection(dbManager.getUrl(), dbManager.getUser(), dbManager.getPassword());
            CallableStatement cs = con.prepareCall("{call INSERT_COURSEH(?,?,?)}");
            cs.setString(2,courseHistory.getProfessor().getIdNumber());
            cs.setString(3,courseHistory.getAssistant().getIdNumber());
            cs.setString(1,courseHistory.getCourse().getId());
            result = cs.executeUpdate();
            con.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return result;
    }
    @Override
    public void update (CourseHistory courseHistory){
        try{
            DBManager dbManager = DBManager.getdbManager();
            Connection con = DriverManager.getConnection(dbManager.getUrl(), dbManager.getUser(), dbManager.getPassword());
            CallableStatement cs = con.prepareCall("{call UPDATE_COURSEH(?,?,?)}");
            cs.setString(1,courseHistory.getProfessor().getIdNumber());
            cs.setString(2,courseHistory.getAssistant().getIdNumber());
            cs.setString(3,courseHistory.getCourse().getId());
			con.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        
    }
}
