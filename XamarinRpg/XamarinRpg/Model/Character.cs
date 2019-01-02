using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinRpg.Model
{
    class Character
    {
        private string Name;
        private int Strength;
        private int Agility;
        private int Endurance;
        private int Intelligence;
        private int Wisdom;

        #region Constructor
        // Contructor for new character
        public Character(string name) {
            Name = name;
        }

        public Character(string name, int str, int agi, int end, int intel, int wis) {
            Name = name;
            Strength = str;
            Agility = agi;
            Endurance = end;
            Intelligence = intel;
            Wisdom = wis;
        }
        #endregion

        #region Public functions

        #endregion


    }
}
