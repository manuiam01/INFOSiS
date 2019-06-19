/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.INFOSiS.server;

import java.util.ArrayList;
import pe.edu.pucp.INFOSiS.controller.mysql.MySQLProfessor;
import pe.edu.pucp.INFOSiS.controller.mysql.MySQLUser;
import pe.edu.pucp.INFOSiS.model.bean.professor.Professor;
import pe.edu.pucp.INFOSiS.model.bean.user.User;

/**
 *
 * @author alulab14
 */
public class mian {
    
    public static void main(String[] args) {
        MySQLProfessor sqlProfessor = new MySQLProfessor();
        Professor p=new Professor();
        p.setIdPUCP("20151811");
        System.out.println(sqlProfessor.insert(p));
    }
    
}
