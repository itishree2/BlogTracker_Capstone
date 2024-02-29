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
    public class EmpInfoTesting
    {
        [Test]
        public void EmpInfo_ValidData_ShouldPassValidation()
        {
            // Arrange
            EmpInfo empInfo = new EmpInfo
            {
                EmailId = "iti@gmail.com",
                Name = "Itishree",
                PassCode = 12345
            };

            // Act
            var validationResults = ValidateModel(empInfo);

            // Assert
            Assert.IsEmpty(validationResults, "Validation should pass");
        }

        
      
        private List<ValidationResult> ValidateModel(object model)
        {
            var validationContext = new ValidationContext(model, null, null);
            var validationResults = new List<ValidationResult>();

            Validator.TryValidateObject(model, validationContext, validationResults, true);

            return validationResults;
        }

        private bool HasErrorMessage(List<ValidationResult> validationResults, string errorMessage)
        {
            return validationResults.Any(result => result.ErrorMessage != null && result.ErrorMessage.Contains(errorMessage));
        }

    }
}

