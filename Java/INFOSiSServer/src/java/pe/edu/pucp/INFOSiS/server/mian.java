/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.INFOSiS.server;

import java.io.File;
import java.io.IOException;
import java.nio.file.Files;
import java.util.ArrayList;
import pe.edu.pucp.INFOSiS.controller.config.DBController;
import pe.edu.pucp.INFOSiS.controller.mysql.MySQLUser;
import pe.edu.pucp.INFOSiS.model.bean.HR.Intern;
import pe.edu.pucp.INFOSiS.model.bean.course.Course;
import pe.edu.pucp.INFOSiS.model.bean.course.CourseType;
import pe.edu.pucp.INFOSiS.model.bean.professor.Professor;
import pe.edu.pucp.INFOSiS.model.bean.user.User;
import pe.edu.pucp.INFOSiS.model.bean.user.UserType;

/**
 *
 * @author alulab14
 */
public class mian {
    
    public static void main(String[] args)  {
//        ArrayList<User> users = DBController.queryAllUsers();
//        for(User u: users){
//            System.out.println(u.getUsername());
//        }

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
    }  
}
