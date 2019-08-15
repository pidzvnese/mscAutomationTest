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

public class EditInformation 
{

    WebDriver driver;
	JavascriptExecutor js;
	Select select;
	String mabenhnhansearch = "c28";
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

	// Test case 4: sua thong tin ca chup khong thanh cong
	@Parameters({"maBn", "newName","maBnMoi","userName","password"})
	@Test
	public void tc_04_Sua_Thong_Tin_Ca_Chup(String maBn, String newName, String maBnMoi, String userName, String password) 
	throws Exception 
	{
		// Đăng nhập thông tin đúng
		driver.findElement(usernametxt).sendKeys(userName);
		driver.findElement(passwordtxt).sendKeys(password);
		driver.findElement(loginbtn).click();
		// vào danh sách ca chụp
		driver.findElement(By.xpath("//i[@class='icon-loop']")).click();
		driver.manage().timeouts().implicitlyWait(10, TimeUnit.SECONDS);
		Assert.assertTrue(driver.findElement(boloctimkiem).isDisplayed());
		driver.findElement(boloctimkiem).click();
		Thread.sleep(3000);
		
		// chọn tìm theo mã bệnh nhân ở dropdown
		WebElement mabenhnhan = driver.findElement(mabenhnhanDropdown);
		select = new Select(mabenhnhan);
		select.selectByVisibleText("Mã bệnh nhân");
		driver.findElement(By.xpath("//input[@id='txtCustom1']")).sendKeys(maBn);
		driver.findElement(By.xpath("//a[@id='btnSearch']")).click();
		Thread.sleep(3000);

		// tìm kiếm bệnh nhân đã chụp
		driver.findElement(By.xpath("//input[@id='txtCustom4']/following-sibling::span")).click();
		Thread.sleep(1000);
		driver.findElement(By.xpath("//input[@id='txtCustom4']/following-sibling::ul/li[text()='Đã chụp']")).click();		
		Thread.sleep(1000);
		driver.findElement(By.xpath("//a[@id='btnSearch']"));
		
		// click chuột phải, chọn Sửa thông tin ca chụp
		Actions actions = new Actions(driver);
		WebElement trangthai = driver.findElement(trangthaiduyet);
		actions.contextClick(trangthai).perform();
		Thread.sleep(1000);

		driver.findElement(suathongtincachup).click();
//		Assert.assertTrue(driver.findElement(By.xpath("//ul[contains(@style,'width')]/li[2]")).isDisplayed());
//		driver.findElement(By.xpath("//ul[contains(@style,'width')]/li[2]")).click();
		Thread.sleep(3000);

		// điền thông tin bệnh nhân
		driver.findElement(mabenhnhan1).sendKeys(maBnMoi);
		driver.findElement(tenbenhnhan).sendKeys("");
		driver.findElement(tuoi).sendKeys("40");
		driver.findElement(gioitinh).sendKeys("nam");
		driver.findElement(diachi).sendKeys("CT2-DN1_Dinh Cong");  
		driver.findElement(bhxh).sendKeys("321654978");
		driver.findElement(bophanchup).sendKeys("Chan-Tay_Mieng");
		driver.findElement(giotaochidinh).sendKeys("10/04/19");
		driver.findElement(chidinh).sendKeys("chup ngoai he thong");
		driver.findElement(chuandoan).sendKeys("benh ngoai da");	
		driver.findElement(bacsichidinh).sendKeys("Hua An");
		
		driver.findElement(By.xpath("//a[@class='btn green pull-right']")).click();
		Thread.sleep(4000);
		
		// popup cảnh báo xuất hiện
//		System.out.println(driver.findElement(errormsg).getText());
//		Assert.assertTrue(driver.findElement(errormsg).isDisplayed());
//		Assert.assertEquals(driver.findElement(errormsg).getText(), "Ten benh nhan khong duoc rong.");
//		Thread.sleep(2000);
		
		// điền thêm tên bệnh nhân
		driver.findElement(tenbenhnhan).sendKeys(newName);
		driver.findElement(By.xpath("//a[@class='btn green pull-right']")).click();
		Thread.sleep(2000);
		// điền lý do và nhấn ok
		driver.findElement(By.xpath("//input[@placeholder='Lý do']")).sendKeys("Hoi lam gi");
		driver.findElement(By.xpath("//button[text()='Đồng ý']")).click();
		Thread.sleep(2000);
		

	}
	

	@AfterClass
	public void afterClass() 
	{
		driver.close();
	}

}