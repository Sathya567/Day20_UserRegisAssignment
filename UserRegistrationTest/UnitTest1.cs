using Day20_UserRegistrationTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UserRegistrationTest
{
    [TestClass]
    public class UnitTest1
    {
        private readonly Program program;
        public UnitTest1()
        {
            program = new Program();
        }
        [TestMethod]
        public void FirstNameTest()
        {
            string name = "Sathya";
            bool result = program.FirstNameVal(name);
            Assert.AreEqual(true, result);

        }
        [TestMethod]
        public void LastNameTest()
        {
            string name = "Sriman";
            bool result = program.LastNameVal(name);
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void EmailTest()
        {
            string email = "Satya.bhandari@gmail.com.in";
            bool result = program.EmailValidation(email);
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void MobileTest()
        {
            string mobile = "91 7989501656";
            bool result = program.MobileValidation(mobile);
            Assert.AreEqual(true, result);

        }
        [TestMethod]
        public void PasswordTest()
        {
            string password = "Sathya@456";
            bool result = program.PasswordRule(password);
            Assert.AreEqual(true, result);
        }
    }
}

   
   
        