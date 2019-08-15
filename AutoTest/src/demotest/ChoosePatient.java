package demotest;

import org.testng.annotations.Test;

import junit.framework.Assert;

import org.testng.annotations.BeforeClass;
import org.testng.annotations.Parameters;

import java.awt.List;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.Iterator;
import java.util.Map;
import java.util.Set;
import java.util.concurrent.TimeUnit;

import org.openqa.selenium.Alert;
import org.openqa.selenium.By;
import org.openqa.selenium.JavascriptExecutor;
import org.openqa.selenium.Keys;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.chrome.ChromeDriver;
import org.openqa.selenium.firefox.FirefoxDriver;
import org.openqa.selenium.interactions.Actions;
import org.openqa.selenium.support.ui.Select;
import org.testng.annotations.AfterClass;

public class ChoosePatient 
{
	Map<String, String> rs = new HashMap<String, String>();
	WebDriver driver;
	JavascriptExecutor js;
	Select select;
	String mabenhnhansearch = "c26";
	String report = "abcXYZ";
	By usernametxt = By.xpath("//input[@id='LoginUser_UserName']");
	By passwordtxt = By.xpath("//input[@id='LoginUser_Password']");
	By loginbtn = By.xpath("//a[@id='LoginUser_LoginButton']");
	By errormsg = By.xpath("//span[contains(text(),'Sai')]");
	By logoutbtn = By.xpath("//input[@id='btnInsert']");
	By mabenhnhan1 = By.xpath("//input[@name='matchedInfo[code]']");
	By tenbenhnhan = By.xpath("//input[@name='matchedInfo[name]']");
	By tuoi = By.xpath("//input[@name='matchedInfo[age]']");
	By gioitinh = By.xpath("//input[@name='matchedInfo[gender]']");
	By diachi = By.xpath("//input[@name='matchedInfo[address]']");
	By bhxh = By.xpath("//input[@name='matchedInfo[BHXH]']");
	By bophanchup = By.xpath("//input[@name='matchedOrderInfo[bodyPart]']");
	By giotaochidinh = By.xpath("//input[@name='matchedOrderInfo[createdDate]']");
	By chidinh = By.xpath("//input[@name='matchedOrderInfo[description]']");
	By chuandoan = By.xpath("//input[@name='matchedOrderInfo[chanDoan]']");
	By bacsichidinh = By.xpath("//input[@name='matchedOrderInfo[orderDoctor]']");

	By mabenhnhanDropdown = By.xpath("//select[@id='slCustom1']");
	By tenbenhnhanDropdown = By.xpath("//select[@id='slCustom1']");
	By trangthaiduyet = By.xpath("//td[@class=\"StatusName\"][1]");
	By boloctimkiem = By.xpath("//a[@id='root1_anchor']");
	By suathongtincachup = By.xpath("//ul[contains(@style,'width')]//li[text()=' Sửa thông tin ca chụp']");
	
	
	@Parameters({"url"})
	@BeforeClass
	public void beforeClass(String url) 
	{
		System.setProperty("webdriver.chrome.driver", "lib\\chromedriver.exe");
		// 1. Open browser
		driver = new ChromeDriver();
		// 2. Open website
		driver.get(url);
		driver.manage().window().maximize();
		// wait for element visible 30s
		driver.manage().timeouts().implicitlyWait(30, TimeUnit.SECONDS);

		js = (JavascriptExecutor) driver;
	}
	
	// Test case 3: chọn bệnh nhân, vào pacsviewer
	@Parameters({"maBn", "userName", "password"})
	@Test
	public void tc_03_Pacs_Viewer(String maBn, String userName, String password)
	throws Exception
	{
			
			// Đăng nhập thông tin đúng
			driver.findElement(usernametxt).sendKeys(userName);
			driver.findElement(passwordtxt).sendKeys(password);
			driver.findElement(loginbtn).click();
			
			try {
				// vào danh sách ca chụp
				driver.findElement(By.xpath("//i[@class='icon-loop']")).click();
				driver.manage().timeouts().implicitlyWait(10, TimeUnit.SECONDS);
				Assert.assertTrue(driver.findElement(boloctimkiem).isDisplayed());
				driver.findElement(boloctimkiem).click();
				Thread.sleep(3000);
				rs.put("vào danh sách ca chụp","Pass");
			} catch (Exception e) {
				rs.put("vào danh sách ca chụp","Fail");
			}
			
			try {
				// chọn tìm theo mã bệnh nhân ở dropdown
				WebElement mabenhnhan = driver.findElement(mabenhnhanDropdown);
				select = new Select(mabenhnhan);
				select.selectByVisibleText("Mã bệnh nhân");
				driver.findElement(By.xpath("//input[@id='txtCustom1']")).sendKeys(maBn);
				driver.findElement(By.xpath("//a[@id='btnSearch']")).click();
				Thread.sleep(3000);
				rs.put("chọn tìm theo mã bệnh nhân ở dropdown","Pass");
			} catch (Exception e) {
				rs.put("chọn tìm theo mã bệnh nhân ở dropdown","Fail");
			}
			
			// try {
				// // tìm kiếm bệnh nhân đã chụp
				// driver.findElement(By.xpath("//input[@id='txtCustom4']/following-sibling::span")).click();
				// Thread.sleep(1000);
				// driver.findElement(By.xpath("//input[@id='txtCustom4']/following-sibling::ul/li[text()='Đã chụp']")).click();		
				// Thread.sleep(1000);
				// driver.findElement(By.xpath("//a[@id='btnSearch']"));
				// rs.put("tìm kiếm bệnh nhân đã chụp","Pass");
			// } catch (Exception e) {
				// rs.put("tìm kiếm bệnh nhân đã chụp","Fail");
			// }

			try {
				// Click chuột để vào pacsviewer
				Actions actions = new Actions(driver);
				WebElement trangthai = driver.findElement(trangthaiduyet);
				actions.doubleClick(trangthai).perform();
				Thread.sleep(2000);
				rs.put("Click chuột để vào pacsviewer","Pass");
				
			} catch (Exception e) {
				rs.put("Click chuột để vào pacsviewer","Fail");
			}
			
			try {
				// Chỉnh sáng tối
				WebElement iframeView = driver.findElement(By.xpath("//iframe[@id='icase-study-0']"));
				driver.switchTo().frame(iframeView);
				driver.findElement(By.xpath("//*[@id='common']/*[@id='common-icons']/a[11]")).click();
				Thread.sleep(3000);
				driver.findElement(By.xpath("//*[@id='div-prefix-window']/ul/li[9]")).click();
				Thread.sleep(3000);
				rs.put("Chỉnh sáng tối","Pass");
			} catch (Exception e) {
				rs.put("Chỉnh sáng tối","Fail");
			}
			
			
			
		    // Quay lại trạng thái ban đầu
			driver.findElement(By.xpath("//*[@id='common-icons']/a[17]")).click();
			Thread.sleep(3000);
			
			
			// Đóng Pacsviewer
			driver.findElement(By.xpath("//span[@class='ui-icon ui-icon-close']")).click();
			driver.switchTo().defaultContent();
			Thread.sleep(2000);
	}

	

	@AfterClass
	public void afterClass() 
	{
		Set set2 = rs.entrySet();
		Iterator iterator2 = set2.iterator();
	      while(iterator2.hasNext()) {
	          Map.Entry mentry2 = (Map.Entry)iterator2.next();
	          System.out.print("Key is: "+mentry2.getKey() + " & Value is: ");
	          System.out.println(mentry2.getValue());
	       }
		driver.close();
	}

}