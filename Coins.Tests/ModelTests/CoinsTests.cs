using Coins;
using System.Collections.Generic;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Coins.Tests
{
  [TestClass]
  public class ChangeMakerTests
  {
      
    [TestMethod]
    public void CalculateChange_CalculateChangeAmount_0()
    {
        int[] value = {0, 0, 0, 0};
        CollectionAssert.AreEqual(value, ChangeMaker.CalculateChange(5.00, 5.00));
    }

    
    [TestMethod]
    public void CalculateChange_CalculateChangeAmount_1penny()
    {
        int[] value = {0, 0, 0, 1};
        CollectionAssert.AreEqual(value, ChangeMaker.CalculateChange(4.99, 5.00));
    }

    [TestMethod]
    public void CalculateChange_CalculateChangeAmount_1nickle()
    {
        int[] value = { 0, 0, 1, 0 };
        CollectionAssert.AreEqual(value, ChangeMaker.CalculateChange(4.95, 5.00));
    }

    [TestMethod]
    public void CalculateChange_CalculateChangeAmount_1dime()
    {
        int[] value = { 0, 1, 0, 0 };
        CollectionAssert.AreEqual(value, ChangeMaker.CalculateChange(4.90, 5.00));
    }

    [TestMethod]
    public void CalculateChange_CalculateChangeAmount_1quarter()
    {
        int[] value = { 1, 0, 0, 0 };
        CollectionAssert.AreEqual(value, ChangeMaker.CalculateChange(4.75, 5.00));
    }
    [TestMethod]
    public void CalculateChange_CalculateChangeAmount_1ofeach()
    {
        int[] value = { 1, 1, 1, 1 };
        CollectionAssert.AreEqual(value, ChangeMaker.CalculateChange(4.59, 5.00));
    }
  }
}