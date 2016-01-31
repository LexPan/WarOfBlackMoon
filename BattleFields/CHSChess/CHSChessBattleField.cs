using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HikariX3X.BlackMoon.BattleFields.CHSChess
{
    public class CHSChessBattleField
    {
        private List<CHSChessPosition> m_battlePositions;

        public CHSChessBattleField()
        {
            m_battlePositions = new List<CHSChessPosition>();
            for (uint i = 1; i < 9; i++)
            {
                for (uint j = 1; j < 9; j++)
                {
                    m_battlePositions.Add(new CHSChessPosition(i, j));
                }
            }
        }

        public CHSChessPosition this[int a,int b]
        {
            get
            {
                return m_battlePositions.Find(c=> {return c.Equals(a,b) });
            }
        }

    }
}
