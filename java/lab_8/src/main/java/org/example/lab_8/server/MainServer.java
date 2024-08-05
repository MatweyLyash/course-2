package org.example.lab_8.server;
import java.io.*;
import java.net.*;
import java.util.HashSet;
import java.util.Set;

public class MainServer {
    private static Set<ClientHandler> clients = new HashSet<>();

    public static void main(String[] args) {
        try {
            ServerSocket serverSocket = new ServerSocket(8000);
            System.out.println("Сервер запущен...");

            while (true) {
                Socket clientSocket = serverSocket.accept();
                System.out.println("Новый клиент подключен: " + clientSocket.getInetAddress().getHostAddress());

                ClientHandler clientHandler = new ClientHandler(clientSocket);
                clients.add(clientHandler);
                clientHandler.start();
            }
        } catch (IOException e) {
            e.printStackTrace();
        }
    }

    private static class ClientHandler extends Thread {
        private final Socket clientSocket;
        private final BufferedReader in;
        private final PrintWriter out;
        private String clientName;

        public ClientHandler(Socket socket) throws IOException {
            this.clientSocket = socket;
            this.in = new BufferedReader(new InputStreamReader(socket.getInputStream()));
            this.out = new PrintWriter(socket.getOutputStream(), true);
            this.clientName = "Unknown";
        }

        @Override
        public void run() {
            try {
                clientName = in.readLine(); // получаем имя клиента
                broadcastMessage(clientName + " присоединился к чату");

                String line;
                while ((line = in.readLine()) != null) {
                    if (line.startsWith("/private")) {
                        String recipient = line.split(" ")[1];
                        String message = line.substring(line.indexOf(" ", 10) + 1);
                        sendPrivateMessage(recipient, clientName + ": " + message);
                    } else {
                        broadcastMessage(clientName + ": " + line);
                    }
                }
            } catch (IOException e) {
                e.printStackTrace();
            } finally {
                clients.remove(this);
                broadcastMessage(clientName + " покинул чат");
                try {
                    clientSocket.close();
                } catch (IOException e) {
                    e.printStackTrace();
                }
            }
        }

        private void broadcastMessage(String message) {
            for (ClientHandler client : clients) {
                client.out.println(message);
            }
        }

        private void sendPrivateMessage(String recipient, String message) {
            for (ClientHandler client : clients) {
                if (client.clientName.equals(recipient)) {
                    client.out.println(message);
                    break;
                }
            }
        }
    }
}
