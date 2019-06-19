/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.INFOSiS.controller.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import pe.edu.pucp.INFOSiS.controller.config.DBManager;
import pe.edu.pucp.INFOSiS.controller.dao.DAOProfessor;
import pe.edu.pucp.INFOSiS.model.bean.professor.Professor;

/**
 *
 * @author Usuario
 */
public class MySQLProfessor implements DAOProfessor {

    @Override
    public int insert(Professor professor) {
        int result = 0;
        try{
            DBManager dbManager = DBManager.getdbManager();
            Connection con = DriverManager.getConnection(dbManager.getUrl(), dbManager.getUser(), dbManager.getPassword());
            CallableStatement cs = con.prepareCall("{call INSERT_PROFESSOR(?,?,?,?,?,?,?,?,?,?,?,?,?)}");
            cs.setString(1,professor.getIdPUCP());
            cs.setString(2,professor.getIdNumber());
            cs.setInt(3,professor.getIdType());
            cs.setString(4,professor.getEmailPUCP());
            cs.setDate(5,new java.sql.Date(professor.getBirthDate().getTime()));
            cs.setString(6,professor.getFirstName());
            cs.setString(7,professor.getMiddleName());
            cs.setString(8,professor.getPrimaryLastName());
            cs.setString(9,professor.getSecondLastName());
            cs.setString(10,professor.getGender());
            cs.setString(11,professor.getEmail());
            cs.setString(12,professor.getCellPhoneNumber());
            cs.setInt(13,1);
            result=cs.executeUpdate();
            con.close();
        }catch(SQLException ex){
            System.out.println(ex.getMessage());
        }        
        return result;
    }

    @Override
    public int update(Professor professor) {
        int result = 0;
        try{
            DBManager dbManager = DBManager.getdbManager();
            Connection con = DriverManager.getConnection(dbManager.getUrl(), dbManager.getUser(), dbManager.getPassword());
            CallableStatement cs = con.prepareCall("{call UPDATE_PROFESSOR(?,?,?,?,?,?,?,?,?,?,?,?,?)}");
            cs.setString(1,professor.getIdPUCP());
            cs.setString(2,professor.getIdNumber());
            cs.setInt(3,professor.getIdType());
            cs.setString(4,professor.getEmailPUCP());
            cs.setDate(5,new java.sql.Date(professor.getBirthDate().getTime()));
            cs.setString(6,professor.getFirstName());
            cs.setString(7,professor.getMiddleName());
            cs.setString(8,professor.getPrimaryLastName());
            cs.setString(9,professor.getSecondLastName());
            cs.setString(10,professor.getGender());
            cs.setString(11,professor.getEmail());
            cs.setString(12,professor.getCellPhoneNumber());
            cs.setBoolean(13,professor.getIsActive());
            result=cs.executeUpdate();
            con.close();
        }catch(SQLException ex){
            System.out.println(ex.getMessage());
        }        
        return result;
    }

    @Override
    public ArrayList<Professor> queryAll() {
        ArrayList<Professor> professors = new ArrayList<Professor>();
        try{
            DBManager dbManager = DBManager.getdbManager();
            Connection con = DriverManager.getConnection(dbManager.getUrl(), dbManager.getUser(), dbManager.getPassword());
            CallableStatement cs = con.prepareCall("{call LIST_PROFESSORS()}");
            ResultSet rs = cs.executeQuery();
            while(rs.next()){
                Professor p = new Professor();
                p.setIdPUCP(rs.getString(1));
                p.setIdNumber(rs.getString(2));
                p.setIdType(rs.getInt(3));
                p.setEmailPUCP(rs.getString(4));
                p.setBirthDate(rs.getDate(5));
                p.setFirstName(rs.getString(6));
                p.setMiddleName(rs.getString(7));
                p.setPrimaryLastName(rs.getString(8));
                p.setSecondLastName(rs.getString(9));
                p.setGender(rs.getString(10));
                p.setEmail(rs.getString(11));
                p.setCellPhoneNumber(rs.getString(12));
                    p.setIsActive(rs.getBoolean(13));
                professors.add(p);
            }            
            con.close();
        }catch(SQLException ex){
            System.out.println(ex.getMessage());
        }        
        return professors;
    }

