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
    Professor search_by_idPUCP(String id);
    ArrayList<Professor> search_by_name(String name, String middle_name,
            String first_last_name, String second_last_name);
    int search_by_id(String id);
}
