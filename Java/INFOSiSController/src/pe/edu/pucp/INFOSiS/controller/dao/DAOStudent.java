/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.INFOSiS.controller.dao;

import java.util.ArrayList;
import pe.edu.pucp.INFOSiS.model.bean.student.Student;

/**
 *
 * @author tkuser
 */
public interface DAOStudent {
    int insertStudent(Student student, String birthDate);
    int updateStudent(Student student, String birthDate);
    Student queryStudentById(String id);
    ArrayList<Student> queryAll();
}
