using Dev2.Common.Interfaces.Scheduler.Interfaces;
using Dev2.Studio.Core.AppResources.Converters;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dev2.Core.Tests.AppResources.Converters
{
    [TestClass]
    public class InverseScheduleStatusConverterTest
    {
        [TestMethod]
        [Owner("Sanele Mthembu")]
        public void Convert_GivenSchedulerIsEnabled_Should_Return_False()
        {
            //------------Setup for test--------------------------
            var statusConverter = new InverseScheduleStatusConverter();
            //------------Execute Test---------------------------
            var convert = statusConverter.Convert(SchedulerStatus.Enabled, null, null, null);
            //------------Assert Results-------------------------    
            Assert.IsFalse(convert != null && (bool)convert);
        }

        [TestMethod]
        [Owner("Sanele Mthembu")]
        public void Convert_GivenSchedulerIsDisabled_Should_Return_True()
        {
            //------------Setup for test--------------------------
            var statusConverter = new InverseScheduleStatusConverter();
            //------------Execute Test---------------------------
            var convert = statusConverter.Convert(SchedulerStatus.Disabled, null, null, null);
            //------------Assert Results-------------------------    
            Assert.IsTrue(convert != null && (bool)convert);
        }

        [TestMethod]
        [Owner("Sanele Mthembu")]
        public void ConvertBack_GivenSchedulerEnabled_Should_Return_False()
        {
            //------------Setup for test--------------------------
            var statusConverter = new InverseScheduleStatusConverter();
            //------------Execute Test---------------------------
            var convert = statusConverter.ConvertBack(SchedulerStatus.Enabled, null, null, null);
            //------------Assert Results-------------------------    
            Assert.IsFalse(convert != null && (bool)convert);
        }
        [TestMethod]
        [Owner("Sanele Mthembu")]
        public void ConvertBack_GivenSchedulerIsDisabled_Should_Return_True()
        {
            //------------Setup for test--------------------------
            var statusConverter = new InverseScheduleStatusConverter();
            //------------Execute Test---------------------------
            var convert = statusConverter.ConvertBack(SchedulerStatus.Disabled, null, null, null);
            //------------Assert Results-------------------------    
            Assert.IsTrue(convert != null && (bool)convert);
        }
    }
}
