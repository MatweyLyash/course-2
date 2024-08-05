import org.testng.annotations.AfterSuite;
import org.testng.annotations.BeforeMethod;
import org.testng.annotations.Test;

import static org.testng.Assert.*;

public class TestCompany {
    private Company testCompany;
    private Employee testEmployee1;
    private Employee testEmployee2;

    @BeforeMethod
    public void setUp() {
        testCompany = new Company();
        testEmployee1 = new Employee("Aboba", 10, true);
        testEmployee2 = new Employee("Ilya", 2, false);
    }

    @AfterSuite
    public void End() {
        testCompany = null;
        testEmployee1 = null;
        testEmployee2 = null;
        System.out.println("Тест закончен!");
    }

    @Test (enabled = false)
    public void addNewEmployee() {
        testCompany.addNewEmployee(testEmployee1);
        assertTrue(testCompany.arr.contains(testEmployee1));
    }

    @Test(timeOut = 1100)
    public void removeEmployee() throws InterruptedException {
        testCompany.arr.add(testEmployee1);
        testCompany.removeEmployee(testEmployee1);
        Thread.sleep(1000);
        assertFalse(testCompany.arr.contains(testEmployee1));
    }

    @Test
    public void removeNonexistentEmployee() {
        testCompany.removeEmployee(testEmployee1);
        assertFalse(testCompany.arr.contains(testEmployee1));
    }


    @Test
    public void testGetAllEmployee() {
        testCompany.addNewEmployee(testEmployee1);
//         testCompany.addNewEmployee(testEmployee2);
        String str = "Aboba 10 true \n";
        assertEquals(str, testCompany.getAllEmployee());
    }
}