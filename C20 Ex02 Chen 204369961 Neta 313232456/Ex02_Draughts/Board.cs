using System;
using System.Collections.Generic;
using System.Text;

namespace Ex02_Draughts
{
    class Board
    {
        private int m_BoardSize = 6;
        private int m_NumberOfO;
        private int m_NumberOfX;
        private readonly Cell[,] r_TheBoard;
        
        public Board(int i_BoardSize)
        {
            BoardSize = i_BoardSize;
            m_NumberOfO = ((m_BoardSize / 2) - 1) * (m_BoardSize / 2);
            m_NumberOfX = ((m_BoardSize / 2) - 1) * (m_BoardSize / 2);
            r_TheBoard = new Cell[m_BoardSize, m_BoardSize];
        }

        public void CreateBoard()
        {
            for(int i = 0; i < m_BoardSize; i++)
            {
                for(int j = 0; j < m_BoardSize; j++)
                {
                    
                    if(i < (m_BoardSize / 2) - 1 && (i+j) % 2 == 1)
                    {
                        r_TheBoard[i, j] = new Cell("O", false, i, j);

                    }
                    else if(i > (m_BoardSize / 2) && (i + j) % 2 == 1)
                    {
                        r_TheBoard[i, j] = new Cell("X", false, i, j);

                    }
                    else
                    {
                        r_TheBoard[i, j] = new Cell(" ", true, i, j);
                    }
                    
                }
            }
        }

        public int BoardSize
        {
            set
            {
                m_BoardSize = value;

            }
            get
            {
                return m_BoardSize;

            }
        }

        public void PrintBoard()
        {
            char rowChar = 'a';
            ColumnLabelsToPrint(m_BoardSize);
            StringBuilder boardSeparateLineToPrint = CreateBoardSeparateLine(m_BoardSize);
            StringBuilder boardToPrint = new StringBuilder();
            for(int i = 0; i < m_BoardSize; i++)
            {
                for(int j = 0; j < m_BoardSize; j++)
                {
                    if(j == 0)
                    {
                        boardToPrint.Append(rowChar);
                        boardToPrint.Append("| ");
                        boardToPrint.Append(r_TheBoard[i, j].CellValue);
                        boardToPrint.Append(" |");
                    }
                    else
                    {
                        boardToPrint.Append(" ");
                        boardToPrint.Append(r_TheBoard[i, j].CellValue);
                        boardToPrint.Append(" |");
                    }
                }
                rowChar++;
                boardToPrint.AppendLine();
                boardToPrint.Append(boardSeparateLineToPrint);
                boardToPrint.AppendLine();
            }
            Console.Write(boardToPrint);
        }

        public void ColumnLabelsToPrint(int i_BoardSize)
        {
            int i;
            char columnLabel = 'A';

            
            for (i = 0; i < i_BoardSize; i++)
            {

                string stringColumnLabelToPrint = string.Format("   {0}", (char)(columnLabel + i));
                Console.Write(stringColumnLabelToPrint);
            }

            Console.WriteLine();
        }

        public StringBuilder CreateBoardSeparateLine(int i_BoardSize)
        {
            StringBuilder o_StringToReturn = new StringBuilder();
            o_StringToReturn.Append(' ', 1);
            o_StringToReturn.Append('=', (i_BoardSize * 4) + 1);
            return o_StringToReturn;
        }
    }
}


