﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HearthstoneKillerApp
{
    class Card
    {
        private string type;
        private string name;
        private int manacost;
        private string klasse;
        private int attack;
        private int durability;
        private string race;
        public string Type { get { return type; } set { type = value; } }
        public string Name { get { return name; } set { name = value; } }
        public int Manacost { get { return manacost; } set { manacost = value; } }
        public string Klasse { get { return klasse; } set { klasse = value; } }
        public int Attack { get { return attack; } set { attack = value; } }
        public int Durability { get { return durability; } set { durability = value; } }
        public string Race { get { return race; } set { race = value; } }

        public override string ToString()
        {
            return type + " [" + manacost + "] - " + name + " - " + klasse + " - " + race;
        }
    }
}
