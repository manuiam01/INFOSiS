/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.INFOSiS.controller.dao;

import java.util.ArrayList;
import pe.edu.pucp.INFOSiS.model.bean.user.User;

/**
 *
 * @author tkuser
 */
public interface DAOUser {
    int insert(User user);
    int update(User user);
    ArrayList<User> queryAll();
}
