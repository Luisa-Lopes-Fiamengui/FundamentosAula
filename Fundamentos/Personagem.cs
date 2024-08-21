using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos
{
    public class Personagem
    {
        public string? Nome { get; set; }
        public int Nivel { get; set; }
        public int Forca { get; set; }
        public int Agilidade { get; set; }
        public int Inteligencia { get; set; }
        public int Vida { get; set; }

        public virtual void apresentarse() { }
        public virtual void evoluir()
        {
            this.Nivel += 2;
            this.Forca += 2;
            this.Inteligencia += 2;
            this.Agilidade += 2;
            Console.WriteLine("O jogador " + this.Nome + " evoluiu para o nível " + this.Nivel + ". Seus novos valores são: \nAgilidade: " + this.Agilidade + "\nInteligência: " + this.Inteligencia + "\nForça: " + this.Forca);
        }
        public virtual int atacar()
        {
            int pontosAtacar = 0;
            pontosAtacar = (this.Inteligencia + this.Forca + (this.Agilidade) + this.Nivel) / 10;
            return pontosAtacar;
        }
        public virtual int defender()
        {
            int pontosDefesa = 0;
            pontosDefesa = (this.Inteligencia + this.Forca + this.Agilidade + this.Nivel + this.Vida) / 5;
            return pontosDefesa;
        }
        public virtual void batalhar(Personagem p)
        {
            bool vencedor = false;
            while (vencedor == true) ;

            int valorAtaque = this.atacar();
            int valorDefesaInimigo = p.defender();
            int danoDeVida = valorAtaque - valorDefesaInimigo;
            if (danoDeVida <= 0)
            {
                danoDeVida = 1;
            }
            p.Vida = p.Vida - danoDeVida;
            Console.WriteLine("Dano na Vida do Inimigo em " + danoDeVida);
            Console.WriteLine("O nível de vida do Inimigo agora é " + p.Vida);

            int valorAtaqueInimigo = p.atacar();
            int valorDefesa = this.defender();
            int danoDeVida2 = valorAtaqueInimigo - valorDefesa;
            if (danoDeVida2 <= 0)
            {
                danoDeVida2 = 1;
            }
            this.Vida = this.Vida - danoDeVida2;
            Console.WriteLine("Dano na Vida do Atacante em " + danoDeVida2);
            Console.WriteLine("O nível de vida do Atacante agora é " + this.Vida);
            Console.WriteLine("-------------------------------------------");

            if (this.Vida <= 0)
            {
                Console.WriteLine("O personagem " + p.Nome + " venceu!");
                vencedor = true;
                p.evoluir();

                if (p.Vida <= 0)
                {
                    Console.WriteLine("O personagem " + this.Nome + " venceu!");
                    vencedor = true;
                    this.evoluir();
                }
            }

        }
    }
}
