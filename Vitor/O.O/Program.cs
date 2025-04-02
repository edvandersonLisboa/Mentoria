using O.O;

Console.WriteLine("Hello, World!");
Pessoa p = new Pessoa() { Nome = "João", Idade = 25 };
Console.WriteLine(p.Nome);


Animal animal = new Animal("Rex", 5, "masculino");
animal.EmitirSom();

Cachorro cachorro = new Cachorro();
cachorro.Nome = "Rex";
cachorro.Idade = 5;
cachorro.Sexo = "masculino";
cachorro.TipoDeRaça = "Vira-lata";

Cachorro cachorro2 = new Cachorro("Rex", "masculino", 5);

cachorro.EmitirSom();

Papagaio papagaio = new Papagaio();
papagaio.Nome = "Loro";
papagaio.Idade = 2;
papagaio.Sexo = "feminino";
papagaio.TipoDePena = "Azul";
papagaio.EmitirSom();
papagaio.Miado();


Papagaio papagaio2 = new Papagaio("Loro", 2, "f");
Ave  papagaio32 = new Papagaio("Loro", 2, "f");
papagaio32.cantar();
papagaio32.fala();
papagaio

IAve ave = new Papagaio("Loro", 2, "f");
ave.voar();
ave.Miado();
IMamifero mamifero = new Papagaio("Rex",2, "masculino");
mamifero.Amamentar();


var calculo = Calculadora.Subtrair(1, 2);

var calculo2 = Calculadora.Subtrair(1, 2);  



