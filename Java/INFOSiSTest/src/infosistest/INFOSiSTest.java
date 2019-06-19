/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package infosistest;

import java.util.ArrayList;
import pe.edu.pucp.INFOSiS.controller.mysql.MySQLInterested;
import pe.edu.pucp.INFOSiS.controller.mysql.MySQLUser;
import pe.edu.pucp.INFOSiS.model.bean.course.Course;
import pe.edu.pucp.INFOSiS.model.bean.interested.Interested;
import pe.edu.pucp.INFOSiS.model.bean.user.User;

/**
 *
 * @author Usuario
 */
public class INFOSiSTest {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
//        MySQLUser mysql= new MySQLUser();
//        ArrayList<User> l = mysql.queryAll();
//        for(User u : l){
//            System.out.println(u.getUsername());
//        }
        MySQLInterested mysql1 = new MySQLInterested();
        ArrayList<Interested> ints = mysql1.queryAll();
        for(Interested i : ints){
            ArrayList<Course> cs = new ArrayList<Course>();
            cs = i.getCourses();
            for(Course c : cs)
                System.out.println(c.getName());
        }
    }
    
}
