using System;
using System.Collections.Generic;
using NUnit.Framework;
using ListOperations.check;
namespace ListOperations.check.Tests
{
    [TestFixture]
    public class ListManagerCheck
    {
        
        private ListManager manager;
        private List<int> list;
        [SetUp]
        public void SetUp()
        {
            manager = new ListManager();
            list = new List<int>();
        }
        [Test]
        public void Add_ToList()
        {
            manager.AddElement(list,10);
            Assert.AreEqual(1,list.Count);
            Assert.Contains(10,list);
        }
        [Test]
        public void Remove_Elemnet_From_List()
        {
            list.Add(10);
            list.Add(11);
            manager.RemoveElement(list,10);
            Assert.AreEqual(1,list.Count);
            Assert.IsFalse(list.Contains(10));
        }
        [Test]
        public void ListSizeCalculation()
        {
            list.Add(10);
            list.Add(20);
            list.Add(700);
            Assert.AreEqual(3,manager.GetSize(list));
        }
    }
}