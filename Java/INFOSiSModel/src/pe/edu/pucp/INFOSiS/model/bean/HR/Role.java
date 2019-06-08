package pe.edu.pucp.INFOSiS.model.bean.HR;
import java.util.*;

/**
 * 
 */
public class Role {

    /**
     * Default constructor
     */
    public Role() {
    }

    private int id;
    private String name;
    private boolean isActive;
    private double minSalary;
    private double maxSalary;

    public Role(int id, String name, boolean isActive, double minSalary, double maxSalary) {
        this.id = id;
        this.name = name;
        this.isActive = isActive;
        this.minSalary = minSalary;
        this.maxSalary = maxSalary;
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

    public double getMinSalary() {
        return minSalary;
    }

    public void setMinSalary(double minSalary) {
        this.minSalary = minSalary;
    }

    public double getMaxSalary() {
        return maxSalary;
    }

    public void setMaxSalary(double maxSalary) {
        this.maxSalary = maxSalary;
    }

}