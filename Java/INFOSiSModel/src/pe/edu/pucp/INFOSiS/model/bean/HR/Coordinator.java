package pe.edu.pucp.INFOSiS.model.bean.HR;

import java.io.Serializable;
import java.util.Date;
import pe.edu.pucp.INFOSiS.model.bean.user.User;

/**
 * 
 */
public class Coordinator extends Employee implements Serializable{

    public Coordinator() {
    }

    public Coordinator(String idPUCP, String emailPUCP, String address, String homePhone, User user, String idNumber, int idType, String firstName, String middleName, String primaryLastName, String secondLastName, String gender, String email, String cellPhoneNumber, Date birthday) {
        super(idPUCP, emailPUCP, address, homePhone, user, idNumber, idType, firstName, middleName, primaryLastName, secondLastName, gender, email, cellPhoneNumber, birthday);
    }

}