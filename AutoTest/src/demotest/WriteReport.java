package demotest;

import org.testng.annotations.Test;

import junit.framework.Assert;

import org.testng.annotations.BeforeClass;
import org.testng.annotations.Parameters;

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

public class WriteReport 
{

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

	// Testcase 5: Viết báo cáo
	@Parameters({"tenBn", "userName", "password"})
	@Test
	public void tc_05_Viet_Bao_Cao_Ca_Chup(String tenBn, String userName, String password) 
	throws Exception
	{
		// Test case 2: Đăng nhập thông tin đúng
		driver.findElement(usernametxt).sendKeys(userName);
		driver.findElement(passwordtxt).sendKeys(password);
		driver.findElement(loginbtn).click();
		// vào danh sách ca chụp
		driver.findElement(By.xpath("//i[@class='icon-loop']")).click();
		driver.manage().timeouts().implicitlyWait(10, TimeUnit.SECONDS);
		Assert.assertTrue(driver.findElement(boloctimkiem).isDisplayed());
		driver.findElement(boloctimkiem).click();
		Thread.sleep(3000);
		driver.findElement(By.xpath("//*[@id='btnClear']")).click();
		// Chọn tìm bệnh nhân mới sửa
		WebElement tenbenhnhan = driver.findElement(tenbenhnhanDropdown);
		select = new Select(tenbenhnhan);
		select.selectByVisibleText("Tên bệnh nhân");
		driver.findElement(By.xpath("//input[@id='txtCustom1']")).sendKeys(tenBn);
		driver.findElement(By.xpath("//a[@id='btnSearch']")).click();
		Thread.sleep(3000);
			
		// tìm kiếm bệnh nhân đã chụp
		driver.findElement(By.xpath("//input[@id='txtCustom4']/following-sibling::span")).click();
		Thread.sleep(1000);
		driver.findElement(By.xpath("//input[@id='txtCustom4']/following-sibling::ul/li[text()='Đã chụp']")).click();
		Thread.sleep(1000);
		driver.findElement(By.xpath("//a[@id='btnSearch']"));
	
		// Click vào bệnh nhân để thực hiện viết báo cáo
		driver.findElement(By.xpath("//*[@id='gridPerson']/div[2]/div[1]/table/tbody/tr[1]/td[2]")).click();
		
		// viết báo cáo và duyệt		
		Actions actions = new Actions(driver);
		actions.doubleClick(driver.findElement(By.xpath("//*[@id='txtnReading']"))).perform();
		driver.findElement(By.xpath("//*[@id='txtnReading']")).sendKeys(report);
		driver.findElement(By.xpath("//*[@id='btn-save']")).click();
		Thread.sleep(5000);
		driver.findElement(By.xpath("//span[@class='btn green btn-approved']")).click();
		driver.findElement(By.xpath("//a[@id='btnSearch']")).click();
		Thread.sleep(3000);
		
		// Tìm kiếm bệnh nhân đã duyệt
		driver.findElement(By.xpath("//input[@id='txtCustom4']/following-sibling::span")).click();
		Thread.sleep(1000);
		driver.findElement(By.xpath("//input[@id='txtCustom4']/following-sibling::ul/li[text()='Đã duyệt']")).click();
		Thread.sleep(1000);
		driver.findElement(By.xpath("//a[@id='btnSearch']"));
		
		// Bỏ duyệt ca chụp
		driver.findElement(By.xpath("//*[@id=\"btnUnapprove\"]")).click();

	}
	

	@AfterClass
	public void afterClass() 
	{
		driver.close();
	}

}