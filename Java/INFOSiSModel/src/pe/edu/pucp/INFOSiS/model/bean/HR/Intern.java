package pe.edu.pucp.INFOSiS.model.bean.HR;
import java.io.Serializable;
import java.util.*;
import pe.edu.pucp.INFOSiS.model.bean.user.User;

/**
 * 
 */
public class Intern extends Employee implements Serializable{

    
    private ArrayList<InternAssistance> assistance;
    private String weekAvailability;
    private String weekSchedule;
    
    public Intern() {
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