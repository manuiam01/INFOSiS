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
        Course rowor = new Course("100");
        Course ruwur = new Course("102");
        ArrayList<Interested> ints = mysql1.queryAllByCourseType(rowor);
        for(Interested i : ints){
            System.out.println(i.getFirstName());
//            ArrayList<Course> cs = new ArrayList<Course>();
//            cs = i.getCourses();
//            for(Course c : cs)
//                System.out.println(c.getName());
        }

//        ArrayList<Course> courses = new ArrayList<Course>();
//        courses.add(rowor);
//        courses.add(ruwur);
//        Interested inte = new Interested(courses,false,"75287431",0,"Ricardo","Ricon","Milos","Segundo","M","ricardo.ricon@pucp.pe","987654321");
//        mysql1.update(inte);
    }
    
}
