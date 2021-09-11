using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    public class Participante
    {
        public List<Baraja> barajas;
        public void AddJugada(List<Baraja> barajas)
        {
            this.barajas = barajas;
        }

    }
}
