using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HikariX3X.BlackMoon.BattleFields.CHSChess
{
    public class CHSChessCmder : BiTurnBasedCmder
    {
        private List<CHSChessSoldier> m_livingSoldiers;
        private List<CHSChessSoldier> m_deadSoldiers;
        private CHSChessBattleField m_battleField;

        public CHSChessCmder(CHSChessBattleField battleField, BiCmderTurns turn)
            : base((int)turn, battleField)
        {
            this.m_turn = turn;
            this.m_battleField = battleField;

            
            
        }
    }
}
