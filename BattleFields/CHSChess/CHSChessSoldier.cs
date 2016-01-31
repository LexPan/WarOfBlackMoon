using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HikariX3X.BlackMoon.BattleFields.CHSChess
{
    internal class CHSChessSoldier : Soldier
    {
        protected CHSChessPosition m_position;
        public CHSChessPosition Position
        {
            get
            {
                return Position;
            }
        }

        public CHSChessSoldier(CHSChessPosition position, string name):base(name)
        {
            m_position = position;
        }

        public CHSChessSoldier(CHSChessPosition position)
        {
            m_position = position;
        }

        internal void MoveToPosition(CHSChessPosition position)
        {
            m_position = position;
        }
    }

}

namespace HikariX3X.BlackMoon.BattleFields.CHSChess.Soldiers
{
    internal class Footman : CHSChessSoldier
    {
        public Footman()
        {

        }
    }

}