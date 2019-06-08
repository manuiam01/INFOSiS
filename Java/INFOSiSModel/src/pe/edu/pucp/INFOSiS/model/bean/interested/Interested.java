package pe.edu.pucp.INFOSiS.model.bean.interested;
import java.util.*;
import pe.edu.pucp.INFOSiS.model.bean.course.CourseType;
import pe.edu.pucp.INFOSiS.model.bean.Person;

/**
 * 
 */
public class Interested extends Person {

    /**
     * Default constructor
     */
    public Interested() {
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }
    private int id;
    private ArrayList<CourseType> courseTypes;
    private boolean isUnsubscribed;
    private String emailPUCP;
    private Date regDate;

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
  

    public Interested(ArrayList<CourseType> courseTypes, boolean isUnsubscribed, String idNumber, int idType, String firstName, String middleName, String primaryLastName, String secondLastName, String gender, String email, String cellPhoneNumber) {
        super(idNumber, idType, firstName, middleName, primaryLastName, secondLastName, gender, email, cellPhoneNumber);
        this.courseTypes = courseTypes;
        this.isUnsubscribed = isUnsubscribed;
    }

    public ArrayList<CourseType> getCourseTypes() {
        return courseTypes;
    }

    public void setCourseTypes(ArrayList<CourseType> courseTypes) {
        this.courseTypes = courseTypes;
    }

    public boolean isIsUnsubscribed() {
        return isUnsubscribed;
    }

    public void setIsUnsubscribed(boolean isUnsubscribed) {
        this.isUnsubscribed = isUnsubscribed;
    }


}