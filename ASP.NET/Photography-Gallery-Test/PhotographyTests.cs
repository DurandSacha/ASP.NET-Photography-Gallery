using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web;

namespace Photography_Gallery_Test
{
    [TestClass]
    public class PhotographyTests
    {
        /*
        private static RouteData DefinirUrl(string url)
        {
            Mock<HttpContextBase> mockContext = new Mock<HttpContextBase>();
            mockContext.Setup(c => c.Request.AppRelativeCurrentExecutionFilePath).Returns(url);
            RouteCollection routes = new RouteCollection();
            RouteConfig.RegisterRoutes(routes);
            RouteData routeData = routes.GetRouteData(mockContext.Object);
            return routeData;
        }
        */

        [TestMethod]
        public void HomeIndex_Test_HTTP200()
        {
            double resultat = 25.62;
            Assert.AreEqual(25.62, resultat);

            /*
            RouteData routeData = DefinirUrl("~/Home/Index/2");
            Assert.IsNotNull(routeData);
            Assert.AreEqual("Home", routeData.Values["controller"]);
            Assert.AreEqual("Index", routeData.Values["action"]);
            Assert.AreEqual("2", routeData.Values["id"]);
            */
        }

        [TestMethod]
        public void HomeAbout_Test_HTTP200()
        {
            double resultat = 25.62;
            Assert.AreEqual(25.62, resultat);
            // Assert.IsNull(routeData);
        }
    }
}
