/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.INFOSiS.controller.dao;

import pe.edu.pucp.INFOSiS.model.bean.course.Course;

/**
 *
 * @author tkuser
 */
public interface DAOCourse {
    int insert(Course course);
    void update (Course course,int id);
}
