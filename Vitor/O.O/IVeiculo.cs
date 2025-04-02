using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O.O
{
    public interface IVeiculo
    {
        
        void Mover();
        public void roda()
        {
            throw new NotImplementedException();
        }

    }
    public class Moto : IVeiculo
    {
        public void Mover()
        {
            throw new NotImplementedException();
        }
    }
}
