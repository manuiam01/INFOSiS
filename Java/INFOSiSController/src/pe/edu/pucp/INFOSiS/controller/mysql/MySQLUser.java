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
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.ArrayList;
import java.util.logging.Level;
import java.util.logging.Logger;
import pe.edu.pucp.INFOSiS.controller.config.DBManager;
import pe.edu.pucp.INFOSiS.controller.dao.DAOUser;
import pe.edu.pucp.INFOSiS.model.bean.user.User;
import pe.edu.pucp.INFOSiS.model.bean.user.UserType;

/**
 *
 * @author tkuser
 */
public class MySQLUser implements DAOUser{
    @Override
    public int insert(User user) {
        int res = 0;
        try{
            DBManager dbManager = DBManager.getdbManager();
            Connection con = DriverManager.getConnection(dbManager.getUrl(), dbManager.getUser(), dbManager.getPassword());
            CallableStatement cs = con.prepareCall("{call INSERT_USER(?,?,?,?,?)}");
            cs.registerOutParameter("_id",java.sql.Types.INTEGER);
            cs.setString(2,user.getUsername());
            cs.setString(3,user.getPassword());
            cs.setInt(4,user.getAcces().getId());
            cs.setInt(5,1); //active user
            res=cs.executeUpdate();
            user.setId(cs.getInt("_id"));
            cs.close();
            con.close();
        }catch(SQLException ex){
            System.out.println(ex.getMessage());
        }
        return res;
    }

    @Override
    public int update(User user) {
        int result=0;
        try{
            DBManager dbManager = DBManager.getdbManager();
            Connection con = DriverManager.getConnection(dbManager.getUrl(), dbManager.getUser(), dbManager.getPassword());
            Statement sentencia = con.createStatement();
            String query ="UPDATE Users "
                    + "SET password=MD5('"+user.getPassword()+"') "
                    + "WHERE username='"+user.getUsername()+"'";
            result = sentencia.executeUpdate(query);
            con.close();   
        }catch(SQLException ex){
            System.out.println(ex.getMessage());
        }
        return result;
    }

    @Override
    public ArrayList<User> queryAll(){
        ArrayList<User> users = new ArrayList<>();
        try{
            
            DBManager dbManager = DBManager.getdbManager();
            Connection con = DriverManager.getConnection(dbManager.getUrl(), dbManager.getUser(), dbManager.getPassword());
            Statement sentence = con.createStatement();
            String query = "SELECT * FROM Users";
            ResultSet rs = sentence.executeQuery(query);
            while(rs.next()){
                User user = new User();
                int id = rs.getInt("idUser");
                String username = rs.getString("userName");
                int idAccess = rs.getInt("idAccess");
                boolean isActive = rs.getBoolean("isActive");
                user.setUsername(username);
                user.setIsActive(isActive);
                users.add(user);
            }
            rs.close();
            con.close();
        }catch(SQLException ex){
            System.out.println(ex.getMessage());
        }
        return users;
        
    }

    @Override
    public UserType verifyUser(User user) {
        UserType ut = new UserType();
        ut.setId(-1);
        try{
            DBManager dbManager = DBManager.getdbManager();
            Connection con = DriverManager.getConnection(dbManager.getUrl(), dbManager.getUser(), dbManager.getPassword());
            Statement sentencia = con.createStatement();
            String query =
                    "SELECT idAccess, name FROM Users, Acces_Role WHERE userName='"
                    +user.getUsername()+"' AND password=MD5('"+user.getPassword()+
                    "') AND idAccess=idAcces_Role AND isActive=1";
            ResultSet rs= sentencia.executeQuery(query);
            while(rs.next()){
                ut.setId(rs.getInt("idAccess"));
                ut.setName(rs.getString("name"));
            }
            rs.close();
            con.close();
        }
        catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return ut;  
    }
}
