package pe.edu.pucp.INFOSiS.model.bean.HR;
import java.io.Serializable;
import java.util.*;

/**
 * 
 */
public class Role implements Serializable {

    /**
     * Default constructor
     */
    public Role() {
    }

    private int id;
    private String name;
    private boolean isActive;


    public Role(int id, String name, boolean isActive, double minSalary, double maxSalary) {
        this.id = id;
        this.name = name;
        this.isActive = isActive;
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public boolean isIsActive() {
        return isActive;
    }

    public void setIsActive(boolean isActive) {
        this.isActive = isActive;
    }

}