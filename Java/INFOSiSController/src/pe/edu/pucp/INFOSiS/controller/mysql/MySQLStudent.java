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
    public int insertStudent(Student student) {
        int result = 0;
        try{
            DBManager dbManager = DBManager.getdbManager();
            Connection con = DriverManager.getConnection(dbManager.getUrl(), dbManager.getUser(), dbManager.getPassword());
            Statement sentencia = con.createStatement();
            //DateFormat dateFormat = new SimpleDateFormat("mm/dd/yyyy");  
            //String strDate = dateFormat.format(student.getBirthDate());  
            String query="INSERT INTO Student (idStudent,homePhone,address) VALUES ("+
                    "'"+student.getIdNumber()+"','"+student.getHomePhone()+"','"+student.getAddress()+"')";
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
    public int updateStudent(Student student, String id) {
        /*POR ACTUALIZAR*/
        int result = 0;
        try{
            DBManager dbManager = DBManager.getdbManager();
            Connection con = DriverManager.getConnection(dbManager.getUrl(), dbManager.getUser(), dbManager.getPassword());
            CallableStatement cStmt = con.prepareCall("{call UPDATE_STUDENT(?,?,?,?,?,?,?,?,?,?,?,?,?)}");
            cStmt.setString("_idStudent", id);
            //cStmt.setString("_idNumber", student.getIdNumber());
            cStmt.setInt("_idType", student.getIdType());
            cStmt.setString("_firstName", student.getFirstName());
            cStmt.setString("_middleName", student.getMiddleName());
            cStmt.setString("_primaryLastName", student.getPrimaryLastName());
            cStmt.setString("_secondLastName", student.getSecondLastName());
            cStmt.setString("_gender", student.getGender());
            cStmt.setString("_email", student.getEmail());
            cStmt.setString("_cellPhoneNuber", student.getCellPhoneNumber());
            cStmt.setString("_homePhone", student.getHomePhone());
            cStmt.setDate("_birthday",(Date)student.getBirthDate());
            cStmt.setString("_address", student.getAddress());
            cStmt.execute();
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
            Connection con = DriverManager.getConnection(dbManager.getUrl(), dbManager.getUser(), dbManager.getPassword());
            Statement sentence = con.createStatement();
            String query = "SELECT * FROM Users";
            ResultSet rs = sentence.executeQuery(query);
            while(rs.next()){
                Student student = new Student();
                
                String id = rs.getString("idStudent");
                int idType = rs.getInt("idType");
                String firstName = rs.getString("firstName");
                String middleName = rs.getString("middleName");
                String primaryLastName = rs.getString("primaryLastName");
                String secondLastName = rs.getString("secondLastName");
                String gender = rs.getString("gender");
                String emailPUCP = rs.getString("emailPUCP");
                String cellPhoneNumber = rs.getString("cellPhoneNumber");
                String homePhone = rs.getString("homePhone");
                Date birthday = rs.getDate("birthday");
                String address = rs.getString("address");
                String email = rs.getString("email");
                                
                student.setIdNumber(id);
                student.setIdType(idType);
                student.setFirstName(firstName);
                student.setPrimaryLastName(primaryLastName);
                student.setMiddleName(middleName);
                student.setSecondLastName(secondLastName);
                student.setGender(gender);
                student.setEmailPUCP(emailPUCP);
                student.setCellPhoneNumber(cellPhoneNumber);
                student.setHomePhone(homePhone);
                student.setBirthDate(birthday);
                student.setAddress(address);
                student.setEmail(email);
                students.add(student);
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
