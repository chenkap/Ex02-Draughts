using System;
using System.Collections.Generic;
using System.Text;

namespace Ex02_Draughts
{
    /// <summary>
    /// TODO - reconsider using this struct!!!
    /// </summary>
    public struct Coordinate
    {
        private int m_ColumnCapitalLetter;
        private int m_RowSmallLetter;

        public Coordinate(int i_ColumnCoordinate, int i_RowCoordinate)
        {
            m_ColumnCapitalLetter = i_ColumnCoordinate;
            m_RowSmallLetter = i_RowCoordinate;
        }

        public Coordinate(Coordinate i_Coordinate)
        {
            this.m_ColumnCapitalLetter = i_Coordinate.m_ColumnCapitalLetter;
            this.m_RowSmallLetter = i_Coordinate.m_RowSmallLetter;
        }

        public int ColumnCoordinate
        {
            get
            {
                return m_ColumnCapitalLetter;
            }
            set
            {
                m_ColumnCapitalLetter = value;
            }
        }

        public int RowCapitalLetter
        {
            get
            {
                return m_RowSmallLetter;
            }
            set
            {
                m_RowSmallLetter = value;
            }
        }

    }
}
