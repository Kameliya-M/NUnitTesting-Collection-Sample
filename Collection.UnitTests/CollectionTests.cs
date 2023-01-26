using Collections;

namespace Collection.UnitTests
{
    public class CollectionTests
    {
       

        [Test]
        public void Test_Collection_EmptyConstructor() { 
            //Arrange and Act
            var coll = new Collection<int>();

            //Assert
            Assert.AreEqual(coll.ToString(), "[]");
        }

        [Test]
        public void Test_Collection_ConstructorSingleItem()
        {
           var coll = new Collection<int>(5);
           Assert.AreEqual(coll.ToString(), "[5]");
        }
        [Test]
        public void Test_Collection_ConstructorMultileItems()
        {
            var coll = new Collection<int>(5, 6);
            Assert.AreEqual(coll.ToString(), "[5, 6]");
        }
        [Test]
        public void Test_Collection_Count()
        {
            var coll = new Collection<int>(5, 6);
            Assert.AreEqual(coll.Count, 2);
            Assert.That(coll.Capacity, Is.GreaterThanOrEqualTo(coll.Count));
        }
        [Test]
        public void Test_Collection_Add()
        {
            var coll = new Collection<string>("Kami", "Emi");
            coll.Add("Emo");
            Assert.AreEqual(coll.ToString(), "[Kami, Emi, Emo]");
        }
    }
}

       
   