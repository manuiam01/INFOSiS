package pe.edu.pucp.INFOSiS.model.bean.student;
import pe.edu.pucp.INFOSiS.model.bean.interested.Interested;
import java.util.*;
import pe.edu.pucp.INFOSiS.model.bean.course.CourseHistory;
import pe.edu.pucp.INFOSiS.model.bean.course.CourseType;
import pe.edu.pucp.INFOSiS.model.bean.course.Voucher;

/**
 * 
 */
public class Student extends Interested {

    /**
     * Default constructor
     */
    public Student() {
    }


    private String homePhone;
    private ArrayList<String> idPUCPList;
    private Date birthDate;
    private String address;
    private ArrayList<CourseHistory> history;
    private ArrayList<Float> historyGrade;
    private ArrayList<String> historyState;
    private ArrayList<Voucher> vouchers;

    public Student(String homePhone, ArrayList<String> idPUCPList, Date birthDate, String address, ArrayList<CourseHistory> history, ArrayList<Float> historyGrade, ArrayList<String> historyState, ArrayList<Voucher> vouchers, ArrayList<CourseType> courseTypes, boolean isUnsubscribed, String idNumber, int idType, String firstName, String middleName, String primaryLastName, String secondLastName, String gender, String email, String cellPhoneNumber) {
        super(courseTypes, isUnsubscribed, idNumber, idType, firstName, middleName, primaryLastName, secondLastName, gender, email, cellPhoneNumber);
        this.homePhone = homePhone;
        this.idPUCPList = idPUCPList;
        this.birthDate = birthDate;
        this.address = address;
        this.history = history;
        this.historyGrade = historyGrade;
        this.historyState = historyState;
        this.vouchers = vouchers;
    }

   

    public String getHomePhone() {
        return homePhone;
    }

    public void setHomePhone(String homePhone) {
        this.homePhone = homePhone;
    }

    public ArrayList<String> getIdPUCPList() {
        return idPUCPList;
    }

    public void setIdPUCPList(ArrayList<String> idPUCPList) {
        this.idPUCPList = idPUCPList;
    }

    public Date getBirthDate() {
        return birthDate;
    }

    public void setBirthDate(Date birthDate) {
        this.birthDate = birthDate;
    }

    public String getAddress() {
        return address;
    }

    public void setAddress(String address) {
        this.address = address;
    }

    public ArrayList<CourseHistory> getHistory() {
        return history;
    }

    public void setHistory(ArrayList<CourseHistory> history) {
        this.history = history;
    }

    public ArrayList<Float> getHistoryGrade() {
        return historyGrade;
    }

    public void setHistoryGrade(ArrayList<Float> historyGrade) {
        this.historyGrade = historyGrade;
    }

    public ArrayList<String> getHistoryState() {
        return historyState;
    }

    public void setHistoryState(ArrayList<String> historyState) {
        this.historyState = historyState;
    }

    public ArrayList<Voucher> getVouchers() {
        return vouchers;
    }

    public void setVouchers(ArrayList<Voucher> vouchers) {
        this.vouchers = vouchers;
    }



}