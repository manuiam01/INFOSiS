/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.INFOSiS.controller.dao;

import java.util.ArrayList;
import pe.edu.pucp.INFOSiS.model.bean.course.CourseType;

/**
 *
 * @author JEREMI
 */
public interface DAOCourseType {
    int insert(CourseType coursetype);
    int update(CourseType coursetype);
    ArrayList<CourseType> queryAll();
}
