using System;
using Project4Life.Domain.Catalog;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Project4Life.Domain.Tests;

[TestClass]
public class ItemsTests
{
    [TestMethod]
    public void Can_Create_New_Item()
    {
        // Arrange
        var item = new Item("Name", "Description", "Brand", 10.00m);

        // Act (empty)

        // Assert
        Assert.AreEqual("Name", item.Name);
        Assert.AreEqual("Description", item.Description);
        Assert.AreEqual("Brand", item.Brand);
        Assert.AreEqual(10.00m, item.Price);
    }
    [TestMethod]
    public void Can_Create_Add_Rating()
    {
        // Arrange
        var item = new Item("Name", "Description", "Brand",10.00m);
        var rating = new Rating(5,"Name","Review");

        // Act (empty)
        item.AddRating(rating);

        // Assert
        Assert.AreEqual(rating, item.Ratings[0]);

    }

}