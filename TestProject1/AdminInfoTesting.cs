using BlogLib;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    [TestFixture]
    public class AdminInfoTesting
    {
        [Test]
        public void ValidAdmainInfo()
        {
            //Arrange
            var adminInfo = new AdminInfo
            {
                EmailId = "iti@gmail.com",
                Password = "iti2121"
            };
            // Act
            var validationContext = new ValidationContext(adminInfo, null, null);
            var validationResults = new List<ValidationResult>();
            var isValid = Validator.TryValidateObject(adminInfo, validationContext, validationResults, true);
            // Assert
            Assert.IsTrue(isValid);
        }
        
        // Add more test cases as needed for other scenarios.
    }

}
