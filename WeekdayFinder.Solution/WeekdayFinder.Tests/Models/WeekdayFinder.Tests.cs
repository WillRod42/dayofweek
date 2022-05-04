using Microsoft.VisualStudio.TestTools.UnitTesting;
using WeekdayFinder.Models;
using System;
using System.Collections.Generic;

namespace WeekdayFinder.Tests
{
  [TestClass]
  public class WeekdayFinderTests
  {
    [TestMethod]
    public void Find_ReturnsInvalidWhenDateIsInvalid_InvalidMessage()
    {
      Assert.AreEqual("Invalid date", DateFinder.Find(100, 100, -100));
    }

    [TestMethod]
    public void Find_ReturnsDayOfWeek_Tuesday()
    {
      Assert.AreEqual("Tuesday", DateFinder.Find(5, 3, 2022));
    }

    [TestMethod]
    public void CheckDateIsValid_ReturnsBoolIfInvalidDate_False()
    {
      Assert.AreEqual(false, DateFinder.CheckDateIsValid(100, 100, -100));
    }

    [TestMethod]
    public void CheckDateIsValid_ReturnsBoolIfInvalidDate_True()
    {
      Assert.AreEqual(true, DateFinder.CheckDateIsValid(1, 1, 1));
    }

    [TestMethod]
    public void DayOfWeek_ReturnsDayOfWeek_Tuesday()
    {
      Assert.AreEqual("Tuesday", DateFinder.DayOfWeek(5, 3, 2022));
    }


    // [TestMethod]
    // public void FindWithoutDateTime_ReturnsDayOfWeek_Tuesday()
    // {
    //   Assert.AreEqual("Tuesday", DateFinder.Find(5, 3, 2022));
    // }

    // [TestMethod]
    // public void FindWithoutDateTime_ReturnsDayOfWeek_Monday()
    // {
    //   Assert.AreEqual("Monday", DateFinder.FindWithoutDateTime(1, 1, 1798));
    // }

    // [TestMethod]
    // public void FindWithoutDateTime_ReturnsDayOfWeek_Wednesday()
    // {
    //   Assert.AreEqual("Wednesday", DateFinder.FindWithoutDateTime(3, 12, 1321));
    // }
  }
}