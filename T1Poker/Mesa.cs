using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    public class Mesa
    {
        public List<Baraja> jugada = new List<Baraja>();
        public void AddBaraja(Baraja carta)
        {
            jugada.Add(carta);
        }
        public Juego ObtenerLaJugadadeParticiapante()
        {
            if (TieneCartasConsecutivasDelMismoPaloYEmpiezaEn10())
            {
                return new Juego { Valor = 9, Nombre = "Flor Imperial" };
            }
            if(TieneCartasConsecutivasDelMismoPalo())
            {
                return new Juego { Valor = 8, Nombre = "Escalera Color" };
            }
            if (TieneCuatroCartasIguales())
            {
                return new Juego { Valor = 7, Nombre = "Poker" };
            }
            if(TieneUnParYUnTrio())
            {
                return new Juego { Valor = 6, Nombre = "Full" };
            }
            if(HayCincoCartasConcecutivas())
            {
                return new Juego { Valor = 5, Nombre = "Escalera" };
            }
            if(TieneSoloTresCartasIguales())
            {
                return new Juego { Valor = 4, Nombre = "Trio"};
            }
            // Si hay dos pares de cartas iguales
            if(TieneUnParDeCartasIguales())
            {
                return new Juego { Valor = 3, Nombre = "Dos Dobles" };
            }
            // si hay dos cartas iguales es un doble
            if(TieneSoloDosCartasIguales())
            {
                return new Juego { Valor = 2, Nombre = "Un Doble" };
            }
            return new Juego { Valor = 1, Nombre = "Carta Alta" };
        }

        private bool TieneCartasConsecutivasDelMismoPaloYEmpiezaEn10()
        {
            var numeroDeCartasConsecutivas = 1;
            var cartasOrdenadas = jugada.OrderBy(o => o.Valor).ToList();
            for (var i = 0; i < cartasOrdenadas.Count() - 1; i++)
            {
                if ((cartasOrdenadas.ElementAt(i).Valor + 1 == cartasOrdenadas.ElementAt(i + 1).Valor) &&
                    (cartasOrdenadas.ElementAt(i).Palo == cartasOrdenadas.ElementAt(i + 1).Palo))
                    numeroDeCartasConsecutivas++;
            }
            return numeroDeCartasConsecutivas == 5 && cartasOrdenadas.ElementAt(0).Valor == 10;
        }

        private bool TieneCartasConsecutivasDelMismoPalo()
        {
            var numeroDeCartasConsecutivas = 1;
            var cartasOrdenadas = jugada.OrderBy(o => o.Valor).ToList();
            for (var i = 0; i < cartasOrdenadas.Count() - 1; i++)
            {
                if ((cartasOrdenadas.ElementAt(i).Valor + 1 == cartasOrdenadas.ElementAt(i + 1).Valor) &&
                    (cartasOrdenadas.ElementAt(i).Palo == cartasOrdenadas.ElementAt(i + 1).Palo))
                    numeroDeCartasConsecutivas++;
            }
            return numeroDeCartasConsecutivas == 5;
        }

        private bool TieneCuatroCartasIguales()
        {
            return GetNumeroDeColectivos(4) == 1;
        }

        private bool TieneUnParYUnTrio()
        {           
            return TieneSoloTresCartasIguales() && TieneSoloDosCartasIguales();
        }
    

        private bool HayCincoCartasConcecutivas()
        {
            var numeroDeCartasConsecutivas = 1;
            var cartasOrdenadas = jugada.OrderBy(o => o.Valor).ToList();
            for(var i = 0; i < cartasOrdenadas.Count() - 1; i++)
            {
                numeroDeCartasConsecutivas += (cartasOrdenadas.ElementAt(i).Valor + 1) == cartasOrdenadas.ElementAt(i + 1).Valor ? 1: 0;
            }
            return numeroDeCartasConsecutivas == 5;
        }

        private bool TieneSoloTresCartasIguales()
        {
            return GetNumeroDeColectivos(3) == 1;

        }

        private bool TieneUnParDeCartasIguales()
        {
            return GetNumeroDeColectivos(2) == 2;
        }

        private bool TieneSoloDosCartasIguales()
        {
            return GetNumeroDeColectivos(2) == 1;
        }       


        private int GetNumeroDeColectivos(int colectivosDe)
        {            
            var numerodeColectivos = 0;

            for (var valor = 1; valor <= 14; valor++)
            {
                var numCartasIguales = 0;
                for (var j = 0; j < jugada.Count(); j++)
                {
                    var carta = jugada.ElementAt(j);
                    if (carta.Valor == valor)
                        numCartasIguales++;
                }

                if (numCartasIguales == colectivosDe)
                    numerodeColectivos++;

            }
            return numerodeColectivos;
        }
    }
}
