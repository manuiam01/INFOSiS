package pe.edu.pucp.INFOSiS.model.bean.HR;
import java.util.*;
import pe.edu.pucp.INFOSiS.model.bean.user.User;

/**
 * 
 */
public class Intern extends Employee {

    /**
     * Default constructor
     */
    public Intern() {
    }

    private ArrayList<RoleHistory> history;
    private ArrayList<InternAssistance> assistance;
    /**
     * String de 0's y 1's por cada hora de cada de día de la semana, donde 0 es no disponible y 1 es disponible.
     */
    private String weekAvailability;
    /**
     * String de 0's y 1's por cada hora de cada de día de la semana, donde 0 es no agendado y 1 es agendado.
     */
    private String weekSchedule;

    public Intern(ArrayList<RoleHistory> history, ArrayList<InternAssistance> assistance, String weekAvailability, String weekSchedule, String idPUCP, String emailPUCP, String address, String homePhone, Date birthDate, User user, String idNumber, int idType, String firstName, String middleName, String primaryLastName, String secondLastName, String gender, String email, String cellPhoneNumber) {
        super(idPUCP, emailPUCP, address, homePhone, birthDate, user, idNumber, idType, firstName, middleName, primaryLastName, secondLastName, gender, email, cellPhoneNumber);
        this.history = history;
        this.assistance = assistance;
        this.weekAvailability = weekAvailability;
        this.weekSchedule = weekSchedule;
    }

    

    public ArrayList<RoleHistory> getHistory() {
        return history;
    }

    public void setHistory(ArrayList<RoleHistory> history) {
        this.history = history;
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