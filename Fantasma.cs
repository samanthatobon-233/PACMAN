using DocumentFormat.OpenXml.Drawing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PACMAN
{
    class Fantasma
    {
        public string nombre;
        public string color;
        public int velocidad;
        public int vidas;

        public void Aparecer()
        {
            Console.WriteLine($"Fantasma {color} Aparece en pantalla...!");
        }

        public void Acelerar(int acelera)
        {
            velocidad += acelera;
            Console.WriteLine($"Fantasma esta acelerando!!! Velocidad actual {velocidad}");
        }

        public void Morir()
        {
            this.vidas--;
            if (this.vidas == 0)
                Console.WriteLine($"GAME OVER del Fantasma {color}");
            else if (this.vidas > 0)
            {
                Console.WriteLine($"Fantasma {color} pierde una vida. Vidas actuales: {this.vidas}");
            }
        }

        public Fantasma(string nombre, string color, int velocidad, int vidas)
        {
            this.nombre = nombre;
            this.color = color;
            this.velocidad = velocidad;
            this.vidas = vidas;
            this.MostrarInformacion();
        }

        public Fantasma(string color, int vidas)
        {
            this.color = color;
            this.vidas = vidas;
            this.nombre = "NONE";
            this.velocidad = 5;
            this.MostrarInformacion();
        }

        public Fantasma()
        {
            this.nombre = "NONE";
            this.color = "NONE";
            this.velocidad = 5;
            this.vidas = 3;
        }

        public void MostrarInformacion()
        {
            ConsoleColor originalColor = Console.ForegroundColor;

            switch (color.ToUpper())
            {
                case "ROJO":
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case "AZUL":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case "AMARILLO":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }

            Console.WriteLine($"Informacion Fantasma {color}");
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Velocidad: {velocidad}");
            Console.WriteLine($"Vida: {vidas}");
            Aparecer();

            Console.ForegroundColor = originalColor; // Restore original color
        }
    }
}