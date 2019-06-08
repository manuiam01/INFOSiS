package pe.edu.pucp.INFOSiS.model.bean.course;
import pe.edu.pucp.INFOSiS.model.bean.student.Student;
import java.util.*;

/**
 * 
 */
public class Voucher {

    /**
     * Default constructor
     */
    public Voucher() {
    }

    private int id;
    private String type;
    private double amount;
    private Date date;
    private CourseHistory course;
    private Student student;

    public Voucher(int id, String type, double amount, Date date, CourseHistory course, Student student) {
        this.id = id;
        this.type = type;
        this.amount = amount;
        this.date = date;
        this.course = course;
        this.student = student;
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public String getType() {
        return type;
    }

    public void setType(String type) {
        this.type = type;
    }

    public double getAmount() {
        return amount;
    }

    public void setAmount(double amount) {
        this.amount = amount;
    }

    public Date getDate() {
        return date;
    }

    public void setDate(Date date) {
        this.date = date;
    }

    public CourseHistory getCourse() {
        return course;
    }

    public void setCourse(CourseHistory course) {
        this.course = course;
    }

    public Student getStudent() {
        return student;
    }

    public void setStudent(Student student) {
        this.student = student;
    }

  
}