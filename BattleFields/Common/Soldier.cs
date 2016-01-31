using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HikariX3X.BlackMoon.BattleFields
{
    internal class Soldier
    {
        #region Name

        protected string m_name;
        public string Name
        {
            set
            {
                m_name = value;
            }
        }

        protected string m_displayName;
        string DisplayName
        {
            get
            {
                if (m_displayName == null)
                {
                    m_displayName = m_name;
                }
                return m_displayName;
            }
        }

        public Soldier(string name)
        {
            this.Name = name;
        }

        #endregion
    }
}
