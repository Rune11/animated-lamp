using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinRpg.Model
{

    public class Character
    {

        #region Properties

        public string Name { get; set; }
        public int Str { get; set; }
        public int Agi { get; set; }
        public int End { get; set; }
        public int Intel { get; set; }
        public int Wis { get; set; }
        public int MaxHP { get; set; }
        public int CurrHP { get; set; }
        public int Lvl { get; set; }
        public int Xp { get; set; }
        public Inventory Inv { get; set; }

        #endregion

        #region Constructor
        // Contructor for new character
        public Character(string charName) {
            Name = charName;
            Str = 0;
            Agi = 0;
            End = 0;
            Intel = 1;
            Wis = 0;
            MaxHP = 100;
            CurrHP = MaxHP;
            Lvl = 1;
            Xp = 0;
            Inv = new Inventory();
        }

        

        // Constructor for loading an existing character
        // most likely we wont need that constructror
        /*
        public Character(string name, int str, int agi, int end, int intel, int wis) {
            Name = name;
            Strength = str;
            Agility = agi;
            Endurance = end;
            Intelligence = intel;
            Wisdom = wis;
        }*/
        #endregion

        #region Public functions

        #endregion


    }
}
