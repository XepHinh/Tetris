using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerisWF
{
    class Tetromino
    {
        public int Width;
        public int Height;
        public string Type;
        public int[,] DotMatrix;
    }
    static class TetrominoHandler
    {
        private static Tetromino[] tetrominoArray;

        static TetrominoHandler()
        {
            //Khoi tao mang de quan ly cac manh Tetromino
            tetrominoArray = new Tetromino[]
            {
                new Tetromino
                {
                    Width = 2,
                    Height = 2,
                    Type = "O",
                    DotMatrix = new int[,]
                    {
                        {1, 1 },
                        {1, 1 }
                    }
                },
                new Tetromino
                {
                    Width = 1,
                    Height = 4,
                    Type = "I",
                    DotMatrix = new int[,]
                    {
                        {1 },
                        {1 },
                        {1 },
                        {1 }
                    }
                },
                new Tetromino
                {
                    Width = 3,
                    Height = 2,
                    Type = "S",
                    DotMatrix = new int[,]
                    {
                        {0, 1, 1 },
                        {1, 1, 0 }
                    }
                },
                new Tetromino
                {
                    Width = 3,
                    Height = 2,
                    Type = "S1",
                    DotMatrix = new int[,]
                    {
                        {1, 1, 0 },
                        {0, 1, 1 }
                    }
                },
                new Tetromino
                {
                    Width = 3,
                    Height = 2,
                    Type = "L",
                    DotMatrix = new int[,]
                    {
                        {0, 0, 1 },
                        {1, 1, 1 }
                    }
                },
                new Tetromino
                {
                    Width = 3,
                    Height = 2,
                    Type = "L1",
                    DotMatrix = new int[,]
                    {
                        {1, 0, 0 },
                        {1, 1, 1 }
                    }
                },
                new Tetromino
                {
                    Width = 3,
                    Height = 2,
                    Type = "T",
                    DotMatrix = new int[,]
                    {
                        {0, 1, 0 },
                        {1, 1, 1 }
                    }
                }
            };
        }
        public static Tetromino getRandomTetromino()
        {
            var shape = tetrominoArray[new Random().Next(tetrominoArray.Length)];
            return shape;
        }
    }
}
