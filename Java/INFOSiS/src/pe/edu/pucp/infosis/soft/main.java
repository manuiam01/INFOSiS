/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.INFOSiS.soft;
import java.util.ArrayList;
import pe.edu.pucp.INFOSiS.controller.mysql.MySQLIntern;
import pe.edu.pucp.INFOSiS.controller.mysql.MySQLUser;
import pe.edu.pucp.INFOSiS.model.bean.HR.Intern;
import pe.edu.pucp.INFOSiS.model.bean.user.User;
import pe.edu.pucp.INFOSiS.model.bean.user.UserType;

/**
 *
 * @author alulab14
 */
public class main {
    
    public static void main(String[] args) {
        MySQLIntern internC = new MySQLIntern();
//        ArrayList<Intern> interns = internC.searchInternByName("Diego","","","");
//        
//        for(Intern i : interns){
//            System.out.println(i.getMiddleName());
//        }
        
//        Intern intern = new Intern();
//        
//        intern.setIdPUCP("20190000");
//        intern.getUser().setId(90);
//        intern.setIdType(1);
//        intern.setIdNumber("222222222222");
//        intern.setFirstName("Ian");
//        intern.setPrimaryLastName("Smith");
//        intern.setGender("M");
//        intern.setEmail("ismith@gmail.com");
//        intern.setCellPhoneNumber("9876543210");
//        intern.setEmailPUCP("ismith@pucp.pe");
//        intern.setAddress("EEUU");
//        intern.setHomePhone("5556644");
//        intern.setBirthday(null);
//                
//        System.out.println(internC.update(intern));
          //internC.updateWeekAvailability("20135002", "0011");
          System.out.println(internC.getWeekAvailability("20135002"));
    }
}
