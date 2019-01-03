using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinRpg.Model
{
    [System.Runtime.Serialization.DataContract]
    public class Character
    {
        #region private data
        [System.Runtime.Serialization.DataMember]
        private string Name;

        [System.Runtime.Serialization.DataMember]
        private int Strength;

        [System.Runtime.Serialization.DataMember]
        private int Agility;

        [System.Runtime.Serialization.DataMember]
        private int Endurance;

        [System.Runtime.Serialization.DataMember]
        private int Intelligence;

        [System.Runtime.Serialization.DataMember]
        private int Wisdom;

        [System.Runtime.Serialization.DataMember]
        private int MaxHP;

        [System.Runtime.Serialization.DataMember]
        private int CurrentHP;
        #endregion

        #region Constructor
        // Contructor for new character
        public Character(string name) {
            Name = name;
            Strength = 0;
            Agility = 0;
            Endurance = 0;
            Intelligence = 1;
            Wisdom = 0;
            MaxHP = 100;
            CurrentHP = MaxHP;
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
