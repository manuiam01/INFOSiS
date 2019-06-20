package pe.edu.pucp.INFOSiS.model.bean.HR;
import java.io.Serializable;
import java.time.LocalDateTime;
import java.util.*;
import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlRootElement;

/**
 * 
 */
@XmlRootElement(name="InternAssistance")
@XmlAccessorType(XmlAccessType.FIELD)
public class InternAssistance implements Serializable{

    /**
     * Default constructor
     */
    public InternAssistance() {
    }

    private int id;
    private LocalDateTime begin;
    private LocalDateTime end;

    public InternAssistance(int id, LocalDateTime begin, LocalDateTime end) {
        this.id = id;
        this.begin = begin;
        this.end = end;
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public LocalDateTime getBegin() {
        return begin;
    }

    public void setBegin(LocalDateTime begin) {
        this.begin = begin;
    }

    public LocalDateTime getEnd() {
        return end;
    }

    public void setEnd(LocalDateTime end) {
        this.end = end;
    }
    
    

}