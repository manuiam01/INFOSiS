/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.INFOSiS.controller.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.SQLException;
import pe.edu.pucp.INFOSiS.controller.config.DBManager;
import pe.edu.pucp.INFOSiS.controller.dao.DAOCoordinator;
import pe.edu.pucp.INFOSiS.model.bean.HR.Coordinator;

/**
 *
 * @author Usuario
 */
public class MySQLCoordinator implements DAOCoordinator{

    @Override
    public int insert(Coordinator coordinator) {
        int result = 0;
        try{
            DBManager dbManager = DBManager.getdbManager();
            Connection con = DriverManager.getConnection(dbManager.getUrl(), dbManager.getUser(), dbManager.getPassword());
            CallableStatement cs = con.prepareCall("{call INSERT_COORDINATOR (?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)}");
            cs.setString(1, coordinator.getIdPUCP());
            cs.setInt(2, coordinator.getUser().getId());
            cs.setString(3, coordinator.getIdNumber());
            cs.setInt(4, coordinator.getIdType());
            cs.setString(5, coordinator.getFirstName());
            cs.setString(6, coordinator.getMiddleName());
            cs.setString(7, coordinator.getPrimaryLastName());
            cs.setString(8, coordinator.getSecondLastName());
            cs.setString(9, coordinator.getGender());
            cs.setString(10, coordinator.getEmail());
            cs.setString(11, coordinator.getCellPhoneNumber());
            cs.setString(12, coordinator.getEmailPUCP());
            cs.setString(13, coordinator.getAddress());
            cs.setString(14, coordinator.getHomePhone());
            cs.setDate(15, new java.sql.Date(coordinator.getBirthDate().getTime()));
            result = cs.executeUpdate();
            con.close();
        }catch(SQLException ex){
            System.out.println(ex.getMessage());
        }
        return result;
    }

    @Override
    public int update(Coordinator coordinator) {
        int result = 0;
        try{
            DBManager dbManager = DBManager.getdbManager();
            Connection con = DriverManager.getConnection(dbManager.getUrl(), dbManager.getUser(), dbManager.getPassword());
            CallableStatement cs = con.prepareCall("{call UPDATE_COORDINATOR(?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)}");
            cs.setInt(1, coordinator.getUser().getId());
            cs.setString(2, coordinator.getIdNumber());   
            cs.setInt(3, coordinator.getIdType());         
            cs.setString(4, coordinator.getFirstName());
            cs.setString(5, coordinator.getMiddleName());
            cs.setString(6, coordinator.getPrimaryLastName());
            cs.setString(7, coordinator.getSecondLastName());
            cs.setString(8, coordinator.getGender());
            cs.setString(9, coordinator.getEmail());
            cs.setString(10, coordinator.getCellPhoneNumber());
            cs.setString(11, coordinator.getEmailPUCP());
            cs.setString(12, coordinator.getAddress());
            cs.setString(13, coordinator.getHomePhone());
            cs.setDate(14, new java.sql.Date(coordinator.getBirthDate().getTime()));
            cs.setString(15, coordinator.getIdPUCP());
            result = cs.executeUpdate();
            con.close();
        }catch(SQLException ex){
            System.out.println(ex.getMessage());
        }
        return result;
    }
    
}
