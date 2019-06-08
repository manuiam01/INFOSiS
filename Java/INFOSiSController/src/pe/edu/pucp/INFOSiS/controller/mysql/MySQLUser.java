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
import pe.edu.pucp.INFOSiS.controller.config.DBManager;
import pe.edu.pucp.INFOSiS.controller.dao.DAOUser;
import pe.edu.pucp.INFOSiS.model.bean.user.User;

/**
 *
 * @author tkuser
 */
public class MySQLUser implements DAOUser{
    @Override
    public int insert(User user) {
        int id = 0;
        try{
            DBManager dbManager = DBManager.getdbManager();
            Connection con = DriverManager.getConnection(dbManager.getUrl(), dbManager.getUser(), dbManager.getPassword());
            CallableStatement cs = con.prepareCall("{call INSERT_USER(?,?,?,?,?)}");
            cs.registerOutParameter("_id",java.sql.Types.INTEGER);
            cs.setString(2,user.getUsername());
            cs.setString(3,user.getPassword());
            cs.setInt(4,user.getAcces().getId());
            cs.setInt(3,1); //active user
            cs.executeUpdate();
            id=cs.getInt("_id");
            con.close();
        }catch(SQLException ex){
            System.out.println(ex.getMessage());
        }
        return id;
    }

    @Override
    public int update(User user) {
        int result=0;
        try{
            DBManager dbManager = DBManager.getdbManager();
            Connection con = DriverManager.getConnection(dbManager.getUrl(), dbManager.getUser(), dbManager.getPassword());
            String sql = "UPDATE Users SET password=? WHERE userName = ?"; 
            PreparedStatement ps = con.prepareStatement(sql);
            ps.setString(1,user.getPassword());
            ps.setString(2, user.getUsername());
            result = ps.executeUpdate();
            con.close();   
        }catch(SQLException ex){
            System.out.println(ex.getMessage());
        }
        return result;
    }

    @Override
    public ArrayList<User> queryAll(){
        
        ArrayList<User> users = new ArrayList<User>();
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
            con.close();
        }catch(SQLException ex){
            System.out.println(ex.getMessage());
        }
        return users;
        
    }
}
