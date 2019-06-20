/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.INFOSiS.controller.config;

import java.util.ArrayList;
import pe.edu.pucp.INFOSiS.model.bean.course.Course;
import pe.edu.pucp.INFOSiS.model.bean.interested.Interested;
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
    
    public static int insertInterested(Interested interested){
        return daoFactory.getInterestedDAO().insert(interested);
    }
    
    public static int updateInterested(Interested interested){
        return daoFactory.getInterestedDAO().update(interested);
    }
    
    public static ArrayList<Interested> queryAll(){
        return daoFactory.getInterestedDAO().queryAll();
    }
    
    public static ArrayList<Interested> queryAllByCourse(Course course){
        return daoFactory.getInterestedDAO().queryAllByCourseType(course);
    }
}
