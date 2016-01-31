using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HikariX3X.BlackMoon.BattleFields.CHSChess
{
    internal class CHSChessPosition
    {
        #region Attribute
        private uint X;
        private uint Y;

        public string XName
        {
            get
            {
                return X.ToString();
            }
        }
        public string YName
        {
            get
            {
                return Y.ToString();
            }
        }

        public string PositionName
        {
            get
            {
                return "(" + XName + "," + YName + ")";
            }
        }
        #endregion

        #region Initialize
        private CHSChessPosition()
        {
        }
        public CHSChessPosition(uint x, uint y)
        {
            if (x > 8 || y > 8)
            {
                throw new ArgumentNullException();
            }
            else
            {
                this.X = x;
                this.Y = y;
            }
        }
        #endregion

        public override bool Equals(object obj)
        {
            if (obj is CHSChessPosition)
            {
                CHSChessPosition that = (CHSChessPosition)obj;
                return that.X == this.X && that.Y == this.Y;
            }
            else
            {
                return base.Equals(obj);
            }
        }
        public override bool Equals(int a, int b)
        {
            return a == this.X && b == this.Y;
        }
    }
}
