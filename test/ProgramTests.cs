using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleApp2.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void IsSudokuPuzzleSolvedTest_should_return_true_1()
        {
            Assert.IsTrue(Program.IsSudokuPuzzleSolved(new[] { new[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[] { 7, 8, 9 } }));
        }

        [TestMethod()]
        public void IsSudokuPuzzleSolvedTest_should_return_true_2()
        {
            Assert.IsTrue(Program.IsSudokuPuzzleSolved(new[] { new[] { 1, 2, 3 }, new int[] { 2, 3, 1 }, new int[] { 3, 1, 2 } }));
        }

        [TestMethod()]
        public void IsSudokuPuzzleSolvedTest_should_return_false_1()
        {
            Assert.IsFalse(Program.IsSudokuPuzzleSolved(new[] { new[] { 1, 2, 3 }, new int[] { 1, 5, 6 }, new int[] { 7, 8, 9 } }));
        }

        [TestMethod()]
        public void IsSudokuPuzzleSolvedTest_should_return_false_2()
        {
            Assert.IsFalse(Program.IsSudokuPuzzleSolved(new[] { new[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[] { 7, 8, 8 } }));
        }
    }
}