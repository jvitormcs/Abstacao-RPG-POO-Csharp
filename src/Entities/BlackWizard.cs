namespace Astração_de_um_RPG_com_POO.src.Entities
{
    public class BlackWizard : Hero
    {
        public BlackWizard(string Name, int Level, string HeroType){
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public override string Attack(){
            return this.Name + " Lançou sua magia negra";
        
        }

        public override string Attack(int Bonus){

            if (Bonus > 6){
                return this.Name + " Lançou sua magia negra - Super Efetiva com bonus de " + Bonus;
            } else{
                return this.Name + " Lançou uma magia negra com força fraca com bonus de " + Bonus;
            }

        }
    }
}