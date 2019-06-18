/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.INFOSiS.server;

import java.util.ArrayList;
import pe.edu.pucp.INFOSiS.controller.mysql.MySQLUser;
import pe.edu.pucp.INFOSiS.model.bean.user.User;

/**
 *
 * @author alulab14
 */
public class mian {
    
    public static void main(String[] args) {
        MySQLUser mysql= new MySQLUser();
        ArrayList<User> l = mysql.queryAll();
        for(User u : l){
            System.out.println(u.getUsername());
        }
    }
    
}
