/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.INFOSiS.model.bean.course;

import java.io.Serializable;
import java.time.LocalDate;
import java.time.LocalDateTime;

import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlRootElement;

/**
 *
 * @author alulab14
 */
@XmlRootElement(name="Session")
@XmlAccessorType(XmlAccessType.FIELD)
public class Session implements Serializable{

    public Session() {
        id = 0;
    }
    
    
    private int id;
    private LocalDateTime dateSession;
    private String location;
    private int hours;
    private boolean isActive; 

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public LocalDateTime getDateSession() {
        return dateSession;
    }

    public void setDateSession(LocalDateTime dateSession) {
        this.dateSession = dateSession;
    }

    
    
    public String getLocation() {
        return location;
    }

    public void setLocation(String location) {
        this.location = location;
    }

    public int getHours() {
        return hours;
    }

    public void setHours(int hours) {
        
        this.hours = hours;
    }

    public boolean isIsActive() {
        return isActive;
    }

    public void setIsActive(boolean isActive) {
        this.isActive = isActive;
    }
    
}
