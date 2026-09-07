using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassRoomNet60;

namespace ClassroomTest
{
    [TestClass]
    public sealed class Test1
    {
      
        [DataTestMethod]
        [DataRow("Christian", 12, 12, "Vinter")]
        [DataRow("Rasmus", 7, 7, "Sommer")]
        

        public void TestÅrstid(string navn, int fødselsmåned, int fødselsdag, string forventetÅrstid)
        {
            // Arrange
            var studerende = new Studerende(navn, fødselsmåned, fødselsdag);
            // Act
            var årstid = studerende.årstid();
            // Assert
            Assert.AreEqual(forventetÅrstid, årstid);
        }
    }
}
