using NUnit.Framework;
using Raven.Client.Document;
using isct.arduinoscada.common.entities;
using isct.arduinoscada.services.config;

namespace isct.arduinoscada.tests.services {
  [TestFixture]
  public class ConfigurationServiceTests {
    [Test]
    public void TestUserOperations() {
      //var docStore = new DocumentStore {Url = "http://localhost:8081"};
      //docStore.Initialize();
      //var docSession = docStore.OpenSession("arduinosacada.config");
      //var cfgService = new ConfigurationService(docSession);
      ////var nDeviceId = cfgService.CreateDevice(new ArduinoDevice {Name="Device1", BaseUrl = "URL", Description = "DESC", LastTimeOnline = DateTime.Now});
      ////Assert.Greater(nDeviceId,0);
      ////var oldItem = cfgService.GetDevice(nDeviceId);
      ////Assert.NotNull(oldItem);
      ////Assert.AreEqual(oldItem.Id,nDeviceId);
      ////oldItem.BaseUrl = "http://10.1.0.1/ServicioARDUINO";
      ////cfgService.EditDevice(oldItem);
      ////var oldOldItem= cfgService.GetDevice(nDeviceId);
      ////Assert.NotNull(oldOldItem);
      ////Assert.AreEqual(oldOldItem.Id,nDeviceId);
      ////Assert.AreEqual(oldOldItem.BaseUrl, "http://10.1.0.1/ServicioARDUINO");

      //var demoItem = new ArdDevice {Id = 33, Name = "XXXX", BaseUrl = "XXXX", Description = "XXXX", LastTimeOnline = null};
      //cfgService.EditDevice(demoItem);
    }
  }
}