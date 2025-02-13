/*Apenas um exercicio de métodos e propiedades que estou estudando*/

Como: 

Parse() - Converte uma String para um tipo específico (Int, Double..);
  Console.WriteLine("Quantos quartos tem na sua casa?");
  int room = int.Parse(Console.ReadLine());

Split() - Divide uma String de acordo com um delimitador => Split( ';') => separa encontrando ; dentro da String;
  string info = Console.ReadLine();
  string[] info2 = info.Split(' ');

E a propiedade:
CultureInfo.InvariantCulture - Serve para padrozinar a formataçao de um número, data ou texto; //Independente da config. regional do sistema;
