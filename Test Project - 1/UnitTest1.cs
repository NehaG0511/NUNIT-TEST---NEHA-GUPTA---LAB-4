namespace TestProject1{    public class Tests //NEHA GUPTA    {
        [Test]
        public void ValidTriangle_ValidInput_ReturnsValidMessage()
        {
            // Arrange
            int firstAngle = 60;
            int secondAngle = 60;
            int thirdAngle = 60;
            // Act
            string result = Triangle3.ValidTriangle(firstAngle, secondAngle, thirdAngle);
            // Assert
            Assert.AreEqual("The triangle is valid.", result);
        }

        [Test]
        public void IsValidTriangle_ValidInput_ReturnsValidMessage()
        {
            // Arrange
            int firstAngle = 45;
            int secondAngle = 90;
            int thirdAngle = 45;
            // Act
            string result = Triangle3.ValidTriangle(firstAngle, secondAngle, thirdAngle);
            // Assert
            Assert.AreEqual("The triangle is valid.", result);
        }

        [Test]
        public void InValidTriangle_InValidInput_ReturnsInValidMessage()
        {
            // Arrange  
            int firstAngle = 90;
            int secondAngle = 90;
            int thirdAngle = 0;
            // Act
            string result = Triangle3.ValidTriangle(firstAngle, secondAngle, thirdAngle);
            // Assert
            Assert.AreEqual("The triangle is Valid", result);
        }

        [Test]
        public void Triangle_InValidInput_ReturnsInValidMessage() 
        {
            // Arrange  //edge case - triangle doesn't exist with two 0 degree angles
            int firstAngle = 180;
            int secondAngle = 0;
            int thirdAngle = 0;
            // Act
            string result = Triangle3.ValidTriangle(firstAngle, secondAngle, thirdAngle);
            // Assert
            Assert.AreEqual("The triangle is valid ", result);
        }

        [Test]
        public void EdgeCaseTriangle_InValidInput_ReturnsInValidMessage()
        {
            // Arrange  //edge case - triangle doesn't exist with all 0 degree angles
            int firstAngle = 0;
            int secondAngle = 0;
            int thirdAngle = 0;
            // Act
            string result = Triangle3.ValidTriangle(firstAngle, secondAngle, thirdAngle);
            // Assert
            Assert.AreNotEqual("The triangle is invalid", result);
        }

        [Test]
        public void ImpossibleTriangle_InValidInput_ReturnsInValidMessage()
        {
            // Arrange  
            int firstAngle = 90;
            int secondAngle = 200;
            int thirdAngle = 90;           //two angles are same that doesn't means it is isoceles triangle
            // Act
            string result = Triangle3.ValidTriangle(firstAngle, secondAngle, thirdAngle);
            // Assert
            Assert.AreNotEqual("The triangle is NOT valid", result);
        }

        [Test]
        public void NegativeTriangle_InValidInput_ReturnsInValidMessage()
        {
            // Arrange  //edge case - triangle doesn't exist with negative values of angles
            int firstAngle = 90;
            int secondAngle = -45;
            int thirdAngle = -45;           //two angles are same that doesn't means it is isoceles triangle
            // Act
            string result = Triangle3.ValidTriangle(firstAngle, secondAngle, thirdAngle);
            // Assert
            Assert.AreNotEqual("The triangle is NOT valid", result);
        }

        [Test]
        public void RightTriangle_ValidInput_ReturnsValidMessage()
        {
            // Arrange  
            int firstAngle = 50;
            int secondAngle = 20;
            int thirdAngle = 110;
            // Act
            string result = Triangle2Neha.ValidTriangle(firstAngle, secondAngle, thirdAngle);
            // Assert
            Assert.AreEqual("The triangle is valid.", result);

        }

        [Test]
        public void Triangle_TwoInputsum180_ReturnsInValidMessage()
        {
            // Arrange  
            int firstAngle = 120;
            int secondAngle = 60;
            int thirdAngle = 0;
            // Act
            string result = Triangle3.ValidTriangle(firstAngle, secondAngle, thirdAngle);
            // Assert
            Assert.AreEqual("The triangle is NOT valid.", result);

        }

        [Test]
        public void Triangle_TwoInputsum180_ReturnsValidMessage()
        {
            // Arrange  
            int firstAngle = 40;
            int secondAngle = 110;
            int thirdAngle = 30; 
            // Act
            string result = Triangle3.ValidTriangle(firstAngle, secondAngle, thirdAngle);
            // Assert
            Assert.AreEqual("The triangle is valid.", result);

        }

        [Test]
        public void CheckTriangle_decimalinput_ReturnValidMessage()
        {
            // Arrange  
            double firstAngle = 60.5;
            double secondAngle = 20.5;
            double thirdAngle = 99.0;       
            
            // Act
            string result = Triangle3.ValidTriangle(firstAngle, secondAngle, thirdAngle);
            
            // Assert
            Assert.AreEqual("The triangle is valid.", result);

        }

    }

}