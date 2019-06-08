package pe.edu.pucp.INFOSiS.model.bean.HR;
import java.time.LocalDateTime;
import java.util.*;

/**
 * 
 */
public class InternAssistance {

    /**
     * Default constructor
     */
    public InternAssistance() {
    }

    private int id;

    /**
     * //Para darle formato
     * DateTimeFormatter dtf = DateTimeFormatter.ofPattern("yyyy/MM/dd HH:mm:ss");
     * 	LocalDateTime now = LocalDateTime.now();
     * 	System.out.println(dtf.format(now)); //2016/11/16 12:08:43
     */
    private LocalDateTime begin;

    /**
     * //Para darle forma
     * DateTimeFormatter dtf = DateTimeFormatter.ofPattern("yyyy/MM/dd HH:mm:ss");
     * 	LocalDateTime now = LocalDateTime.now();
     * 	System.out.println(dtf.format(now)); //2016/11/16 12:08:43
     */
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