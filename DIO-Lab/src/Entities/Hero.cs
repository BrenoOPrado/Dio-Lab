using System;

namespace DIO_Lab.src.Entities
{
    public class Hero
    {
        public string Name;
        public int Level;
        public string HeroType;
        public int HealthPointsMax;
        public int HealthPointsNow;
        public int MagicPointsMax;
        public int MagicPointsNow;

        public Hero(string Name, int Level, string HeroType, int HealthPointsMax, int HealthPointsNow, int MagicPointsMax, int MagicPointsNow)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HealthPointsMax = HealthPointsMax;
            this.HealthPointsNow = HealthPointsNow;
            this.MagicPointsMax = MagicPointsMax;
            this.MagicPointsNow = MagicPointsNow;
        }
        public Hero()
        {
            
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += this.Name + " " + this.HeroType + " Level: " + this.Level + Environment.NewLine;
            retorno += "HP: " + this.HealthPointsNow + " / " + this.HealthPointsMax + Environment.NewLine;
            retorno += "MP: " + this.MagicPointsNow + " / " + this.MagicPointsMax;
            return retorno;
        }
        public virtual string Attack()
        {
            return this.Name + " atacou";
        }
    }
}