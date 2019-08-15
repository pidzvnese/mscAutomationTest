set projectPath={path}
set CLASSPATH=%ProjectPath%\class;%ProjectPath%\lib\*
cd /d %projectPath%
java org.testng.TestNG %ProjectPath%\{batname}.xml
echo %CLASSPATH%