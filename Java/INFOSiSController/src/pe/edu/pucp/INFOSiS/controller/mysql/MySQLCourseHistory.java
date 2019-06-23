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
import java.util.ArrayList;
import java.util.Date;
import pe.edu.pucp.INFOSiS.controller.config.DBManager;
import pe.edu.pucp.INFOSiS.controller.dao.DAOCourseHistory;
import pe.edu.pucp.INFOSiS.model.bean.course.Course;
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
    
    public ArrayList<CourseHistory> queryByDate(Date datecourse){
        ArrayList<CourseHistory> courses = new ArrayList<CourseHistory>();
        
        try{
            DBManager dbManager = DBManager.getdbManager();
            Connection con = DriverManager.getConnection(dbManager.getUrl(), dbManager.getUser(), dbManager.getPassword());
            CallableStatement cs = con.prepareCall("{call COURSEH_BY_DATE(?)}");
            cs.setDate(1,new java.sql.Date(datecourse.getDate()));
            ResultSet rs = cs.executeQuery();
            while(rs.next()){
                ArrayList<Date> dates = new ArrayList<Date>();
                CourseHistory c = new CourseHistory();
                c.setId(rs.getInt("idCourseHistory"));
                dates.add(new java.sql.Date(rs.getDate("startDate").getTime()));
                
                c.setSessions(dates);
                c.setHours(rs.getInt("hours"));
                //CursoH tiene ahora id, fecha de inicio y las horas totales
                //falta agregar el curso al cual pertenece 0;
                String id = rs.getString("idCourse");
                CallableStatement cs2 = con.prepareCall("{call COURSE_BY_ID(?)}");
                cs2.setString(1, id);
                ResultSet rs2 = cs2.executeQuery();
                while(rs2.next()){
                    Course cr = new Course();
                    cr.setId(rs.getString("idCourse"));
                    cr.setName(rs2.getString("name"));
                    cr.setDescription(rs2.getString("description"));
                    c.setCourse(cr);
                }
                //Como no sé como comparar las fechas en mysql, lo haré acá ptmre :v
                if(dates.get(0).after(datecourse)){
                    courses.add(c);
                }
            }            
            con.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        
        return courses;
    }
}
