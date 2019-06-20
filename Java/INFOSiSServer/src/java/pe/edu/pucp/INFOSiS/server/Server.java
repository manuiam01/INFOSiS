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
import pe.edu.pucp.INFOSiS.model.bean.course.CourseType;
import pe.edu.pucp.INFOSiS.model.bean.student.Student;


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
    
    @WebMethod (operationName = "UpdateProfessor")
    public int UpdateProfessor(@WebParam(name = "professor") Professor professor){
        return DBController.updateProfessor(professor);
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
    
    @WebMethod(operationName="QueryInterestedByID")
    public Interested queryInterestedByID(@WebParam(name="IDInterested")String idInterested){
        return DBController.queryInterestedById(idInterested);
    }
    
    @WebMethod(operationName="UpdateInterested")
    public int updateInterested(@WebParam(name="interested")Interested interested){
        return DBController.updateInterested(interested);
    }
    
    @WebMethod(operationName="InsertStudent")
    public int insertStudent(@WebParam(name="student")Student student){
        return DBController.insertStudent(student);
    }

    
    @WebMethod(operationName="SearchProfessorById")
    public Professor SearchProfessorById(@WebParam(name="id") String id){
        return DBController.searchProfessorById(id);
    }
    
    @WebMethod(operationName="SearchProfessorByName")
    public ArrayList<Professor> SearchProfessorByName(@WebParam(name="name") String name,
            @WebParam(name="middle_name") String middle_name,
            @WebParam(name="first_last_name") String first_last_name,
            @WebParam(name="second_last_name") String second_last_name){
        return DBController.searchProfessorByName(name,middle_name,first_last_name,second_last_name);
    }
    
    @WebMethod(operationName="InsertCourse")
    public int InsertCourse(@WebParam(name="Course") Course course){
        return DBController.insertCourse(course);
    }
    
    @WebMethod(operationName="UpdateCourse")
    public int UpdateCourse(@WebParam(name="Course") Course course){
        return DBController.updateCourse(course);
    }
    
    @WebMethod(operationName="DisableCourse")
    public int DisableCourse(@WebParam(name="Course") Course course){
        return DBController.disableCourse(course);
    }
    
    @WebMethod(operationName="queryAllCourse")
    public ArrayList<Course> QueryAllCourse(){
        return DBController.queryAllCourse();
    }
    
    @WebMethod(operationName="queryCourseById")
    public Course InsertCourse(@WebParam(name="id") String id){
        return DBController.queryCourseById(id);
    }
    
    @WebMethod(operationName="InsertCourse")
    public ArrayList<Course> QueryAllCoursesByName(@WebParam(name="name") String name){
        return DBController.queryCourseByName(name);
    }
    
    @WebMethod(operationName="InsertCourseType")
    public int InsertCourseType(CourseType coursetype){
        return DBController.insertCourseType(coursetype);
    }
    
    @WebMethod(operationName="UpdateCourseType")
    public int UpdateCourseType(CourseType coursetype){
        return DBController.updateCourseType(coursetype);
    }
    
    @WebMethod(operationName="queryAllCourseType")
    public ArrayList<CourseType> QueryAllCourseType(){
        return DBController.queryAllCourseType();

    }
    
    @WebMethod(operationName="queryCourseTypeById")
    public CourseType QueryCourseTypeById(int id){
        return DBController.queryCourseTypeById(id);
    }
    
}
