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
import pe.edu.pucp.INFOSiS.model.bean.course.Course;
import pe.edu.pucp.INFOSiS.model.bean.professor.Professor;
import pe.edu.pucp.INFOSiS.model.bean.user.User;

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

try{
        Course c = new Course();
        c.setId("1023");
        c.setName("Excel Super Básico");
        c.setIsActive(true);
        c.setDescription("Curso Super básico de excel");
        File file = new File("C:\\Users\\Ivette\\Desktop\\2019-1\\Final\\INFOSiS\\Java\\INFOSiSTest\\Horario_Parcial.pdf");
        
        c.setSyllabus(Files.readAllBytes(file.toPath()));
        
        int result  = DBController.insertCourse(c);
        System.out.println(result);
        
}
catch(Exception ex){
    System.out.println(ex.getMessage() + "uwur");
}
        
        
    }
    
}
