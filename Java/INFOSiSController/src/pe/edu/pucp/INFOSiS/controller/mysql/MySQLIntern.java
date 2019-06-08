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
import pe.edu.pucp.INFOSiS.controller.dao.DAOIntern;
import pe.edu.pucp.INFOSiS.model.bean.HR.Intern;
import pe.edu.pucp.INFOSiS.model.bean.HR.RoleHistory;

/**
 *
 * @author tkuser
 */
public class MySQLIntern implements DAOIntern {
    @Override
    public int insert(Intern intern, RoleHistory roleHistory, int idUser) {        
        int result = 0;
        try{
            DBManager dbManager = DBManager.getdbManager();
            Connection con = DriverManager.getConnection(dbManager.getUrl(), dbManager.getUser(), dbManager.getPassword());
            CallableStatement cs = con.prepareCall("{CALL INSERT_INTERN(?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)}");
            cs.setString(1, intern.getIdPUCP());
            cs.setInt(2, idUser);
            cs.setInt(3, intern.getIdType());
            cs.setString(4, intern.getIdNumber());
            cs.setString(5, intern.getFirstName());
            cs.setString(6, intern.getMiddleName());
            cs.setString(7, intern.getPrimaryLastName());
            cs.setString(8, intern.getSecondLastName());
            cs.setString(9, intern.getGender());
            cs.setString(10, intern.getEmail());
            cs.setString(11, intern.getCellPhoneNumber());
            cs.setString(12, intern.getEmailPUCP());
            cs.setString(13, intern.getAddress());
            cs.setString(14, intern.getHomePhone());
         //   cs.setDate(15, intern.getBirthDate());
            cs.setString(16, intern.getWeekAvailability());
//            cs.setInt(17, roleHistory.getRole().getId());
//            cs.setFloat(18,roleHistory.getSalary());
            cs.setInt(19, roleHistory.getHours());
            result = cs.executeUpdate();
            con.close();
        }catch(SQLException ex){
            System.out.println(ex.getMessage());
        }
        return result;
    }

    @Override
    public int update(Intern intern, int idUser) {
        int result = 0;
        try{
            DBManager dbManager = DBManager.getdbManager();
            Connection con = DriverManager.getConnection(dbManager.getUrl(), dbManager.getUser(), dbManager.getPassword());
            String sql = "UPDATE Interns SET idType=?,idNumber=?,firstName=?,middleName=?,primaryLastName=?,secondLastName=?,gender=?,email=?,cellPhoneNumber=?,emailPUCP=?,address=?,homePhone=?,birthDate=?,weekAvailability=? WHERE idUser=?";
            PreparedStatement ps = con.prepareStatement(sql);
            ps.setInt(1, intern.getIdType());
            ps.setString(2, intern.getIdNumber());
            ps.setString(3, intern.getFirstName());
            ps.setString(4, intern.getMiddleName());
            ps.setString(5, intern.getPrimaryLastName());
            ps.setString(6, intern.getSecondLastName());
            ps.setString(7, intern.getGender());
            ps.setString(8, intern.getEmail());
            ps.setString(9, intern.getCellPhoneNumber());
            ps.setString(10, intern.getEmailPUCP());
            ps.setString(11, intern.getAddress());
            ps.setString(12, intern.getHomePhone());
    //        ps.setDate(13, intern.getBirthDate());
            ps.setString(16, intern.getWeekAvailability());
            ps.setInt(17, idUser);
            result = ps.executeUpdate();
            con.close();
        }catch(SQLException ex){
            System.out.println(ex.getMessage());
        }
        return result;
    }

    @Override
    public ArrayList<Intern> queryAll() {
        ArrayList<Intern> interns = new ArrayList<Intern>();
        try{
            DBManager dbManager = DBManager.getdbManager();
            Connection con = DriverManager.getConnection(dbManager.getUrl(), dbManager.getUser(), dbManager.getPassword());
            Statement sentence = con.createStatement();
            String query = "SELECT * FROM Interns";
            ResultSet rs = sentence.executeQuery(query);
            while(rs.next()){
                Intern intern = new Intern();
                String idIntern = rs.getString("idIntern");
                int idUser = rs.getInt("idUser");      
                String idNumber = rs.getString("idNumber");
                String firstName = rs.getString("firstName");
                String middleName = rs.getString("middleName");
                String primaryLastName = rs.getString("primaryLastName");
                String secondLastName = rs.getString("secondLastName");
                String emailPUCP = rs.getString("emailPUCP");
      //          intern.setIdIntern(idIntern);
                intern.setFirstName(firstName);
                intern.setMiddleName(middleName);
                intern.setPrimaryLastName(primaryLastName);
                intern.setSecondLastName(secondLastName);
                intern.setEmailPUCP(emailPUCP);
                interns.add(intern);
            }
            con.close();
        }catch(SQLException ex){
            System.out.println(ex.getMessage());
        }        
        return interns;
    }

    @Override
    public Intern queryIntern(String idIntern) {
        Intern intern = new Intern();
        try{
            DBManager dbManager = DBManager.getdbManager();
            Connection con = DriverManager.getConnection(dbManager.getUrl(), dbManager.getUser(), dbManager.getPassword());
            String sql="SELECT * FROM Interns WHERE idIntern = ?";
            PreparedStatement ps = con.prepareStatement(sql);
            ps.setString(1, idIntern);
            ResultSet rs = ps.executeQuery();
            if(rs.next()){
           //     intern.setIdIntern(rs.getString(1));
              //  intern.setIdUser(rs.getInt(2));
                intern.setIdType(rs.getInt(3));
                intern.setIdNumber(rs.getString(4));
                intern.setFirstName(rs.getString(5));
                intern.setMiddleName(rs.getString(6));
                intern.setPrimaryLastName(rs.getString(7));
                intern.setSecondLastName(rs.getString(8));
                intern.setGender(rs.getString(9));
                intern.setEmail(rs.getString(10));
                intern.setCellPhoneNumber(rs.getString(11));
                intern.setEmailPUCP(rs.getString(12));
                intern.setAddress(rs.getString(13));
                intern.setHomePhone(rs.getString(14));
                intern.setBirthDate(rs.getDate(15));
                intern.setWeekAvailability(rs.getString(16));               
            }
            con.close();
        }catch(SQLException ex){
            System.out.println(ex.getMessage());
        }
        return intern;
    }
}
