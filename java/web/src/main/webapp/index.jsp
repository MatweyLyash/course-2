<%@ page import="java.io.OutputStream" %>
<%@ page import="javax.xml.transform.TransformerFactory" %>
<%@ page import="javax.xml.transform.Transformer" %>
<%@ page import="javax.xml.transform.stream.StreamSource" %>
<%@ page import="java.io.ByteArrayOutputStream" %>
<%@ page import="javax.xml.transform.stream.StreamResult" %>
<%@ page import="java.io.InputStream" %>
<%@ page import="java.io.ByteArrayInputStream" %>
<%@ page contentType="text/html; charset=UTF-8" pageEncoding="UTF-8" %>
<!DOCTYPE html>
<html>
<head>
  <title>JSP - Hello World</title>
</head>
<body>
<h1><%= "Ekz" %></h1>
<br/>
<a href="hello-servlet"><input TYPE="button" value="TRANSFORM"> </input></a>
<%
  if (request.getParameter("transform") != null) {
    try {
      String personsXml =
              "<?xml version=\"1.0\" encoding=\"UTF-8\"?>\n" +
                      "<persons>\n" +
                      "    <person fio=\"Petrov\" type=\"1000000\"/>\n" +
                      "    <person fio=\"Filin\" type=\"10\"/>\n" +
                      "</persons>";
      String cardsXml =
              "<?xml version=\"1.0\" encoding=\"UTF-8\"?>\n" +
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

      InputStream personsInputStream = new ByteArrayInputStream(personsXml.getBytes("UTF-8"));
      InputStream cardsInputStream = new ByteArrayInputStream(cardsXml.getBytes("UTF-8"));
      ByteArrayOutputStream outputStream = new ByteArrayOutputStream();

      TransformerFactory transformerFactory = TransformerFactory.newInstance();
      Transformer transformer = transformerFactory.newTransformer();
      transformer.transform(new StreamSource(personsInputStream), new StreamResult(outputStream));
      transformer.transform(new StreamSource(cardsInputStream), new StreamResult(outputStream));

      String result = outputStream.toString("UTF-8");
      response.getWriter().println("<pre>" + result + "</pre>");
    } catch (Exception e) {
      response.getWriter().println("<p>Error: " + e.getMessage() + "</p>");
    }
  }
%>

<form method="post">
  <input type="submit" value="Transform" name="transform">
</form>

</body>
</html>