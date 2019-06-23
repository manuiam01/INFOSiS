/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.INFOSiS.soft;
import java.util.ArrayList;
import pe.edu.pucp.INFOSiS.controller.mysql.MySQLIntern;
import pe.edu.pucp.INFOSiS.controller.mysql.MySQLUser;
import pe.edu.pucp.INFOSiS.model.bean.HR.Intern;
import pe.edu.pucp.INFOSiS.model.bean.user.User;
import pe.edu.pucp.INFOSiS.model.bean.user.UserType;

/**
 *
 * @author alulab14
 */
public class main {
    
    public static void main(String[] args) {
        MySQLIntern internC = new MySQLIntern();
        System.out.println(internC.searchInternByIdNumber("76289820").getIdPUCP());
    }
}
