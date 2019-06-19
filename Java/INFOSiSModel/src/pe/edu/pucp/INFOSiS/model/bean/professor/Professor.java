package pe.edu.pucp.INFOSiS.model.bean.professor;
import java.io.Serializable;
import java.util.*;
import pe.edu.pucp.INFOSiS.model.bean.course.Course;
import pe.edu.pucp.INFOSiS.model.bean.Person;

/**
 * 
 */
public class Professor extends Person implements Serializable{

    /**
     * Default constructor
     */
    public Professor() {
        coursesCanTeach = new ArrayList<>();
    }

    private String idPUCP;
    private String emailPUCP;
    private Date birthDate;
    private ArrayList<Course> coursesCanTeach;
    private boolean isActive;
    
    public Professor(String idPUCP, String emailPUCP, Date birthDate, ArrayList<Course> coursesCanTeach, boolean isActive) {
        this.idPUCP = idPUCP;
        this.emailPUCP = emailPUCP;
        this.birthDate = birthDate;
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

    public Date getBirthDate() {
        return birthDate;
    }

    public void setBirthDate(Date birthDate) {
        this.birthDate = birthDate;
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