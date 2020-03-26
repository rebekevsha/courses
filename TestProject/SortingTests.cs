using NUnit.Framework;
using LessonFour;

namespace TestProject
{
    public class SortingTests
    {
        [Test]
        public void Given_UnsortedArray_When_InsertionSort_Then_SortedArray()
        {
            //GIVEN
            long[] numbers1 = { 10, 20, 15, -45 };
            long[] numbers2 = { -45, 10, 15, 20 };

            //When
            Program.InsertionSort(numbers1);

            //Then

            CollectionAssert.AreEqual(numbers2, numbers1, "dssdsdsdsd");
        }

        [Test]
        public void Given_UnsortedArray_When_BubbleSort_Then_SortedArray()
        {
            //GIVEN
            long[] numbers1 = { 10, 20, 15, -45 };
            long[] numbers2 = { -45, 10, 15, 20 };

            //When
            Program.BubbleSort(numbers1);

            //Then

            CollectionAssert.AreEqual(numbers2, numbers1, "dssdsdsdsd");
        }
    }
}