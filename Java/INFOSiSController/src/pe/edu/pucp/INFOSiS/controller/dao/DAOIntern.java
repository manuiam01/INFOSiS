/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.INFOSiS.controller.dao;

import java.util.ArrayList;
import pe.edu.pucp.INFOSiS.model.bean.HR.Intern;
import pe.edu.pucp.INFOSiS.model.bean.user.UserType;

/**
 *
 * @author tkuser
 */
public interface DAOIntern {
    int insert(Intern intern, UserType access);
    int update(Intern intern, UserType access);
    Intern searchInternByIdNumber(String idIntern);
    ArrayList<Intern> queryAll();
}
