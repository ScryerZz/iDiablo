using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iDiablo.Units
{
    class Unit
    {
        private string _name;
        private double _strenght;
        private double _dexterity;
        private double _inteligence;
        private double _vitality;
        private double _health;
        private double _mana;
        private double _physycal_damage;
        private double _armor;
        private double _magic_damage;
        private double _magic_defence;
        private double _crit_chance;
        private double _crit_damage;
        public Unit(string name, double strenght, double dexterity, double inteligence, double vitality,
            double health, double mana, double physycal_damage, double armor, double magic_damage, double magic_defence,
            double crit_chance, double crit_damage)
        {
            _name = name;
            _strenght = strenght;
            _dexterity = dexterity;
            _inteligence = inteligence;
            _vitality = vitality;
            _health = health;
            _mana = mana;
            _physycal_damage = physycal_damage;
            _armor = armor;
            _magic_damage = magic_damage;
            _magic_defence = magic_defence;
            _crit_chance = crit_chance;
            _crit_damage = crit_damage;
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public double Strenght
        {
            get { return _strenght; }
            set { _strenght = value; }
        }

        public double Dexterity
        {
            get { return _dexterity; }
            set { _dexterity = value; }
        }
        public double Inteligence
        {
            get { return _inteligence; }
            set { _inteligence = value; }
        }
        public double Vitality
        {
            get { return _vitality; }
            set { _vitality = value; }
        }
        public double Health
        {
            get { return _health; }
            set { _health = value; }
        }
        public double Mana
        {
            get { return _mana; }
            set { _mana = value; }
        }
        public double PhysycalDamage
        {
            get { return _physycal_damage; }
            set { _physycal_damage = value; }
        }
        public double Armor
        {
            get { return _armor; }
            set { _armor = value; }
        }
        public double MagicDamage
        {
            get { return _magic_damage; }
            set { _magic_damage = value; }
        }
        public double MagicDefence
        {
            get { return _magic_defence; }
            set { _magic_defence = value; }
        }
        public double CritChance
        {
            get { return _crit_chance; }
            set { _crit_chance = value; }
        }
        public double CritDamage
        {
            get { return _crit_damage; }
            set { _crit_damage = value; }
        }
    }
}
