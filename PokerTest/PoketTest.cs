using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace T1.Test
{


    [TestFixture]
    class PoketTest
    {



        private Mesa juego = new Mesa();

        

        [Test]
        public void ManoDePokerEsBarajaAlta()
        {
            //Act
            juego.AddBaraja(new Baraja { Valor = 1, Palo = "Corazon" });
            juego.AddBaraja(new Baraja { Valor = 3, Palo = "Diamante" });
            juego.AddBaraja(new Baraja { Valor = 5, Palo = "Corazon" });
            juego.AddBaraja(new Baraja { Valor = 7, Palo = "Trebol" });
            juego.AddBaraja(new Baraja { Valor = 9, Palo = "Corazon" });

            //Assert
            Assert.AreEqual("Baraja Alta", juego.ObtenerLaJugadadeParticiapante().Nombre);
        }

        [Test]
        public void ManoDePokerTieneUnDobleDeAses()
        {
            //Act
            juego.AddBaraja(new Baraja { Valor = 1, Palo = "Corazon" });
            juego.AddBaraja(new Baraja { Valor = 1, Palo = "Diamante" });

            juego.AddBaraja(new Baraja { Valor = 5, Palo = "Corazon" });
            juego.AddBaraja(new Baraja { Valor = 7, Palo = "Trebol" });
            juego.AddBaraja(new Baraja { Valor = 9, Palo = "Corazon" });

            //Assert
            Assert.AreEqual("Un Doble", juego.ObtenerLaJugadadeParticiapante().Nombre);
        }

        [Test]
        public void ManoDePokerTieneUnDobleTreces()
        {
            //Act
            juego.AddBaraja(new Baraja { Valor = 1, Palo = "Corazon" });
            juego.AddBaraja(new Baraja { Valor = 13, Palo = "Diamante" });

            juego.AddBaraja(new Baraja { Valor = 5, Palo = "Corazon" });
            juego.AddBaraja(new Baraja { Valor = 13, Palo = "Trebol" });
            juego.AddBaraja(new Baraja { Valor = 9, Palo = "Corazon" });

            //Assert
            Assert.AreEqual("Un Doble", juego.ObtenerLaJugadadeParticiapante().Nombre);
        }

        [Test]
        public void ManoDePokerTieneUnParDeDoblesAsesYTreces()
        {
            //Act
            juego.AddBaraja(new Baraja { Valor = 1, Palo = "Corazon" });
            juego.AddBaraja(new Baraja { Valor = 13, Palo = "Diamante" });

            juego.AddBaraja(new Baraja { Valor = 5, Palo = "Corazon" });
            juego.AddBaraja(new Baraja { Valor = 13, Palo = "Trebol" });
            juego.AddBaraja(new Baraja { Valor = 1, Palo = "Diamante" });

            //Assert
            Assert.AreEqual("Dos Dobles", juego.ObtenerLaJugadadeParticiapante().Nombre);
        }

        [Test]
        public void ManoDePokerTieneUnTrioDeAses()
        {
            //Act
            juego.AddBaraja(new Baraja { Valor = 1, Palo = "Corazon" });
            juego.AddBaraja(new Baraja { Valor = 13, Palo = "Diamante" });

            juego.AddBaraja(new Baraja { Valor = 5, Palo = "Corazon" });
            juego.AddBaraja(new Baraja { Valor = 1, Palo = "Trebol" });
            juego.AddBaraja(new Baraja { Valor = 1, Palo = "Diamante" });

            //Assert
            Assert.AreEqual("Trio", juego.ObtenerLaJugadadeParticiapante().Nombre);
        }

        [Test]
        public void ManoDePokerTieneUnaEscalera()
        {
            //Act
            juego.AddBaraja(new Baraja { Valor = 1, Palo = "Corazon" });
            juego.AddBaraja(new Baraja { Valor = 3, Palo = "Diamante" });

            juego.AddBaraja(new Baraja { Valor = 2, Palo = "Corazon" });
            juego.AddBaraja(new Baraja { Valor = 4, Palo = "Trebol" });
            juego.AddBaraja(new Baraja { Valor = 5, Palo = "Diamante" });

            //Assert
            Assert.AreEqual("Escalera", juego.ObtenerLaJugadadeParticiapante().Nombre);
        }

        [Test]
        public void ManoDePokerTieneFullHouse()
        {
            //Act
            juego.AddBaraja(new Baraja { Valor = 1, Palo = "Corazon" });
            juego.AddBaraja(new Baraja { Valor = 1, Palo = "Diamante" });

            juego.AddBaraja(new Baraja { Valor = 1, Palo = "Trebol" });
            juego.AddBaraja(new Baraja { Valor = 13, Palo = "Trebol" });
            juego.AddBaraja(new Baraja { Valor = 13, Palo = "Diamante" });

            //Assert
            Assert.AreEqual("Full", juego.ObtenerLaJugadadeParticiapante().Nombre);
        }

        [Test]
        public void ManoDePokerTienePoker()
        {
            //Act
            juego.AddBaraja(new Baraja { Valor = 1, Palo = "Corazon" });
            juego.AddBaraja(new Baraja { Valor = 1, Palo = "Diamante" });

            juego.AddBaraja(new Baraja { Valor = 1, Palo = "Trebol" });
            juego.AddBaraja(new Baraja { Valor = 1, Palo = "Espada" });
            juego.AddBaraja(new Baraja { Valor = 13, Palo = "Diamante" });

            //Assert
            Assert.AreEqual("Poker", juego.ObtenerLaJugadadeParticiapante().Nombre);
        }

        [Test]
        public void ManoDePokerTieneEscaleraColor()
        {
            //Act
            juego.AddBaraja(new Baraja { Valor = 1, Palo = "Corazon" });
            juego.AddBaraja(new Baraja { Valor = 2, Palo = "Corazon" });

            juego.AddBaraja(new Baraja { Valor = 3, Palo = "Corazon" });
            juego.AddBaraja(new Baraja { Valor = 4, Palo = "Corazon" });
            juego.AddBaraja(new Baraja { Valor = 5, Palo = "Corazon" });

            //Assert
            Assert.AreEqual("Escalera Color", juego.ObtenerLaJugadadeParticiapante().Nombre);
        }

        [Test]
        public void ManoDePokerTieneEscaleraReal()
        {
            //Act
            juego.AddBaraja(new Baraja { Valor = 10, Palo = "Corazon" });
            juego.AddBaraja(new Baraja { Valor = 11, Palo = "Corazon" });

            juego.AddBaraja(new Baraja { Valor = 12, Palo = "Corazon" });
            juego.AddBaraja(new Baraja { Valor = 13, Palo = "Corazon" });
            juego.AddBaraja(new Baraja { Valor = 14, Palo = "Corazon" });

            //Assert
            Assert.AreEqual("Flor Imperial", juego.ObtenerLaJugadadeParticiapante().Nombre);
        }








    }
}
