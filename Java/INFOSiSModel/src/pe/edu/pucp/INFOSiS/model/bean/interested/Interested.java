package pe.edu.pucp.INFOSiS.model.bean.interested;
import java.io.Serializable;
import java.util.*;
import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlRootElement;
import pe.edu.pucp.INFOSiS.model.bean.course.CourseType;
import pe.edu.pucp.INFOSiS.model.bean.Person;
import pe.edu.pucp.INFOSiS.model.bean.course.Course;

/**
 * 
 */

@XmlRootElement(name="Interested")
@XmlAccessorType(XmlAccessType.FIELD)
public class Interested extends Person implements Serializable{

    /**
     * Default constructor
     */
    public Interested() {
    }
    private int id;
    private ArrayList<Course> courses;
    private boolean isUnsubscribed;
    private String emailPUCP;
    private Date regDate;

    public Interested(int id, ArrayList<Course> courses, boolean isUnsubscribed, String emailPUCP, Date regDate, String idNumber, int idType, String firstName, String middleName, String primaryLastName, String secondLastName, String gender, String email, String cellPhoneNumber, Date birthday) {
        super(idNumber, idType, firstName, middleName, primaryLastName, secondLastName, gender, email, cellPhoneNumber, birthday);
        this.id = id;
        this.courses = courses;
        this.isUnsubscribed = isUnsubscribed;
        this.emailPUCP = emailPUCP;
        this.regDate = regDate;
    }
    

    
    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public Date getRegDate() {
        return regDate;
    }

    public void setRegDate(Date regDate) {
        this.regDate = regDate;
    }

    public String getEmailPUCP() {
        return emailPUCP;
    }

    public void setEmailPUCP(String emailPUCP) {
        this.emailPUCP = emailPUCP;
    }

    public ArrayList<Course> getCourses() {
        return courses;
    }

    public void setCourses(ArrayList<Course> courses) {
        this.courses = courses;
    }

    public boolean isIsUnsubscribed() {
        return isUnsubscribed;
    }

    public void setIsUnsubscribed(boolean isUnsubscribed) {
        this.isUnsubscribed = isUnsubscribed;
    }


}