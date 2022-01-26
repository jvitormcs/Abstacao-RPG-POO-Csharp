namespace Astração_de_um_RPG_com_POO.src.Entities
{
    public class Ninja : Hero
    {
        public Ninja(string Name, int Level, string HeroType){
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public override string Attack(){
            return this.Name + " Lançou sua shuriken";
        
        }

        public override string Attack(int Bonus){

            if (Bonus > 6){
                return this.Name + " Lançou sua shuriken - Super Efetiva com bonus de " + Bonus;
            } else{
                return this.Name + " Lançou uma shuriken com força fraca com bonus de " + Bonus;
            }

        }
    }
}