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
        ArrayList<Course> courses = DBController.queryCourseByName("Excel");
        for(Course c : courses){
            System.out.println(c);
        }
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
    }  
}
