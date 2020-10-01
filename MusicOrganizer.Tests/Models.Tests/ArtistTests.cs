using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using MusicOrganizer.Models;

namespace MusicOrganizer.Models
{
  [TestClass]
  public class ArtistTest : IDisposable
  {
    public void Dispose()
    {
      Artist.ClearAll();
    }
  
    [TestMethod]
    public void ArtistConstructor_CreatesInstanceOfArtist_Artist()
    {
      Artist newArtist = new Artist("test artist");
      Assert.AreEqual(typeof(Artist), newArtist.GetType());
    }
    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      //Arrange
      string name = "Test Artist";
      Artist newArtist = new Artist(name);

      //Act
      string result = newArtist.Name;

      //Assert
      Assert.AreEqual(name, result);
    }
    [TestMethod]
    public void GetId_ReturnsArtistId_Int()
    {
      //Arrange
      string name = "Test Artist";
      Artist newArtist = new Artist(name);

      //Act
      int result = newArtist.Id;

      //Assert
      Assert.AreEqual(1, result);
    }
    [TestMethod]
    public void GetAll_ReturnsAllArtistObjects_ArtistList()
    {
      //Arrange
      string name01 = "Elvis";
      string name02 = "The Beatles";
      Artist newArtist1 = new Artist(name01);
      Artist newArtist2 = new Artist(name02);
      List<Artist> newList = new List<Artist> { newArtist1, newArtist2 };

      //Act
      List<Artist> result = Artist.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void Find_ReturnsCorrectArtist_Artist()
    {
      //Arrange
      string name01 = "Beck";
      string name02 = "Meute";
      Artist newArtist1 = new Artist(name01);
      Artist newArtist2 = new Artist(name02);

      //Act
      Artist result = Artist.Find(2);

      //Assert
      Assert.AreEqual(newArtist2, result);
    }
    [TestMethod]
    public void AddRecord_AssociatesRecordWithArtist_RecordList()
    {
      //Arrange
      string title = "Nite Creatures";
      Record newRecord = new Record(title);
      List<Record> newList = new List<Record> { newRecord };
      string name = "Joe Wong";
      Artist newArtist = new Artist(name);
      newArtist.AddRecord(newRecord);

      //Act
      List<Record> result = newArtist.Records;

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }
  }
}