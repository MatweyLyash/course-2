package org.example.lab_8.UDP;
import java.io.IOException;
import java.net.DatagramPacket;
import java.net.DatagramSocket;
import java.net.InetAddress;
public class UDPSender {
    private final int PORT = 8000;
    private final String RECEIVER_IP = "localhost";

    public void sendMessage(String message) {
        try {
            DatagramSocket socket = new DatagramSocket();
            byte[] buffer = message.getBytes();
            InetAddress receiverAddress = InetAddress.getByName(RECEIVER_IP);
            DatagramPacket packet = new DatagramPacket(buffer, buffer.length, receiverAddress, PORT);
            socket.send(packet);
            System.out.println("Сообщение отправлено: " + message);
            socket.close();
        } catch (IOException e) {
            e.printStackTrace();
        }
    }

    public static void main(String[] args) {
        UDPSender sender = new UDPSender();
        sender.sendMessage("Привет, мир!");
    }
}
