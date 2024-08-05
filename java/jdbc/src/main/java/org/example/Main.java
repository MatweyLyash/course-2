package org.example;
import DAO.SomeConnect;

import  java.sql.*;
public class Main {
    public static void main(String[] args) throws SQLException {
        SomeConnect someConnect = new SomeConnect();
        someConnect.openConnection();
        someConnect.closeConnection();
    }
}