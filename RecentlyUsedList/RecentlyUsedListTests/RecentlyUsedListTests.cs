using System;
using NUnit.Framework;
using RecentlyUsedListNS;

namespace RecentlyUsedListTests
{
    [TestFixture]
    public class RecentlyUsedListTests
    {
        [Test]
        public void List_is_initially_empty()
        {
            Assert.IsTrue(new RecentlyUsedList().IsEmpty());
        }
        [Test]
        public void Most_recent_is_first()
        {
            var list = new RecentlyUsedList();
            list.Add(25);
            list.Add(32);
            Assert.AreEqual(32, list.First());
        }
        [Test]
        public void Latest_recent_is_last()
        {
            var list = new RecentlyUsedList();
            list.Add(25);
            list.Add(32);
            Assert.AreEqual(25, list.Last());
        }
        
        [Test]
        public void Items_accessed_by_index()
        {
            var list = new RecentlyUsedList();
            list.Add(25);
            list.Add(32);
            list.Add(67);
            list.Add(13);
            Assert.AreEqual(13, list.Index(0));
            Assert.AreEqual(67, list.Index(1));
            Assert.AreEqual(32, list.Index(2));
            Assert.AreEqual(25, list.Index(3));
        }

        [Test]
        public void Items_are_unique()
        {
            var list = new RecentlyUsedList();
            list.Add(25);
            list.Add(67);
            list.Add(25);
            list.Add(25);
            Assert.AreEqual(25, list.Index(0));
            Assert.AreEqual(67, list.Index(1));
        }
        
        [Test]
        public void duplicate_insertions_are_moved()
        {
            var list = new RecentlyUsedList();
            list.Add(25);
            list.Add(67);
            Assert.AreEqual(67, list.Index(0));
            Assert.AreEqual(25, list.Index(1));
            list.Add(25);
            Assert.AreEqual(25, list.Index(0));
            Assert.AreEqual(67, list.Index(1));
        }
        
        [Test]
        public void Capacity_set_in_constructor_item_dropped_on_overflow()
        {
            var list = new RecentlyUsedList(3);
            list.Add(33);
            list.Add(67);
            list.Add(87);
            list.Add(55);
            list.Add(88);
            Assert.AreEqual(87, list.Index(0));
            Assert.AreEqual(67, list.Index(1));
            Assert.AreEqual(33, list.Index(2));
        }
        
        
    }
}