package pe.edu.pucp.INFOSiS.model.bean.interested;
import java.io.Serializable;
import java.util.*;
import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlRootElement;
import pe.edu.pucp.INFOSiS.model.bean.course.CourseType;
import pe.edu.pucp.INFOSiS.model.bean.Person;

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
    private ArrayList<CourseType> courseTypes;
    private boolean isUnsubscribed;
    private String emailPUCP;
    private Date regDate;
    
    public Interested(ArrayList<CourseType> courseTypes, boolean isUnsubscribed, String idNumber, int idType, String firstName, String middleName, String primaryLastName, String secondLastName, String gender, String email, String cellPhoneNumber) {
        super(idNumber, idType, firstName, middleName, primaryLastName, secondLastName, gender, email, cellPhoneNumber);
        this.courseTypes = courseTypes;
        this.isUnsubscribed = isUnsubscribed;
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