package org.example.lab_8.UDP;
import java.io.IOException;
import java.net.DatagramPacket;
import java.net.DatagramSocket;
public class UDPReceiver {
    private final int PORT = 8000; // Порт для получения сообщений

    public void receiveMessages() {
        try {
            DatagramSocket socket = new DatagramSocket(PORT);
            byte[] buffer = new byte[1024];
            System.out.println("Ожидание сообщений...");

            while (true) {
                DatagramPacket packet = new DatagramPacket(buffer, buffer.length);
                socket.receive(packet);
                String message = new String(packet.getData(), 0, packet.getLength());
                System.out.println("Полученное сообщение: " + message);
            }
        } catch (IOException e) {
            e.printStackTrace();
        }
    }

    public static void main(String[] args) {
        UDPReceiver receiver = new UDPReceiver();
        receiver.receiveMessages();
    }
}
