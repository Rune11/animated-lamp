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
            Strength = 0;
            Agility = 0;
            Endurance = 0;
            Intelligence = 1;
            Wisdom = 0;
        }

        // Constructor for loading an existing character
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
