/* Como você deve ter visto, o C# dá suporte a quatro tipos de instruções de iteração: for, foreach, do-while e while. A documentação de referência de linguagem da Microsoft descreve essas instruções da seguinte maneira:

A instrução for: executa seu corpo enquanto uma expressão Booliana especificada (a "condição") é avaliada como verdadeira.
A instrução foreach: enumera os elementos de uma coleção e executa o corpo para cada um deles.
A instrução do-while: executa condicionalmente o corpo uma ou mais vezes.
A instrução while: executa condicionalmente o corpo zero ou mais vezes.
 */


/* // Escrever uma instrução do-while que seja interrompida quando determinado número aleatório for gerado
Random random = new Random();
int current = 0;

do
{
    current = random.Next(1, 11);
    Console.WriteLine(current);
} while (current != 7); */





/* // Escrever uma instrução while que itere somente enquanto um número aleatório for maior que determinado valor
Random random = new Random();
int current = random.Next(1, 11);

while (current >= 3)
{
    Console.WriteLine(current);
    current = random.Next(1, 11);
}
Console.WriteLine($"Last number: {current}"); */




/* // Usar a instrução continue para passar diretamente para a expressão booliana
Random random = new Random();
int current = random.Next(1, 11);

do
{
    current = random.Next(1, 11);

    if (current >= 8) continue;

    Console.WriteLine(current);
} while (current != 7);
*/



/* Desafio de código – Escrever um código para implementar as regras de jogo
Veja as regras para o jogo de batalha que você precisa implementar em seu projeto de código:

Você deve usar a instrução do-while ou a instrução while como um loop de jogo externo.
O herói e o monstro começam com 10 pontos de vida.
Todos os ataques têm um valor entre 1 e 10.
O herói ataca primeiro.
Imprima a quantidade de integridade que o monstro perdeu e a integridade que resta a ele.
Se a integridade do monstro for maior que zero, ele poderá atacar o herói.
Imprima a quantidade de integridade que o herói perdeu e a integridade que resta a ele.
Continue esta sequência de ataque até que a integridade do monstro ou do herói seja zero ou menos.
Imprima quem foi o vencedor. */

/*
Random random = new Random();
int hero = 10;
int monster = 10;
do 
{    
    int heroAttack = random.Next(1, 11);    
    monster -= heroAttack;
    Console.WriteLine("Amount of integrity the monster lost was " + heroAttack + ". The monster's current amount of integrity is " + monster);

    if (monster > 0) 
    {
        int monsterAttack = random.Next(1, 11);
        hero -= monsterAttack;
        Console.WriteLine("Amount of integrity the hero lost was " + monsterAttack + ". The hero's current amount of integrity is " + hero);

    }
} while (monster > 0 && hero > 0);

*/


/* 
Projeto de código 1 – escrever o código que valida a entrada de inteiro
Veja as seguintes condições que seu primeiro projeto de codificação deve implementar:

A solução deve incluir uma iteração do-while ou while.

Antes do bloco de iteração: a solução deve usar uma instrução Console.WriteLine() para solicitar ao usuário um valor inteiro entre 5 e 10.

Dentro do bloco de iteração:

A solução deve usar uma instrução Console.ReadLine() para obter uma entrada do usuário.
A solução deve garantir que a entrada seja uma representação válida de um inteiro.
Se o valor inteiro não estiver entre 5 e 10, o código deverá usar uma instrução Console.WriteLine() para solicitar ao usuário um valor inteiro entre 5 e 10.
A solução deve garantir que o valor inteiro esteja entre 5 e 10 antes de sair da iteração.
Abaixo (depois) do bloco de código de iteração: a solução deve usar uma instrução Console.WriteLine() para informar ao usuário que o valor de entrada foi aceito.
Console.WriteLine("Favor informe um valor inteiro entre 5 e 10:");
*/

Console.WriteLine("\nProjeto de código 1 – escrever o código que valida a entrada de inteiro\n");

string? readResult;
int numericValue;
bool validNumber;

Console.WriteLine("Favor informe um valor inteiro entre 5 e 10: ");
do
{
    
    readResult = Console.ReadLine();
    validNumber = int.TryParse(readResult, out numericValue);

    if (validNumber)  
    {
        if (IsItBetween5And10(numericValue))         
            Console.WriteLine($"O valor {readResult} está fora do intervalor entre 5 e 10. Favor tente novamente:"); 
    }               
    else    
        Console.WriteLine($"A entrada {readResult} é inválida! Não será aceito letras ou sinal de pontuação. Favor informe um valor inteiro válido:");
    
    
} while (IsItBetween5And10(numericValue));

