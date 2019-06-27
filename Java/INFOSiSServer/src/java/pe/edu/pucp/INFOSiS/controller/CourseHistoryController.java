/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.INFOSiS.controller;

import java.io.Serializable;
import pe.edu.pucp.INFOSiS.model.bean.course.CourseHistory;

/**
 *
 * @author alulab14
 */
public class CourseHistoryController implements Serializable{
    private CourseHistory courseHistory;

    public CourseHistoryController(CourseHistory courseHistory) {
        courseHistory = new CourseHistory();
    }       

    public CourseHistory getCourseHistory() {
        return courseHistory;
    }

    public void setCourseHistory(CourseHistory courseHistory) {
        this.courseHistory = courseHistory;
    }
    
}
