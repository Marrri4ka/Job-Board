using Microsoft.AspNetCore.Mvc;
using JobBoard.Models;
using System.Collections.Generic;
using System;

namespace JobBoard.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult IndexHome()
    {
      return View();
    }

    [HttpGet("/jobdetails/new")]
    public ActionResult NewJob()
    {
      return View();
    }

    [HttpGet("/jobdetails")]
    public ActionResult IndexJobs()
    {
      List<Job> allJobs = Job.GetAll();
      return View(allJobs);
    }

    [HttpPost ("/jobdetails")]
    public ActionResult Create (string title, string description, int phonenumber)
    {
      Job myJob = new Job(title,description,phonenumber);
      return RedirectToAction("IndexJobs");
    }
    [HttpPost("/jobdetails/delete")]
    public ActionResult DeleteAll()
    {
      Job.ClearAll();
      return View();
    }
    [HttpGet("/jobdetails/{id}")]
    public ActionResult Show(int id)
    {
      Job job = Job.Find(id);
      return View(job);
    }
  }
}
