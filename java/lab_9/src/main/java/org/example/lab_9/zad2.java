package org.example.lab_9;

import jakarta.servlet.ServletException;
import jakarta.servlet.annotation.WebServlet;
import jakarta.servlet.http.HttpServlet;
import jakarta.servlet.http.HttpServletRequest;
import jakarta.servlet.http.HttpServletResponse;
import org.example.lab_9.database.User;
import org.example.lab_9.database.UsersDataBase;

import java.io.IOException;
import java.io.PrintWriter;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;

@WebServlet(name = "задание-2", value = "/задание-2")
public class zad2 extends HttpServlet {

    public void init(){

    }

    public void doGet(HttpServletRequest request, HttpServletResponse response) throws IOException {
        response.setContentType("text/html");
        PrintWriter out = response.getWriter();
        out.println("<h2>form</h2>");
        out.println("<form method=\"POST\"  action=\"auth-servlet\">\n" +
                "<input name=\"login\" type='text' placeholder='login' >\n" +
                "<input name\"password\" type='password' placeholder='password' >\n" +
                "<input type='submit' value='send'>"+
                "</form>");
        try {
            getConnect();
        } catch (SQLException e) {
            throw new RuntimeException(e);
        }

    }
    public void doPost(HttpServletRequest request, HttpServletResponse response) throws IOException, ServletException {
        String login = request.getParameter("login");
        String password = request.getParameter("password");

        UsersDataBase base = new UsersDataBase();
        base.openConnection();
        User user = new User(login,password);

        if (base.isHasUser(user)){

            System.out.println("Пользователь существует!");
            request.getRequestDispatcher("welcome.jsp").forward(request, response);
            request.setAttribute("authMessage", "");
            response.sendRedirect("welcome.jsp");
        }
        else {
            response.setContentType("text/html");
            PrintWriter out = response.getWriter();
            out.println("<h2>form</h2>");
            out.println("<form method=\"POST\" >\n" +
                    "<input type='text' name='login' placeholder='login' >\n" +
                    "<input type='password' name='password' placeholder='password' >\n" +
                    "<input type='submit' value='send'>" +
                    "</form>");
            out.println("<p>Неудачная попытка входа. Неправильный логин или пароль.</p>");
        }
    }
    public void getConnect() throws SQLException {
        UsersDataBase base = new UsersDataBase();
        base.openConnection();
    }


    public void destroy(){

    }
}
