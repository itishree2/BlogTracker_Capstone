using BlogLib;
using System.ComponentModel.DataAnnotations;

namespace TestProject1
{
    [TestFixture]
    public class BlogTests
    {
        [Test]
        public void BlogInfo_ValidProperties_PassesValidation()
        {
            // Arrange
            var blogInfo = new BlogInfo
            {
                BlogId = 10,
                Title = "Azure",
                Subject = "Azure Connect to MVC",
                BolgUrl = "https://github.com/deepakk2000/Deploy-an-ASP.NET-WebForms-Application-on-Azure.git",
                EmpEmailId = "iti@gmail.com",

            };

            // Act
            var validationResults = ValidateModel(blogInfo);

            // Assert
            Assert.IsEmpty(validationResults); // If validationResults is empty, validation passed
        }

       
        private System.Collections.Generic.List<ValidationResult> ValidateModel(object model)
        {
            var validationContext = new ValidationContext(model, serviceProvider: null, items: null);
            var validationResults = new System.Collections.Generic.List<ValidationResult>();

            Validator.TryValidateObject(model, validationContext, validationResults, validateAllProperties: true);

            return validationResults;
        }
    }
}