/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.INFOSiS.server;

import java.util.ArrayList;
import pe.edu.pucp.INFOSiS.controller.config.DBController;
import pe.edu.pucp.INFOSiS.controller.mysql.MySQLUser;
import pe.edu.pucp.INFOSiS.model.bean.professor.Professor;
import pe.edu.pucp.INFOSiS.model.bean.user.User;

/**
 *
 * @author alulab14
 */
public class mian {
    
    public static void main(String[] args) {
//        ArrayList<User> users = DBController.queryAllUsers();
//        for(User u: users){
//            System.out.println(u.getUsername());
//        }
        Professor p = new Professor();
        p.setIdNumber("12345678");
        p.setIdPUCP("2014444");
        p.setFirstName("asdf");
        p.setMiddleName("asdf");
        p.setPrimaryLastName("asdf");
        p.setSecondLastName("asdf");
        p.setGender("f");
        p.setEmail("asdf");
        p.setEmailPUCP("adsf");
        p.setIdType(1);
        p.setBirthDate(new java.sql.Date(1999,05,01));
        p.setCellPhoneNumber("asdfa");
        DBController.insertProfessor(p);
    }
    
}
