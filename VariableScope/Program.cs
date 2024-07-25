/* // Criar uma variável dentro de um bloco de código
bool flag = true;
if (flag)
{
    int value = 10;
    Console.WriteLine($"Inside the code block: {value}");
}
 */


/* // Tentar acessar uma variável fora do bloco de código no qual ela é declarada
bool flag = true;
if (flag)
{
    int value = 10;
    Console.WriteLine($"Inside the code block: {value}");
}
Console.WriteLine($"Outside the code block: {value}");
 */



/* // Mover a declaração de variável acima do bloco de código
bool flag = true;
int value;

if (flag)
{
    Console.WriteLine($"Inside the code block: {value}");
}

value = 10;
Console.WriteLine($"Outside the code block: {value}");
*/



 

/* // Inicializar uma variável como parte da declaração de variável
bool flag = true;
int value = 0;

if (flag)
{
    Console.WriteLine($"Inside the code block: {value}");
}

value = 10;
Console.WriteLine($"Outside the code block: {value}"); */



/*
// Examinar a legibilidade de instruções if com apenas uma linha
//Como a instrução if e a chamada de método para Console.WriteLine() 
//são curtas, você pode se sentir impelido a agrupá-las na mesma 
//linha. Afinal, a sintaxe do C# para a instrução if permite agrupar 
//instruções dessa maneira.
bool flag = true;
if (flag) Console.WriteLine(flag);



// O código é executado, mas essas linhas de código são densas e 
//difíceis de ler. 
string name = "steve";
if (name == "bob") Console.WriteLine("Found Bob");
else if (name == "steve") Console.WriteLine("Found Steve");
else Console.WriteLine("Found Chuck");


//Talvez você queira reformatar o código para 
//incluir uma quebra de linha após as instruções if, else if e else.
string name2 = "bob";

if (name2 == "bob")
    Console.WriteLine("Found Bob");
else if (name2 == "steve") 
    Console.WriteLine("Found Steve");
else
    Console.WriteLine("Found Chuck");

*/

/* Se você perceber que tem apenas uma linha de código listada nos
blocos de código de uma instrução if-elseif-else, remova as 
chaves e o espaço em branco do bloco de código. A Microsoft
recomenda que as chaves sejam usadas de modo consistente em
todos os blocos de código das instruções if-elseif-else 
presentes no código, seja incluindo ou omitindo as chaves
em todas as ocorrências semelhantes. */


/*
// Desafio de código: atualizar um código problemático no editor de código

int[] numbers = { 4, 8, 15, 16, 23, 42 };
int total= 0;
bool found = false;

foreach (int number in numbers)
{
    total += number;
    if (number == 42) 
        found = true;
}

if (found) 
    Console.WriteLine("Set contains 42");

Console.WriteLine($"Total: {total}");

*/



/*
int number = 1;

if (number > 0) 
{
    int number2 = 8;
    number += number2;
} 

Console.WriteLine(number);
*/

int number = 5;

if (number > 0)
{
    int number2 = 6;
}

number += number2; 
Console.WriteLine(number);

 