Console.WriteLine($"O valor da entrada {readResult} foi aceito!");


bool IsItBetween5And10(int numericValue)
{
    return numericValue < 5 || numericValue > 10;
}





/* Projeto de código 2 – escrever o código que valida a entrada de cadeia de caracteres
Veja as seguintes condições que seu segundo projeto de codificação deve implementar:

A solução deve incluir uma iteração do-while ou while.

Antes do bloco de iteração: a solução deve usar uma instrução Console.WriteLine() para solicitar ao usuário um dos três nomes de função: Administrador, Gerente ou Usuário.

Dentro do bloco de iteração:

A solução deve usar uma instrução Console.ReadLine() para obter uma entrada do usuário.
A solução deve garantir que o valor inserido corresponda a uma das três opções de função.
Sua solução deve usar o método Trim() no valor de entrada para ignorar caracteres de espaço de entrelinhamento e à direita.
A solução deve usar o método ToLower() no valor de entrada para ignorar maiúsculas e minúsculas.
Se o valor inserido não corresponder a uma das opções de função, o código deverá usar uma instrução Console.WriteLine() para solicitar ao usuário uma entrada válida.
Abaixo (depois) do bloco de código de iteração: a solução deve usar uma instrução Console.WriteLine() para informar ao usuário que o valor de entrada foi aceito. */

Console.WriteLine("\nProjeto de código 2 – escrever o código que valida a entrada de cadeia de caracteres: \n");

string? readResult1;
Console.WriteLine("Qual sua ocupação: Administrador, Gerente ou Usuario: ");

do
{
    readResult1 = Console.ReadLine()?.Trim().ToLower();
    if (!EhOcupacaoValida(readResult1))    
        Console.WriteLine($"Favor tente novamente! A ocupação {readResult1} não é válida:");   
        
} while(!EhOcupacaoValida(readResult1));


bool EhOcupacaoValida(string? readResult)
{    
    return readResult == "administrador" || readResult == "gerente" || readResult == "usuario";
}

Console.WriteLine($"O valor da entrada {readResult1} foi aceito"); 





// Projeto de código 3: escreva um código que processe o conteúdo de uma matriz de caracteres
/* Veja as seguintes condições que seu terceiro projeto de codificação deve implementar:

A solução deve usar a seguinte matriz de cadeia de caracteres para representar a entrada para a lógica de codificação:
string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };

A solução deve declarar uma variável inteira chamada periodLocation que pode ser usada para manter o local do caractere de ponto dentro de uma cadeia de caracteres.

A solução deve incluir um loop foreach ou for externo que possa ser usado para processar cada elemento da cadeia de caracteres na matriz. A variável da cadeia de caracteres que será processada dentro dos loops deve ser chamada de myString.

No loop externo, a solução deve usar o método IndexOf() da classe String para obter a localização do primeiro caractere de ponto na variável myString. A chamada de método deve ser semelhante a: myString.IndexOf("."). Se não houver nenhum caractere de ponto na cadeia de caracteres, um valor de -1 será retornado.

A solução deve incluir um loop do-while ou while interno que possa ser usado para processar a variável myString.

No loop interno, a solução deve extrair e exibir (gravar no console) cada frase contida em cada uma das cadeias de caracteres processadas.

No loop interno, a solução não deve exibir o caractere de ponto.

No loop interno, a solução deve usar os métodos Remove(), Substring() e TrimStart() para processar as informações da cadeia de caracteres. */

Console.WriteLine("\nProjeto de código 3: escreva um código que processe o conteúdo de uma matriz de caracteres\n");

string[] myStrings = ["I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices"];

int periodLocation;
string? frase;
string? newMyString;

foreach (string myString in myStrings)
{
    newMyString = myString;
    do
    {   
        if (newMyString.Contains('.'))
        {
            periodLocation = newMyString.IndexOf('.');
            frase = newMyString.Substring(0, periodLocation);  
            Console.WriteLine(frase); 
            newMyString = newMyString.Remove(0, periodLocation).TrimStart('.').Trim();
        }        

    } while (newMyString.Contains('.'));

    Console.WriteLine(newMyString);        
}





















