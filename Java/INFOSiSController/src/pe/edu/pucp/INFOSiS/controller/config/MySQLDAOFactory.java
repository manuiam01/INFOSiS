/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.INFOSiS.controller.config;

import pe.edu.pucp.INFOSiS.controller.dao.DAOCourse;
import pe.edu.pucp.INFOSiS.controller.dao.DAOCourseType;
import pe.edu.pucp.INFOSiS.controller.dao.DAOInterested;
import pe.edu.pucp.INFOSiS.controller.dao.DAOIntern;
import pe.edu.pucp.INFOSiS.controller.dao.DAOProfessor;
import pe.edu.pucp.INFOSiS.controller.dao.DAOStudent;
import pe.edu.pucp.INFOSiS.controller.dao.DAOUser;
import pe.edu.pucp.INFOSiS.controller.mysql.MySQLCourse;
import pe.edu.pucp.INFOSiS.controller.mysql.MySQLCourseType;
import pe.edu.pucp.INFOSiS.controller.mysql.MySQLInterested;
import pe.edu.pucp.INFOSiS.controller.mysql.MySQLIntern;
import pe.edu.pucp.INFOSiS.controller.mysql.MySQLProfessor;
import pe.edu.pucp.INFOSiS.controller.mysql.MySQLStudent;
import pe.edu.pucp.INFOSiS.controller.mysql.MySQLUser;

/**
 *
 * @author ASUS
 */
public class MySQLDAOFactory extends DAOFactory{

    public MySQLDAOFactory() {
        
    }
    
    @Override
    public DAOUser getUserDAO(){
        return new MySQLUser();
    }
    @Override
    public DAOInterested getInterestedDAO(){
        return new MySQLInterested();
    }

    @Override
    public DAOProfessor getProfessorDAO() {
        return new MySQLProfessor();
    }

    @Override
    public DAOCourse getCourseDAO() {
        return new MySQLCourse();
    }

    @Override
    public DAOCourseType getCourseTypeDAO() {
        return new MySQLCourseType();
    }   

    @Override
    public DAOIntern getDAOIntern() {
        return new MySQLIntern();
    }

    @Override
    public DAOStudent getStudentDAO() {
        return new MySQLStudent();
    }
    
    
    
}
