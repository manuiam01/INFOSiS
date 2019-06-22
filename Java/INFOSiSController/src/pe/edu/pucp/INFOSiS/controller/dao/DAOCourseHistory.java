/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.INFOSiS.controller.dao;

import java.sql.Date;
import java.util.ArrayList;
import pe.edu.pucp.INFOSiS.model.bean.course.CourseHistory;

/**
 *
 * @author tkuser
 */
public interface DAOCourseHistory {
    int insert(CourseHistory courseHistory);
    void update(CourseHistory courseHistory);
    ArrayList<CourseHistory> queryByDate(Date datecourse);
}
