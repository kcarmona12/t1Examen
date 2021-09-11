using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace T1.Test
{



    class PoketTest
    {



        private Mesa juego = new Mesa();

        

        [Test]
        public void caso01()
        {
            //Act
            juego.AddBaraja(new Baraja { Valor = 1, Palo = "Corazon" });
            juego.AddBaraja(new Baraja { Valor = 3, Palo = "Diamante" });
            juego.AddBaraja(new Baraja { Valor = 5, Palo = "Corazon" });
            juego.AddBaraja(new Baraja { Valor = 7, Palo = "Trebol" });
            juego.AddBaraja(new Baraja { Valor = 9, Palo = "Corazon" });

            //Assert
            Assert.AreEqual("Carta Alta", juego.ObtenerLaJugadadeParticiapante().Nombre);
        }

        [Test]
        public void caso2()
        {
            //Act
            juego.AddBaraja(new Baraja { Valor = 1, Palo = "Corazon" });
            juego.AddBaraja(new Baraja { Valor = 1, Palo = "Diamante" });

            juego.AddBaraja(new Baraja { Valor = 5, Palo = "Corazon" });
            juego.AddBaraja(new Baraja { Valor = 7, Palo = "Trebol" });
            juego.AddBaraja(new Baraja { Valor = 9, Palo = "Corazon" });

            //Assert
            Assert.AreEqual("Trio", juego.ObtenerLaJugadadeParticiapante().Nombre);
        }

        [Test]
        public void caso3()
        {
            //Act
            juego.AddBaraja(new Baraja { Valor = 1, Palo = "Corazon" });
            juego.AddBaraja(new Baraja { Valor = 13, Palo = "Diamante" });

            juego.AddBaraja(new Baraja { Valor = 5, Palo = "Corazon" });
            juego.AddBaraja(new Baraja { Valor = 13, Palo = "Trebol" });
            juego.AddBaraja(new Baraja { Valor = 9, Palo = "Corazon" });

            //Assert
            Assert.AreEqual("Escalera Color", juego.ObtenerLaJugadadeParticiapante().Nombre);
        }

        [Test]
        public void caso4()
        {
            //Act
            juego.AddBaraja(new Baraja { Valor = 1, Palo = "Corazon" });
            juego.AddBaraja(new Baraja { Valor = 13, Palo = "Diamante" });

            juego.AddBaraja(new Baraja { Valor = 5, Palo = "Corazon" });
            juego.AddBaraja(new Baraja { Valor = 13, Palo = "Trebol" });
            juego.AddBaraja(new Baraja { Valor = 1, Palo = "Diamante" });

            //Assert
            Assert.AreEqual("Escalera Color", juego.ObtenerLaJugadadeParticiapante().Nombre);
        }

        [Test]
        public void caso5()
        {
            //Act
            juego.AddBaraja(new Baraja { Valor = 1, Palo = "Corazon" });
            juego.AddBaraja(new Baraja { Valor = 13, Palo = "Diamante" });

            juego.AddBaraja(new Baraja { Valor = 5, Palo = "Corazon" });
            juego.AddBaraja(new Baraja { Valor = 1, Palo = "Trebol" });
            juego.AddBaraja(new Baraja { Valor = 1, Palo = "Diamante" });

            //Assert
            Assert.AreEqual("Escalera Color", juego.ObtenerLaJugadadeParticiapante().Nombre);
        }

        [Test]
        public void caso6()
        {
            //Act
            juego.AddBaraja(new Baraja { Valor = 1, Palo = "Corazon" });
            juego.AddBaraja(new Baraja { Valor = 3, Palo = "Diamante" });

            juego.AddBaraja(new Baraja { Valor = 2, Palo = "Corazon" });
            juego.AddBaraja(new Baraja { Valor = 4, Palo = "Trebol" });
            juego.AddBaraja(new Baraja { Valor = 5, Palo = "Diamante" });

            //Assert
            Assert.AreEqual("Trio", juego.ObtenerLaJugadadeParticiapante().Nombre);
        }

        [Test]
        public void caso7()
        {
            //Act
            juego.AddBaraja(new Baraja { Valor = 1, Palo = "Corazon" });
            juego.AddBaraja(new Baraja { Valor = 1, Palo = "Diamante" });

            juego.AddBaraja(new Baraja { Valor = 1, Palo = "Trebol" });
            juego.AddBaraja(new Baraja { Valor = 13, Palo = "Trebol" });
            juego.AddBaraja(new Baraja { Valor = 13, Palo = "Diamante" });

            //Assert
            Assert.AreEqual("Escalera Color", juego.ObtenerLaJugadadeParticiapante().Nombre);
        }

        [Test]
        public void caso8()
        {
            //Act
            juego.AddBaraja(new Baraja { Valor = 1, Palo = "Corazon" });
            juego.AddBaraja(new Baraja { Valor = 1, Palo = "Diamante" });

            juego.AddBaraja(new Baraja { Valor = 1, Palo = "Trebol" });
            juego.AddBaraja(new Baraja { Valor = 1, Palo = "Espada" });
            juego.AddBaraja(new Baraja { Valor = 13, Palo = "Diamante" });

            //Assert
            Assert.AreEqual("Escalera Color", juego.ObtenerLaJugadadeParticiapante().Nombre);
        }

        [Test]
        public void caso9()
        {
            //Act
            juego.AddBaraja(new Baraja { Valor = 1, Palo = "Corazon" });
            juego.AddBaraja(new Baraja { Valor = 2, Palo = "Corazon" });

            juego.AddBaraja(new Baraja { Valor = 3, Palo = "Corazon" });
            juego.AddBaraja(new Baraja { Valor = 4, Palo = "Corazon" });
            juego.AddBaraja(new Baraja { Valor = 5, Palo = "Corazon" });

            //Assert
            Assert.AreEqual("Carta Alta", juego.ObtenerLaJugadadeParticiapante().Nombre);
        }

        [Test]
        public void caso10()
        {
            //Act
            juego.AddBaraja(new Baraja { Valor = 10, Palo = "Corazon" });
            juego.AddBaraja(new Baraja { Valor = 11, Palo = "Corazon" });

            juego.AddBaraja(new Baraja { Valor = 12, Palo = "Corazon" });
            juego.AddBaraja(new Baraja { Valor = 13, Palo = "Corazon" });
            juego.AddBaraja(new Baraja { Valor = 14, Palo = "Corazon" });

            //Assert
            Assert.AreEqual("Carta Alta", juego.ObtenerLaJugadadeParticiapante().Nombre);
        }








    }
}
