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
    }
}
   
   
        