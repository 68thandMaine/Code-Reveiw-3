using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;
using System;
using System.Collections.Generic;

namespace HairSalon.Controllers
{
  public class ClientController : Controller
  {
    [HttpGet("/clients")]
    public ActionResult Index()
    {
      List<Clients> allStylists = Stylist.GetAll();
      return View(allStylists);
    }
    [HttpGet("/clients/new")]
    public ActionResult New()
    {
      return View();
    }
    [HttpPost("/clients")]
    public ActionResult Create(string stylistName)
    {
      Stylist newStylist = new Stylist (stylistName);
      newStylist.Save();
      List<Stylist> allStylists = Stylist.GetAll();
      return RedirectToAction("Index");
      // return View("Index", allStylists);
    }
    [HttpGet("/clients/{id}")]
    public ActionResult Show(int id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Stylist selectedStylist = Stylist.Find(id);
      List<Client> stylistClients = selectedStylist.GetClients();
      model.Add("stylist", selectedStylist);
      model.Add("clients", stylistClients);
      return View(model);
    }
  }
}
