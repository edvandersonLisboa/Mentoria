using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O.O
{
    //Polimorfismo
    public class Forma
    {
        public virtual void Desenhar()
        {
            Console.WriteLine("Desenhando uma forma");
        }
        public virtual string cor()
        {
            return "Vermelho";
        }

        public string cantos()
        {
            return "6";
        }

    }

    public class Circulo : Forma
    {
        public override void Desenhar()
        {
            Console.WriteLine("Desenhando um círculo");
        }

        public override string cor()
        {
            return "Azul";
        }
    }

    public class Triangulo : Forma
    {
        public override void Desenhar()
        {
            Console.WriteLine("Desenhando um Triangulo");
        }
        public override string cor()
        {
            return "Verde";
        }
    }
    public class Quadrado : Forma
    {
    
        public override string cor()
        {
            return "Amarelo";
        }
    }
}
