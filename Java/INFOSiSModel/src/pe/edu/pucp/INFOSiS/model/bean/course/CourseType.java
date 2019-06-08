package pe.edu.pucp.INFOSiS.model.bean.course;
import java.util.*;

/**
 * 
 */
public class CourseType {

    /**
     * Default constructor
     */
    public CourseType() {
    }


    private int id;
    private String name;
    public ArrayList<Course> coursesList;

    public CourseType(int id, String name, ArrayList<Course> coursesList) {
        this.id = id;
        this.name = name;
        this.coursesList = coursesList;
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public ArrayList<Course> getCoursesList() {
        return coursesList;
    }

    public void setCoursesList(ArrayList<Course> coursesList) {
        this.coursesList = coursesList;
    }


}