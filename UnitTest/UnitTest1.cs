using System;
using WebPipeline;
using WebPipeline.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Index()
        {
            pipeController pipeController = new pipeController();
            ActionResult test = pipeController.Index(); 
        }
    }
}
