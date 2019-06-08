package pe.edu.pucp.INFOSiS.model.bean.HR;
import java.util.*;

/**
 * 
 */
public class RoleHistory extends Role {

    /**
     * Default constructor
     */
    public RoleHistory() {
    }
    private int id;
    private Date beginDate;
    private Date endDate;
    private boolean isActual;
    private int hours;

    public RoleHistory(int id, Date beginDate, Date endDate, boolean isActual, int hours) {
        this.id = id;
        this.beginDate = beginDate;
        this.endDate = endDate;
        this.isActual = isActual;
        this.hours = hours;
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public Date getBeginDate() {
        return beginDate;
    }

    public void setBeginDate(Date beginDate) {
        this.beginDate = beginDate;
    }

    public Date getEndDate() {
        return endDate;
    }

    public void setEndDate(Date endDate) {
        this.endDate = endDate;
    }

    public boolean isIsActual() {
        return isActual;
    }

    public void setIsActual(boolean isActual) {
        this.isActual = isActual;
    }

    public int getHours() {
        return hours;
    }

    public void setHours(int hours) {
        this.hours = hours;
    }


}