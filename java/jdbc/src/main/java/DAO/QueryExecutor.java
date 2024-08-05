package DAO;

import java.util.List;

import org.example.User;

public interface QueryExecutor {
    User getMinLetterLengthUser();
    void getUsersLetterInfo();
    List<User> getUsersByReceivedLetterSubject(String subject);
    List<User> getUsersByNotReceivedLetterSubject(String subject);
}
