/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.INFOSiS.controller.mysql;

import java.io.File;
import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Collections;
import java.util.Date;
import java.util.HashMap;
import java.util.Map;
import java.util.logging.Level;
import java.util.logging.Logger;
import net.sf.jasperreports.engine.JRException;
import net.sf.jasperreports.engine.JasperCompileManager;
import net.sf.jasperreports.engine.JasperExportManager;
import net.sf.jasperreports.engine.JasperFillManager;
import net.sf.jasperreports.engine.JasperPrint;
import net.sf.jasperreports.engine.JasperReport;
import net.sf.jasperreports.engine.design.JasperDesign;
import net.sf.jasperreports.engine.xml.JRXmlLoader;
import pe.edu.pucp.INFOSiS.controller.config.DBController;
import pe.edu.pucp.INFOSiS.controller.config.DBManager;
import pe.edu.pucp.INFOSiS.controller.dao.DAOCourseHistory;
import pe.edu.pucp.INFOSiS.model.bean.course.CalendarSession;
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
            CallableStatement cs = con.prepareCall("{call INSERT_COURSEH(?,?,?,?,?,?,?,?)}");
            cs.setString(2,courseHistory.getCourse().getId());
            cs.setString(3,courseHistory.getProfessor().getIdPUCP());
            cs.setString(4,courseHistory.getAssistant().getIdPUCP());   
            cs.setInt(5, courseHistory.getHours());
            SimpleDateFormat formatIni = new SimpleDateFormat("yyyy-MM-dd");
            ArrayList<Date> dateSession = new ArrayList<>();
            for(Session s: courseHistory.getSessions()){
                dateSession.add(s.getDateSession());
            }
            Date start = Collections.min(dateSession);
            cs.setString(6, formatIni.format(start));   
            Date end = Collections.max(dateSession);
            cs.setString(7,formatIni.format(end));   
            cs.setBytes(8, courseHistory.getSurvey());
            cs.registerOutParameter("_idCourseHistory", java.sql.Types.INTEGER);
            result = cs.executeUpdate();
            int id = cs.getInt("_idCourseHistory");
            courseHistory.setId(id);  
            SimpleDateFormat format = new SimpleDateFormat("yyyy-MM-dd HH:mm:ss");
            for(Session s: courseHistory.getSessions()){
                cs = con.prepareCall("{call INSERT_SESSION(?,?,?,?,?,?)}");
                cs.setInt(1, id);
                cs.setString(2,format.format(s.getDateSession()));              
                cs.setInt(3,s.getHours());
                cs.setString(4,s.getLocation());
                cs.setBoolean(5, true);
                cs.registerOutParameter(6, java.sql.Types.INTEGER);
                result = cs.executeUpdate();
                s.setId(cs.getInt(6));
            }           
            ArrayList<Student> students = courseHistory.getStudents();
            for(int i = 0; i < students.size();i++){                
                cs = con.prepareCall("{call INSERT_STUDENTHISTORY(?,?,?,?,?,?)}");
                cs.setString(1,students.get(i).getIdNumber());
                cs.setInt(2, id);
                cs.setFloat(3, courseHistory.getHistoryGrade().get(i));
                cs.setString(4, courseHistory.getHistoryState().get(i));
                cs.setFloat(5,courseHistory.getAmountPaids().get(i));
                cs.setBoolean(6,true);
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
            CallableStatement cs = con.prepareCall("{call UPDATE_COURSEH(?,?,?,?,?,?,?,?)}");
            cs.setInt(1,courseHistory.getId());
            cs.setString(2,courseHistory.getCourse().getId());
            cs.setString(3,courseHistory.getProfessor().getIdPUCP());
            cs.setString(4,courseHistory.getAssistant().getIdPUCP());
            cs.setInt(5, courseHistory.getHours());
            SimpleDateFormat formatIni = new SimpleDateFormat("yyyy-MM-dd");
            ArrayList<Date> dateSession = new ArrayList<>();
            for(Session s: courseHistory.getSessions()){
                dateSession.add(s.getDateSession());
            }     
            Date start = Collections.min(dateSession);
            cs.setString(6, formatIni.format(start));
            Date end = Collections.max(dateSession);
            cs.setString(7,formatIni.format(end));
            cs.setBytes(8, courseHistory.getSurvey());
            result = cs.executeUpdate();                
            cs = con.prepareCall("{call DISABLE_SESSIONS_BY_COURSEH(?)}");           
            cs.setInt(1, courseHistory.getId());
            result = cs.executeUpdate();
            SimpleDateFormat format = new SimpleDateFormat("yyyy-MM-dd HH:mm:ss");
            ResultSet rs;
            for(Session s: courseHistory.getSessions()){  
                
                cs = con.prepareCall("{call SESSION_BY_ID(?)}");
                cs.setInt(1, s.getId());
                rs = cs.executeQuery();
               
                if(rs.next()){
                   
                    cs = con.prepareCall("{call ENABLE_SESSION(?)}");
                    cs.setInt(1, s.getId());     
                    result = cs.executeUpdate();
                }
                else{
                    
                    cs = con.prepareCall("{call INSERT_SESSION(?,?,?,?,?,?)}");
                    cs.setInt(1, courseHistory.getId());
                    cs.setString(2,format.format(s.getDateSession()));              
                    cs.setInt(3,s.getHours());
                    cs.setString(4,s.getLocation());
                    cs.setBoolean(5,true);
                    cs.registerOutParameter(6, java.sql.Types.INTEGER);                  
                    result = cs.executeUpdate();
                    s.setId(cs.getInt(6));
                }               
            }     
            cs = con.prepareCall("{call DISABLE_STUDENTH_BY_COURSEH(?)}");
            cs.setInt(1, courseHistory.getId());
            result = cs.executeUpdate();
            ArrayList<Student> students = courseHistory.getStudents();
            for(int i = 0; i < students.size();i++){                
                cs = con.prepareCall("{call STUDENTH_BY_ID(?,?)}");  
                cs.setString(1, students.get(i).getIdNumber());
                cs.setInt(2, courseHistory.getId());
                rs = cs.executeQuery();
                if(rs.next()){
                    cs = con.prepareCall("{call ENABLE_STUDENTH(?)}");
                    cs.setInt(1, rs.getInt(1));
                    result = cs.executeUpdate();
                }
                else{
                    cs = con.prepareCall("{call INSERT_STUDENTHISTORY(?,?,?,?,?,?)}");
                    cs.setString(1,students.get(i).getIdNumber());
                    cs.setInt(2, courseHistory.getId());
                    cs.setFloat(3, courseHistory.getHistoryGrade().get(i));
                    cs.setString(4, courseHistory.getHistoryState().get(i));
                    cs.setFloat(5,courseHistory.getAmountPaids().get(i));
                    cs.setBoolean(6,true);
                    result = cs.executeUpdate();
                }
                
            }
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
            SimpleDateFormat format = new SimpleDateFormat("yyyy-MM-dd HH:mm:ss");
            cs.setString(1,format.format(datecourse));
            ResultSet rs = cs.executeQuery();           
            while(rs.next()){
                CourseHistory c = new CourseHistory();
                c.setId(rs.getInt("idCourseHistory"));
                c.setCourse(DBController.queryCourseById(rs.getString(2)));
                c.setProfessor(DBController.searchProfessorByIdPUCP(rs.getString(3)));
                c.setAssistant(DBController.searchProfessorByIdPUCP(rs.getString(4)));
                c.setHours(rs.getInt(5));
                c.setStartDate(rs.getDate(6));
                c.setEndDate(rs.getDate(7)); 
                c.setSurvey(rs.getBytes(8));
                ArrayList<Session> sessions = new ArrayList<>();
                cs = con.prepareCall("{call SEARCH_SESSIONS_BY_COURSEH(?)}");
                cs.setInt(1, c.getId());
                ResultSet rs2 = cs.executeQuery();
                while(rs2.next()){
                    Session s = new Session();
                    s.setId(rs2.getInt(1));
                    s.setDateSession(rs2.getTimestamp(3));
                    s.setHours(rs2.getInt(4));
                    s.setLocation(rs.getString(5));
                    s.setIsActive(rs2.getBoolean(6));
                    sessions.add(s);
                }
                c.setSessions(sessions);

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

    @Override
    public ArrayList<CourseHistory> queryByIdProfessor(String idProfessor) {
        ArrayList<CourseHistory> courses = new ArrayList<CourseHistory>();
        
        try{
            DBManager dbManager = DBManager.getdbManager();
            Connection con = DriverManager.getConnection(dbManager.getUrl(), dbManager.getUser(), dbManager.getPassword());
            CallableStatement cs = con.prepareCall("{call COURSEH_BY_PROFESSOR(?)}");          
            cs.setString(1,idProfessor);
            ResultSet rs = cs.executeQuery();         
            while(rs.next()){
                CourseHistory c = new CourseHistory();
                c.setId(rs.getInt("idCourseHistory"));
                //Course course = new Course();
                Course course = DBController.queryCourseById(rs.getString(2));
                c.setCourse(course);
                c.setCourseName(course.getName());
                c.setProfessor(DBController.searchProfessorByIdPUCP(rs.getString(3)));
                c.setAssistant(DBController.searchProfessorByIdPUCP(rs.getString(4)));
                c.setHours(rs.getInt(5));
                c.setStartDate(rs.getDate(6));
                c.setEndDate(rs.getDate(7)); 
                c.setSurvey(rs.getBytes(8));
                ArrayList<Session> sessions = new ArrayList<>();
                cs = con.prepareCall("{call SEARCH_SESSIONS_BY_COURSEH(?)}");
                cs.setInt(1, c.getId());
                ResultSet rs2 = cs.executeQuery();
                while(rs2.next()){
                    Session s = new Session();
                    s.setId(rs2.getInt(1));
                    s.setDateSession(rs2.getTimestamp(3));
                    s.setHours(rs2.getInt(4));
                    s.setLocation(rs.getString(5));
                    s.setIsActive(rs2.getBoolean(6));
                    sessions.add(s);
                }
                c.setSessions(sessions);

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

    @Override
    public byte[] generateReport(int id) {
        DBManager dbManager = DBManager.getdbManager();
        Connection con = null;
        try {
            con = DriverManager.getConnection(dbManager.getUrl(), dbManager.getUser(), dbManager.getPassword());
        } catch (SQLException ex) {
            Logger.getLogger(MySQLCourseHistory.class.getName()).log(Level.SEVERE, null, ex);
        }
        JasperPrint print = new JasperPrint();
        String sourceFileName = "../INFOSiS/src/pe/edu/pucp/infosis/reports/" + "CourseHistoryReport.jrxml";            
        File theFile = new File(sourceFileName);
        JasperDesign jasperDesign = null;
        JasperReport jasperReport = null;
        try {
            jasperDesign = JRXmlLoader.load(theFile);
        } catch (JRException ex) {
            Logger.getLogger(MySQLCourseHistory.class.getName()).log(Level.SEVERE, null, ex);
        }
        try {
            jasperReport = JasperCompileManager.compileReport(jasperDesign);
        } catch (JRException ex) {
            Logger.getLogger(MySQLCourseHistory.class.getName()).log(Level.SEVERE, null, ex);
        }
        Map parameters = new HashMap();
        parameters.put("ID_COURSE_HISTORY",id);
        try {
            print = JasperFillManager.fillReport(jasperReport, parameters, con);
        } catch (JRException ex) {
            Logger.getLogger(MySQLCourseHistory.class.getName()).log(Level.SEVERE, null, ex);
        }
        byte[] pdfBytes = null;
        try {
            pdfBytes = JasperExportManager.exportReportToPdf(print);
        } catch (JRException ex) {
            Logger.getLogger(MySQLCourseHistory.class.getName()).log(Level.SEVERE, null, ex);
        }
        return pdfBytes;
    }
    
    @Override
    public ArrayList<CalendarSession> queryCalendarSessionByBeginDate(String date){
        ArrayList<CalendarSession> lSesiones = new ArrayList<>();
        try{
            DBManager dbManager = DBManager.getdbManager();
            Connection con = DriverManager.getConnection(dbManager.getUrl(), 
                    dbManager.getUser(), dbManager.getPassword());
            Statement st = con.createStatement();
            String query = "SELECT S.sessionDateTime AS 'Inicio', "
                    + "DATE_ADD(S.sessionDateTime, INTERVAL S.cantHours HOUR) as 'Fin', "
                    + "S.classroom as 'Lugar',  C.name as 'Curso', "
                    + "CONCAT(P.primaryLastName,' ',P.secondLastName,', '"
                    + ",P.firstName,' ',P.middleName) as 'Profesor' "
                    + "FROM Sessions S, Professors P, CourseHistory H, "
                    + "Course C "
                    + "WHERE S.idCourseHistory=H.idCourseHistory "
                    + "AND H.idCourse=C.idCourse "
                    + "AND H.idProfessor=P.idProfessor "
                    + "AND S.sessionDateTime>=STR_TO_DATE('"+date+" 00:00:00','%Y/%m/%d %H:%i:%s') "
                    + "ORDER BY Inicio";
            ResultSet rs = st.executeQuery(query);
            CalendarSession calS;
            while (rs.next()){
                calS= new CalendarSession();
                calS.setInicio(rs.getTimestamp("Inicio"));
                calS.setFin(rs.getTimestamp("Fin"));
                calS.setAula(rs.getString("Lugar"));
                calS.setCourseName(rs.getString("Curso"));
                calS.setProfessor(rs.getString("Profesor"));
                lSesiones.add(calS);
            }
            con.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return lSesiones;
    }
    
    
}
