package pe.edu.pucp.INFOSiS.model.bean.course;
import java.io.File;
import java.util.*;

/**
 * 
 */
public class Course {

    /**
     * Default constructor
     */
    public Course() {
    }

    private String id;
    private String name;
    private boolean isActive;
    private CourseType courseType;
    private String description;
    private File syllabus;
    private ArrayList<String> contents;
    private ArrayList<Course> requisites;
    private ArrayList<Course> courseHistory;

    public Course(String id, String name, boolean isActive, CourseType courseType, String description, File syllabus, ArrayList<String> contents, ArrayList<Course> requisites, ArrayList<Course> courseHistory) {
        this.id = id;
        this.name = name;
        this.isActive = isActive;
        this.courseType = courseType;
        this.description = description;
        this.syllabus = syllabus;
        this.contents = contents;
        this.requisites = requisites;
        this.courseHistory = courseHistory;
    }

    public String getId() {
        return id;
    }

    public void setId(String id) {
        this.id = id;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public boolean getIsActive() {
        return isActive;
    }

    public void setIsActive(boolean isActive) {
        this.isActive = isActive;
    }

    public CourseType getCourseType() {
        return courseType;
    }

    public void setCourseType(CourseType courseType) {
        this.courseType = courseType;
    }

    public String getDescription() {
        return description;
    }

    public void setDescription(String description) {
        this.description = description;
    }

    public File getSyllabus() {
        return syllabus;
    }

    public void setSyllabus(File syllabus) {
        this.syllabus = syllabus;
    }

    public ArrayList<String> getContents() {
        return contents;
    }

    public void setContents(ArrayList<String> contents) {
        this.contents = contents;
    }

    public ArrayList<Course> getRequisites() {
        return requisites;
    }

    public void setRequisites(ArrayList<Course> requisites) {
        this.requisites = requisites;
    }

    public ArrayList<Course> getCourseHistory() {
        return courseHistory;
    }

    public void setCourseHistory(ArrayList<Course> courseHistory) {
        this.courseHistory = courseHistory;
    }



}