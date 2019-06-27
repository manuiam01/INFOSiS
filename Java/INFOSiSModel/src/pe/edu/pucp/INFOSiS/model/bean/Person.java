package pe.edu.pucp.INFOSiS.model.bean;

import java.io.Serializable;
import java.util.Date;
import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlRootElement;

/**
 * 
 */
@XmlRootElement(name="Person")
@XmlAccessorType(XmlAccessType.FIELD)

public class Person implements Serializable {

    private String idNumber;
    private int idType;
    private String firstName;
    private String middleName;
    private String primaryLastName;
    private String secondLastName;
    private String completeName;
    private String gender;
    private String email;
    private String cellPhoneNumber;
    private Date birthday;

    public Person() {
        birthday=null;
    }

    public Person(String idNumber, int idType, String firstName, String middleName, String primaryLastName, String secondLastName, String gender, String email, String cellPhoneNumber, Date birthday) {
        this.idNumber = idNumber;
        this.idType = idType;
        this.firstName = firstName;
        this.middleName = middleName;
        this.primaryLastName = primaryLastName;
        this.secondLastName = secondLastName;
        this.completeName = this.firstName + " " + this.middleName + " " + this.primaryLastName + " " + this.secondLastName;
        this.gender = gender;
        this.email = email;
        this.cellPhoneNumber = cellPhoneNumber;
        this.birthday = birthday;
    }

    public String getIdNumber() {
        return idNumber;
    }

    public void setIdNumber(String idNumber) {
        this.idNumber = idNumber;
    }

    public int getIdType() {
        return idType;
    }

    public void setIdType(int idType) {
        this.idType = idType;
    }

    public String getFirstName() {
        return firstName;
    }

    public void setFirstName(String firstName) {
        this.firstName = firstName;
    }

    public String getMiddleName() {
        return middleName;
    }

    public void setMiddleName(String middleName) {
        this.middleName = middleName;
    }

    public String getPrimaryLastName() {
        return primaryLastName;
    }

    public void setPrimaryLastName(String primaryLastName) {
        this.primaryLastName = primaryLastName;
    }

    public String getSecondLastName() {
        return secondLastName;
    }

    public void setSecondLastName(String secondLastName) {
        this.secondLastName = secondLastName;
    }

    public String getGender() {
        return gender;
    }

    public void setGender(String gender) {
        this.gender = gender;
    }

    public String getEmail() {
        return email;
    }

    public void setEmail(String email) {
        this.email = email;
    }

    public String getCellPhoneNumber() {
        return cellPhoneNumber;
    }

    public void setCellPhoneNumber(String cellPhoneNumber) {
        this.cellPhoneNumber = cellPhoneNumber;
    }
    
    public Date getBirthday() {
        return birthday;
    }

    public void setBirthday(Date birthday) {
        this.birthday = birthday;
    }
    
    public String getCompleteName(){
        return firstName + middleName + primaryLastName + secondLastName;
    }
    
    public void setCompleteName(){
        this.completeName = this.firstName + " " + this.middleName + " " + this.primaryLastName + " " + this.secondLastName;
    }
}