    @Override
    public ArrayList<Professor> queryAllActives() {
        ArrayList<Professor> professors = new ArrayList<Professor>();
        try{
            DBManager dbManager = DBManager.getdbManager();
            Connection con = DriverManager.getConnection(dbManager.getUrl(), dbManager.getUser(), dbManager.getPassword());
            CallableStatement cs = con.prepareCall("{call LIST_ACTIVE_PROFESSORS()}");
            ResultSet rs = cs.executeQuery();
            while(rs.next()){
                Professor p = new Professor();
                p.setIdPUCP(rs.getString(1));
                p.setIdNumber(rs.getString(2));
                p.setIdType(rs.getInt(3));
                p.setEmailPUCP(rs.getString(4));
                p.setBirthDate(rs.getDate(5));
                p.setFirstName(rs.getString(6));
                p.setMiddleName(rs.getString(7));
                p.setPrimaryLastName(rs.getString(8));
                p.setSecondLastName(rs.getString(9));
                p.setGender(rs.getString(10));
                p.setEmail(rs.getString(11));
                p.setCellPhoneNumber(rs.getString(12));
                p.setIsActive(rs.getBoolean(13));
                professors.add(p);
            }
        }catch(SQLException ex){
            System.out.println(ex.getMessage());
        }        
        return professors;
    }

    @Override
    public Professor search_by_id(String id) {
        Professor professor = new Professor();
        try{
            DBManager dbManager = DBManager.getdbManager();
            Connection con = DriverManager.getConnection(dbManager.getUrl(), dbManager.getUser(), dbManager.getPassword());
            CallableStatement cs = con.prepareCall("{call SEARCH_PROFESSOR_BY_ID(?)}");
            cs.setString(1, id);
            ResultSet rs = cs.executeQuery();
            while(rs.next()){          
                professor.setIdPUCP(rs.getString(1));
                professor.setIdNumber(rs.getString(2));
                professor.setIdType(rs.getInt(3));
                professor.setEmailPUCP(rs.getString(4));
                professor.setBirthDate(rs.getDate(5));
                professor.setFirstName(rs.getString(6));
                professor.setMiddleName(rs.getString(7));
                professor.setPrimaryLastName(rs.getString(8));
                professor.setSecondLastName(rs.getString(9));
                professor.setGender(rs.getString(10));
                professor.setEmail(rs.getString(11));
                professor.setCellPhoneNumber(rs.getString(12));
                professor.setIsActive(rs.getBoolean(13));
            }            
            con.close();
        }catch(SQLException ex){
            System.out.println(ex.getMessage());
        }        
        return professor;
    }

    @Override
    public ArrayList<Professor> search_by_name(String name, String middle_name,
            String first_last_name, String second_last_name) {
        ArrayList<Professor> professors = new ArrayList<Professor>();
        try{
            DBManager dbManager = DBManager.getdbManager();
            Connection con = DriverManager.getConnection(dbManager.getUrl(), dbManager.getUser(), dbManager.getPassword());
            CallableStatement cs = con.prepareCall("{call SEARCH_PROFESSOR_BY_NAME(?,?,?,?)}");
            cs.setString(1, name);
            cs.setString(2, middle_name);
            cs.setString(3, first_last_name);
            cs.setString(4, second_last_name);
            ResultSet rs = cs.executeQuery();
            while(rs.next()){
                Professor p = new Professor();
                p.setIdPUCP(rs.getString(1));
                p.setIdNumber(rs.getString(2));
                p.setIdType(rs.getInt(3));
                p.setEmailPUCP(rs.getString(4));
                p.setBirthDate(rs.getDate(5));
                p.setFirstName(rs.getString(6));
                p.setMiddleName(rs.getString(7));
                p.setPrimaryLastName(rs.getString(8));
                p.setSecondLastName(rs.getString(9));
                p.setGender(rs.getString(10));
                p.setEmail(rs.getString(11));
                p.setCellPhoneNumber(rs.getString(12));
                p.setIsActive(rs.getBoolean(13));
                professors.add(p);
            }            
            con.close();
        }catch(SQLException ex){
            System.out.println(ex.getMessage());
        }        
        return professors;
    }    
}
