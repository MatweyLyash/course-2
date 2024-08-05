package org.example.lab_8.client;
import java.io.*;
import java.net.*;
import java.util.Scanner;
public class mainClient {
    public static void main(String[] args) {
        try {
            Socket socket = new Socket("localhost", 8000);
            System.out.println("Подключено к серверу...");

            BufferedReader in = new BufferedReader(new InputStreamReader(socket.getInputStream()));
            PrintWriter out = new PrintWriter(socket.getOutputStream(), true);
            Scanner scanner = new Scanner(System.in);

            System.out.print("Введите ваше имя: ");
            String clientName = scanner.nextLine();
            out.println(clientName);

            ClientReceiver receiver = new ClientReceiver(in);
            receiver.start();

            String line;
            while ((line = scanner.nextLine()) != null) {
                out.println(line);
            }

            socket.close();
        } catch (IOException e) {
            e.printStackTrace();
        }
    }

    private static class ClientReceiver extends Thread {
        private final BufferedReader in;

        public ClientReceiver(BufferedReader in) {
            this.in = in;
        }

        @Override
        public void run() {
            try {
                String line;
                while ((line = in.readLine()) != null) {
                    System.out.println(line);
                }
            } catch (IOException e) {
                e.printStackTrace();
            }
        }
    }
}
