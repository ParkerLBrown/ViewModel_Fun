using System;
using Microsoft.AspNetCore.Mvc;
using ViewModel_Fun.Models;
using System.Collections.Generic;

namespace ViewModel_Fun
{
  public class HomeController : Controller
  {
    [HttpGet("")]
    public ViewResult Message()
    {
      Message someMessage = new Message()
      {
        MyMessage = "Hello, this is my message, I really have nothing more to say except that this is a message. Thank you for reading my message. Enjoy your day."
      };
      return View(someMessage);
    }

    [HttpGet("numbers")]
    public ViewResult Numbers()
    {
      Numbers number1 = new Numbers()
      {
        Number = 2
      };
      Numbers number2 = new Numbers()
      {
        Number = 3
      };
      Numbers number3 = new Numbers()
      {
        Number = 106
      };
      Numbers number4 = new Numbers()
      {
        Number = 55
      };
      Numbers number5 = new Numbers()
      {
        Number = 7
      };
      List<Numbers> viewModel = new List<Numbers>()
      {
        number1, number2, number3, number4, number5
      };
      return View(viewModel);
    }

    [HttpGet("users")]
    public ViewResult Users()
    {
      User Tim = new User()
      {
        FirstName = "Timmy",
        LastName = "TimTim"
      };

      User John = new User()
      {
        FirstName = "John",
        LastName = "Johnson"
      };

      User Jake = new User()
      {
        FirstName = "Jacob",
        LastName = "Jacobson"
      };

      User Sarah = new User()
      {
        FirstName = "Sarah",
        LastName = "Marshall"
      };

      List<User> viewModel = new List<User>()
      {
        Tim, John, Jake, Sarah
      };

      return View(viewModel);
    }

    [HttpGet("user")]
    public ViewResult OneUser()
    {
      User Tim = new User()
      {
        FirstName = "Timmy",
        LastName = "TimTim"
      };
      return View("User", Tim);
    }
  }
}