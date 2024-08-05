package org.example.lab_8;
import org.example.lab_8.HTMLParser;
public class Main {

    public static void main(String[] args) {
       String someHtml =  HTMLParser.GetHTML("https://www.dojki.com");
        System.out.println(someHtml);


    }
}
