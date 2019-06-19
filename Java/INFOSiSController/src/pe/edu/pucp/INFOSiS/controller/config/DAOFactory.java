/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.INFOSiS.controller.config;

import pe.edu.pucp.INFOSiS.controller.dao.DAOInterested;
import pe.edu.pucp.INFOSiS.controller.dao.DAOUser;

/**
 *
 * @author ASUS
 */
public abstract class DAOFactory {
    public static DAOFactory getDAOFactory(){
        if(DBManager.getdbManager().getUrl().contains("mysql")){
        return new MySQLDAOFactory();
        }
        else{
            System.err.println("ERROR URL");
            return null;
        }
    }
    
    public abstract DAOUser getUserDAO();
    public abstract DAOInterested getInterestedDAO();
}