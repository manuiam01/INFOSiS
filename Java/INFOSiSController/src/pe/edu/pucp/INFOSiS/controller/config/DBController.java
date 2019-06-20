/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.INFOSiS.controller.config;

import java.util.ArrayList;


import pe.edu.pucp.INFOSiS.model.bean.HR.Intern;
import pe.edu.pucp.INFOSiS.model.bean.course.Course;
import pe.edu.pucp.INFOSiS.model.bean.course.CourseType;
import pe.edu.pucp.INFOSiS.model.bean.interested.Interested;
import pe.edu.pucp.INFOSiS.model.bean.professor.Professor;
import pe.edu.pucp.INFOSiS.model.bean.student.Student;
import pe.edu.pucp.INFOSiS.model.bean.user.User;
import pe.edu.pucp.INFOSiS.model.bean.user.UserType;

/**
 *
 * @author ASUS
 */
public abstract class DBController {
    private static DAOFactory daoFactory= DAOFactory.getDAOFactory();
    
    public static ArrayList<User> queryAllUsers(){
      return daoFactory.getUserDAO().queryAll();
    }
    
    public static UserType verifyUser(User user){
        return daoFactory.getUserDAO().verifyUser(user);
    }
    
    public static int insertProfessor(Professor professor){
        return daoFactory.getProfessorDAO().insert(professor);
    }
    
    public static int updateProfessor(Professor professor){
        return daoFactory.getProfessorDAO().update(professor);
    }
    
    public static Professor searchProfessorById(String id){
        return daoFactory.getProfessorDAO().search_by_id(id);
    }
    
    public static ArrayList<Professor> searchProfessorByName(String name, String middle_name,
            String first_last_name, String second_last_name){
        return daoFactory.getProfessorDAO().search_by_name(name, middle_name, first_last_name, second_last_name);
    }
   
    public static ArrayList<Intern> queryAllInterns(){
        return daoFactory.getDAOIntern().queryAll();
    }
    
    public static int insertIntern(Intern intern, UserType access){
        return daoFactory.getDAOIntern().insert(intern, access);
    }
    
    public static int updateIntern(Intern intern, UserType access){
        return daoFactory.getDAOIntern().update(intern, access);
    }

    public static int insertInterested(Interested interested){
        return daoFactory.getInterestedDAO().insert(interested);
    }
    
    public static int updateInterested(Interested interested){
        return daoFactory.getInterestedDAO().update(interested);
    }
    
    public static ArrayList<Interested> queryAllInterested(){
        return daoFactory.getInterestedDAO().queryAllInterested();
    }
    
    public static ArrayList<Interested> queryAllByCourse(Course course){
        return daoFactory.getInterestedDAO().queryAllByCourseType(course);
    }
    
    //Métodos Course
    public static int insertCourse(Course course){
        return daoFactory.getCourseDAO().insert(course);
    }
    
    public static int updateCourse(Course course){
        return daoFactory.getCourseDAO().update(course);
    }
    
    public static int disableCourse(Course course){
        return daoFactory.getCourseDAO().disable(course);
    }
    
    public static ArrayList<Course> queryAllCourse(){
        return daoFactory.getCourseDAO().queryAll();
    }
    public static Course queryCourseById(String id){
        return daoFactory.getCourseDAO().queryById(id);
    }
    
    public static ArrayList<Course> queryCourseByName(String name){
        return daoFactory.getCourseDAO().queryByName(name);
    }
    
    //Métodos CourseType
    
    public static int insertCourseType(CourseType coursetype){
        return daoFactory.getCourseTypeDAO().insert(coursetype);
    }
    
    public static int updateCourseType(CourseType coursetype){
        return daoFactory.getCourseTypeDAO().update(coursetype);
    }
    
    public static ArrayList<CourseType> queryAllCourseType(){
        return daoFactory.getCourseTypeDAO().queryAll();

    }
    
     public static Interested queryInterestedById(String interestedID){
         return daoFactory.getInterestedDAO().queryInterestedById(interestedID);
     }
     
     public static int insertStudent(Student s){
         return daoFactory.getStudentDAO().insertStudent(s);
     }
}
