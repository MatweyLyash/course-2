package DAO;

import org.example.User;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;
import java.util.List;

public class SomeConnect implements DAO {
    final String url = "jdbc:mysql://localhost:3306/ekz";
    final String username = "user";
    final String password = "";
    Connection connection;
    @Override
    public void openConnection() {
        try  {
            connection = DriverManager.getConnection(url, username, password);
            System.out.println("Подключение к базе данных успешно!");

        } catch (SQLException e) {
            System.out.println("Ошибка при подключении к базе данных: " + e.getMessage());
        }
    }

    @Override
    public void closeConnection() {
        try{
            if(connection != null)
            {
                connection.close();
                System.out.println("Подключение закрыто");
            }
        } catch (SQLException e) {
            System.out.println(e.getMessage());
        }
    }

    @Override
    public void sendLetterToAllRecipients(User sender, String subject, String body) {

    }

    @Override
    public User getMinLetterLengthUser() {
        return null;
    }

    @Override
    public void getUsersLetterInfo() {

    }

    @Override
    public List<User> getUsersByReceivedLetterSubject(String subject) {
        return null;
    }

    @Override
    public List<User> getUsersByNotReceivedLetterSubject(String subject) {
        return null;
    }
}
