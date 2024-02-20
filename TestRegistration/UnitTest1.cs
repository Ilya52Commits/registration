using Microsoft.VisualStudio.TestTools.UnitTesting;
using static registration.CreateUser;

namespace TestRegistration
{
  [TestClass]
  public class UnitTest1
  {
    [TestMethod]
    public void TestPhone()
    {
      Assert.AreEqual(IsPhoneCorrect(""), false);
    }

    [TestMethod]
    public void TestPhone2()
    {
      Assert.AreEqual(IsPhoneCorrect("1"), false);
    }
  }
}

/*
 1. пустая строка; 
2. непуста строка (1 символ); 
3. проверка на длину с +;
4. проверка на длину с 8; 
5. проверка на буквы в строке; 
6. проверка на +7;
7. проверка на символ в строке;
8. проверка на букву и на символ в строке. 
 */