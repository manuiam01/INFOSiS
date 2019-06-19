/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.INFOSiS.server;

import java.util.ArrayList;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import pe.edu.pucp.INFOSiS.controller.config.DBController;
import pe.edu.pucp.INFOSiS.controller.mysql.MySQLProfessor;
import pe.edu.pucp.INFOSiS.controller.mysql.MySQLUser;
import pe.edu.pucp.INFOSiS.model.bean.professor.Professor;
import pe.edu.pucp.INFOSiS.model.bean.user.User;


@WebService(serviceName = "Server")
public class Server {
   
    @WebMethod (operationName = "QueryAllUsers")
    public ArrayList<User> QueryAllUsers(){
        return DBController.queryAllUsers();
    }
        
    @WebMethod (operationName = "InsertProfessor")
    public int InsertProfessor(@WebParam(name = "professor") Professor professor){
        MySQLProfessor sqlProfessor = new MySQLProfessor();
        return sqlProfessor.insert(professor);
    }
    

}
