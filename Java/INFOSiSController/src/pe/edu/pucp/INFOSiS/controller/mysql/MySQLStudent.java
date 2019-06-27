/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.INFOSiS.controller.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.Date;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.text.DateFormat;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import pe.edu.pucp.INFOSiS.controller.config.DBManager;
import pe.edu.pucp.INFOSiS.controller.dao.DAOStudent;
import pe.edu.pucp.INFOSiS.model.bean.student.Student;
import pe.edu.pucp.INFOSiS.model.bean.user.User;

/**
 *
 * @author tkuser
 */
public class MySQLStudent implements DAOStudent{
    @Override
    public int insertStudent(Student student, String birthday) {
        int result = 0;
        try{
            DBManager dbManager = DBManager.getdbManager();
            Connection con = DriverManager.getConnection(dbManager.getUrl(), dbManager.getUser(), dbManager.getPassword());
            Statement sentencia = con.createStatement();
            //DateFormat dateFormat = new SimpleDateFormat("mm/dd/yyyy");  
            //String strDate = dateFormat.format(student.getBirthDate());  
            String query="INSERT INTO Student (idStudent,homePhone,address,birthday) VALUES ("+
                    "'"+student.getIdNumber()+"','"+student.getHomePhone()+"','"+student.getAddress()+"',STR_TO_DATE('"+birthday+"', '%Y/%m/%d'))";
            result =sentencia.executeUpdate(query);
            for(String cod : student.getIdPUCPList()){
                sentencia=con.createStatement();
                query="INSERT INTO StudentxIds (idStudent,codPucp) VALUES ('"+student.getIdNumber()+"','"+cod+"')";
                sentencia.executeUpdate(query);
            }
            con.close();
        }
        catch(SQLException ex){
            System.out.println(ex.getMessage());
        }
        return result;
    }

    @Override
    public int updateStudent(Student student, String birthday) {
        int result = 0;
        try{
            DBManager dbManager = DBManager.getdbManager();
            Connection con = DriverManager.getConnection(dbManager.getUrl(), dbManager.getUser(), dbManager.getPassword());
            Statement sentencia = con.createStatement();
            String query = "DELETE FROM StudentxIds WHERE idStudent='"+student.getIdNumber()+"'";
            sentencia.executeUpdate(query);
            for(String cod : student.getIdPUCPList()){
                sentencia=con.createStatement();
                query="INSERT INTO StudentxIds (idStudent,codPucp) VALUES ('"+student.getIdNumber()+"','"+cod+"')";
                sentencia.executeUpdate(query);
            }
            sentencia = con.createStatement();
            query="UPDATE Student "+
                    "SET homePhone='"+student.getHomePhone()+
                    "', birthday=STR_TO_DATE('"+birthday+"', '%Y/%m/%d'), "+
                    "address='"+student.getAddress()+"' "+
                    "WHERE idStudent='"+student.getIdNumber()+"'";
            result=sentencia.executeUpdate(query);
            con.close();
        }
        catch(SQLException ex){
            System.out.println(ex.getMessage());
        }
        return result;
    }
    
    public ArrayList<Student> queryAll(){
        
        ArrayList<Student> students = new ArrayList<Student>();
        try{
            /*POR ACTUALIZAR*/
            DBManager dbManager = DBManager.getdbManager();
            Connection con = DriverManager.getConnection(dbManager.getUrl(), 
                    dbManager.getUser(), dbManager.getPassword());
            Statement st = con.createStatement();
            String query = "SELECT S.idStudent, I.idNumberType, I.firstName, "
                    + "I.middleName, I.primaryLastName, I.secondLastName, "
                    + "I.gender, I.cellPhoneNumber, I.email, I.regDate, S.address, "
                    + "S.birthday, S.homePhone "
                    + "FROM Student S, Interested I "
                    + "WHERE S.idStudent=I.IdNumber ";
                    
            ResultSet rs = st.executeQuery(query);
            while(rs.next()){
                Student s = new Student();
                s.setIdNumber(rs.getString("idStudent"));
                s.setIdType(rs.getInt("idNumberType"));
                s.setFirstName(rs.getString("firstName"));
                s.setMiddleName(rs.getString("middleName"));
                s.setPrimaryLastName(rs.getString("primaryLastName"));
                s.setSecondLastName(rs.getString("secondLastName"));
                s.setGender(rs.getString("gender"));
                s.setCellPhoneNumber(rs.getString("cellPhoneNumber"));
                s.setEmail(rs.getString("email"));
                s.setRegDate(rs.getDate("regDate"));
                s.setAddress(rs.getString("address"));
                s.setBirthDate(rs.getDate("birthday"));
                s.setHomePhone(rs.getString("homePhone"));
                ArrayList<String> idPucp = new ArrayList<>();
                String queryIdPUCP= "SELECT codPucp "
                        + "FROM StudentxIds "
                        + "WHERE idStudent='"+s.getIdNumber()+"'";
                Statement stID = con.createStatement();
                ResultSet rsID = stID.executeQuery(queryIdPUCP);
                while(rsID.next()){
                    idPucp.add(rsID.getString("codPucp"));
                }
                s.setIdPUCPList(idPucp);  
                students.add(s);
            }
            con.close();
        }catch(SQLException ex){
            System.out.println(ex.getMessage());
        }
        return students;
        
    }
    
    public Student queryStudentById(String id){
        Student s = new Student();
        s.setIdNumber("NULL");
        try{
            DBManager dbManager = DBManager.getdbManager();
            Connection con = DriverManager.getConnection(dbManager.getUrl(), 
                    dbManager.getUser(), dbManager.getPassword());
            Statement st = con.createStatement();
            String query = "SELECT S.idStudent, I.idNumberType, I.firstName, "
                    + "I.middleName, I.primaryLastName, I.secondLastName, "
                    + "I.gender, I.cellPhoneNumber, I.email, I.regDate, S.address, "
                    + "S.birthday, S.homePhone "
                    + "FROM Student S, Interested I "
                    + "WHERE S.idStudent=I.IdNumber "
                    + "AND S.IdStudent='"+id+"'";
            ResultSet rs = st.executeQuery(query);
            while(rs.next()){
                s.setIdNumber(rs.getString("idStudent"));
                s.setIdType(rs.getInt("idNumberType"));
                s.setFirstName(rs.getString("firstName"));
                s.setMiddleName(rs.getString("middleName"));
                s.setPrimaryLastName(rs.getString("primaryLastName"));
                s.setSecondLastName(rs.getString("secondLastName"));
                s.setGender(rs.getString("gender"));
                s.setCellPhoneNumber(rs.getString("cellPhoneNumber"));
                s.setEmail(rs.getString("email"));
                s.setRegDate(rs.getDate("regDate"));
                s.setAddress(rs.getString("address"));
                s.setBirthDate(rs.getDate("birthday"));
                s.setHomePhone(rs.getString("homePhone"));
                ArrayList<String> idPucp = new ArrayList<>();
                String queryIdPUCP= "SELECT codPucp "
                        + "FROM StudentxIds "
                        + "WHERE idStudent='"+id+"'";
                Statement stID = con.createStatement();
                ResultSet rsID = stID.executeQuery(queryIdPUCP);
                while(rsID.next()){
                    idPucp.add(rsID.getString("codPucp"));
                }
                s.setIdPUCPList(idPucp);               
            }
            con.close();
        }
        catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return s;
    }

}
