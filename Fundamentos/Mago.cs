﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos
{
    public class Mago : Personagem
    {

        public override void apresentarse()
        {
            Console.WriteLine("Olá, eu sou o Mago " + this.Nome + " tenho " + this.Vida + "pontos de vida. Inteligencia: " + this.Inteligencia + ", Agilidade: " + this.Agilidade + ", Força: " + this.Forca + "e meu nível é: " + this.Nivel);
        }



    }
}
