namespace Astração_de_um_RPG_com_POO.src.Entities
{
    public abstract class Hero
    {   
        public Hero(string Name, int Level, string HeroType){
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public Hero(){

        }
        public string Name;
        public int Level;
        public string HeroType;


        public override string ToString(){

            return this.Name + " " + this.Level + " " + this.HeroType;

        }

        public virtual string Attack(){
            return this.Name + " Atacou usando a espada";
        
        }

        public virtual string Attack(int Bonus){
            if (Bonus > 6){
                return this.Name + " Atacou com a espada - Super Efetiva com bonus de " + Bonus;
            } else{
                return this.Name + " Atacou com a espada com força fraca com bonus de " + Bonus;
            }
        }

    }
}