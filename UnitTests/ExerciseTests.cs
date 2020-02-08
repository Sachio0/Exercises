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
        [DataTestMethod]
        [DataRow(new[] { 1, 2, 3 }, 5)]
        [DataRow(new[] { 0, 0, 3 }, 4)]
        [DataRow(new[] { 0, 0, 0 }, 3)]
        public void ResizeTest(int[] array, int size)
        {
            int[] res = _exercise.Resize(array,size);
            for (int i = 0; i < array.Length; i++)
            {
                Assert.AreEqual(res[i], array[i]);
            }
            
            Assert.AreEqual(size,res.Length);
        }
        [DataTestMethod]
        [DataRow(new[] { 1, 2, 3 }, 3)]
        [DataRow(new[] { 0, 0, 3 }, 4)]
        [DataRow(new[] { 0, 0, 0 }, 2)]
        public void ResizeLvlUpTest(int[] array, int size)
        {
            int[] res = _exercise.ResizeLvlUp(array, size);
            for (int i = 0; i < res.Length; i++)
            {
                if( i < array.Length - 1)
                {
                    Assert.AreEqual(res[i], array[i]);
                }
                
            }

            Assert.AreEqual(size, res.Length);
        }
    
        [DataTestMethod]
        [DataRow("",'e', "","")]
        [DataRow("ale dziwne zadanie", 'e', "nie", "alenie dziwnenie zadanienie")]
        public void CezarCode(string sentence, char character, string word, string outData)
        {
            Assert.AreEqual(outData, _exercise.AddWord(sentence, character, word));
        }
        [DataTestMethod]
        [DataRow(new[] { 1, 2, 3 }, new[] { 3, 2, 1 }, new[] { 1, 2, 3, 3, 2, 1 })]
        [DataRow(new[] { 0, 0, 3 }, new[] { 3, 0, 0 }, new[] { 0, 0, 3, 3, 0, 0 })]
        [DataRow(new[] { 0, 0, 0 }, new[] { 0, 0, 0 }, new[] { 0, 0, 0, 0, 0, 0 })]
        public void JoinTest(int[] a, int[] b, int[] expect)
        {
            var res = _exercise.Join(a, b);
            CollectionAssert.AreEqual(expect, res);
        }
        [DataTestMethod]
        [DataRow(new[] { 1, 2, 3 }, new[] { 1, 2, 3 }, new[] { 1, 1, 2, 2, 3, 3 })]
        [DataRow(new[] { 1, 2 }, new[] { 1, 2, 3 }, new[] { 1, 1, 2, 2, 3 })]
        [DataRow(new[] { 1, 1, 1 }, new[] { 2, 2 }, new[] { 1, 2, 1, 2, 1 })]
        public void HarderJoinTest(int[] a, int[] b, int[] expect)
        {
            var res = _exercise.HarderJoin(a, b);
            CollectionAssert.AreEqual(expect, res);
        }
        
    }
}
