import java.util.*;
public class Company {
    public String nameCompany;
    public ArrayList<Employee> arr = new ArrayList<Employee>();

    public void addNewEmployee(Employee em)
    {
        arr.add(em);
    }

    public void removeEmployee(Employee em)
    {
        if(arr.contains(em)) {
            arr.remove(em);
        }
        else
        {
            System.out.println("Такого сотрудника нет!");
        }
    }

    public String getAllEmployee()
    {
        String sb = "";
        for (var a : arr) {
            sb += a.name + " ";
            sb += Integer.toString(a.yearExp) + " ";
            sb += Boolean.toString(a.education) + " ";
            sb += "\n";
        }
        return sb;
    }

    public void getEmployeeWithHigherEducation()
    {
        for (var a: arr) {
            if (a.education) {
                a.toString();
            }
        }
    }

    public void getEmployeeWithWorkExp(int exp)
    {
        for (var a: arr) {
            if (a.yearExp >= exp) {
                a.toString();
            }
        }
    }
}