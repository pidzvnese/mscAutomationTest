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

public class LoginTest 
{

    WebDriver driver;
	JavascriptExecutor js;
	Select select;
	String mabenhnhansearch = "c15";
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

	@Parameters({"url", "timeOut"})
	@BeforeClass
	public void beforeClass(String url, String timeOut) 
	{
		System.setProperty("webdriver.chrome.driver", "lib\\chromedriver.exe");
		// 1. Open browser
		driver = new ChromeDriver();
		// 2. Open website
		driver.get(url);
		driver.manage().window().maximize();
		// wait for element visible 30s
		driver.manage().timeouts().implicitlyWait(Integer.valueOf(timeOut), TimeUnit.SECONDS);

		js = (JavascriptExecutor) driver;
	}

	// Test case 1: Ä�Äƒng nháº­p sai
	@Parameters({"sleepTime"})
	@Test
	public void tc_01_Login_With_Empty_Field(String sleepTime) 
	throws InterruptedException 
	{
		driver.findElement(usernametxt).sendKeys("");
		driver.findElement(passwordtxt).sendKeys("");
		Thread.sleep(Integer.valueOf(sleepTime));
		driver.findElement(loginbtn).click();
		System.out.println(driver.findElement(errormsg).getText());
		Assert.assertTrue(driver.findElement(errormsg).isDisplayed());
		Assert.assertEquals(driver.findElement(errormsg).getText(), "Sai tên đăng nhập hoặc mật khẩu.");
	}

	// Test case 2: Ä�Äƒng nháº­p thÃ´ng tin Ä‘Ãºng
	@Parameters({"userName", "password", "sleepTime"})
	@Test
	public void tc_02_Login_Success(String userName, String password, String sleepTime) 
	throws InterruptedException 
	{
		driver.findElement(usernametxt).sendKeys(userName);
		driver.findElement(passwordtxt).sendKeys(password);
		Thread.sleep(Integer.valueOf(sleepTime));
		driver.findElement(loginbtn).click();
	}
	


	@AfterClass
	public void afterClass() 
	{
		driver.close();
	}

}