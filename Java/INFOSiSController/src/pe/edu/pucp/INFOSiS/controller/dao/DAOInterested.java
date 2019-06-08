/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.INFOSiS.controller.dao;

import java.util.ArrayList;
import pe.edu.pucp.INFOSiS.model.bean.course.CourseType;
import pe.edu.pucp.INFOSiS.model.bean.interested.Interested;

/**
 *
 * @author JEREMI
 */
public interface DAOInterested {
    int insert(Interested interested);
    int update(Interested interested);
    int disable(Interested interested);
    ArrayList<Interested> queryAll();
    ArrayList<Interested> queryAllByCourseType(CourseType coursetype);
}
