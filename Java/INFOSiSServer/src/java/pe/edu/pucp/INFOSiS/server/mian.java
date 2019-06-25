/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.INFOSiS.server;

import java.io.File;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.OutputStream;
import java.nio.file.Files;
import java.nio.file.Path;
import java.nio.file.Paths;
import java.util.ArrayList;
import java.util.Date;
import pe.edu.pucp.INFOSiS.controller.config.DBController;
import pe.edu.pucp.INFOSiS.controller.mysql.MySQLCourseHistory;
import pe.edu.pucp.INFOSiS.controller.mysql.MySQLUser;
import pe.edu.pucp.INFOSiS.model.bean.HR.Intern;
import pe.edu.pucp.INFOSiS.model.bean.course.Course;
import pe.edu.pucp.INFOSiS.model.bean.course.CourseHistory;
import pe.edu.pucp.INFOSiS.model.bean.course.CourseType;
import pe.edu.pucp.INFOSiS.model.bean.course.Session;
import pe.edu.pucp.INFOSiS.model.bean.professor.Professor;
import pe.edu.pucp.INFOSiS.model.bean.student.Student;
import pe.edu.pucp.INFOSiS.model.bean.user.User;
import pe.edu.pucp.INFOSiS.model.bean.user.UserType;

/**
 *
 * @author alulab14
 */
public class mian {
    
    public static void main(String[] args) throws IOException  {
//        ArrayList<User> users = DBController.queryAllUsers();
//        for(User u: users){
//            System.out.println(u.getUsername());
//        }
//
//        Course course = DBController.queryCourseById("VBA002");
//        Professor professor = DBController.searchProfessorByIdPUCP("19693103");
//        Professor assistant = DBController.searchProfessorByIdPUCP("19794422");
//        CourseHistory c = new CourseHistory();
//        c.setCourse(course);
//        c.setAssistant(assistant);
//        c.setProfessor(professor);
//        c.setHours(10);
//        ArrayList<Date> dates = new ArrayList<>();
//        Date d = new Date();
//        dates.add(d);
//        Date d2 = new Date();
//        d2.setDate(30);
//        dates.add(d2);
//        ArrayList<Session> sessions = new ArrayList<>();
//        Session s = new Session();
//        s.setDateSession(d);
//        s.setHours(4);
//        s.setLocation("A101");
//        sessions.add(s);
//        Session s2 = new Session();
//        s2.setDateSession(d);
//        s2.setHours(6);
//        s2.setLocation("A102");
//        sessions.add(s2);
//        c.setSessions(sessions);
//        ArrayList<Student> students = new ArrayList<>();
//        Student stu = new Student();
//        stu.setIdNumber("11111111");
//        students.add(stu);
//        Student stu2 = new Student();
//        stu2.setIdNumber("56485747");
//        students.add(stu2);
//        c.setStudents(students);
//        ArrayList<Float> grades = new ArrayList<>();
//        grades.add(15.00f);
//        grades.add(19.00f);
//        c.setHistoryGrade(grades);
//        ArrayList<String> states = new ArrayList<>();
//        states.add("APROBADO");
//        states.add("APROBADO");
//        c.setHistoryState(states);
//        ArrayList<Float> amountPaids = new ArrayList<>();
//        amountPaids.add(300f);
//        amountPaids.add(600f);
//       
//        c.setAmountPaids(amountPaids);
//        try{
//            File file = new File("T:\\Temp\\archivo.csv");
//            byte[] survey = Files.readAllBytes(file.toPath());
//            c.setSurvey(survey);
//        }
//        catch(Exception ex){
//            System.out.println(ex.getMessage());
//        }
//   
//        int result = DBController.insertCourseHistory(c);
//        System.out.println(result);
//        
//        
           
//           ArrayList<CourseHistory> courses = DBController.queryCourseHByIdProfessor("20142604");
//           for(CourseHistory c : courses){              
//               System.out.println(c.getCourse().getId() +" "+ c.getCourse().getName()); 
//                try{
//                    File file = new File("T:\\\\Temp\\\\archivo2.csv");
//                    OutputStream os = new FileOutputStream(file);
//                    os.write(c.getSurvey());
//                    os.close();
//                }
//                catch(Exception ex){
//                    System.out.println(ex.getMessage());
//                }
//           }
           
//
//          CourseType coursetype = DBController.queryCourseTypeById(6);
//          Course c = new Course();
//          c.setId("123");
//          c.setName("Grafos2");
//          c.setIsActive(true);
//          c.setDescription("Búsqueda de grafos");
//          c.setSyllabus(null);
//          c.setCourseType(coursetype);
//          System.out.println(DBController.updateCourse(c));

//            ArrayList<Course> courses = DBController.queryAllCourse();
//            for(Course c: courses){
//                System.out.println(c);
//            }
            
        
//        Intern intern = new Intern();
//        intern.setIdNumber("asdf");
//        intern.setIdPUCP("asdf");
//        intern.setIdType(0); 
//        intern.setFirstName("Asdf");
//        intern.setPrimaryLastName("asdf");
//        intern.setSecondLastName("Asdf");
//        intern.setCellPhoneNumber("asdf");
//        intern.setGender("F");
//        intern.setEmail("adf");
//        intern.setEmailPUCP("asdf");       
//        UserType access = new UserType();
//        access.setId(0);
//        access.setName("adf");        
//        DBController.insertIntern(intern, access);
//          ArrayList<Professor> p = DBController.searchProfessorByName("Freddy", "", "","");
//          for(Professor pro : p){
//            System.out.println(pro.getIdPUCP());
//          }
//          Professor p = new Professor();
//          p.setIdPUCP("20142604");
//          p.setIdNumber("724885998");
//          p.setIdType(0);
//          p.setEmailPUCP("estephany.perez@pucp.pe");
//          p.setFirstName("Estephany");
//          p.setPrimaryLastName("Perez");
//          p.setSecondLastName("Cabrera");
//          
//          DBController.updateProfessor(p);

//            int r= DBController.searchProfessorById("09479586");
//            System.out.println(r);
        MySQLCourseHistory msql = new MySQLCourseHistory();        
        byte[] bArray = null;
        bArray = msql.generateReport(20);
        Path path = Paths.get("D:\\myfile.pdf");
        Files.write(path, bArray);
    }  
}
