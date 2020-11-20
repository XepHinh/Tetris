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
        Tetromino nextTetromino;
        public Tetris()
        {
            InitializeComponent();

            loadCanvas();

            currentTetromino = getRandomTetrominoWithCenterAligned();   
            nextTetromino = getNextTetromino();

            timer.Tick += tmrTick;
            timer.Interval = 500;
            timer.Start();

            KeyDown += frmKeyHandle;
        }               

        Bitmap canvasBitmap;
        Graphics canvasGraphics;
        int canvasWidth = 10;
        int canvasHeight = 20;
        int[,] canvasDotArray;
        int dotSize = 23;
        public void loadCanvas()
        {
            //Cai dat kich thuoc pictureBox dua tren kich thuoc diem va so diem
            picBox.Width = canvasWidth * dotSize;
            picBox.Height = canvasHeight * dotSize;

            //Tao Bitmap voi kich thuoc cua pictureBox
            canvasBitmap = new Bitmap(picBox.Width, picBox.Height);
            canvasGraphics = Graphics.FromImage(canvasBitmap);
            canvasGraphics.FillRectangle(Brushes.LightSteelBlue, 0, 0, canvasBitmap.Width, canvasBitmap.Height);
            for (int i = 0; i < canvasWidth; i++)
            {
                for (int j = 0; j < canvasHeight; j++)
                {
                    canvasGraphics = Graphics.FromImage(canvasBitmap);
                    canvasGraphics.FillRectangle(Brushes.SlateGray,
                    i * dotSize, j * dotSize, dotSize, dotSize);
                }
            }

            picBox.Image = canvasBitmap;

            canvasDotArray = new int[canvasWidth, canvasHeight];
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
                currentTetromino = nextTetromino;
                nextTetromino = getNextTetromino();

                clearFilledRowsAndUpdateScore();
            }
        }

        int currentX;
        int currentY;
        /// <summary>
        /// Khi cac khoi xuan hien se o giua man hinh Gameplay
        /// </summary>
        /// <returns></returns>
        private Tetromino getRandomTetrominoWithCenterAligned()
        {
            var tetromino = tetrominoHandler.getRandomTetromino();
            
            currentX = 4;
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
                    if (newY + j > 0 && canvasDotArray[newX + i, newY + j] == 1 && currentTetromino.DotMatrix[j, i] == 1)
                        return false;                    
                }
            }
                     

            currentX = newX;
            currentY = newY;

            drawTetromino();

            return true;
        }

        Bitmap workingBitmap;
        Graphics workingGraphics;
        /// <summary>
        /// Hien thi cac khoi Tetromino len pictureBox
        /// </summary>
        private void drawTetromino()
        {
            workingBitmap = new Bitmap(canvasBitmap);
            workingGraphics = Graphics.FromImage(workingBitmap);
            
            Bitmap myImg;

            for (int i = 0; i < currentTetromino.Width; i++)
            {
                for (int j = 0; j < currentTetromino.Height; j++)
                {                    
                    if (currentTetromino.DotMatrix[j, i] == 1)
                    {
                        switch (currentTetromino.Type)
                        {
                            case "I":
                                myImg = new Bitmap("../../Textures/I.png");
                                workingGraphics.DrawImage(myImg, (currentX + i) * dotSize, (currentY + j) * dotSize, dotSize - 1, dotSize - 1);
                                break;
                            case "L":
                                myImg = new Bitmap("../../Textures/L.png");
                                workingGraphics.DrawImage(myImg, (currentX + i) * dotSize, (currentY + j) * dotSize, dotSize - 1, dotSize - 1);
                                break;
                            case "L1":
                                myImg = new Bitmap("../../Textures/L1.png");
                                workingGraphics.DrawImage(myImg, (currentX + i) * dotSize, (currentY + j) * dotSize, dotSize - 1, dotSize - 1);
                                break;
                            case "O":
                                myImg = new Bitmap("../../Textures/O.png");
                                workingGraphics.DrawImage(myImg, (currentX + i) * dotSize, (currentY + j) * dotSize, dotSize - 1, dotSize - 1);
                                break;
                            case "S":
                                myImg = new Bitmap("../../Textures/S.png");
                                workingGraphics.DrawImage(myImg, (currentX + i) * dotSize, (currentY + j) * dotSize, dotSize - 1, dotSize - 1);
                                break;
                            case "S1":
                                myImg = new Bitmap("../../Textures/S1.png");
                                workingGraphics.DrawImage(myImg, (currentX + i) * dotSize, (currentY + j) * dotSize, dotSize - 1, dotSize - 1);
                                break;
                            case "T":
                                myImg = new Bitmap("../../Textures/T.png");
                                workingGraphics.DrawImage(myImg, (currentX + i) * dotSize, (currentY + j) * dotSize, dotSize - 1, dotSize - 1);
                                break;
                        }
                    }
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
                MessageBox.Show("Game Over!!!");
                Application.Exit();
            }
        }

        private void frmKeyHandle(object sender, KeyEventArgs e)
        {
            int verticalMove = 0;
            int horizontalMove = 0;

            switch (e.KeyCode)
            {
                case Keys.Left:
                    verticalMove--;
                    break;
                case Keys.Right:
                    verticalMove++;
                    break;
                case Keys.Up:
                    currentTetromino.turn();
                    break;
                case Keys.Down:
                    horizontalMove++;
                    break;                
                default:
                    break;
            }

            var isMove = moveTetrominoIfPossible(horizontalMove, verticalMove);
            if (!isMove && e.KeyCode == Keys.Up)
            {
                currentTetromino.turn();
            }
        }

        int score = 0;
        int level = 0;
        /// <summary>
        /// Check dieu kien an diem va xoa dong dung
        /// </summary>
        public void clearFilledRowsAndUpdateScore()
        {
            //Kiem tra tuw ng dong
            for (int i = 0; i < canvasHeight; i++)
            {
                int j;
                for (j = canvasWidth - 1; j >= 0; j--)
                {
                    if (canvasDotArray[j, i] == 0)
                        break;
                }

                if (j == -1)
                {
                    //Cap nhat diem so
                    score++;
                    level = score / 10;

                    timer.Interval -= 10;

                    lblScore.Text = "Score: "+score;                                       
                    lblLevel.Text = "Level: "+level;
                    //cap nhat mang sau khi check
                    for (j = 0; j < canvasWidth; j++)
                    {
                        for (int k = i; k > 0; k--)
                        {
                            canvasDotArray[j, k] = canvasDotArray[j, k - 1];
                        }

                        canvasDotArray[j, 0] = 0;
                    }
                }
            }

            //Ve lai cac o khi cap nhat
            for (int i = 0; i < canvasWidth; i++)
            {
                for (int j = 0; j < canvasHeight; j++)
                {
                    canvasGraphics = Graphics.FromImage(canvasBitmap);
                    Bitmap myImg = new Bitmap("../../Textures/Lock.png");
                    if (canvasDotArray[i, j] == 1)
                    {
                        canvasGraphics.DrawImage(myImg, i * dotSize, j * dotSize, dotSize - 1, dotSize - 1);
                    }
                    else
                    {
                        canvasGraphics.FillRectangle(Brushes.SlateGray, i * dotSize, j * dotSize, dotSize, dotSize);
                    }
                }
            }

            picBox.Image = canvasBitmap;
        }

        Bitmap nextTetrominoBitmap;
        Graphics nextTetrominGraphics;
        private Tetromino getNextTetromino()
        {
            var tetromino = getRandomTetrominoWithCenterAligned();
            
            //Dinh ngia cac gia tri cua phan nextPicBox
            nextTetrominoBitmap = new Bitmap(4 * dotSize, 4 * dotSize);
            nextTetrominGraphics = Graphics.FromImage(nextTetrominoBitmap);
            
            //Ve khung hien thi nextTetromino
            for (int i = 0; i < nextTetrominoBitmap.Width; i++)
            {
                for (int j = 0; j < nextTetrominoBitmap.Height; j++)
                {
                    nextTetrominGraphics = Graphics.FromImage(nextTetrominoBitmap);
                    nextTetrominGraphics.FillRectangle(Brushes.SlateGray,
                    i * dotSize, j * dotSize, dotSize - 1, dotSize - 1);
                }
            }
            
            //Gan vi tri khoi tao
            var startX = (4 - tetromino.Width) / 2;
            var startY = (4 - tetromino.Height) / 2;
            
            //Ve len nex pic
            Bitmap myImg;
            myImg = new Bitmap("../../Textures/I.png");
            for (int i = 0; i < tetromino.Height; i++)
            {
                for (int j = 0; j < tetromino.Width; j++)
                {   
                    
                    if (tetromino.DotMatrix[i, j] == 1)
                    {
                        nextTetrominGraphics.DrawImage(myImg, (startX + j) * dotSize, (startY + i) * dotSize, dotSize - 1, dotSize - 1);
                    }
                    else
                    {
                        nextTetrominGraphics.FillRectangle(Brushes.SlateGray, (startX + j) * dotSize, (startY + i) * dotSize, dotSize - 1, dotSize - 1);
                    }
                                        
                }
            }

            picNextTetromino.Size = nextTetrominoBitmap.Size;
            picNextTetromino.Image = nextTetrominoBitmap;

            return tetromino;
        }
    }
}
