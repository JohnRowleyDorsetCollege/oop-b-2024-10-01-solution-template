using XYZ.Domain;

namespace XYZ.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void AppNameIsCorrect()
        {
            Assert.Equal(ProjectConstants.App_Name, App_XYZ.AppName());
        }
    }
}