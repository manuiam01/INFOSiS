/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.INFOSiS.controller.dao;

import java.util.ArrayList;
import pe.edu.pucp.INFOSiS.model.bean.professor.Professor;

/**
 *
 * @author Usuario
 */
public interface DAOProfessor {
    int insert(Professor professor);
    int update(Professor professor);
    ArrayList<Professor> queryAll();
    ArrayList<Professor> queryAllActives();
}
