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
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Collections;
import java.util.Date;
import pe.edu.pucp.INFOSiS.controller.config.DBController;
import pe.edu.pucp.INFOSiS.controller.config.DBManager;
import pe.edu.pucp.INFOSiS.controller.dao.DAOCourseHistory;
import pe.edu.pucp.INFOSiS.model.bean.course.Course;
import pe.edu.pucp.INFOSiS.model.bean.course.CourseHistory;
import pe.edu.pucp.INFOSiS.model.bean.course.Session;
import pe.edu.pucp.INFOSiS.model.bean.student.Student;

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
            CallableStatement cs = con.prepareCall("{call INSERT_COURSEH(?,?,?,?,?,?,?)}");
            cs.setString(3,courseHistory.getProfessor().getIdPUCP());
            cs.setString(4,courseHistory.getAssistant().getIdPUCP());
            cs.setString(2,courseHistory.getCourse().getId());
            SimpleDateFormat formatIni = new SimpleDateFormat("yyyy-MM-dd");
            Date end = Collections.max(courseHistory.getSessions());
            cs.setString(7,formatIni.format(end));
            Date start = Collections.min(courseHistory.getSessions());
            cs.setString(6, formatIni.format(start));
            cs.setInt(5, courseHistory.getHours());
            cs.registerOutParameter("_idCourseHistory", java.sql.Types.INTEGER);
            result = cs.executeUpdate();
            int id = cs.getInt("_idCourseHistory");
            courseHistory.setId(id);    
            ArrayList<Date> sessions        = courseHistory.getSessions();
            ArrayList<String> locations     = courseHistory.getLocations();
            ArrayList<Integer> hoursSession = courseHistory.getHoursSession();
            int cantSessions = sessions.size();
            SimpleDateFormat format = new SimpleDateFormat("yyyy-MM-dd HH:mm:ss");
            for(int i = 0; i < cantSessions ;i++){
                cs = con.prepareCall("{call INSERT_SESSION(?,?,?,?)}");
                cs.setInt(1, id);
                cs.setString(2,format.format(sessions.get(i)));
                cs.setString(4,locations.get(i));
                cs.setInt(3, hoursSession.get(i));
                result = cs.executeUpdate();
            }
            ArrayList<Student> students = courseHistory.getStudents();
            for(int i = 0; i < students.size();i++){                
                cs = con.prepareCall("{call INSERT_STUDENTHISTORY(?,?,?,?,?)}");
                cs.setString(1,students.get(i).getIdNumber());
                cs.setInt(2, id);
                cs.setFloat(3, courseHistory.getHistoryGrade().get(i));
                cs.setString(4, courseHistory.getHistoryState().get(i));
                cs.setFloat(5,courseHistory.getAmountPaids().get(i));
                result = cs.executeUpdate();
            }
            con.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return result;
    }
    @Override
    public int update (CourseHistory courseHistory){
        int result = 0;
        try{
            DBManager dbManager = DBManager.getdbManager();
            Connection con = DriverManager.getConnection(dbManager.getUrl(), dbManager.getUser(), dbManager.getPassword());
            CallableStatement cs = con.prepareCall("{call UPDATE_COURSEH(?,?,?,?,?,?,?)}");
            cs.setInt(1,courseHistory.getId());
            cs.setString(2,courseHistory.getCourse().getId());
            cs.setString(3,courseHistory.getProfessor().getIdPUCP());
            cs.setString(4,courseHistory.getAssistant().getIdPUCP());
            cs.setInt(5, courseHistory.getHours());
            SimpleDateFormat formatIni = new SimpleDateFormat("yyyy-MM-dd");
            Date start = Collections.min(courseHistory.getSessions());
            cs.setString(6, formatIni.format(courseHistory.getStartDate()));
            Date end = Collections.max(courseHistory.getSessions());
            cs.setString(7, formatIni.format(courseHistory.getEndDate()));        
            result = cs.executeUpdate();               
            con.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return result;
        
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
                dates.add(new java.sql.Date(rs.getDate("endDate").getTime()));
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

    @Override
    public ArrayList<CourseHistory> queryByDate2(Date datecourse) {
        ArrayList<CourseHistory> courses = new ArrayList<CourseHistory>();      
        try{
            DBManager dbManager = DBManager.getdbManager();
            Connection con = DriverManager.getConnection(dbManager.getUrl(), dbManager.getUser(), dbManager.getPassword());
            CallableStatement cs = con.prepareCall("{call COURSEH_BY_DATE(?)}");
            SimpleDateFormat format = new SimpleDateFormat("yyyy-MM-dd HH:mm:ss");
            cs.setString(1,format.format(datecourse));
            ResultSet rs = cs.executeQuery();
            System.out.println(datecourse.toString());
            while(rs.next()){
                CourseHistory c = new CourseHistory();
                c.setId(rs.getInt("idCourseHistory"));
                c.setCourse(DBController.queryCourseById(rs.getString(2)));
                c.setProfessor(DBController.searchProfessorByIdPUCP(rs.getString(3)));
                c.setAssistant(DBController.searchProfessorByIdPUCP(rs.getString(4)));
                c.setHours(rs.getInt(5));
                c.setStartDate(rs.getDate(6));
                c.setEndDate(rs.getDate(7));  
                System.out.println(c.getCourse().getId() +  " " + c.getCourse().getName());                
                
                    ArrayList<Session> sessions = new ArrayList<>();
                    cs = con.prepareCall("{call SEARCH_SESSIONS_BY_COURSEH(?)}");
                    cs.setInt(1, c.getId());
                    ResultSet rs2 = cs.executeQuery();
                    while(rs2.next()){
                        Session s = new Session();
                        s.setId(rs2.getInt(1));
                        s.setSession(rs2.getDate(3));
                        s.setHours(rs2.getInt(4));
                        s.setLocation(rs.getString(5));
                        sessions.add(s);
                    }
                    c.setSessions2(sessions);
                    
                    ArrayList<Student> students = new ArrayList<>();
                    ArrayList<Float> grades = new ArrayList<>();
                    ArrayList<String> states = new ArrayList<>();
                    ArrayList<Float> amountPaids = new ArrayList<>();
                    
                    cs = con.prepareCall("{call SEARCH_STUDENTH_BY_COURSEH(?)}");
                    cs.setInt(1, c.getId());
                    rs2 = cs.executeQuery();
                     while(rs2.next()){
                        Student s = new Student();
                        s.setId(rs2.getInt(2));
                        students.add(s);
                        grades.add(rs.getFloat(4));
                        states.add(rs2.getString(5));                      
                        amountPaids.add(rs2.getFloat(6));                       
                    }
                     c.setStudents(students);
                     c.setHistoryGrade(grades);
                     c.setHistoryState(states); 
                     c.setAmountPaids(amountPaids);
                     courses.add(c);
               
            }            
            con.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }       
        return courses;
    }
}
