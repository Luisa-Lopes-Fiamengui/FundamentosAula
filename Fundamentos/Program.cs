using Fundamentos;

internal class Program
{

    private static void Main(string[] args)
    {
        //Aluno aluno1 = new Aluno();
        //aluno1.Nome = "Jacinto Pinto";
        //aluno1.RM = "123456";
        //aluno1.Email = "vaisefudefiadaputa@gmail.com";
        //aluno1.Nascimento = new DateOnly(1981, 07, 17);

        //Console.WriteLine("-------------------------------------------");
        //Console.WriteLine("Aluno 1");
        //Console.WriteLine("Nome: " + aluno1.Nome);

        //Console.WriteLine("RM: " + aluno1.RM);

        //Console.WriteLine("Email: " + aluno1.Email);

        //Console.WriteLine("Nascimento: " + aluno1.Nascimento);

        //Aluno aluno2 = new Aluno();
        //aluno2.Nome = "Ana Maria da Silva";
        //aluno2.RM = "654321";
        //aluno2.Email = "affemariacheiadegraça@gmail.com";
        //aluno2.Nascimento = new DateOnly(2000, 09, 22);

        //Console.WriteLine("-------------------------------------------");
        //Console.WriteLine("Aluno 2");
        //Console.WriteLine("Nome: " + aluno2.Nome);

        //Console.WriteLine("RM: " + aluno2.RM);

        //Console.WriteLine("Email: " + aluno2.Email);

        //Console.WriteLine("Nascimento: " + aluno2.Nascimento);
        //Console.WriteLine("-------------------------------------------");

        //Produto p1 = new Produto();
        //p1.Codigo = 123456;
        //p1.Nome = "coca-cola 2l";
        //p1.Preco = 12.20;
        //p1.Estoque = 69;

        //p1.QuantidadeEstoque();
        //p1.Estoque = 85;

        //p1.QuantidadeEstoque();

        //Console.WriteLine("-------------------------------------------");


        //Carro carro1 = new Carro();
        //carro1.Marca = "Ferrari";
        //carro1.Modelo = "488";
        //carro1.Velocidade = 80;

        //carro1.Acelerar();

        //Console.WriteLine("-------------------------------------------");
        //Console.WriteLine();

        //Pessoa pessoa1 = new Pessoa();
        //pessoa1.Nome = "José";
        //pessoa1.Idade = 20;

        //pessoa1.Envelhecer(5);
        //pessoa1.Envelhecer(2);

        //Console.WriteLine("-------------------------------------------");
        //Console.WriteLine();

        //Funcionario func1 = new Funcionario();
        //func1.Nome = "josé Carlos";
        //func1.Idade = 30;
        //func1.Cargo = "Aprendiz";
        //func1.Salario = 3.000;

        //Animal animal1 = new Animal();
        //animal1.Especie = "Cachorro";
        //animal1.emitirSom();
        //Console.WriteLine("O animal " + animal1.Especie + "emite um som");

        Gato gato1 = new Gato();
        gato1.Nome = "Frajola";
        Console.WriteLine(gato1.Nome + " faz ");
        gato1.emitirSom();

        Console.WriteLine("-------------------------------------------");

        Galinha galinha1 = new Galinha();
        galinha1.Nome = "Ginger";
        Console.WriteLine(galinha1.Nome + " faz ");
        galinha1.emitirSom();

        Console.WriteLine("-------------------------------------------");

        Porco porco1 = new Porco();
        porco1.Nome = "Pedro";
        Console.WriteLine(porco1.Nome + " faz ");
        porco1.emitirSom();

        Console.WriteLine("-------------------------------------------");

        Mago espresso = new Mago();

        espresso.Nome = "Mago Espresso";
        espresso.Vida = 100;
        espresso.Inteligencia = 87;
        espresso.Agilidade = 55;
        espresso.Forca = 62;
        espresso.Nivel = 1;

        Cavalheiro madelena = new Cavalheiro();

        madelena.Nome = "Mago Espresso";
        madelena.Vida = 100;
        madelena.Inteligencia = 33;
        madelena.Agilidade = 40;
        madelena.Forca = 89;
        madelena.Nivel = 1;

        espresso.apresentarse();
        madelena.apresentarse();

        int ataque = madelena.atacar();
        int defesa = madelena.defender();
        Console.WriteLine("Força do Ataque: " + ataque);
        Console.WriteLine("Força do Defesa: " + defesa);
    }
}