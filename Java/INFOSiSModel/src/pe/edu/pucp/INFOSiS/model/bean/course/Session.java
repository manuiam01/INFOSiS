/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.INFOSiS.model.bean.course;

import java.util.Date;

/**
 *
 * @author alulab14
 */
public class Session {

    public Session() {
    }
    
    
    private int id;
    private Date session;
    private String location;
    private int hours;

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public Date getSession() {
        return session;
    }

    public void setSession(Date session) {
        this.session = session;
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
    
}
