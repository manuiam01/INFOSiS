/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.INFOSiS.controller.config;

import java.util.ArrayList;
<<<<<<< HEAD
import pe.edu.pucp.INFOSiS.model.bean.HR.Intern;
=======
import pe.edu.pucp.INFOSiS.model.bean.course.Course;
import pe.edu.pucp.INFOSiS.model.bean.interested.Interested;
>>>>>>> 4cf4c7c7f7c9888fa37f816e986a3a0844e8c1ef
import pe.edu.pucp.INFOSiS.model.bean.professor.Professor;
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
    
<<<<<<< HEAD
    public static ArrayList<Intern> queryAllInterns(){
        return daoFactory.getDAOIntern().queryAll();
    }
    
    public static int insertIntern(Intern intern, UserType access){
        return daoFactory.getDAOIntern().insert(intern, access);
    }
    
    public static int updateIntern(Intern intern, UserType access){
        return daoFactory.getDAOIntern().update(intern, access);
=======
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
>>>>>>> 4cf4c7c7f7c9888fa37f816e986a3a0844e8c1ef
    }
}
