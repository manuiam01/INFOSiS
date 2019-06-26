/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.INFOSiS.controller.dao;

import java.util.ArrayList;
import pe.edu.pucp.INFOSiS.model.bean.HR.Intern;
import pe.edu.pucp.INFOSiS.model.bean.HR.InternAssistance;
import pe.edu.pucp.INFOSiS.model.bean.user.UserType;

/**
 *
 * @author tkuser
 */
public interface DAOIntern {
    int insert(Intern intern, UserType access);
    int update(Intern intern);
    int updateWeekAvailability(String idIntern, String weekAvailability);
    Intern searchInternByIdNumber(String idNumber);
    Intern searchInternByIdPUCP (String idPUCP);
    ArrayList<Intern> searchInternByName(String firstName,String middleName,String firstLastName,String secondLastName);
    String getWeekAvailability(String idIntern);
    ArrayList<Intern> queryAll();
    InternAssistance getLastRegisterOfDay(String pucpId);
    int insertAssistance(String idPucp);
    int updateAsisstance(String id);
}
