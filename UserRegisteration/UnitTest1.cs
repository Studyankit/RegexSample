using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistration;

namespace UserRegisteration
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow("abc@yahoo.com")]
        [DataRow("abc-100@yahoo.com")]
        [DataRow("abc.100@yahoo.com")]
        [DataRow("abc111@abc.com")]
        [DataRow("abc-100@abc.net")]
        [DataRow("abc.100@abc.com.au")]
        [DataRow("abc@1.com")]
        [DataRow("abc@gmail.com.com")]
        [DataRow("abc+100@gmail.com")]
        public void TestSampleEmails(string email)
        {
            string excepted = "true";
            var actual = UserRegister.ValidateEmailID(email);
            Assert.AreNotEqual(actual, excepted);

        }
    }
}