using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bank
{
    public partial class Bank : Form
    {
        const int ROWS = 33;
        const int COLS = 125;

        const int SAFE_ROWS = 7;
        const int SAFE_COLS = 15;

        const int LOBBY_ROW_MAX = 15;
        const int LOBBY_COL = COLS - 10 ;
        const int LOBBY_ROWS = 5;
        int rndCol;

        string [,] bankLayout = new string[ROWS, COLS];
        string safeDoor = "ʘ";
        string safeWall = "#";
        string cam = "C";
        string[,] safe = new string[SAFE_ROWS, SAFE_COLS];
        int numCams;

        bool generated = false;

        string man = "B";
        int manRow = ROWS - 2;
        int manCol = (COLS -1 )/ 2;

        public Bank()
        {
            InitializeComponent();
        }
        private void Bank_Load(object sender, EventArgs e)
        {

        }
        private void fill()
        {
            for (int i = 0; i < ROWS; i ++)
            {
                for (int j = 0; j < COLS; j++)
                {
                    bankLayout[i, j] = " ";
                }
            }
        }
        private void setBorder()
        {
            //set top/bot border
            for (int i = 0; i < COLS; i++)
            {
                bankLayout[0, i] = "#";
                bankLayout[ROWS - 1, i] = "#";
            }
            //set side border
            for (int i = 0; i < ROWS -1; i++)
            {
                bankLayout[i, 0] = "#";
                bankLayout[i, COLS - 1] = "#";
            }
            //doors
            for (int i = -3; i < 3; i ++)
            {
                bankLayout[ROWS - 1, COLS / 2 + i] = "|";
            }
        }
        private void camsDisplay()
        {
            List<int[]> list = new List<int[]>();
            List<int> rand = new List<int>();
            for (int i = 0; i < ROWS; i++)
            {
                for (int j = 0; j < COLS; j++)
                {
                    if (bankLayout[i, j].Equals("#"))
                    {
                        list.Add(new int[2] { i, j });
                    };
                }
            }
            Random rnd = new Random();
            for (int i = 0; i < numCams; i++)
            {
                int ran = rnd.Next(0, list.Count);
                if (!rand.Contains(ran))
                {
                    rand.Add(ran);
                    bankLayout[list.ElementAt(ran)[0], list.ElementAt(ran)[1]] = cam;
                }
            }
        }
        private void display()
        {
            string output = "";
            
            

            for (int i = 0; i < ROWS; i++)
            {
                for (int j = 0; j < COLS; j++)
                {
                    output += bankLayout[i, j];
                }
                if (i != ROWS - 1)
                {
                    output += "\r\n";
                }
            }
            txtLayout.Text = output;
        }
        private void genSafe()
        {
            Random rnd = new Random();
            int rndRow = rnd.Next(0, SAFE_ROWS);
            int rndCol;
            //top bottom
            for (int i = 0; i < SAFE_ROWS; i ++)
            {
                //sides
                for (int j =0; j < SAFE_COLS; j++)
                {
                    if (i == 0 || i == SAFE_ROWS - 1)
                    {
                        safe[i, j] = safeWall;
                    }
                    else
                    {
                        if (j == 0 || j == SAFE_COLS - 1)
                        {
                            safe[i, j] = safeWall;
                        }
                        else
                        {
                            safe[i, j] = "$";
                        }
                    }
                }
            }
            //randomly place safe door
            if (rndRow == 0 || rndRow == SAFE_ROWS - 1)
            {
                rndCol = rnd.Next(1, SAFE_COLS-1);
                safe[rndRow, rndCol] = safeDoor;
            }
            else
            {
                rndCol = rnd.Next(2);
                if (rndCol == 1)
                {
                    safe[rndRow, SAFE_COLS-1] = safeDoor;
                }
                else
                {
                    safe[rndRow, 0] = safeDoor;
                }
            }
            //place safe in bank
            //generate random gap between bank borders, must have 1 space in between
            rndRow = rnd.Next(2, (ROWS - LOBBY_ROW_MAX) - SAFE_ROWS);
            //leave room for bank lobby
            rndCol = rnd.Next(2, (COLS - 1) - SAFE_COLS);
            for (int i = 0; i < SAFE_ROWS; i++)
            {
                for (int j = 0; j < SAFE_COLS; j++)
                {
                    bankLayout[i + rndRow, j + rndCol] = safe[i, j];
                }
            }
        }
        private void genLobby()
        {
            Random rnd = new Random();
            rndCol = rnd.Next(0,3) * (COLS - LOBBY_COL) / 2;



            //top wall
            //left doors
            for (int i = 1; i < 1 + rndCol; i++)
            {
                bankLayout[ROWS - LOBBY_ROW_MAX, i] = "_";
            }
            for (int i = 1; i < 1 + rndCol; i++)
            {
                bankLayout[ROWS - LOBBY_ROW_MAX + LOBBY_ROWS - 1, i] = "_";
            }

            //wall
            for (int i = 0 + rndCol; i < COLS - (COLS - LOBBY_COL - rndCol); i++)
            {
                bankLayout[ROWS - LOBBY_ROW_MAX, i] = "#";
            }
            //right door
            for (int i = COLS - (COLS - LOBBY_COL - rndCol); i < COLS - 1; i++)
            {
                bankLayout[ROWS - LOBBY_ROW_MAX, i] = "_";
                bankLayout[ROWS - LOBBY_ROW_MAX + LOBBY_ROWS - 1, i] = "_";
            }
            //side walls
            for (int i = 1; i < LOBBY_ROWS ; i++)
            {
                //side walls
                bankLayout[i + ROWS - LOBBY_ROW_MAX, rndCol] = "#";
                bankLayout[i + ROWS - LOBBY_ROW_MAX, rndCol+ LOBBY_COL - 1] = "#";
            }
            //front wall
            for (int i = 1; i < LOBBY_COL - 1; i++)
            {
                bankLayout[ROWS - LOBBY_ROW_MAX + LOBBY_ROWS - 1, i + rndCol] = "_";
                if (i % 19 == 0)
                {
                    bankLayout[ROWS - LOBBY_ROW_MAX + LOBBY_ROWS - 1, i + rndCol] = "|";
                }
            }
            //bank employees
            for (int i = 0; i < 6; i++)
            {
                bankLayout[ROWS - LOBBY_ROW_MAX + LOBBY_ROWS - 2, i * 19 + rndCol + 19/2] = "@";
            }

            //customers in front
            for (int i = 0; i < 6; i++)
            {
                bankLayout[ROWS - LOBBY_ROW_MAX + LOBBY_ROWS , i * 19 + rndCol + 19 / 2] = "@";
            }

            //waiting line
            int rowOff = 8;
            int distancing = 6;
            int waiters = rnd.Next(4, 20);
            string[,] waiterLine = new string[5, 61];
            for ( int i = 0; i < 5; i ++)
            {
                if ( i == 0)
                {
                    for (int j = 0; j < 61; j++)
                    {
                        if (j < 5)
                        {
                            bankLayout[i + ROWS - rowOff, j + rndCol*5 + 2] = " ";
                        }
                        else
                        {
                            bankLayout[i + ROWS - rowOff, j + rndCol *5 + 2] = "_";
                        }
                    }
                }
                if (i <=3 && i >= 1)
                {
                    bankLayout[i + ROWS - rowOff, 0 + rndCol * 5 + 2] = "|";
                    bankLayout[i + ROWS - rowOff, 60 + rndCol * 5 + 2] = "|";
                }
                if (i == 2)
                {
                    for (int j = 1; j < 56; j++)
                    {
                        bankLayout[i + ROWS - rowOff, rndCol * 5 + 2 + j] = "-";
                    }
                }
                if ( i == 4)
                {
                    bankLayout[i + ROWS - rowOff, rndCol * 5 + 2 + 60] = "|";
                    for (int j = 59; j > 4; j--)
                    {
                        bankLayout[i + ROWS - rowOff, rndCol * 5 + 2 + j] = "-";
                    }
                }
            }
            //waiters
            for (int i = 0; i < waiters; i++)
            {
                if (i < 10)
                {
                    bankLayout[1 + ROWS - rowOff, rndCol * 5 + 5 + i * distancing] = "@";
                }
                else
                {
                    bankLayout[3 + ROWS - rowOff, rndCol * 5 + 60 - (i - 9) * distancing] = "@";
                }
            }

        }

        private void generateMaze()
        {
            //top wall
            Random rnd = new Random();
            int[,] top = new int[COLS - 4,2];
            for (int i = 0; i < COLS - 4; i++)
            {
                top[i, 0] = 0;
                top[i, 1] = i + 2;
            }

            Random rndLen = new Random();
            for (int i = 0; i < rnd.Next(14, 18); i++){
                mazeBranch(0, top[rnd.Next(COLS - 4), 1], rndLen, 10);
            }


            //left wall
            int[,] left = new int[ROWS - LOBBY_ROW_MAX - 4, 2];
            for (int i = 0; i < ROWS - LOBBY_ROW_MAX - 4; i++)
            {
                left[i, 0] = 0;
                left[i, 1] = i + 2;
            }
            for (int i = 0; i < rnd.Next(13, 16); i++)
            {
                mazeBranch(left[rnd.Next(ROWS - LOBBY_ROW_MAX - 4), 1], 0, rndLen, 10);
            }


            //right wall
            int[,] right = new int[ROWS - LOBBY_ROW_MAX - 4, 2];
            for (int i = 0; i < ROWS - LOBBY_ROW_MAX - 4; i++)
            {
                right[i, 0] = 0;
                right[i, 1] = i + 2;
            }
            for (int i = 0; i < rnd.Next(13, 16); i++)
            {
                mazeBranch(right[rnd.Next(ROWS - LOBBY_ROW_MAX - 4), 1], COLS -1, rndLen, 10);
            }

            //right wall
            int[,] bot = new int[LOBBY_COL - 4, 2];
            for (int i = 0; i < LOBBY_COL - 4; i++)
            {
                bot[i, 0] = 0;
                bot[i, 1] = i + 2;
            }
            for (int i = 0; i < rnd.Next(13, 16); i++)
            {
                mazeBranch( ROWS - LOBBY_ROW_MAX, bot[rnd.Next(rndCol, LOBBY_COL - 4), 1], rndLen, 10);
            }


        }
        private void mazeBranch(int row, int col, Random rnd, int times)
        {
            if (times <=0)
            {
                return;
            }
            int direction = 0;
            int length = 0;
            //if on a wall
            if (row == 0 )
            {
                direction = 3;
                length = rnd.Next(3, 16);
            }
            else if (row == ROWS - LOBBY_ROW_MAX)
            {
                direction = 1;
                length = rnd.Next(3, 16);
            }
            else if (col == 0)
            {
                direction = 2;
                length = rnd.Next(3, 18);
            }
            else if (col == COLS - 1)
            {
                direction = 4;
                length = rnd.Next(3, 18);
            }
            //branch
            else
            {
                if (bankLayout[row + 1, col].Equals("#"))
                {
                    if (rnd.Next(2) == 0)
                    {
                        direction = 2;
                        length = rnd.Next(3, 18);
                    }
                    else
                    {
                        direction = 4;
                        length = rnd.Next(3, 18);
                    }
                }
                else{
                    if (rnd.Next(2) == 0)
                    {
                        direction = 1;
                        length = rnd.Next(3, 16);
                    }
                    else
                    {
                        direction = 3;
                        length = rnd.Next(3, 16);
                    }
                }
            }

            int[,] points = new int[length, 2];
            int i = 0;
            int r = row;
            int c = col;
            while (i < length && frontClear(r, c, direction))
            {
                switch (direction)
                {
                    case 1:
                        r--;
                        break;
                    case 2:
                        c++;
                        break;
                    case 3:
                        r++;
                        break;
                    case 4:
                        c--;
                        break;
                }
                if (!frontClear(r, c, direction))
                {
                    break;
                }
                bankLayout[r, c] = "#";
                points[i, 0] = r;
                points[i, 1] = c;
                i++;
            }
            for (int j = 0; j < rnd.Next(1,6); j++)
            {
                int rec = rnd.Next(0, i);
                mazeBranch(points[rec, 0], points[rec, 1], rnd, times -1);
            }
            
            
        }
        private bool frontClear(int row, int col, int direction)
        {
            int[,] offsets = new int[3, 2];
            switch (direction)
            {
                //north
                case 1:
                    offsets[0,0] = 0;
                    offsets[0,1] = 1;
                    offsets[1, 0] = 1;
                    offsets[1, 1] = 1;
                    offsets[2, 0] = -1;
                    offsets[2, 1] = 1;
                    break;
                //east
                case 2:
                    offsets[0, 0] = 1;
                    offsets[0, 1] = 0;
                    offsets[1, 0] = 1;
                    offsets[1, 1] = 1;
                    offsets[2, 0] = 1;
                    offsets[2, 1] = -1;
                    break;
                //south
                case 3:
                    offsets[0, 0] = 0;
                    offsets[0, 1] = -1;
                    offsets[1, 0] = 1;
                    offsets[1, 1] = -1;
                    offsets[2, 0] = -1;
                    offsets[2, 1] = -1;
                    break;
                //west
                case 4:
                    offsets[0, 0] = -1;
                    offsets[0, 1] = 0;
                    offsets[1, 0] = -1;
                    offsets[1, 1] = 1;
                    offsets[2, 0] = -1;
                    offsets[2, 1] = -1;
                    break;
                default:
                    break;
            }
            for(int i =0; i < 3; i++){
                if (!bankLayout[row - offsets[i, 1], col + offsets[i, 0]].Equals(" "))
                {
                    return false;
                }
            }
            return true;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Array.Clear(bankLayout, 0, bankLayout.Length);
            numCams = (int)nupNumCams.Value;
            fill();
            setBorder();
            calcTime();
            genSafe();
            genLobby();
            generateMaze();
            bankLayout[manRow, manCol] = man;
            generated = true;
            camsDisplay();
            display();
        }
        
        private void calcTime()
        {
            decimal time = 0;
            //hack time
            time += nupHackTime.Value * nupNumCams.Value;
            //drill time
            time += (decimal)((int)nupNumBoxes.Value / (int)nupDrillers.Value) * nupDrillTime.Value;
            //drill time remainder
            time += (decimal)((int)nupNumBoxes.Value % (int)nupDrillers.Value) * nupDrillTime.Value;

            lblTime.Text = "Time: " + ((int)time/60) + " minutes " + (time%60) + " seconds";
        }

        private bool checkBound(int row, int col)
        {
            if (!generated)
            {
                return false;
            }
            if (row <= 0 || col <= 0 || row >= ROWS-1 || col >= COLS-1 )
            {
                return false;
            }
            if (!bankLayout[row,col].Equals(" ") && !bankLayout[row, col].Equals("_")
                && !bankLayout[row, col].Equals(safeDoor) && !bankLayout[row, col].Equals("$"))
            {
                return false;
            }
            return true;
        }

        private void updateMan(int row, int col, int nRow, int nCol)
        {
            if (bankLayout[row, col].Equals(man))
            {
                bankLayout[nRow, nCol] = man;
                bankLayout[row, col] = " ";
            }
            display();
        }


        private void txtLayout_KeyDown(object sender, KeyEventArgs e)
        {
            int row = 0;
            int col = 0;
            switch (e.KeyCode)
            {
                case Keys.A:
                    col = -1;
                    if (checkBound(manRow + row, manCol + col))
                    {
                        updateMan(manRow, manCol, manRow + row, manCol + col);
                        manRow = manRow + row;
                        manCol = manCol + col;
                    }
                    break;
                case Keys.D:
                    col = 1;
                    if (checkBound(manRow + row, manCol + col))
                    {
                        updateMan(manRow, manCol, manRow + row, manCol + col);
                        manRow = manRow + row;
                        manCol = manCol + col;
                    }
                    break;
                case Keys.W:
                    row = -1;
                    if (checkBound(manRow + row, manCol + col))
                    {
                        updateMan(manRow, manCol, manRow + row, manCol + col);
                        manRow = manRow + row;
                        manCol = manCol + col;
                    }
                    break;
                case Keys.S:
                    row = 1;
                    if (checkBound(manRow + row, manCol + col))
                    {
                        updateMan(manRow, manCol, manRow + row, manCol + col);
                        manRow = manRow + row;
                        manCol = manCol + col;
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
