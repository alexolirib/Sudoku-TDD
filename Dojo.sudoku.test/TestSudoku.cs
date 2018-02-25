using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dojo.sudoku;

namespace Dojo.sudoku.test
{
    [TestClass]
    public class TestSudoku
    {
        [TestMethod]
        public void TestVerificaArrayTrue()
        {
            Sudoku test = new Sudoku();
            int[] vSudoku = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var result = test.verificaVetor(vSudoku);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestVerificaArrayFalse()
        {
            Sudoku test = new Sudoku();
            int[] vSudoku = { 1, 2, 3, 4, 5, 6, 1, 8, 9 };
            var result = test.verificaVetor(vSudoku);
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void TestTransformaQuandranteEmVetorTrue()
        {
            Sudoku test = new Sudoku();
            int[,] mSudoku = new int[3, 3];
            mSudoku[0, 1] = 1; mSudoku[0, 0] = 6;
            mSudoku[0, 2] = 2; mSudoku[2, 1] = 7;
            mSudoku[1, 0] = 3; mSudoku[2, 0] = 8;
            mSudoku[1, 1] = 4; mSudoku[2, 2] = 9;
            mSudoku[1, 2] = 5;
            var result = test.QuadranteTransoformaVetor(mSudoku);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestTransformaQuandranteEmVetorTrue2()
        {
            Sudoku test = new Sudoku();
            int[,] mSudoku = new int[3, 3];
            mSudoku[0, 1] = 132; mSudoku[0, 0] = 6;
            mSudoku[0, 2] = 2; mSudoku[2, 1] = 1;
            mSudoku[1, 0] = 123; mSudoku[2, 0] = 7;
            mSudoku[1, 1] = 22; mSudoku[2, 2] = 10;
            mSudoku[1, 2] = 15;
            var result = test.QuadranteTransoformaVetor(mSudoku);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestTransformaQuandranteEmVetorFalse()
        {
            Sudoku test = new Sudoku();
            int[,] mSudoku = new int[3, 3];
            mSudoku[0, 1] = 1; mSudoku[0, 0] = 6;
            mSudoku[0, 2] = 2; mSudoku[2, 1] = 2;
            mSudoku[1, 0] = 3; mSudoku[2, 0] = 8;
            mSudoku[1, 1] = 4; mSudoku[2, 2] = 9;
            mSudoku[1, 2] = 5;
            var result = test.QuadranteTransoformaVetor(mSudoku);
            Assert.AreEqual(false, result);
        }


        [TestMethod]
        public void TestTransformaQuandranteEmVetorFalse2()
        {
            Sudoku test = new Sudoku();
            int[,] mSudoku = new int[3, 3];
            mSudoku[0, 1] = 10; mSudoku[0, 0] = 6;
            mSudoku[0, 2] = 24; mSudoku[2, 1] = 2;
            mSudoku[1, 0] = 32; mSudoku[2, 0] = 1;
            mSudoku[1, 1] = 41; mSudoku[2, 2] = 9;
            mSudoku[1, 2] = 1;
            var result = test.QuadranteTransoformaVetor(mSudoku);
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void TestVerificaCadaQuadranteTrue()
        {
            Sudoku test = new Sudoku();
            int[,] mSudoku = new int[9, 9];

            mSudoku[0, 0] = 5; mSudoku[0, 1] = 3; mSudoku[0, 2] = 4; mSudoku[0, 3] = 6; mSudoku[0, 4] = 7; mSudoku[0, 5] = 8; mSudoku[0, 6] = 9; mSudoku[0, 7] = 1; mSudoku[0, 8] = 2;
            mSudoku[1, 0] = 6; mSudoku[1, 1] = 7; mSudoku[1, 2] = 2; mSudoku[1, 3] = 1; mSudoku[1, 4] = 9; mSudoku[1, 5] = 5; mSudoku[1, 6] = 3; mSudoku[1, 7] = 4; mSudoku[1, 8] = 8;
            mSudoku[2, 0] = 1; mSudoku[2, 1] = 9; mSudoku[2, 2] = 8; mSudoku[2, 3] = 3; mSudoku[2, 4] = 4; mSudoku[2, 5] = 2; mSudoku[2, 6] = 5; mSudoku[2, 7] = 6; mSudoku[2, 8] = 7;
            mSudoku[3, 0] = 8; mSudoku[3, 1] = 5; mSudoku[3, 2] = 9; mSudoku[3, 3] = 7; mSudoku[3, 4] = 6; mSudoku[3, 5] = 1; mSudoku[3, 6] = 4; mSudoku[3, 7] = 2; mSudoku[3, 8] = 3;
            mSudoku[4, 0] = 4; mSudoku[4, 1] = 2; mSudoku[4, 2] = 6; mSudoku[4, 3] = 8; mSudoku[4, 4] = 5; mSudoku[4, 5] = 3; mSudoku[4, 6] = 7; mSudoku[4, 7] = 9; mSudoku[4, 8] = 1;
            mSudoku[5, 0] = 7; mSudoku[5, 1] = 1; mSudoku[5, 2] = 3; mSudoku[5, 3] = 9; mSudoku[5, 4] = 2; mSudoku[5, 5] = 4; mSudoku[5, 6] = 8; mSudoku[5, 7] = 5; mSudoku[5, 8] = 6;
            mSudoku[6, 0] = 9; mSudoku[6, 1] = 6; mSudoku[6, 2] = 1; mSudoku[6, 3] = 5; mSudoku[6, 4] = 3; mSudoku[6, 5] = 7; mSudoku[6, 6] = 2; mSudoku[6, 7] = 8; mSudoku[6, 8] = 4;
            mSudoku[7, 0] = 2; mSudoku[7, 1] = 8; mSudoku[7, 2] = 7; mSudoku[7, 3] = 4; mSudoku[7, 4] = 1; mSudoku[7, 5] = 9; mSudoku[7, 6] = 6; mSudoku[7, 7] = 3; mSudoku[7, 8] = 5;
            mSudoku[8, 0] = 3; mSudoku[8, 1] = 4; mSudoku[8, 2] = 5; mSudoku[8, 3] = 2; mSudoku[8, 4] = 8; mSudoku[8, 5] = 6; mSudoku[8, 6] = 1; mSudoku[8, 7] = 7; mSudoku[8, 8] = 9;

            var result = test.verificaArrayComVetorDeNovePosicao(mSudoku);
            Assert.AreEqual(true, result);

        }

        [TestMethod]
        public void TestVerificaCadaQuadranteTrue2()
        {
            Sudoku test = new Sudoku();
            int[,] mSudoku = new int[9, 9];

            mSudoku[0, 0] = 1; mSudoku[0, 1] = 4; mSudoku[0, 2] = 7; mSudoku[0, 3] = 1; mSudoku[0, 4] = 4; mSudoku[0, 5] = 7; mSudoku[0, 6] = 1; mSudoku[0, 7] = 4; mSudoku[0, 8] = 7;
            mSudoku[1, 0] = 2; mSudoku[1, 1] = 5; mSudoku[1, 2] = 8; mSudoku[1, 3] = 2; mSudoku[1, 4] = 5; mSudoku[1, 5] = 8; mSudoku[1, 6] = 2; mSudoku[1, 7] = 5; mSudoku[1, 8] = 8;
            mSudoku[2, 0] = 3; mSudoku[2, 1] = 6; mSudoku[2, 2] = 9; mSudoku[2, 3] = 3; mSudoku[2, 4] = 6; mSudoku[2, 5] = 9; mSudoku[2, 6] = 3; mSudoku[2, 7] = 6; mSudoku[2, 8] = 9;
            mSudoku[3, 0] = 1; mSudoku[3, 1] = 4; mSudoku[3, 2] = 7; mSudoku[3, 3] = 1; mSudoku[3, 4] = 4; mSudoku[3, 5] = 7; mSudoku[3, 6] = 1; mSudoku[3, 7] = 4; mSudoku[3, 8] = 7;
            mSudoku[4, 0] = 2; mSudoku[4, 1] = 5; mSudoku[4, 2] = 8; mSudoku[4, 3] = 2; mSudoku[4, 4] = 5; mSudoku[4, 5] = 8; mSudoku[4, 6] = 2; mSudoku[4, 7] = 5; mSudoku[4, 8] = 8;
            mSudoku[5, 0] = 3; mSudoku[5, 1] = 6; mSudoku[5, 2] = 9; mSudoku[5, 3] = 3; mSudoku[5, 4] = 6; mSudoku[5, 5] = 9; mSudoku[5, 6] = 3; mSudoku[5, 7] = 6; mSudoku[5, 8] = 9;
            mSudoku[6, 0] = 1; mSudoku[6, 1] = 4; mSudoku[6, 2] = 7; mSudoku[6, 3] = 1; mSudoku[6, 4] = 4; mSudoku[6, 5] = 7; mSudoku[6, 6] = 1; mSudoku[6, 7] = 4; mSudoku[6, 8] = 7;
            mSudoku[7, 0] = 2; mSudoku[7, 1] = 5; mSudoku[7, 2] = 8; mSudoku[7, 3] = 2; mSudoku[7, 4] = 5; mSudoku[7, 5] = 8; mSudoku[7, 6] = 2; mSudoku[7, 7] = 5; mSudoku[7, 8] = 8;
            mSudoku[8, 0] = 3; mSudoku[8, 1] = 6; mSudoku[8, 2] = 9; mSudoku[8, 3] = 3; mSudoku[8, 4] = 6; mSudoku[8, 5] = 9; mSudoku[8, 6] = 3; mSudoku[8, 7] = 6; mSudoku[8, 8] = 9;

            var result = test.verificaArrayComVetorDeNovePosicao(mSudoku);
            Assert.AreEqual(true, result);

        }

        [TestMethod]
        public void TestVerificaCadaQuadranteTrue3()
        {
            Sudoku test = new Sudoku();
            int[,] mSudoku = new int[9, 9];

            mSudoku[0, 0] = 8; mSudoku[0, 1] = 7; mSudoku[0, 2] = 1; mSudoku[0, 3] = 4; mSudoku[0, 4] = 5; mSudoku[0, 5] = 3; mSudoku[0, 6] = 9; mSudoku[0, 7] = 2; mSudoku[0, 8] = 6;
            mSudoku[1, 0] = 9; mSudoku[1, 1] = 5; mSudoku[1, 2] = 3; mSudoku[1, 3] = 7; mSudoku[1, 4] = 2; mSudoku[1, 5] = 6; mSudoku[1, 6] = 4; mSudoku[1, 7] = 8; mSudoku[1, 8] = 1;
            mSudoku[2, 0] = 2; mSudoku[2, 1] = 4; mSudoku[2, 2] = 6; mSudoku[2, 3] = 8; mSudoku[2, 4] = 9; mSudoku[2, 5] = 1; mSudoku[2, 6] = 5; mSudoku[2, 7] = 3; mSudoku[2, 8] = 7;
            mSudoku[3, 0] = 7; mSudoku[3, 1] = 6; mSudoku[3, 2] = 5; mSudoku[3, 3] = 3; mSudoku[3, 4] = 8; mSudoku[3, 5] = 9; mSudoku[3, 6] = 1; mSudoku[3, 7] = 4; mSudoku[3, 8] = 2;
            mSudoku[4, 0] = 1; mSudoku[4, 1] = 3; mSudoku[4, 2] = 2; mSudoku[4, 3] = 5; mSudoku[4, 4] = 4; mSudoku[4, 5] = 7; mSudoku[4, 6] = 8; mSudoku[4, 7] = 6; mSudoku[4, 8] = 9;
            mSudoku[5, 0] = 4; mSudoku[5, 1] = 9; mSudoku[5, 2] = 8; mSudoku[5, 3] = 1; mSudoku[5, 4] = 6; mSudoku[5, 5] = 2; mSudoku[5, 6] = 7; mSudoku[5, 7] = 5; mSudoku[5, 8] = 3;
            mSudoku[6, 0] = 6; mSudoku[6, 1] = 8; mSudoku[6, 2] = 7; mSudoku[6, 3] = 9; mSudoku[6, 4] = 3; mSudoku[6, 5] = 5; mSudoku[6, 6] = 2; mSudoku[6, 7] = 1; mSudoku[6, 8] = 4;
            mSudoku[7, 0] = 5; mSudoku[7, 1] = 2; mSudoku[7, 2] = 9; mSudoku[7, 3] = 6; mSudoku[7, 4] = 1; mSudoku[7, 5] = 4; mSudoku[7, 6] = 3; mSudoku[7, 7] = 7; mSudoku[7, 8] = 8;
            mSudoku[8, 0] = 3; mSudoku[8, 1] = 1; mSudoku[8, 2] = 4; mSudoku[8, 3] = 2; mSudoku[8, 4] = 7; mSudoku[8, 5] = 8; mSudoku[8, 6] = 6; mSudoku[8, 7] = 9; mSudoku[8, 8] = 5;

            var result = test.verificaArrayComVetorDeNovePosicao(mSudoku);
            Assert.AreEqual(true, result);

        }

        [TestMethod]
        public void TestVerificaCadaQuadranteFalse()
        {
            Sudoku test = new Sudoku();
            int[,] mSudoku = new int[9, 9];

            mSudoku[0, 0] = 8; mSudoku[0, 1] = 7; mSudoku[0, 2] = 1; mSudoku[0, 3] = 4; mSudoku[0, 4] = 5; mSudoku[0, 5] = 3; mSudoku[0, 6] = 9; mSudoku[0, 7] = 2; mSudoku[0, 8] = 6;
            mSudoku[1, 0] = 9; mSudoku[1, 1] = 5; mSudoku[1, 2] = 3; mSudoku[1, 3] = 7; mSudoku[1, 4] = 2; mSudoku[1, 5] = 6; mSudoku[1, 6] = 4; mSudoku[1, 7] = 8; mSudoku[1, 8] = 1;
            mSudoku[2, 0] = 6; mSudoku[2, 1] = 4; mSudoku[2, 2] = 6; mSudoku[2, 3] = 8; mSudoku[2, 4] = 9; mSudoku[2, 5] = 1; mSudoku[2, 6] = 5; mSudoku[2, 7] = 3; mSudoku[2, 8] = 7;
            mSudoku[3, 0] = 7; mSudoku[3, 1] = 6; mSudoku[3, 2] = 5; mSudoku[3, 3] = 3; mSudoku[3, 4] = 8; mSudoku[3, 5] = 9; mSudoku[3, 6] = 1; mSudoku[3, 7] = 4; mSudoku[3, 8] = 2;
            mSudoku[4, 0] = 1; mSudoku[4, 1] = 3; mSudoku[4, 2] = 2; mSudoku[4, 3] = 5; mSudoku[4, 4] = 4; mSudoku[4, 5] = 7; mSudoku[4, 6] = 8; mSudoku[4, 7] = 6; mSudoku[4, 8] = 9;
            mSudoku[5, 0] = 4; mSudoku[5, 1] = 9; mSudoku[5, 2] = 8; mSudoku[5, 3] = 1; mSudoku[5, 4] = 6; mSudoku[5, 5] = 2; mSudoku[5, 6] = 7; mSudoku[5, 7] = 5; mSudoku[5, 8] = 3;
            mSudoku[6, 0] = 6; mSudoku[6, 1] = 8; mSudoku[6, 2] = 7; mSudoku[6, 3] = 9; mSudoku[6, 4] = 3; mSudoku[6, 5] = 5; mSudoku[6, 6] = 2; mSudoku[6, 7] = 1; mSudoku[6, 8] = 4;
            mSudoku[7, 0] = 5; mSudoku[7, 1] = 2; mSudoku[7, 2] = 9; mSudoku[7, 3] = 6; mSudoku[7, 4] = 1; mSudoku[7, 5] = 4; mSudoku[7, 6] = 3; mSudoku[7, 7] = 7; mSudoku[7, 8] = 8;
            mSudoku[8, 0] = 3; mSudoku[8, 1] = 1; mSudoku[8, 2] = 4; mSudoku[8, 3] = 2; mSudoku[8, 4] = 7; mSudoku[8, 5] = 8; mSudoku[8, 6] = 6; mSudoku[8, 7] = 9; mSudoku[8, 8] = 5;

            var result = test.verificaArrayComVetorDeNovePosicao(mSudoku);
            Assert.AreEqual(false, result);

        }

        [TestMethod]
        public void TestVerificaCadaQuadranteFalse2()
        {
            Sudoku test = new Sudoku();
            int[,] mSudoku = new int[9, 9];

            mSudoku[0, 0] = 1; mSudoku[0, 1] = 4; mSudoku[0, 2] = 7; mSudoku[0, 3] = 1; mSudoku[0, 4] = 4; mSudoku[0, 5] = 7; mSudoku[0, 6] = 1; mSudoku[0, 7] = 4; mSudoku[0, 8] = 7;
            mSudoku[1, 0] = 2; mSudoku[1, 1] = 5; mSudoku[1, 2] = 8; mSudoku[1, 3] = 2; mSudoku[1, 4] = 5; mSudoku[1, 5] = 8; mSudoku[1, 6] = 2; mSudoku[1, 7] = 5; mSudoku[1, 8] = 8;
            mSudoku[2, 0] = 3; mSudoku[2, 1] = 6; mSudoku[2, 2] = 9; mSudoku[2, 3] = 3; mSudoku[2, 4] = 6; mSudoku[2, 5] = 9; mSudoku[2, 6] = 3; mSudoku[2, 7] = 6; mSudoku[2, 8] = 9;
            mSudoku[3, 0] = 1; mSudoku[3, 1] = 4; mSudoku[3, 2] = 7; mSudoku[3, 3] = 1; mSudoku[3, 4] = 4; mSudoku[3, 5] = 7; mSudoku[3, 6] = 1; mSudoku[3, 7] = 4; mSudoku[3, 8] = 7;
            mSudoku[4, 0] = 2; mSudoku[4, 1] = 5; mSudoku[4, 2] = 8; mSudoku[4, 3] = 2; mSudoku[4, 4] = 5; mSudoku[4, 5] = 1; mSudoku[4, 6] = 2; mSudoku[4, 7] = 5; mSudoku[4, 8] = 8;
            mSudoku[5, 0] = 3; mSudoku[5, 1] = 6; mSudoku[5, 2] = 9; mSudoku[5, 3] = 3; mSudoku[5, 4] = 6; mSudoku[5, 5] = 9; mSudoku[5, 6] = 3; mSudoku[5, 7] = 6; mSudoku[5, 8] = 9;
            mSudoku[6, 0] = 1; mSudoku[6, 1] = 4; mSudoku[6, 2] = 7; mSudoku[6, 3] = 1; mSudoku[6, 4] = 4; mSudoku[6, 5] = 7; mSudoku[6, 6] = 1; mSudoku[6, 7] = 4; mSudoku[6, 8] = 7;
            mSudoku[7, 0] = 2; mSudoku[7, 1] = 5; mSudoku[7, 2] = 8; mSudoku[7, 3] = 2; mSudoku[7, 4] = 5; mSudoku[7, 5] = 8; mSudoku[7, 6] = 2; mSudoku[7, 7] = 5; mSudoku[7, 8] = 8;
            mSudoku[8, 0] = 3; mSudoku[8, 1] = 6; mSudoku[8, 2] = 9; mSudoku[8, 3] = 3; mSudoku[8, 4] = 6; mSudoku[8, 5] = 9; mSudoku[8, 6] = 3; mSudoku[8, 7] = 6; mSudoku[8, 8] = 9;

            var result = test.verificaArrayComVetorDeNovePosicao(mSudoku);
            Assert.AreEqual(false, result);

        }

        [TestMethod]
        public void TestVerificaCadaQuadranteFalse3()
        {
            Sudoku test = new Sudoku();
            int[,] mSudoku = new int[9, 9];

            mSudoku[0, 0] = 5; mSudoku[0, 1] = 3; mSudoku[0, 2] = 4; mSudoku[0, 3] = 6; mSudoku[0, 4] = 7; mSudoku[0, 5] = 8; mSudoku[0, 6] = 9; mSudoku[0, 7] = 1; mSudoku[0, 8] = 2;
            mSudoku[1, 0] = 6; mSudoku[1, 1] = 7; mSudoku[1, 2] = 2; mSudoku[1, 3] = 1; mSudoku[1, 4] = 9; mSudoku[1, 5] = 5; mSudoku[1, 6] = 3; mSudoku[1, 7] = 4; mSudoku[1, 8] = 8;
            mSudoku[2, 0] = 1; mSudoku[2, 1] = 9; mSudoku[2, 2] = 8; mSudoku[2, 3] = 3; mSudoku[2, 4] = 4; mSudoku[2, 5] = 2; mSudoku[2, 6] = 5; mSudoku[2, 7] = 6; mSudoku[2, 8] = 7;
            mSudoku[3, 0] = 8; mSudoku[3, 1] = 5; mSudoku[3, 2] = 9; mSudoku[3, 3] = 7; mSudoku[3, 4] = 6; mSudoku[3, 5] = 1; mSudoku[3, 6] = 4; mSudoku[3, 7] = 2; mSudoku[3, 8] = 3;
            mSudoku[4, 0] = 4; mSudoku[4, 1] = 2; mSudoku[4, 2] = 6; mSudoku[4, 3] = 8; mSudoku[4, 4] = 5; mSudoku[4, 5] = 3; mSudoku[4, 6] = 7; mSudoku[4, 7] = 9; mSudoku[4, 8] = 1;
            mSudoku[5, 0] = 7; mSudoku[5, 1] = 1; mSudoku[5, 2] = 3; mSudoku[5, 3] = 9; mSudoku[5, 4] = 2; mSudoku[5, 5] = 4; mSudoku[5, 6] = 8; mSudoku[5, 7] = 5; mSudoku[5, 8] = 6;
            mSudoku[6, 0] = 9; mSudoku[6, 1] = 6; mSudoku[6, 2] = 1; mSudoku[6, 3] = 5; mSudoku[6, 4] = 3; mSudoku[6, 5] = 7; mSudoku[6, 6] = 2; mSudoku[6, 7] = 8; mSudoku[6, 8] = 4;
            mSudoku[7, 0] = 2; mSudoku[7, 1] = 8; mSudoku[7, 2] = 7; mSudoku[7, 3] = 4; mSudoku[7, 4] = 1; mSudoku[7, 5] = 9; mSudoku[7, 6] = 6; mSudoku[7, 7] = 3; mSudoku[7, 8] = 5;
            mSudoku[8, 0] = 3; mSudoku[8, 1] = 4; mSudoku[8, 2] = 5; mSudoku[8, 3] = 2; mSudoku[8, 4] = 8; mSudoku[8, 5] = 6; mSudoku[8, 6] = 1; mSudoku[8, 7] = 7; mSudoku[8, 8] = 1;

            var result = test.verificaArrayComVetorDeNovePosicao(mSudoku);
            Assert.AreEqual(false, result);

        }

        [TestMethod]
        public void TestSudokuTrue()
        {
            Sudoku test = new Sudoku();
            int[,] mSudoku = new int[9, 9];

            mSudoku[0, 0] = 5; mSudoku[0, 1] = 3; mSudoku[0, 2] = 4; mSudoku[0, 3] = 6; mSudoku[0, 4] = 7; mSudoku[0, 5] = 8; mSudoku[0, 6] = 9; mSudoku[0, 7] = 1; mSudoku[0, 8] = 2;
            mSudoku[1, 0] = 6; mSudoku[1, 1] = 7; mSudoku[1, 2] = 2; mSudoku[1, 3] = 1; mSudoku[1, 4] = 9; mSudoku[1, 5] = 5; mSudoku[1, 6] = 3; mSudoku[1, 7] = 4; mSudoku[1, 8] = 8;
            mSudoku[2, 0] = 1; mSudoku[2, 1] = 9; mSudoku[2, 2] = 8; mSudoku[2, 3] = 3; mSudoku[2, 4] = 4; mSudoku[2, 5] = 2; mSudoku[2, 6] = 5; mSudoku[2, 7] = 6; mSudoku[2, 8] = 7;
            mSudoku[3, 0] = 8; mSudoku[3, 1] = 5; mSudoku[3, 2] = 9; mSudoku[3, 3] = 7; mSudoku[3, 4] = 6; mSudoku[3, 5] = 1; mSudoku[3, 6] = 4; mSudoku[3, 7] = 2; mSudoku[3, 8] = 3;
            mSudoku[4, 0] = 4; mSudoku[4, 1] = 2; mSudoku[4, 2] = 6; mSudoku[4, 3] = 8; mSudoku[4, 4] = 5; mSudoku[4, 5] = 3; mSudoku[4, 6] = 7; mSudoku[4, 7] = 9; mSudoku[4, 8] = 1;
            mSudoku[5, 0] = 7; mSudoku[5, 1] = 1; mSudoku[5, 2] = 3; mSudoku[5, 3] = 9; mSudoku[5, 4] = 2; mSudoku[5, 5] = 4; mSudoku[5, 6] = 8; mSudoku[5, 7] = 5; mSudoku[5, 8] = 6;
            mSudoku[6, 0] = 9; mSudoku[6, 1] = 6; mSudoku[6, 2] = 1; mSudoku[6, 3] = 5; mSudoku[6, 4] = 3; mSudoku[6, 5] = 7; mSudoku[6, 6] = 2; mSudoku[6, 7] = 8; mSudoku[6, 8] = 4;
            mSudoku[7, 0] = 2; mSudoku[7, 1] = 8; mSudoku[7, 2] = 7; mSudoku[7, 3] = 4; mSudoku[7, 4] = 1; mSudoku[7, 5] = 9; mSudoku[7, 6] = 6; mSudoku[7, 7] = 3; mSudoku[7, 8] = 5;
            mSudoku[8, 0] = 3; mSudoku[8, 1] = 4; mSudoku[8, 2] = 5; mSudoku[8, 3] = 2; mSudoku[8, 4] = 8; mSudoku[8, 5] = 6; mSudoku[8, 6] = 1; mSudoku[8, 7] = 7; mSudoku[8, 8] = 9;

            var result = test.verificaSudoku(mSudoku);
            Assert.AreEqual(true, result);

        }

        [TestMethod]
        public void TestSudokuTrue2()
        {
            Sudoku test = new Sudoku();
            int[,] mSudoku = new int[9, 9];

            mSudoku[0, 0] = 8; mSudoku[0, 1] = 7; mSudoku[0, 2] = 1; mSudoku[0, 3] = 4; mSudoku[0, 4] = 5; mSudoku[0, 5] = 3; mSudoku[0, 6] = 9; mSudoku[0, 7] = 2; mSudoku[0, 8] = 6;
            mSudoku[1, 0] = 9; mSudoku[1, 1] = 5; mSudoku[1, 2] = 3; mSudoku[1, 3] = 7; mSudoku[1, 4] = 2; mSudoku[1, 5] = 6; mSudoku[1, 6] = 4; mSudoku[1, 7] = 8; mSudoku[1, 8] = 1;
            mSudoku[2, 0] = 2; mSudoku[2, 1] = 4; mSudoku[2, 2] = 6; mSudoku[2, 3] = 8; mSudoku[2, 4] = 9; mSudoku[2, 5] = 1; mSudoku[2, 6] = 5; mSudoku[2, 7] = 3; mSudoku[2, 8] = 7;
            mSudoku[3, 0] = 7; mSudoku[3, 1] = 6; mSudoku[3, 2] = 5; mSudoku[3, 3] = 3; mSudoku[3, 4] = 8; mSudoku[3, 5] = 9; mSudoku[3, 6] = 1; mSudoku[3, 7] = 4; mSudoku[3, 8] = 2;
            mSudoku[4, 0] = 1; mSudoku[4, 1] = 3; mSudoku[4, 2] = 2; mSudoku[4, 3] = 5; mSudoku[4, 4] = 4; mSudoku[4, 5] = 7; mSudoku[4, 6] = 8; mSudoku[4, 7] = 6; mSudoku[4, 8] = 9;
            mSudoku[5, 0] = 4; mSudoku[5, 1] = 9; mSudoku[5, 2] = 8; mSudoku[5, 3] = 1; mSudoku[5, 4] = 6; mSudoku[5, 5] = 2; mSudoku[5, 6] = 7; mSudoku[5, 7] = 5; mSudoku[5, 8] = 3;
            mSudoku[6, 0] = 6; mSudoku[6, 1] = 8; mSudoku[6, 2] = 7; mSudoku[6, 3] = 9; mSudoku[6, 4] = 3; mSudoku[6, 5] = 5; mSudoku[6, 6] = 2; mSudoku[6, 7] = 1; mSudoku[6, 8] = 4;
            mSudoku[7, 0] = 5; mSudoku[7, 1] = 2; mSudoku[7, 2] = 9; mSudoku[7, 3] = 6; mSudoku[7, 4] = 1; mSudoku[7, 5] = 4; mSudoku[7, 6] = 3; mSudoku[7, 7] = 7; mSudoku[7, 8] = 8;
            mSudoku[8, 0] = 3; mSudoku[8, 1] = 1; mSudoku[8, 2] = 4; mSudoku[8, 3] = 2; mSudoku[8, 4] = 7; mSudoku[8, 5] = 8; mSudoku[8, 6] = 6; mSudoku[8, 7] = 9; mSudoku[8, 8] = 5;

            var result = test.verificaSudoku(mSudoku);
            Assert.AreEqual(true, result);

        }

        [TestMethod]
        public void TestSudokuFalse()
        {
            Sudoku test = new Sudoku();
            int[,] mSudoku = new int[9, 9];

            mSudoku[0, 0] = 1; mSudoku[0, 1] = 4; mSudoku[0, 2] = 7; mSudoku[0, 3] = 1; mSudoku[0, 4] = 4; mSudoku[0, 5] = 7; mSudoku[0, 6] = 1; mSudoku[0, 7] = 4; mSudoku[0, 8] = 7;
            mSudoku[1, 0] = 2; mSudoku[1, 1] = 5; mSudoku[1, 2] = 8; mSudoku[1, 3] = 2; mSudoku[1, 4] = 5; mSudoku[1, 5] = 8; mSudoku[1, 6] = 2; mSudoku[1, 7] = 5; mSudoku[1, 8] = 8;
            mSudoku[2, 0] = 3; mSudoku[2, 1] = 6; mSudoku[2, 2] = 9; mSudoku[2, 3] = 3; mSudoku[2, 4] = 6; mSudoku[2, 5] = 9; mSudoku[2, 6] = 3; mSudoku[2, 7] = 6; mSudoku[2, 8] = 9;
            mSudoku[3, 0] = 1; mSudoku[3, 1] = 4; mSudoku[3, 2] = 7; mSudoku[3, 3] = 1; mSudoku[3, 4] = 4; mSudoku[3, 5] = 7; mSudoku[3, 6] = 1; mSudoku[3, 7] = 4; mSudoku[3, 8] = 7;
            mSudoku[4, 0] = 2; mSudoku[4, 1] = 5; mSudoku[4, 2] = 8; mSudoku[4, 3] = 2; mSudoku[4, 4] = 5; mSudoku[4, 5] = 8; mSudoku[4, 6] = 2; mSudoku[4, 7] = 5; mSudoku[4, 8] = 8;
            mSudoku[5, 0] = 3; mSudoku[5, 1] = 6; mSudoku[5, 2] = 9; mSudoku[5, 3] = 3; mSudoku[5, 4] = 6; mSudoku[5, 5] = 9; mSudoku[5, 6] = 3; mSudoku[5, 7] = 6; mSudoku[5, 8] = 9;
            mSudoku[6, 0] = 1; mSudoku[6, 1] = 4; mSudoku[6, 2] = 7; mSudoku[6, 3] = 1; mSudoku[6, 4] = 4; mSudoku[6, 5] = 7; mSudoku[6, 6] = 1; mSudoku[6, 7] = 4; mSudoku[6, 8] = 7;
            mSudoku[7, 0] = 2; mSudoku[7, 1] = 5; mSudoku[7, 2] = 8; mSudoku[7, 3] = 2; mSudoku[7, 4] = 5; mSudoku[7, 5] = 8; mSudoku[7, 6] = 2; mSudoku[7, 7] = 5; mSudoku[7, 8] = 8;
            mSudoku[8, 0] = 3; mSudoku[8, 1] = 6; mSudoku[8, 2] = 9; mSudoku[8, 3] = 3; mSudoku[8, 4] = 6; mSudoku[8, 5] = 9; mSudoku[8, 6] = 3; mSudoku[8, 7] = 6; mSudoku[8, 8] = 9;

            var result = test.verificaSudoku(mSudoku);
            Assert.AreEqual(false, result);

        }
    }
}
