/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package infosistest;

import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Date;
import pe.edu.pucp.INFOSiS.controller.mysql.MySQLCourse;
import pe.edu.pucp.INFOSiS.controller.mysql.MySQLCourseHistory;
import pe.edu.pucp.INFOSiS.controller.mysql.MySQLInterested;
import pe.edu.pucp.INFOSiS.controller.mysql.MySQLUser;
import pe.edu.pucp.INFOSiS.model.bean.course.Course;
import pe.edu.pucp.INFOSiS.model.bean.course.CourseHistory;
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
    public static void main(String[] args) throws ParseException {
//        MySQLUser mysql= new MySQLUser();
//        ArrayList<User> l = mysql.queryAll();
//        for(User u : l){
//            System.out.println(u.getUsername());
//        }
//        MySQLInterested mysql1 = new MySQLInterested();
        
//        ArrayList<Interested> ints = mysql1.queryAllByCourseType(rowor);
//        for(Interested i : ints){
//            System.out.println(i.getFirstName());
//            ArrayList<Course> cs = new ArrayList<Course>();
//            cs = i.getCourses();
//            for(Course c : cs)
//                System.out.println(c.getName());
//        }

//        ArrayList<Course> courses = new ArrayList<Course>();
//        courses.add(rowor);
//        courses.add(ruwur);
//        Interested inte = new Interested(courses,false,"75287431",0,"Ricardo","Ricon","Milos","Segundo","M","ricardo.ricon@pucp.pe","987654321");
//        mysql1.update(inte);
//        MySQLCourseHistory mysqlch = new MySQLCourseHistory();
//        Date fechamax = new SimpleDateFormat("yyyy-MM-dd").parse("2019-07-10");
//        ArrayList<CourseHistory> courses = mysqlch.queryByDate(fechamax);
//        for(CourseHistory c : courses){
//            System.out.println(c.getCourse().getName());
//        }
//        MySQLCourse mysqlcourse = new MySQLCourse();
//        Course course = mysqlcourse.queryById("1023");
//        System.out.println(course.getName());
       MySQLInterested mysql = new MySQLInterested();
       ArrayList<Interested> inte = mysql.queryAllInterested();
       for(Interested i : inte){
           if(i.isIsUnsubscribed())
               System.out.println(i.getFirstName());
       }
//       ArrayList<Interested> inte = mysql.search_by_name("Ga", "", "", "");
//       for(Interested i : inte){
//           System.out.println(i.getCourses().get(0).getName());
//       }
    }
    
}
