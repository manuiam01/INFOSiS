package pe.edu.pucp.INFOSiS.model.bean.HR;
import java.io.Serializable;
import java.util.*;
import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlRootElement;
import pe.edu.pucp.INFOSiS.model.bean.user.User;

/**
 * 
 */
@XmlRootElement(name="Intern")
@XmlAccessorType(XmlAccessType.FIELD)
public class Intern extends Employee implements Serializable{
    
    private ArrayList<InternAssistance> assistance;
    private String weekAvailability;
    private String weekSchedule;
    
    public Intern() {
        assistance = new ArrayList<InternAssistance>();
    }

    public Intern(ArrayList<InternAssistance> assistance, String weekAvailability, String weekSchedule, String idPUCP, String emailPUCP, String address, String homePhone, User user, String idNumber, int idType, String firstName, String middleName, String primaryLastName, String secondLastName, String gender, String email, String cellPhoneNumber, Date birthday) {
        super(idPUCP, emailPUCP, address, homePhone, user, idNumber, idType, firstName, middleName, primaryLastName, secondLastName, gender, email, cellPhoneNumber, birthday);
        this.assistance = assistance;
        this.weekAvailability = weekAvailability;
        this.weekSchedule = weekSchedule;
    }


    public ArrayList<InternAssistance> getAssistance() {
        return assistance;
    }

    public void setAssistance(ArrayList<InternAssistance> assistance) {
        this.assistance = assistance;
    }

    public String getWeekAvailability() {
        return weekAvailability;
    }

    public void setWeekAvailability(String weekAvailability) {
        this.weekAvailability = weekAvailability;
    }

    public String getWeekSchedule() {
        return weekSchedule;
    }

    public void setWeekSchedule(String weekSchedule) {
        this.weekSchedule = weekSchedule;
    }


}