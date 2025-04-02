// See https://aka.ms/new-console-template for more information
using Exercicios.Aulas.Aula01;
using Exercicios.ContaBancaria;

Console.WriteLine("Hello, World!");


Produto produto1 = new Produto("caixote");

var produto2 = new Produto("canaleta", 10.0M);

//produto2.addCategoria("material de construção");
//produto2.addCategoria("material");
//produto2.addCategoria("material");

//produto2.Categorias.ForEach(c => Console.WriteLine(c));

var carrinho = new Carrinho("carrinho de corrida",10.00M,"roxo","aro 18");
carrinho.addCategoria("Brinquedo");
carrinho.Funcionalidade();

carrinho._preco = 10.0M;
carrinho.addCategoria("catal");

ContaBancaria conta1 = new ContaBancaria();




