using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HikariX3X.BlackMoon.BattleFields
{
    internal enum CmderTurns : int
    {
    }

    protected class TurnBasedCmder
    {
        public BattleField BattleField;
        private bool m_hasTurn;

        protected TurnBasedCmder()
        {
            m_hasTurn = false;
        }
        protected TurnBasedCmder(bool hasturn)
        {
            m_hasTurn = hasturn;
        }  


        public void GetTurn()
        {
            m_hasTurn = true;
        }
        public bool HasTurn()
        {
            return m_hasTurn;
        }


    }
}
