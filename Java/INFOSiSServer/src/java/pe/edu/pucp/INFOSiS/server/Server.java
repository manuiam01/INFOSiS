/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.INFOSiS.server;

import java.util.ArrayList;
import java.util.Date;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import pe.edu.pucp.INFOSiS.controller.config.DBController;
import pe.edu.pucp.INFOSiS.controller.mysql.MySQLProfessor;
import pe.edu.pucp.INFOSiS.controller.mysql.MySQLUser;
import pe.edu.pucp.INFOSiS.model.bean.HR.Coordinator;
import pe.edu.pucp.INFOSiS.model.bean.course.Course;
import pe.edu.pucp.INFOSiS.model.bean.interested.Interested;
import pe.edu.pucp.INFOSiS.model.bean.professor.Professor;
import pe.edu.pucp.INFOSiS.model.bean.user.User;
import pe.edu.pucp.INFOSiS.model.bean.user.UserType;
import pe.edu.pucp.INFOSiS.model.bean.HR.Intern;
import pe.edu.pucp.INFOSiS.model.bean.HR.InternAssistance;
import pe.edu.pucp.INFOSiS.model.bean.course.CalendarSession;
import pe.edu.pucp.INFOSiS.model.bean.course.CourseHistory;
import pe.edu.pucp.INFOSiS.model.bean.course.CourseType;
import pe.edu.pucp.INFOSiS.model.bean.student.Student;
import pe.edu.pucp.INFOSiS.model.bean.course.Session;


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
    //INTERN
    @WebMethod (operationName = "QueryAllInterns")
    public ArrayList<Intern> QueryAllInterns(){
        return DBController.queryAllInterns();
    }
    
    @WebMethod (operationName = "SearchInternByIdPUCP")
    public Intern SearchInternByIdPUCP(@WebParam(name="id") String id){
        return DBController.searchInternByIdPUCP(id);
    }
    
    @WebMethod (operationName = "SearchInternByIdNumber")
    public Intern SearchInternByIdNumber(@WebParam(name="id") String id){
        return DBController.searchInternByIdNumber(id);
    }
    
    @WebMethod (operationName = "SearchInternByName")
    public ArrayList<Intern> SearchInternByName(@WebParam(name="firstName") String firstName,@WebParam(name="middleName") String middleName,@WebParam(name="primaryLastName") String primaryLastName,@WebParam(name="secondLastName") String secondLastName){
        return DBController.searchInternByName(firstName, middleName, primaryLastName, secondLastName);
    }
    
    @WebMethod (operationName = "InsertIntern")
    public int InsertIntern(@WebParam(name = "intern") Intern intern,@WebParam(name = "access") UserType access){
        return DBController.insertIntern(intern, access);
    }
    
    @WebMethod (operationName = "UpdateIntern")
    public int UpdateIntern(@WebParam(name = "intern") Intern intern){
        return DBController.updateIntern(intern);
    }
    
    @WebMethod (operationName = "UpdateWeekAvailability")
    public int UpdateWeekAvailability(@WebParam(name = "weekAvailability") String weekAvailability,@WebParam(name = "idIntern") String idIntern){
        return DBController.updateWeekAvailability(weekAvailability, idIntern);
    }
    
    @WebMethod (operationName = "GetWeekAvailability")
    public String GetWeekAvailability(@WebParam(name = "idIntern") String idIntern){
        return DBController.getWeekAvailability(idIntern);
    }
    
    //INTERESTED
    @WebMethod (operationName= "InsertInterested")
    public int InsertInterested(@WebParam(name="interested")Interested interested){
        return DBController.insertInterested(interested);
    }
    
    @WebMethod (operationName= "QueryAllInterested")
    public ArrayList<Interested> queryAllInterested(){
        return DBController.queryAllInterested();
    }
    
    @WebMethod (operationName= "QueryAllActiveInterested")
    public ArrayList<Interested> queryAllActiveInterested(){
        return DBController.queryAllActiveInterested();
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
    
    @WebMethod(operationName="SearchInterestedByName")
    public ArrayList<Interested> SearchInterestedByName(@WebParam(name="name") String name,
            @WebParam(name="middle_name") String middle_name,
            @WebParam(name="first_last_name") String first_last_name,
            @WebParam(name="second_last_name") String second_last_name){
        return DBController.searchInterestedByName(name,middle_name,first_last_name,second_last_name);
    }
    
    @WebMethod(operationName="InsertStudent")
    public int insertStudent(@WebParam(name="student")Student student,
            @WebParam(name="birthday") String birthday){
        return DBController.insertStudent(student, birthday);
    }
    
    @WebMethod(operationName="SearchProfessorByIdPUCP")
    public Professor SearchProfessorByIdPUCP(@WebParam(name="id") String id){
        return DBController.searchProfessorByIdPUCP(id);
    }
    
    @WebMethod(operationName="SearchProfessorById")
    public int SearchProfessorById(@WebParam(name="id") String id){
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
    public int InsertCourse(@WebParam(name="course") Course course){
        return DBController.insertCourse(course);
    }
    
    @WebMethod(operationName="UpdateCourse")
    public int UpdateCourse(@WebParam(name="course") Course course){
        return DBController.updateCourse(course);
    }
    
    @WebMethod(operationName="DisableCourse")
    public int DisableCourse(@WebParam(name="course") Course course){
        return DBController.disableCourse(course);
    }
    
    @WebMethod(operationName="queryAllCourse")
    public ArrayList<Course> QueryAllCourse(){
        return DBController.queryAllCourse();
    }
    
    @WebMethod(operationName="queryCourseById")
    public Course queryCourseById(@WebParam(name="id") String id){
        return DBController.queryCourseById(id);
    }
    
    @WebMethod(operationName="queryAllCoursesByName")
    public ArrayList<Course> QueryAllCoursesByName(@WebParam(name="name") String name){
        return DBController.queryCourseByName(name);
    }
    
    @WebMethod(operationName="InsertCourseType")
    public int InsertCourseType(@WebParam(name="courseType") CourseType coursetype){
        return DBController.insertCourseType(coursetype);
    }
    
    @WebMethod(operationName="UpdateCourseType")
    public int UpdateCourseType(@WebParam(name="courseType") CourseType coursetype){
        return DBController.updateCourseType(coursetype);
    }
    
    @WebMethod(operationName="queryAllCourseType")
    public ArrayList<CourseType> QueryAllCourseType(){
        return DBController.queryAllCourseType();

    }
    
    @WebMethod(operationName="queryCourseTypeById")
    public CourseType QueryCourseTypeById(@WebParam(name="id") int id){
        return DBController.queryCourseTypeById(id);
    }
    
    @WebMethod(operationName="queryCourseHByDate")
    public ArrayList<CourseHistory> QueryCourseHByDate(@WebParam(name="date") Date date){
        return DBController.queryCourseHByDate(date);
    }       
    
    @WebMethod(operationName="updateStudent")
    public int updateStudent(@WebParam(name="student") Student student, 
            @WebParam(name="birthday") String birthday){
        return DBController.updateStudent(student, birthday);
    }
    
    @WebMethod(operationName="queryStudentById")
    public Student queryStudentById(@WebParam(name="idStudent") String idStudent){
        return DBController.queryStudentByID(idStudent);
    }
    
    @WebMethod(operationName="queryCourseHistoryByIdProfessor")
    public ArrayList<CourseHistory> queryCourseHistoryByIdProfessor(@WebParam(name="idProfessor") String idProfessor){
        return DBController.queryCourseHByIdProfessor(idProfessor);
    }
    
    @WebMethod(operationName="queryAllProfessorsActive")
    public ArrayList<Professor> queryAllProfessorsActive(){
        return DBController.queryAllProfessorsActive();
    }
    

    @WebMethod(operationName="queryCourseHistoryByCourse")
    public ArrayList<CourseHistory> queryCourseHistoryByCourse(@WebParam(name="idCourse") String idCourse){
        return DBController.queryCourseHByCourse(idCourse);
    }
    @WebMethod(operationName="querySessionsByDate")
    public ArrayList<CalendarSession> queryCalendarSessionByBeginDate(@WebParam(name="date")String date){
        return DBController.queryCalendarSessionByBeginDate(date);

    }
    
    @WebMethod(operationName="generateCourseHistoryReport")
    public byte[] generateCourseHistoryReport(@WebParam(name="idCourseHistory") int idCourseHistory){
        return DBController.generateCourseHistoryReport(idCourseHistory);
    }
    
    @WebMethod(operationName="saveCourseHistoryReport")
    public int saveCourseHistoryReport(@WebParam(name="idCourseHistory") int idCourseHistory, 
            @WebParam(name="route") String route){
        return DBController.saveCourseHistoryReport(idCourseHistory,route);
    }
    
    @WebMethod(operationName="insertCourseHistory")
    public int insertCourseHistory(@WebParam(name="CourseHistory") CourseHistory courseHistory,
                                   @WebParam(name="dias") ArrayList<Long> dias  ){
        return DBController.insertCourseHistory(courseHistory, dias);
    }
    
    @WebMethod(operationName="updateCourseHistory")
    public int updateCourseHistory(@WebParam(name="CourseHistory") CourseHistory courseHistory){
        return DBController.updateCourseHistory(courseHistory);
    }
    

    @WebMethod(operationName="getLastRegisterIntern")
    public InternAssistance getLastRegisterOfDay(@WebParam(name="pucpId") String pucpId){
        return DBController.getLastRegisterOfDay(pucpId);
    }
    
    @WebMethod(operationName="insertAssistance")
    public int insertAssistance(@WebParam(name="idPucp")String idPucp){
        return DBController.insertAssistance(idPucp);
    }
    
    @WebMethod(operationName="updateAssistance")
    public int updateAssistance(@WebParam(name="id") String id){
        return DBController.updateAsisstance(id);
    }
    
    public int updateUser(@WebParam(name="user") User u){
        return DBController.updateUser(u);
    }
    
    @WebMethod(operationName="queryCoordByID")
    public Coordinator queryCoordById(@WebParam(name="idPucp") String id){
        return DBController.queryCoordById(id);
    }
    
    @WebMethod(operationName="queryAllStudent")
    public ArrayList<Student> queryAllStudent(){
        return DBController.queryAllStudent();
    }
}
