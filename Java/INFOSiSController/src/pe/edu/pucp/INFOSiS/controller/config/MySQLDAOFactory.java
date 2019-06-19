/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.INFOSiS.controller.config;

import pe.edu.pucp.INFOSiS.controller.dao.DAOInterested;
import pe.edu.pucp.INFOSiS.controller.dao.DAOUser;
import pe.edu.pucp.INFOSiS.controller.mysql.MySQLInterested;
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
}