namespace DIO_Lab.src.Entities
{
    public class BlackWizard : Hero
    {
        public BlackWizard(string Name, int Level, string HeroType, int HealthPointsMax, int HealthPointsNow, int MagicPointsMax, int MagicPointsNow)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HealthPointsMax = HealthPointsMax;
            this.HealthPointsNow = HealthPointsNow;
            this.MagicPointsMax = MagicPointsMax;
            this.MagicPointsNow = MagicPointsNow;
        }
        public override string Attack()
        {
            return base.Attack() + " com sua magia das trevas!";
        }
    }
}