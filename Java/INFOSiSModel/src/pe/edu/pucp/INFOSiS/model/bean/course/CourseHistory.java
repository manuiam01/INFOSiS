package pe.edu.pucp.INFOSiS.model.bean.course;

import pe.edu.pucp.INFOSiS.model.bean.student.Student;
import pe.edu.pucp.INFOSiS.model.bean.professor.Professor;
import java.io.File;
import java.io.Serializable;
import java.util.*;
import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlRootElement;

/**
 * Curso dictado en algún momento
 */
@XmlRootElement(name="CourseHistory")
@XmlAccessorType(XmlAccessType.FIELD)
public class CourseHistory implements Serializable{
    
    public CourseHistory() {
        id = 0;
    }

    private int id;    
    private ArrayList<Session> sessions;
    private Course course;
    private Professor professor;
    private Professor assistant;
    private int hours;
    private byte[] survey;
    private Date startDate;
    private Date endDate;
    private ArrayList<Student> students;
    private ArrayList<Float> amountPaids;
    private ArrayList<Float> historyGrade;
    private ArrayList<String> historyState;
    private String courseName; 

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public Course getCourse() {
        return course;
    }

    public void setCourse(Course course) {
        this.course = course;
    }

    public Professor getProfessor() {
        return professor;
    }

    public void setProfessor(Professor professor) {
        this.professor = professor;
    }

    public Professor getAssistant() {
        return assistant;
    }

    public void setAssistant(Professor assistant) {
        this.assistant = assistant;
    }

    public int getHours() {
        return hours;
    }

    public void setHours(int hours) {
        this.hours = hours;
    }

    public byte[] getSurvey() {
        return survey;
    }

    public void setSurvey(byte[] survey) {
        this.survey = survey;
    }    

    public ArrayList<Student> getStudents() {
        return students;
    }

    public void setStudents(ArrayList<Student> students) {
        this.students = students;
    }

    public ArrayList<Float> getAmountPaids() {
        return amountPaids;
    }

    public void setAmountPaids(ArrayList<Float> amountPaids) {
        this.amountPaids = amountPaids;
    }

    public ArrayList<Float> getHistoryGrade() {
        return historyGrade;
    }

    public void setHistoryGrade(ArrayList<Float> historyGrade) {
        this.historyGrade = historyGrade;
    }

    public ArrayList<String> getHistoryState() {
        return historyState;
    }

    public void setHistoryState(ArrayList<String> historyState) {
        this.historyState = historyState;
    }

    public Date getStartDate() {
        return startDate;
    }

    public void setStartDate(Date startDate) {
        this.startDate = startDate;
    }

    public Date getEndDate() {
        return endDate;
    }

    public void setEndDate(Date endDate) {
        this.endDate = endDate;
    }

    public ArrayList<Session> getSessions() {
        return sessions;
    }

    public void setSessions(ArrayList<Session> sessions) {
        this.sessions = sessions;
    }

    public String getCourseName() {
        return courseName;
    }

    public void setCourseName(String courseName) {
        this.courseName = courseName;
    }
    
    

}