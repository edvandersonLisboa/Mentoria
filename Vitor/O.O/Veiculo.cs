using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O.O
{
    // classes abstratas
    abstract class Veiculo
    {
        public abstract void Mover();
        public abstract void Parar();

        public void Ligar()
        {
            Console.WriteLine("O veículo está ligado");
        }
    }
    class Carro : Veiculo
    {
        public override void Mover()
        {
            Console.WriteLine("O carro está se movendo");
        }

        public override void Parar()
        {
            throw new NotImplementedException();
        }
    }
}
