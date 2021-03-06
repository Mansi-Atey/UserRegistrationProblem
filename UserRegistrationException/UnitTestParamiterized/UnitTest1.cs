using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Runtime.Serialization;
using UserRegistrationException;

namespace UnitTestParamiterized
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        { }
             private RegexValidation user;
    
        [TestInitialize]
        public void InitClassObject()
        {
            //Arrange
            user = new RegexValidation();
        }
        [TestMethod]
        public void GivenUserFistName_WhenValidate_ShouldReturnTrue()
        {
            string firstName = "Mansi";
            //Act
            bool result = user.ValidateFirstName(firstName);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void GivenUserLastName_WhenValidate_ShouldReturnTrue()
        {
            string lastName = "Atey";
            //Act
            bool result = user.ValidateFirstName(lastName);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void GivenEmailId_WhenValidate_ShouldReturnTrue()
        {
            string email = "mansiatey31@gmail.com";
            //Act
            bool result = user.ValidateEmail(email);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void GivenMobileNumber_WhenValidate_ShouldReturnTrue()
        {
            string mobileNumber = "91 9988776655";
            //Act
            bool result = user.ValidateMobile(mobileNumber);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void GivenPassword_WhenValidate_ShouldReturnTrue()
        {
            //Arrange

            string password = "Mansi-123";
            //Act
            bool result = user.ValidatePassword(password);
            //Assert
            Assert.IsTrue(result);
        }
        //Sad Test Cases(Test Cases Fail The Entry)
        [TestMethod]
        public void GivenUserFistName_WhenValidate_Should_throw_Custom_InvalidFirstNameException()
        {
            try
            {
                string firstName = "Mansi";
                bool result = user.ValidateFirstName(firstName);
            }
            catch (InvalidUserDetailException e)
            {
                Assert.AreEqual("Invalid First Name", e.Message);
            }
        }
        [TestMethod]
        public void GivenUserLastName_WhenValidate_Should_throw_Custom_InvalidLastNameException()
        {
            try
            {
                string lastName = "atey";
                bool result = user.ValidateLastName(lastName);
            }
            catch (InvalidUserDetailException e)
            {
                Assert.AreEqual("Invalid Last Name", e.Message);
            }
        }
        [TestMethod]
        public void GivenEmailId_WhenValidate_Should_throw_Custom_InvalidEmailException()
        {
            try
            {
                string email = "mansiatey31@.com";
                bool result = user.ValidateEmail(email);
            }
            catch (InvalidUserDetailException e)
            {
                Assert.AreEqual("Invalid Email", e.Message);
            }
        }
        [TestMethod]
        public void GivenMobileNumber_WhenValidate_Should_throw_Custom_InvalidMobileException()
        {
            try
            {
                string mobileNumber = "91 998877655";
                bool result = user.ValidateMobile(mobileNumber);
            }
            catch (InvalidUserDetailException e)
            {
                Assert.AreEqual("Invalid Mobile Number", e.Message);
            }
        }
        [TestMethod]
        public void GivenPassword_WhenValidate_Should_throw_Custom_InvalidPasswordException()
        {
            try
            {
                string password = "mansi-1234";
                bool result = user.ValidatePassword(password);
            }
            catch (InvalidUserDetailException e)
            {
                Assert.AreEqual("Invalid Password", e.Message);
            }
        }
        [TestMethod]
        [DataRow("abc@yahoo.com")]
        [DataRow("abc-100@yahoo.com")]
        [DataRow("abc.100@yahoo.com")]
        [DataRow("abc111@abc.com")]
        [DataRow("abc.100@abc.com.au")]
        [DataRow("abc-100@abc.net")]
        [DataRow("abc@1.com")]
        [DataRow("abc@gmail.com.com")]
        [DataRow("abc+100@gmail.com")]
        public void ValidateEmailId_Should_return_true(string email)
        {
            Assert.IsTrue(user.ValidateEmail(email));
        }
    }

    [Serializable]
    internal class InvalidUserDetailException : Exception
    {
        public InvalidUserDetailException()
        {
        }

        public InvalidUserDetailException(string message) : base(message)
        {
        }

        public InvalidUserDetailException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidUserDetailException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
    

