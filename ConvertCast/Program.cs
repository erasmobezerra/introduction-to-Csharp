// Converter tipos de dados usando técnicas de conversão cast em C# 

/* 
Há diversas técnicas para executar uma conversão de tipo de dados. A técnica escolhida depende de sua resposta a duas perguntas importantes:

É possível, dependendo do valor, que a tentativa de alterar o tipo de dados do valor gerasse uma exceção em tempo de execução?
É possível, dependendo do valor, que a tentativa de alterar o tipo de dados do valor resultasse em uma perda de informações?
 */


// Escreva um código que tente somar um int com uma string e salve o resultado em um int.
// Se o compilador C# tentou converter "hello" em um número que causaria uma exceção em tempo de execução. 
// Para evitar essa possibilidade, o compilador C# não executa implicitamente a conversão de string para int por você.
/* int first = 2;
string second = "4";
int result = first + second;
Console.WriteLine(result); */


// É possível fazer o contrário para concatenar um número a um string e salvá-lo em uma variável de cadeia de caracteres, 
// Pois o compilador só executará uma conversão implícita se esta for uma conversão segura
/* int first = 2;
string second = "4";
string result = first + second;
Console.WriteLine(result); */



// Tentar alterar o tipo de dados do valor resultaria em uma perda de informações?
// O termo conversão de expansão significa que você está tentando converter um valor 
// de um tipo de dados que poderia armazenar menos informações em um tipo de dados que pode armazenar mais informações
// Como qualquer valor int pode se ajustar facilmente dentro de um decimal, o compilador executa a conversão.
/* int myInt = 3;
Console.WriteLine($"int: {myInt}");

decimal myDecimal = myInt;
Console.WriteLine($"decimal: {myDecimal}"); */



// Executar uma coerção: use o operador de coerção () para cercar um tipo de dados e 
// coloque-o ao lado da variável que deseja converter (por exemplo: (int)myDecimal). 
// Você executará uma conversão explícita para o tipo de dados de coerção definido (int)
/* decimal myDecimal = 3.14m;
Console.WriteLine($"decimal: {myDecimal}");

int myInt = (int)myDecimal;
Console.WriteLine($"int: {myInt}"); */


// Determine se sua conversão é uma "conversão de expansão" ou uma "conversão de restrição"
/* decimal myDecimal = 1.23456789m;
float myFloat = (float)myDecimal;

Console.WriteLine($"Decimal: {myDecimal}");
Console.WriteLine($"Float  : {myFloat}"); */



/* 
Executar conversões de dados
Anteriormente, foi declarado que uma alteração de valor de um tipo de dados para outro poderia causar uma 
exceção de runtime e é necessário realizar a conversão de dados. Para conversões de dados, há três técnicas que podem ser usadas:

=> Usar um método auxiliar na variável
=> Usar um método auxiliar no tipo de dados
=> Use os métodos da classe Convert */

// Use ToString() para converter um número em um string
/* int first = 5;
int second = 7;
string message = first.ToString() + second.ToString();
Console.WriteLine(message);
 */


// Converter um string em um int usando o método auxiliar Parse()
// E se uma das variáveis first ou second estiver definida como valores que não podem ser convertidos em um int? 
// Uma exceção é lançada no runtime. O compilador C# e o runtime esperam que você se antecipe e evite conversões "ilegais".
/* string first = "5";
string second = "7";
int sum = int.Parse(first) + int.Parse(second);
Console.WriteLine(sum); */


// É possível resolver a exceção do runtime de diversas maneiras.
// A maneira mais fácil é usar TryParse(), que é uma versão melhorada do método Parse().


// Converter um string em um int usando a classe Convert
/* string value1 = "5";
string value2 = "7";
int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
Console.WriteLine(result); */


/* 
O método ToInt32() tem 19 versões sobrecarregadas, o que permite aceitar praticamente todos os tipos de dados.

Você usou o método Convert.ToInt32() com uma cadeia de caracteres aqui, mas provavelmente deve usar TryParse() quando possível.

Então, quando usar a classe Convert? A classe Convert é melhor para converter números fracionários em números inteiros (int) porque os arredonda da maneira esperada. 
*/


/* Comparar a coerção e a conversão de um decimal em um int

A coerção resulta em truncamentos e a conversão resulta em valores arredondados

=> Ao fazer a coerção de int value = (int)1.5m;, o valor do float é truncado para que o resultado seja 1, o que significa que o valor após o decimal é completamente 
ignorado. É possível alterar o float literal para 1.999m e o resultado da coerção é o mesmo. */

/* int value = (int)1.5m; 
Console.WriteLine(value); */

