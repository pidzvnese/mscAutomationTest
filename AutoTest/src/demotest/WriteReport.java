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

	// Testcase 5: Viáº¿t bÃ¡o cÃ¡o
	@Parameters({"tenBn", "userName", "password", "sleepTime"})
	@Test
	public void tc_05_Viet_Bao_Cao_Ca_Chup(String tenBn, String userName, String password, String sleepTime) 
	throws Exception
	{
		// Test case 2: Ä�Äƒng nháº­p thÃ´ng tin Ä‘Ãºng
		driver.findElement(usernametxt).sendKeys(userName);
		driver.findElement(passwordtxt).sendKeys(password);
		driver.findElement(loginbtn).click();
		// vÃ o danh sÃ¡ch ca chá»¥p
		driver.findElement(By.xpath("//i[@class='icon-loop']")).click();
		driver.manage().timeouts().implicitlyWait(10, TimeUnit.SECONDS);
		Assert.assertTrue(driver.findElement(boloctimkiem).isDisplayed());
		driver.findElement(boloctimkiem).click();
		Thread.sleep(Integer.valueOf(sleepTime) + 500);
		driver.findElement(By.xpath("//*[@id='btnClear']")).click();
		// Chá»�n tÃ¬m bá»‡nh nhÃ¢n má»›i sá»­a
		WebElement tenbenhnhan = driver.findElement(tenbenhnhanDropdown);
		select = new Select(tenbenhnhan);
		select.selectByVisibleText("Têm bệnh nhân");
		driver.findElement(By.xpath("//input[@id='txtCustom1']")).sendKeys(tenBn);
		driver.findElement(By.xpath("//a[@id='btnSearch']")).click();
		Thread.sleep(Integer.valueOf(sleepTime) + 500);
			
		// tÃ¬m kiáº¿m bá»‡nh nhÃ¢n Ä‘Ã£ chá»¥p
		driver.findElement(By.xpath("//input[@id='txtCustom4']/following-sibling::span")).click();
		Thread.sleep(Integer.valueOf(sleepTime));
		driver.findElement(By.xpath("//input[@id='txtCustom4']/following-sibling::ul/li[text()='Ä�Ã£ chá»¥p']")).click();
		Thread.sleep(Integer.valueOf(sleepTime));
		driver.findElement(By.xpath("//a[@id='btnSearch']"));
	
		// Click vÃ o bá»‡nh nhÃ¢n Ä‘á»ƒ thá»±c hiá»‡n viáº¿t bÃ¡o cÃ¡o
		driver.findElement(By.xpath("//*[@id='gridPerson']/div[2]/div[1]/table/tbody/tr[1]/td[2]")).click();
		
		// viáº¿t bÃ¡o cÃ¡o vÃ  duyá»‡t		
		Actions actions = new Actions(driver);
		actions.doubleClick(driver.findElement(By.xpath("//*[@id='txtnReading']"))).perform();
		driver.findElement(By.xpath("//*[@id='txtnReading']")).sendKeys(report);
		driver.findElement(By.xpath("//*[@id='btn-save']")).click();
		Thread.sleep(Integer.valueOf(sleepTime) + 1000);
		driver.findElement(By.xpath("//span[@class='btn green btn-approved']")).click();
		driver.findElement(By.xpath("//a[@id='btnSearch']")).click();
		Thread.sleep(Integer.valueOf(sleepTime));
		
		// TÃ¬m kiáº¿m bá»‡nh nhÃ¢n Ä‘Ã£ duyá»‡t
		driver.findElement(By.xpath("//input[@id='txtCustom4']/following-sibling::span")).click();
		Thread.sleep(Integer.valueOf(sleepTime) - 500);
		driver.findElement(By.xpath("//input[@id='txtCustom4']/following-sibling::ul/li[text()='Ä�Ã£ duyá»‡t']")).click();
		Thread.sleep(Integer.valueOf(sleepTime) - 500);
		driver.findElement(By.xpath("//a[@id='btnSearch']"));
		
		// Bá»� duyá»‡t ca chá»¥p
		driver.findElement(By.xpath("//*[@id=\"btnUnapprove\"]")).click();
		Thread.sleep(Integer.valueOf(sleepTime) - 500);
	}
	

	@AfterClass
	public void afterClass() 
	{
		driver.close();
	}

}