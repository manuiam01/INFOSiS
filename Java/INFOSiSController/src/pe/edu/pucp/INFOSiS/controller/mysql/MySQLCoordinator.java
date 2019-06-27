/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.INFOSiS.controller.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.util.Date;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.text.SimpleDateFormat;
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
            cs.setDate(15, (java.sql.Date)(coordinator.getBirthday()));
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
            Statement sentencia = con.createStatement();
            String query = 
                    "UPDATE Coordinator "
                    + "SET "
                    + "firstName='"+coordinator.getFirstName()+"', "
                    + "middleName='"+coordinator.getMiddleName()+"', "
                    + "primaryLastName='"+coordinator.getPrimaryLastName()+"', "
                    + "secondLastName='"+coordinator.getSecondLastName()+"', "
                    + "gender='"+coordinator.getGender()+"', "
                    + "email='"+coordinator.getEmail()+"', "
                    + "cellPhoneNumber='"+coordinator.getCellPhoneNumber()+"', "
                    + "emailPucp='"+coordinator.getEmailPUCP()+"', "
                    + "address='"+coordinator.getAddress()+"', "
                    + "homePhone='"+coordinator.getHomePhone()+"', "
                    + "birthDate=STR_TO_DATE('"
                    +(new SimpleDateFormat("yyyy/MM/dd").format(coordinator.getBirthday()))
                    +"','%Y/%m/%d') "
                    + "WHERE idCoordinator='"+coordinator.getIdPUCP()+"'";
            result=sentencia.executeUpdate(query);
            con.close();
        }catch(SQLException ex){
            System.out.println(ex.getMessage());
        }
        return result;
    }
    
    @Override
    public Coordinator queryCoordById(String idPucp){
        Coordinator c= new Coordinator();
        c.setIdPUCP("-1");
        try{
            DBManager dbManager = DBManager.getdbManager();
            Connection con = DriverManager.getConnection(dbManager.getUrl(), dbManager.getUser(), dbManager.getPassword());
            Statement sentencia = con.createStatement();
            String query ="SELECT idType, idNumber, "
                    + "firstName, middleName, primaryLastName, "
                    + "secondLastName, gender, email, cellPhoneNumber, "
                    + "emailPUCP, address, homePhone, birthDate "
                    + "FROM Coordinator "
                    + "WHERE idCoordinator='"+idPucp+"'";
            ResultSet rs= sentencia.executeQuery(query);
            while(rs.next()){
               c.setIdPUCP(idPucp);
               c.setAddress(rs.getString("address"));
               c.setBirthday(rs.getDate("birthDate"));
               c.setCellPhoneNumber(rs.getString("cellPhoneNumber"));
               c.setEmail(rs.getString("email"));
               c.setEmailPUCP(rs.getString("emailPUCP"));
               c.setFirstName(rs.getString("firstName"));
               c.setGender(rs.getString("gender"));
               c.setHomePhone(rs.getString("homePhone"));
               c.setIdNumber(rs.getString("idNumber"));
               c.setIdType(rs.getInt("idType"));
               c.setMiddleName(rs.getString("middleName"));
               c.setPrimaryLastName(rs.getString("primaryLastName"));
               c.setSecondLastName(rs.getString("secondLastName"));
            }
            con.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return c;
    }
    
}
