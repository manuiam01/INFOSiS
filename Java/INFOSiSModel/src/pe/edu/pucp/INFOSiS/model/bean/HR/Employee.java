package pe.edu.pucp.INFOSiS.model.bean.HR;
import java.util.*;
import pe.edu.pucp.INFOSiS.model.bean.Person;
import pe.edu.pucp.INFOSiS.model.bean.user.User;

/**
 * 
 */
public abstract class Employee extends Person {

    /**
     * Default constructor
     */
    private String idPUCP;
    private String emailPUCP;
    private String address;
    private String homePhone;
    private Date birthDate;
    private User user;

    public Employee(){
        
    }            

    public Employee(String idPUCP, String emailPUCP, String address, String homePhone, Date birthDate, User user, String idNumber, int idType, String firstName, String middleName, String primaryLastName, String secondLastName, String gender, String email, String cellPhoneNumber) {
        super(idNumber, idType, firstName, middleName, primaryLastName, secondLastName, gender, email, cellPhoneNumber);
        this.idPUCP = idPUCP;
        this.emailPUCP = emailPUCP;
        this.address = address;
        this.homePhone = homePhone;
        this.birthDate = birthDate;
        this.user=user;
    }
    
    public User getUser() {
        return user;
    }

    public void setUser(User user) {
        this.user = user;
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

    public String getAddress() {
        return address;
    }

    public void setAddress(String address) {
        this.address = address;
    }

    public String getHomePhone() {
        return homePhone;
    }

    public void setHomePhone(String homePhone) {
        this.homePhone = homePhone;
    }

    public Date getBirthDate() {
        return birthDate;
    }

    public void setBirthDate(Date birthDate) {
        this.birthDate = birthDate;
    }
    
    

}