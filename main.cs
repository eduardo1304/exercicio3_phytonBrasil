using System;
using System.Globalization;
using System.IO;
using System.Dynamic;
using System.Text;

class MainClass {
  public static void Main (string[] args) {
    
    Console.WriteLine ("Digite o seu nome ");
    string nome = Console.ReadLine();

    while (nome.Length <= 3) {
      Console.WriteLine ("incorreto ");
      Console.WriteLine ("Digite o seu nome ");
      nome = Console.ReadLine();
    }

    Console.WriteLine("Digite a sua idade: ");
    int idade = int.Parse(Console.ReadLine());

    while (idade < 0 || idade > 150) {
      Console.WriteLine ("Incorreto ");
      Console.WriteLine("Digite novamente a sua idade: ");
      idade = int.Parse(Console.ReadLine());
    }

    Console.WriteLine ("Digite o seu salário ");
    float salario = float.Parse(Console.ReadLine());

    while (salario <= 0){
      Console.WriteLine ("Incorreto");
      Console.WriteLine ("Digite novamente o seu salário: ");
      salario = float.Parse(Console.ReadLine());  
    }


Console.WriteLine ("Digite o seu sexo 'm' para masculino e 'f' feminino: ");
char sexo = char.Parse(Console.ReadLine());
sexo = char.ToUpper(sexo); 
 

while (sexo != 'M' && sexo != 'F'){
  
  Console.WriteLine ("Incorreto");
  Console.WriteLine ("Digite o seu sexo 'm' para masculino e 'f' feminino: ");
sexo = char.Parse(Console.ReadLine());
sexo = char.ToUpper(sexo);

}


Console.WriteLine ("Digite a primeira letra do seu estado civil: ");
char estado_civil = char.Parse(Console.ReadLine());
estado_civil = char.ToUpper(estado_civil);



while(estado_civil != 'C' && estado_civil != 'S' && estado_civil != 'V' && estado_civil != 'D'){

Console.WriteLine ("Incorreto");
Console.WriteLine ("Digite a primeira letra do seu estado civil: ");
estado_civil = char.Parse(Console.ReadLine());
estado_civil = char.ToUpper(estado_civil);

}

  }
}