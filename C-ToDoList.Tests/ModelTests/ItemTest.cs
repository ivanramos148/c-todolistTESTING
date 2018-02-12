using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using ToDoList;
using ToDoList.Models;


namespace ToDoList.Tests
{
  [TestClass]
  public class ItemTest : IDisposable
  {
    [TestMethod]
    public void Dispose()
    {
      Item.ClearAll();
    }

    public void GetDescription_ReturnsDescription_String()
    {
      string description = "groceries";
      Item newItem = new Item(description);

      string result = newItem.GetDescription();

      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void GetAll_ReturnsItems_ItemList()
    {
      string description01 = "groceries";
      string description02 = "walk the dog";
      Item newItem1 = new Item(description01);
      Item newItem2 = new Item(description02);
      List<Item> newList = new List<Item> { newItem1, newItem2 };

      List<Item> result = Item.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }
  }
}