/*
=> Ao fazer a conversão usando Convert.ToInt32(), o valor do float literal é arredondado corretamente para 2. Se você alterar o valor literal para 1.499m, 
ele será arredondado para baixo para 1. */

/* int value2 = Convert.ToInt32(1.5m); 
Console.WriteLine(value2); */



/* 
*Recapitulação*
Você aprendeu sobre diversos conceitos importantes de conversão e coerção de dados, como os seguintes:

Evitar um erro de runtime ao executar uma conversão de dados
Executar uma coerção explícita para informar ao compilador que você entende o risco de perda de dados
Confiar no compilador para executar uma coerção implícita ao executar uma conversão de expansão
Usar o operador de coerção () e o tipo de dados para executar uma coerção (por exemplo, (int)myDecimal)
Usar a classe Convert para realizar uma conversão de restrição quando você deseja realizar um arredondamento, não um truncamento de informações */








// Usar TryParse()

/* O método TryParse() faz várias coisas simultaneamente:

Ele tenta analisar uma cadeia de caracteres sobre o tipo de dados numérico fornecido.
Se a conversão der certo, o valor convertido é armazenado em um parâmetro de saída, explicado na seção a seguir.
Retorna um bool para indicar se a ação foi bem-sucedida ou falhou. */
/* string value = "102";
int result = 0;
if (int.TryParse(value, out result))
{
   Console.WriteLine($"Measurement: {result}");
}
else
{
   Console.WriteLine("Unable to report the measurement.");
} */


// O int analisado será usado posteriormente no código
/* string value = "102";
int result = 0;
if (int.TryParse(value, out result))
{
   Console.WriteLine($"Measurement: {result}");
}
else
{
   Console.WriteLine("Unable to report the measurement.");
}
Console.WriteLine($"Measurement (w/ offset): {50 + result}"); */



// Modificar a variável de cadeia de caracteres para um valor que não possa ser analisado
/* string value = "bad";
int result = 0;
if (int.TryParse(value, out result))
{
   Console.WriteLine($"Measurement: {result}");
}
else
{
   Console.WriteLine("Unable to report the measurement.");
}

if (result > 0)
   Console.WriteLine($"Measurement (w/ offset): {50 + result}"); */



/* 
*Recapitulação*
O método TryParse() é uma ferramenta valiosa. Veja algumas ideias rápidas das quais se lembrar.

Use TryParse() ao converter uma cadeia de caracteres em um tipo de dados numérico.
TryParse() retornará true se a conversão tiver sido bem-sucedida; false se não tiver sido bem-sucedida.
Os parâmetros de saída fornecem um meio secundário de um método retornar um valor. Nesse caso, o parâmetro out retorna o valor convertido.
Use a palavra-chave out ao passar um argumento para um método que tenha definido um parâmetro out.   
*/
/* string numero = "2,71828";
decimal convertido;
decimal.TryParse(numero, out convertido);
Console.WriteLine(convertido); */





/* DESAFIO DE CÓDIGO

Concluir um desafio em que é preciso combinar valores de matriz de cadeia de caracteres como cadeias de caracteres e inteiros
É necessário implementar as seguintes regras de negócio na lógica do código:

Regra 1: Se o valor for alfabético, concatene-o para formar uma mensagem.

Regra 2: se o valor for numérico, adicione-o ao total.

Regra 3: o resultado deve corresponder à seguinte saída: */

/* using System.Text;

decimal result;
decimal sum = 0m;

StringBuilder str = new StringBuilder();
string[] values = {"12,3", "45", "ABC", "11", "DEF" };

foreach (string item in values)
{
    if (decimal.TryParse(item, out result))    
        sum += result;    
    else     
        str.Append(item);
}

Console.WriteLine(str.ToString());
Console.WriteLine(sum.ToString()); */




/* DESAFIO DE CÓDIGO

Desafio de imprimir na tela operações matemáticas como tipos de número específicos

Substitua os comentários de código do código inicial pelo seu próprio código para resolver o desafio:

Solucionar para result1: dividir value1 por value2, exibir o resultado como int
Solucionar para result2: dividir value2 por value3, exibir o resultado como decimal
Solucionar para result3: dividir value3 por value1, exibir o resultado como float */

int value1 = 11;
decimal value2 = 6.2m;
float value3 = 4.3f;

// Your code here to set result1
int result1 = Convert.ToInt32(value1 / value2);
// Hint: You need to round the result to nearest integer (don't just truncate)
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

// Your code here to set result2
decimal result2 = value2 / Convert.ToDecimal(value3); 
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

// Your code here to set result3
float result3 = value3 / value1;
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");


