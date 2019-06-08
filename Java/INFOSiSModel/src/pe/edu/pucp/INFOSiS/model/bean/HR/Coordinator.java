package pe.edu.pucp.INFOSiS.model.bean.HR;

import java.util.Date;
import pe.edu.pucp.INFOSiS.model.bean.user.User;

/**
 * 
 */
public class Coordinator extends Employee {

    public Coordinator() {
    }

    private String department;

    public Coordinator(String department, String idPUCP, String emailPUCP, String address, String homePhone, Date birthDate, User user, String idNumber, int idType, String firstName, String middleName, String primaryLastName, String secondLastName, String gender, String email, String cellPhoneNumber) {
        super(idPUCP, emailPUCP, address, homePhone, birthDate, user, idNumber, idType, firstName, middleName, primaryLastName, secondLastName, gender, email, cellPhoneNumber);
        this.department = department;
    }

    public String getDepartment() {
        return department;
    }

    public void setDepartment(String department) {
        this.department = department;
    }

    
    
}