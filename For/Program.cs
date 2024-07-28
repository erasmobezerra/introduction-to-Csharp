/*
// Escrever uma instrução for básica
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}


//Alterar as condições da iteração
for (int i = 10; i >= 0; i--)
{
    Console.WriteLine(i);
}

//Faça experimentos com o padrão do iterador
for (int i = 0; i < 10; i += 3)
{
    Console.WriteLine(i);
}

// Usar a palavra-chave break para interromper a instrução de iteração
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
    if (i == 7) break;
}


//Percorrer cada elemento de uma matriz
string[] names = { "Alex", "Eddie", "David", "Michael" };
for (int i = names.Length - 1; i >= 0; i--)
{
    Console.WriteLine(names[i]);
}


//Examinar as limitações da instrução foreach
string[] names = { "Alex", "Eddie", "David", "Michael" };
foreach (var name in names)
{
    // Can't do this:
    if (name == "David") name = "Sammy";
}


//Como superar a limitação da instrução foreach usando a instrução for
string[] names = { "Alex", "Eddie", "David", "Michael" };
for (int i = 0; i < names.Length; i++)
    if (names[i] == "David") 
        names[i] = "Sammy";

foreach (var name in names) 
    Console.WriteLine(name);

*/



/* 
Desafio de código – implementar as regras do desafio FizzBuzz
Aqui estão as regras do FizzBuzz que você precisa implementar em seu projeto de código:

Valores de saída de 1 a 100, um número por linha, dentro do bloco de código de uma instrução de iteração.
Quando o valor atual é divisível por 3, imprima o termo Fizz ao lado do número.
Quando o valor atual é divisível por 5, imprima o termo Buzz ao lado do número.
Quando o valor atual é divisível tanto por 3 quanto por 5, imprima o termo FizzBuzz ao lado do número. 
*/


for (int i = 1; i <= 100; i++)
{
    string str = "";

    if ((i%3==0) && (i%5==0)) 
        str = " - FizzBuzz";
    else if(i%3==0)
        str = " - Fizz";  
    else if (i%5==0)
        str = " - Buzz";  

    Console.WriteLine(i + str);  
}