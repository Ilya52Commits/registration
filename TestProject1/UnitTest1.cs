using registration;
using static registration.MainWindow; 

namespace TestProject1
{
  public class UnitTest1
  {
    [Fact]
    public void Test1()
    {
      var obj = new MainWindow();

      s_checkLogin();
    }
  }
}