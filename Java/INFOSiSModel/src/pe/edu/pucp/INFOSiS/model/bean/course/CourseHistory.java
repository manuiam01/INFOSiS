package pe.edu.pucp.INFOSiS.model.bean.course;

import pe.edu.pucp.INFOSiS.model.bean.student.Student;
import pe.edu.pucp.INFOSiS.model.bean.professor.Professor;
import java.io.File;
import java.util.*;

/**
 * Curso dictado en algún momento
 */
public class CourseHistory {

    /**
     * Default constructor
     */
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
    private ArrayList<Student> students;
    private ArrayList<Voucher> vouchers;
    private ArrayList<Float> historyGrade;
    private ArrayList<String> historyState;

    public CourseHistory(int id, ArrayList<Date> sessions, ArrayList<String> locations, ArrayList<Integer> hoursSession, Course course, Professor professor, Professor assistant, int hours, File survey, ArrayList<Student> students, ArrayList<Voucher> vouchers, ArrayList<Float> historyGrade, ArrayList<String> historyState) {
        this.id = id;
        this.sessions = sessions;
        this.locations = locations;
        this.hoursSession = hoursSession;
        this.course = course;
        this.professor = professor;
        this.assistant = assistant;
        this.hours = hours;
        this.survey = survey;
        this.students = students;
        this.vouchers = vouchers;
        this.historyGrade = historyGrade;
        this.historyState = historyState;
    }

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

    public ArrayList<Voucher> getVouchers() {
        return vouchers;
    }

    public void setVouchers(ArrayList<Voucher> vouchers) {
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






}