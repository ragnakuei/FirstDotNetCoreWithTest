using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pets;

[TestClass]
public class PetTests
{
    [TestMethod]
    public void DogTalkToOwnerTest()
    {
        string expected = "Woof!";
        string actual = new Dog().TalkToOwner();

        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void CatTalkToOwnerTest()
    {
        string expected = "Meow!";
        string actual = new Cat().TalkToOwner();

        Assert.AreEqual(expected, actual);
    }
}