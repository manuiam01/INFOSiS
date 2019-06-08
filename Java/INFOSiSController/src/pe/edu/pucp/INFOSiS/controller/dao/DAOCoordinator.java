/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.INFOSiS.controller.dao;

import pe.edu.pucp.INFOSiS.model.bean.HR.Coordinator;

/**
 *
 * @author Usuario
 */
public interface DAOCoordinator{
    int insert(Coordinator coordinator);
    int update(Coordinator coordinator);
}
