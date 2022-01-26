using Astração_de_um_RPG_com_POO.src.Entities;

namespace Astração_de_um_RPG_com_POO

{
    public class Program
    {
        static void Main(string[] args){
            
            Knight arus = new Knight("Arus", 23, "knight");
            Wizard jennica = new Wizard("Jennica", 23, "White Wizard");
            Ninja wedge = new Ninja("Wedge", 23, "Ninja");
            BlackWizard topapa = new BlackWizard("Topapa", 23, "Black Wizard");

             Console.WriteLine(arus.Attack(5));
             Console.WriteLine(jennica.Attack(9));
             Console.WriteLine(wedge.Attack(7));
             Console.WriteLine(topapa.Attack(3));

        }
    }
}