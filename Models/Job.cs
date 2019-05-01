using System.Collections.Generic;
using System;

namespace JobBoard.Models
{
  public class Job // class
  {
    private string _title;
    private string _description;
    private int _phonenumber;
    private int _id;
    private static List<Job> jobs = new List<Job>(); //list

    public Job (string title, string description, int phonenumber ) // constructor
    {
      _title = title;
      _description = description;
      _phonenumber = phonenumber;
      jobs.Add(this); //what is this
      _id = jobs.Count;
    }


    public string GetTitle()
    {
      return _title;
    }
    public void SetTitle(string newTitle)
    {
      _title = newTitle;
    }

    public string GetDescription()
    {
      return _description;
    }

    public void SetDescription(string newDescription)
    {
      _description = newDescription;
    }

    public int GetPhoneNumber()
    {
      return _phonenumber;
    }

    public void SetPhoneNumber(int newPhoneNumber)
    {
      _phonenumber = newPhoneNumber;
    }
    public static List<Job> GetAll()
    {
      return jobs;
    }

    public static void ClearAll()
    {
      jobs.Clear();
    }
    public int GetId()
    {
      return _id;
    }

    public static Job Find (int searchId)
    {

      return jobs[searchId - 1];
    }
  }
}
