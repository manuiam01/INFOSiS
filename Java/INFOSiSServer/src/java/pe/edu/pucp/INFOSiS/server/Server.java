/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.INFOSiS.server;

import java.util.ArrayList;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import pe.edu.pucp.INFOSiS.controller.config.DBController;
import pe.edu.pucp.INFOSiS.controller.mysql.MySQLProfessor;
import pe.edu.pucp.INFOSiS.controller.mysql.MySQLUser;
import pe.edu.pucp.INFOSiS.model.bean.course.Course;
import pe.edu.pucp.INFOSiS.model.bean.interested.Interested;
import pe.edu.pucp.INFOSiS.model.bean.professor.Professor;
import pe.edu.pucp.INFOSiS.model.bean.user.User;
import pe.edu.pucp.INFOSiS.model.bean.user.UserType;
import pe.edu.pucp.INFOSiS.model.bean.HR.Intern;


@WebService(serviceName = "Server")
public class Server {
   
    @WebMethod (operationName = "QueryAllUsers")
    public ArrayList<User> QueryAllUsers(){
        return DBController.queryAllUsers();
    }
        
    @WebMethod (operationName = "InsertProfessor")
    public int InsertProfessor(@WebParam(name = "professor") Professor professor){
        return DBController.insertProfessor(professor);
    }
    
    @WebMethod (operationName= "VerifyUser")
    public UserType VerifyUser(@WebParam(name="user")User user){
        return DBController.verifyUser(user);
    }
    
    @WebMethod (operationName = "QueryAllInterns")
    public ArrayList<Intern> QueryAllInterns(){
        return DBController.queryAllInterns();
    }
    
    @WebMethod (operationName = "InsertIntern")
    public int InsertIntern(@WebParam(name = "intern") Intern intern,@WebParam(name = "access") UserType access){
        return DBController.insertIntern(intern, access);
    }
    
    @WebMethod (operationName = "UpdateIntern")
    public int UpdateIntern(@WebParam(name = "intern") Intern intern,@WebParam(name = "access") UserType access){
        return DBController.updateIntern(intern, access);
    }
    
    @WebMethod (operationName= "InsertInterested")
    public int InsertInterested(@WebParam(name="interested")Interested interested){
        return DBController.insertInterested(interested);
    }
    
    @WebMethod (operationName= "QueryAllInterested")
    public ArrayList<Interested> queryAllInterested(){
        return DBController.queryAllInterested();
    }
    @WebMethod (operationName= "QueryAllByCourse")
    public ArrayList<Interested> queryAllByCourse(@WebParam(name="course")Course course){
        return DBController.queryAllByCourse(course);
    }
    
}
