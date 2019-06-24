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
    }

    private int id;
    private ArrayList<Date> sessions;
    private ArrayList<String> locations;
    private ArrayList<Integer> hoursSession;
    private Course course;
    private Professor professor;
    private Professor assistant;
    private int hours;
    private File survey;
    private Date startDate;
    private Date endDate;
    private ArrayList<Student> students;
    private ArrayList<Integer> vouchers;
    private ArrayList<Float> historyGrade;
    private ArrayList<String> historyState;

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public ArrayList<Date> getSessions() {
        return sessions;
    }

    public void setSessions(ArrayList<Date> sessions) {
        this.sessions = sessions;
    }

    public ArrayList<String> getLocations() {
        return locations;
    }

    public void setLocations(ArrayList<String> locations) {
        this.locations = locations;
    }

    public ArrayList<Integer> getHoursSession() {
        return hoursSession;
    }

    public void setHoursSession(ArrayList<Integer> hoursSession) {
        this.hoursSession = hoursSession;
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

    public File getSurvey() {
        return survey;
    }

    public void setSurvey(File survey) {
        this.survey = survey;
    }

    public ArrayList<Student> getStudents() {
        return students;
    }

    public void setStudents(ArrayList<Student> students) {
        this.students = students;
    }

    public ArrayList<Integer> getVouchers() {
        return vouchers;
    }

    public void setVouchers(ArrayList<Integer> vouchers) {
        this.vouchers = vouchers;
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

    
}