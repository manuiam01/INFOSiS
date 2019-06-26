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
    private Date begin;
    private Date end;
    
    public Date getBegin() {
        return begin;
    }

    public void setBegin(Date begin) {
        this.begin = begin;
    }

    public Date getEnd() {
        return end;
    }

    public void setEnd(Date end) {
        this.end = end;
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }
    
    

}