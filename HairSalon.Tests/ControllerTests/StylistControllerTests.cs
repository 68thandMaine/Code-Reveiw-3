using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using HairSalon.Controllers;
using HairSalon.Models;

namespace HairSalon.Tests
{
  [TestClass]
  public class StylistsControllerTests
  {
    [TestMethod]
    public void Index_ReturnsCorrectView_True()
    {
      StylistsController controller = new StylistsController();
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
      StylistsController controller = new StylistsController();
      ActionResult newView = controller.New();
      Assert.IsInstanceOfType(newView, typeof(ViewResult));
    }
    [TestMethod]
    public void Show_ReturnsCorrectView_True()
    {
      StylistsController controller = new StylistsController();
      ActionResult newView = controller.Show(1);
      Assert.IsInstanceOfType(newView, typeof(ViewResult));
    }
    [TestMethod]
    public void Show_HasCorrectModelType_Dictionary()
    {
      ViewResult showView = new StylistsController().Show(1) as ViewResult;

      var result = showView.ViewData.Model;

      Assert.IsInstanceOfType(result, typeof(Dictionary<string, object>));
    }
  }
}
