package pe.edu.pucp.INFOSiS.model.bean.professor;
import java.io.Serializable;
import java.util.Date;
import java.util.ArrayList;
import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlRootElement;
import pe.edu.pucp.INFOSiS.model.bean.course.Course;
import pe.edu.pucp.INFOSiS.model.bean.Person;

/**
 * 
 */
@XmlRootElement(name="Professor")
@XmlAccessorType(XmlAccessType.FIELD)

public class Professor extends Person implements Serializable{

    private String idPUCP;
    private String emailPUCP;
    private ArrayList<Course> coursesCanTeach;
    private boolean isActive;
    
    public Professor() {
        coursesCanTeach = new ArrayList<Course>();
    }

    public Professor(String idPUCP, String emailPUCP, Date birthDate, ArrayList<Course> coursesCanTeach, boolean isActive, String idNumber, int idType, String firstName, String middleName, String primaryLastName, String secondLastName, String gender, String email, String cellPhoneNumber, Date birthday) {
        super(idNumber, idType, firstName, middleName, primaryLastName, secondLastName, gender, email, cellPhoneNumber, birthday);
        this.idPUCP = idPUCP;
        this.emailPUCP = emailPUCP;
        this.coursesCanTeach = coursesCanTeach;
        this.isActive = isActive;
    }


    public String getIdPUCP() {
        return idPUCP;
    }

    public void setIdPUCP(String idPUCP) {
        this.idPUCP = idPUCP;
    }

    public String getEmailPUCP() {
        return emailPUCP;
    }

    public void setEmailPUCP(String emailPUCP) {
        this.emailPUCP = emailPUCP;
    }

    public ArrayList<Course> getCoursesCanTeach() {
        return this.coursesCanTeach;
    }

    public void setCoursesCanTeach(ArrayList<Course> coursesCanTeach) {
        this.coursesCanTeach = coursesCanTeach;
    }

    public boolean getIsActive() {
        return isActive;
    }

    public void setIsActive(boolean isActive) {
        this.isActive = isActive;
    }

}