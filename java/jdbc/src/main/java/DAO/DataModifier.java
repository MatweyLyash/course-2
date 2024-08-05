package DAO;

import org.example.User;

public interface DataModifier {
    void sendLetterToAllRecipients(User sender, String subject, String body);
}
