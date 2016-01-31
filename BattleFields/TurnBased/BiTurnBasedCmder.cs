using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HikariX3X.BlackMoon.BattleFields
{
    internal enum BiCmderTurns : int
    {
        First = 1,
        Second = 2
    }
    protected class BiTurnBasedCmder : TurnBasedCmder
    {
        protected BiCmderTurns m_turn;

        protected BiTurnBasedCmder(int turn)
            : base(turn == (int)BiCmderTurns.First)
        {
            this.m_turn = (BiCmderTurns)turn;
        }
    }
}
