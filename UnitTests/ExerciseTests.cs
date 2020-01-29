using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToDo;

namespace UnitTests
{
    [TestClass]
    public class ExerciseTests
    {
        Exercise _exercise;
        public ExerciseTests()
        {
            _exercise = new Exercise();
        }
        [DataTestMethod]
        [DataRow(new[]{1,2,3}, new[] { 3, 2, 1 })]
        [DataRow(new[] { 0, 0, 3 }, new[] { 3, 0, 0 })]
        [DataRow(new[] { 0, 0, 0 }, new[] { 0, 0, 0 })]
        public void ReversArrayTest(int[] array, int[] revers)
        {
            CollectionAssert.AreEqual(revers, _exercise.ReversArray(array));
        }
    }
}
