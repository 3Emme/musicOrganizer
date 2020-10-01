using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using MusicOrganizer.Models;

namespace MusicOrganizer.Tests
{
  [TestClass]
  public class RecordTests : IDisposable
  {
    public void Dispose()

    {
      Record.ClearAll();
    }

    [TestMethod]
    public void RecordConstructor_CreatesInstanceOfRecord_Record()
    {
      Record newRecord = new Record("test");
      Assert.AreEqual(typeof(Record), newRecord.GetType());
    }
    [TestMethod]
    public void GetTitle_ReturnsTitile_String()
    { //arange
      string title = "The Earth is Not a Cold Dead Place";
      Record newRecord = new Record(title);
      //Act
      string result = newRecord.Title;
      //Assert
      Assert.AreEqual(title, result);
    }
    [TestMethod]
    public void SetTitle_SetTitle_String()
    {
      //Arrange
      string title = "Walk the dog.";
      Record newRecord = new Record(title);

      //Act
      string updatedTitle = "Do the dishes";
      newRecord.Title = updatedTitle;
      string result = newRecord.Title;

      //Assert
      Assert.AreEqual(updatedTitle, result);
    }
    [TestMethod]
    public void GetAll_ReturnsEmptyList_RecordList()
    {
      // Arrange
      List<Record> newList = new List<Record> { };

      // Act
      List<Record> result = Record.GetAll();
      // foreach (Record thisRecord in result)
      // {
      //   Console.WriteLine("Output from empty list GetAll test: " + thisItem.Description);  
      // }

      // Assert
      CollectionAssert.AreEqual(newList, result);
    }

  }
}