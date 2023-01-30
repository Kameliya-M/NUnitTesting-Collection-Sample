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
        [Test]
        public void Test_Collection_GetByIndex()
        {
            var coll = new Collection<int>(5, 6, 7);
            var item = coll[1];

            Assert.That(item.ToString(), Is.EqualTo("6"));
        }
        [Test]
        public void Test_Collection_SetByIndex()
        {
            var coll = new Collection<int>(5, 6, 7);
            coll[1] = 8;

            Assert.That(coll.ToString(), Is.EqualTo("[5, 8, 7]"));
        }
        [Test]
        public void Test_GetByInvalidIndex()
        {
            var coll = new Collection<string>("Kami", "Emi");
            Assert.That(() => { var item = coll[2]; }, Throws.InstanceOf<ArgumentOutOfRangeException>());

            
        }
        [Test]
        public void Test_Collection_AddRangeWithGrow()
        {
            var nums = new Collection<int>();
            int oldCapacity = nums.Capacity;
            var newNums = Enumerable.Range(1000, 2000).ToArray();

            nums.AddRange(newNums);

            string expectedNums = "[" + string.Join(",", newNums) + "]";

            Assert.That(nums.Capacity, Is.GreaterThanOrEqualTo(nums.Count));

        }

        [TestCase("Peter,Maria,Ivan", 0, "Peter")]
        [TestCase("Peter,Maria,Ivan", 1, "Maria")]
        [TestCase("Peter,Maria,Ivan", 2, "Ivan")]
        [TestCase("Peter", 0, "Peter")]
        public void Test_Collection_GetByValidIndex(string data, int index, string expected)
        {
            var coll = new Collection<string>(data.Split(","));
            var actual = coll[index];

            Assert.That(actual, Is.EqualTo(expected));
        }
        }
}

       
