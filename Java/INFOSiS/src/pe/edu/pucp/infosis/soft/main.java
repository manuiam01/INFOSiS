/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.INFOSiS.soft;
import java.util.ArrayList;
import pe.edu.pucp.INFOSiS.controller.mysql.MySQLUser;
import pe.edu.pucp.INFOSiS.model.bean.user.User;

/**
 *
 * @author alulab14
 */
public class main {
    
    public static void main(String[] args) {
        // Prints "Hello, World" to the terminal window.
        //System.out.println("Hay que trabajar UwUr");
        //System.out.println("Okey dokey uwur");
        MySQLUser mysql = new MySQLUser();
        ArrayList<User> lista= mysql.queryAll();
        for(User u : lista){
            System.out.println(u.getUsername());
        }
    }
}
