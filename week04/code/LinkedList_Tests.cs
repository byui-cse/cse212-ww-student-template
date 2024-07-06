using Microsoft.VisualStudio.TestTools.UnitTesting;

// DO NOT MODIFY THIS FILE

[TestClass]
public class LinkedListTests
{
    [TestMethod]
    public void LinkedList_InsertTailEmpty() {
        var ll = new LinkedList();

        Assert.IsTrue(ll.HeadAndTailAreNull());
        ll.InsertTail(1);
        Assert.IsTrue(ll.HeadAndTailAreNotNull());
        Assert.AreEqual("<LinkedList>{1}", ll.ToString());
    }

    [TestMethod]
    public void LinkedList_InsertTail() {
        var ll = new LinkedList();

        ll.InsertTail(1);
        ll.InsertHead(2);
        ll.InsertHead(2);
        ll.InsertHead(2);
        ll.InsertHead(3);
        ll.InsertHead(4);
        ll.InsertHead(5);

        Assert.AreEqual("<LinkedList>{5, 4, 3, 2, 2, 2, 1}", ll.ToString());

        ll.InsertTail(0);
        ll.InsertTail(-1);

        Assert.AreEqual("<LinkedList>{5, 4, 3, 2, 2, 2, 1, 0, -1}", ll.ToString());
    }

    [TestMethod]
    public void LinkedList_RemoveTailEmpty() {
        var ll = new LinkedList();

        ll.RemoveTail();
        Assert.IsTrue(ll.HeadAndTailAreNull());
        Assert.AreEqual("<LinkedList>{}", ll.ToString());
    }

    [TestMethod]
    public void LinkedList_RemoveTailSingle() {
        var ll = new LinkedList();

        ll.InsertHead(1);
        ll.RemoveTail();
        Assert.IsTrue(ll.HeadAndTailAreNull());
        Assert.AreEqual("<LinkedList>{}", ll.ToString());
    }

    [TestMethod]
    public void LinkedList_RemoveTail() {
        var ll = new LinkedList();

        ll.InsertHead(2);
        ll.InsertHead(2);
        ll.InsertHead(2);
        ll.InsertHead(3);
        ll.InsertHead(4);
        ll.InsertHead(5);

        ll.RemoveTail();
        Assert.AreEqual("<LinkedList>{5, 4, 3, 2, 2}", ll.ToString());

        ll.RemoveTail();
        Assert.AreEqual("<LinkedList>{5, 4, 3, 2}", ll.ToString());
    }


    [TestMethod]
    public void LinkedList_RemoveNonExistant() {
        var ll = new LinkedList();

        ll.InsertHead(2);
        ll.InsertHead(2);
        ll.InsertHead(2);
        ll.InsertHead(3);
        ll.InsertHead(4);
        ll.InsertHead(5);    

        ll.InsertAfter(3, 35);
        ll.InsertAfter(5, 6);

        Assert.AreEqual("<LinkedList>{5, 6, 4, 3, 35, 2, 2, 2}", ll.ToString());
        ll.Remove(-1);
        Assert.AreEqual("<LinkedList>{5, 6, 4, 3, 35, 2, 2, 2}", ll.ToString());
    }

    [TestMethod]
    public void LinkedList_RemoveEmpty() {
        var ll = new LinkedList();
        ll.Remove(0);
        Assert.AreEqual("<LinkedList{}", ll.ToString());
        Assert.IsTrue(ll.HeadAndTailAreNull());
    }

    [TestMethod]
    public void LinkedList_RemoveSingle() {
        var ll = new LinkedList();
        ll.InsertHead(2);
        ll.Remove(2);
        Assert.AreEqual("<LinkedList{}", ll.ToString());
        Assert.IsTrue(ll.HeadAndTailAreNull());
    }

    [TestMethod]
    public void LinkedList_RemoveMultiple() {
        var ll = new LinkedList();

        ll.InsertHead(2);
        ll.InsertHead(2);
        ll.InsertHead(3);
        ll.InsertHead(4);
        ll.InsertHead(2);
        ll.InsertHead(5);    

        ll.InsertAfter(3, 35);
        ll.InsertAfter(5, 6);

        Assert.AreEqual("<LinkedList>{5, 6, 2, 4, 3, 35, 2, 2}", ll.ToString());
        ll.Remove(3);
        Assert.AreEqual("<LinkedList>{5, 6, 2, 4, 35, 2, 2}", ll.ToString());
        ll.Remove(6);
        Assert.AreEqual("<LinkedList>{5, 2, 4, 35, 2, 2}", ll.ToString());
        ll.Remove(2);
        Assert.AreEqual("<LinkedList>{5, 4, 35, 2, 2}", ll.ToString());
        ll.Remove(2);
        Assert.AreEqual("<LinkedList>{5, 4, 35, 2}", ll.ToString());
        ll.Remove(2);
        Assert.AreEqual("<LinkedList>{5, 4, 35}", ll.ToString());
    }

    [TestMethod]
    public void LinkedList_ReplaceNonExistant() {
        var ll = new LinkedList();

        ll.InsertHead(2);
        ll.InsertHead(2);
        ll.InsertHead(3);
        ll.InsertHead(4);
        ll.InsertHead(2);
        ll.InsertHead(5);    

        ll.Replace(-1, 4);
        Assert.AreEqual("<LinkedList>{5, 2, 4, 3, 2, 2}", ll.ToString());
    }

    [TestMethod]
    public void LinkedList_ReplaceEmpty() {
        var ll = new LinkedList();

        ll.Replace(-1, 4);
        Assert.AreEqual("<LinkedList>{}", ll.ToString());
    }

    [TestMethod]
    public void LinkedList_ReplaceMultiple() {
        var ll = new LinkedList();

        ll.InsertHead(2);
        ll.InsertHead(2);
        ll.InsertHead(3);
        ll.InsertHead(4);
        ll.InsertHead(2);
        ll.InsertHead(5);    

        ll.Replace(2, 4);
        Assert.AreEqual("<LinkedList>{5, 4, 4, 3, 4, 4}", ll.ToString());

        ll.Replace(3, -1);
        Assert.AreEqual("<LinkedList>{5, 4, 4, -1, 4, 4}", ll.ToString());
    }

    [TestMethod]
    public void LinkedList_ReverseEmpty() {
        var ll = new LinkedList();
        Assert.AreEqual("<LinkedList>{}", ll.Reverse().ToString());
    }

    [TestMethod]
    public void LinkedList_ReverseSingle() {
        var ll = new LinkedList();
        ll.InsertHead(5);
        Assert.AreEqual("<LinkedList>{5}", ll.Reverse().ToString());
    }

    [TestMethod]
    public void LinkedList_Reverse() {
        var ll = new LinkedList();
        ll.InsertHead(2);
        ll.InsertHead(2);
        ll.InsertHead(3);
        ll.InsertHead(4);
        ll.InsertHead(2);
        ll.InsertHead(5);   
        Assert.AreEqual("<LinkedList>{2, 2, 3, 4, 2, 5}", ll.Reverse().ToString());
    }
}