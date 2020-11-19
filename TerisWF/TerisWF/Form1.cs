using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TerisWF
{
    public partial class Tetris : Form
    {
        Tetromino currentTetromino;
        public Tetris()
        {
            InitializeComponent();

            loadCanvas();

            currentTetromino = getRandomTetrominoWithCenterAligned();

            timer.Tick += tmrTick;
            timer.Interval = 500;
            timer.Start();
        }

        private void tmrTick(object sender, EventArgs e)
        {
            var isMoveSuccess = moveTetrominoIfPossible(moveDown: 1);

            //Khi khoi xuat hien va cham
            if (!isMoveSuccess)
            {
                canvasBitmap = new Bitmap(workingBitmap);
                updateCanvasDotArrayWithCurrentShape();
                //Them khoi moi
                currentTetromino = getRandomTetrominoWithCenterAligned();
            }
        }

        Bitmap canvasBitmap;
        Graphics canvasGraphics;
        int canvasWidth = 10;
        int canvasHeight = 20;
        int[,] canvasDotArray;
        int dotSize = 30;
        public void loadCanvas()
        {
            //Cai dat kich thuoc pictureBox dua tren kich thuoc diem va so diem
            picBox.Width = canvasWidth * dotSize;
            picBox.Height = canvasHeight * dotSize;

            //Tao Bitmap voi kich thuoc cua pictureBox
            canvasBitmap = new Bitmap(picBox.Width, picBox.Height);
            canvasGraphics = Graphics.FromImage(canvasBitmap);
            canvasGraphics.FillRectangle(Brushes.SlateGray, 0, 0, canvasBitmap.Width, canvasBitmap.Height);

            picBox.Image = canvasBitmap;

            canvasDotArray = new int[canvasWidth, canvasHeight];
        }

        int currentX;
        int currentY;
        /// <summary>
        /// Khi cac khoi xuan hien se o giua man hinh Gameplay
        /// </summary>
        /// <returns></returns>
        private Tetromino getRandomTetrominoWithCenterAligned()
        {
            var tetromino = TetrominoHandler.getRandomTetromino();
            
            currentX = 5;
            currentY = -tetromino.Height;

            return tetromino;
        }
        /// <summary>
        /// Kiem tra khoi co xuat hien va cham dung hay khong
        /// </summary>
        /// <param name="moveDown"></param>
        /// <param name="moveSide"></param>
        /// <returns>true: Khong co va cham || false: Khi xuat hien va cham</returns>
        private bool moveTetrominoIfPossible(int moveDown = 0, int moveSide = 0)
        {
            int newX = currentX + moveSide;
            int newY = currentY + moveDown;

            //Kiem tra khoi da cham day hay canh hay chua
            if (newX < 0 || newX + currentTetromino.Width > canvasWidth || newY + currentTetromino.Height > canvasHeight)
            {
                return false;
            }
            
            //Kiem tra khoi co cham khoi khac hay chua
            for (int i = 0; i < currentTetromino.Width; i++)
            {
                for (int j = 0; j < currentTetromino.Height; j++)
                {
                    if (newY + j > 0 && canvasDotArray[newX + i, newY + j] == 1 && currentTetromino.DotMatrix[i, j] == 1)
                    {
                        return false;
                    }
                }
            }

            currentX = newX;
            currentY = newY;

            drawTetromino();

            return true;
        }

        Bitmap workingBitmap;
        Graphics workingGraphics;

        private void drawTetromino()
        {
            workingBitmap = new Bitmap(canvasBitmap);
            workingGraphics = Graphics.FromImage(workingBitmap);

            for (int i = 0; i < currentTetromino.Width; i++)
            {
                for (int j = 0; j < currentTetromino.Height; j++)
                {
                    /*
                    if (currentTetromino.DotMatrix[i, j] == 1)
                    {
                        string type = currentTetromino.Type;
                        
                        Image img; 
                        TextureBrush tBrush; 
                        Rectangle rt; 
                        
                        switch (type)
                        {
                            case "I":
                                img = new Bitmap("Images\\I.png");
                                tBrush = new TextureBrush(img);
                                rt = new Rectangle((currentX + i) * dotSize, (currentY + j) * dotSize, dotSize, dotSize);
                                workingGraphics.FillRectangle(tBrush, rt);
                                break;
                            case "L":
                                img = new Bitmap("Images\\L.png");
                                tBrush = new TextureBrush(img);
                                rt = new Rectangle((currentX + i) * dotSize, (currentY + j) * dotSize, dotSize, dotSize);
                                workingGraphics.FillRectangle(tBrush, rt);
                                break;
                            case "L1":
                                img = new Bitmap("Images\\L1.png");
                                tBrush = new TextureBrush(img);
                                rt = new Rectangle((currentX + i) * dotSize, (currentY + j) * dotSize, dotSize, dotSize);
                                workingGraphics.FillRectangle(tBrush, rt);
                                break;
                            case "O":
                                img = new Bitmap("Images\\O.png");
                                tBrush = new TextureBrush(img);
                                rt = new Rectangle((currentX + i) * dotSize, (currentY + j) * dotSize, dotSize, dotSize);
                                workingGraphics.FillRectangle(tBrush, rt);
                                break;
                            case "S":
                                img = new Bitmap("Images\\S.png");
                                tBrush = new TextureBrush(img);
                                rt = new Rectangle((currentX + i) * dotSize, (currentY + j) * dotSize, dotSize, dotSize);
                                workingGraphics.FillRectangle(tBrush, rt);
                                break;
                            case "S1":
                                img = new Bitmap("Images\\S1.png");
                                tBrush = new TextureBrush(img);
                                rt = new Rectangle((currentX + i) * dotSize, (currentY + j) * dotSize, dotSize, dotSize);
                                workingGraphics.FillRectangle(tBrush, rt);
                                break;
                            case "T":
                                img = new Bitmap("Images\\T.png");
                                tBrush = new TextureBrush(img);
                                rt = new Rectangle((currentX + i) * dotSize, (currentY + j) * dotSize, dotSize, dotSize);
                                workingGraphics.FillRectangle(tBrush, rt);
                                break;
                            default:
                                break;                            
                        }
                        
                    }
                    */
                    if (currentTetromino.DotMatrix[j, i] == 1)
                        workingGraphics.FillRectangle(Brushes.Black, (currentX + i) * dotSize, (currentY + j) * dotSize, dotSize, dotSize);
                }
            }
            
            picBox.Image = workingBitmap;
        }

        private void updateCanvasDotArrayWithCurrentShape()
        {
            for (int i = 0; i < currentTetromino.Width; i++)
            {
                for (int j = 0; j < currentTetromino.Height; j++)
                {
                    if (currentTetromino.DotMatrix[j, i] == 1)
                    {
                        checkIfGameOver();

                        canvasDotArray[currentX + i, currentY + j] = 1;
                    }
                }
            }
        }

        private void checkIfGameOver()
        {
            if (currentY < 0)
            {
                timer.Stop();
                MessageBox.Show("Game Over");
                Application.Restart();
            }
        }
    }
}
