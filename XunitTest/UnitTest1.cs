using ClassRoomNet60;

namespace XunitTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("Christian", 12, 12, "Vinter")]
        [InlineData("Rasmus", 7, 31, "Sommer")]
        public void TestSeason(string name, int month, int day, string expected)
        {
            // Arrange      
            var studerende = new ClassRoomNet60.Studerende(name, month, day);
            // Act
            var årstid = studerende.årstid();
            // Assert
            Assert.Equal(expected, årstid);
        }
    }

}
