using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using HairSalon.Controllers;
using HairSalon.Models;

namespace HairSalon.Tests
{
  [TestClass]
  public class StylistControllerTest
  {
    [TestMethod]
    public void Index_ReturnsCorrectView_True()
    {
      StylistController controller = new StylistController();
      ActionResult indexView = controller.Index();
      Assert.IsInstanceOfType(indexView, typeof(ViewResult));
    }
    // Could not get to fail. 
    // [TestMethod]
    // public void Index_HasCorrectModelType_StylistList()
    // {
    //   ViewResult indexView = new HomeController().Index() as ViewResult;
    //   var result = indexView.ViewData.Model;
    //   Assert.IsInstanceOfType(result, typeof());
    // }
    [TestMethod]
    public void New_ReturnsCorrectView_True()
    {
      StylistController controller = new StylistController();
      ActionResult newView = controller.New();
      Assert.IsInstanceOfType(newView, typeof(ViewResult));
    }

  }
}
