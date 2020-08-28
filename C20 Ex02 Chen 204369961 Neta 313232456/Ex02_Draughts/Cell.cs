using System;
using System.Collections.Generic;
using System.Text;

namespace Ex02_Draughts
{
    public struct Cell
    {
        private Coordinate m_CellCoordinate;
        private string m_CellValue;
        private bool m_IsCellEmpty;

        internal Cell(string i_CellValue, bool i_IsCellEmpty, int i_CoordinateCol, int i_CoordinateRow)
        {
            m_CellValue = i_CellValue;
            m_CellCoordinate = new Coordinate(i_CoordinateCol, i_CoordinateRow);
            m_IsCellEmpty = i_IsCellEmpty;
        }

        internal string CellValue
        {
            get
            {
                return this.m_CellValue;
            }
        }

    }
}
    
