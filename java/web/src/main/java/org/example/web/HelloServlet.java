package org.example.web;

import java.io.*;
import jakarta.servlet.http.*;
import jakarta.servlet.annotation.*;

import javax.xml.transform.Transformer;
import javax.xml.transform.TransformerFactory;
import javax.xml.transform.stream.StreamResult;
import javax.xml.transform.stream.StreamSource;

@WebServlet(name = "helloServlet", value = "/hello-servlet")
public class HelloServlet extends HttpServlet {
    private String message;
    String transformedXml;

    public void init() {
        message = "Hello World!";
    }

    public void doGet(HttpServletRequest request, HttpServletResponse response) throws IOException {
        response.setContentType("text/html");
        String sourceXml = "<?xml version=\"1.0\" encoding=\"UTF-8\"?>\n" +
                "<cards>\n" +
                "    <card id=\"12354622\">\n" +
                "        <name>Petrov</name>\n" +
                "        <number>34</number>\n" +
                "        <sum>1000000</sum>\n" +
                "    </card>\n" +
                "    <card id=\"C8947633\">\n" +
                "        <name>Filin</name>\n" +
                "        <number>123</number>\n" +
                "        <sum>10</sum>\n" +
                "    </card>\n" +
                "</cards>";


        // Hello
        PrintWriter out = response.getWriter();
        out.println("<html><body>");
        out.println("<h1>" + message + "</h1>");
        out.println("</body></html>");
         transformedXml = transformXml(sourceXml);
        out.println("<pre>" + transformedXml + "</pre>");

    }
    public static String transformXml(String sourceXml) {
        try {

            StringReader reader = new StringReader(sourceXml);
            StringWriter writer = new StringWriter();


            TransformerFactory transformerFactory = TransformerFactory.newInstance();
            Transformer transformer = transformerFactory.newTransformer(new StreamSource(
                    new StringReader(
                            "<?xml version=\"1.0\" encoding=\"UTF-8\"?>\n" +
                                    "<xsl:stylesheet version=\"1.0\" xmlns:xsl=\"http://www.w3.org/1999/XSL/Transform\">\n" +
                                    "    <xsl:output method=\"xml\" encoding=\"UTF-8\" indent=\"yes\"/>\n" +
                                    "    <xsl:template match=\"/\">\n" +
                                    "        <persons>\n" +
                                    "            <xsl:for-each select=\"cards/card\">\n" +
                                    "                <person fio=\"{name}\" type=\"{sum}\"/>\n" +
                                    "            </xsl:for-each>\n" +
                                    "        </persons>\n" +
                                    "     </xsl:template>  " +
                                    "</xsl:stylesheet>"
                    )));


            transformer.transform(new StreamSource(reader), new StreamResult(writer));
            return writer.toString();
        } catch (Exception e) {
            e.printStackTrace();
            return null;
        }
    }
    public void destroy() {
    }
}