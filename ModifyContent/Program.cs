// *Use os métodos auxiliares IndexOf() e Substring() da cadeia de caracteres

// *Escreva um código para encontrar pares de parênteses inseridas em uma cadeia de caracteres

/* string message = "Find what is (inside the parentheses)";

int openingPosition = message.IndexOf('(');
int closingPosition = message.IndexOf(')');

Console.WriteLine(openingPosition);
Console.WriteLine(closingPosition);
 */



// *Adicione o código para recuperar o valor entre parênteses
// O método Substring() precisa da posição inicial e do número de caracteres, ou comprimento, para recuperar. 
// Portanto, você calcula o comprimento em uma variável temporária chamada length e a passamos com o valor 
// openingPosition para recuperar a cadeia de caracteres dentro dos parênteses.

/* string message = "Find what is (inside the parentheses)";

int openingPosition = message.IndexOf('(');
int closingPosition = message.IndexOf(')');

int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length)); */



// *Modificar a posição inicial da subcadeia de caracteres
// O motivo pelo qual você está usando o valor 1 é porque esse é o comprimento do caractere. 
// Se você tentar localizar um valor iniciado após uma cadeia de caracteres mais longa, 
// por exemplo, <div> ou ---, você usaria o comprimento dessa cadeia de caracteres em vez disso.

/* string message = "Find what is (inside the parentheses)";

int openingPosition = message.IndexOf('(');
int closingPosition = message.IndexOf(')');

openingPosition += 1;

int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length)); */



// Nesse caso, você está adicionando 6 ao openingPosition como o deslocamento para calcular o comprimento da subcadeia de caracteres <span>.

/* string message = "What is the value <span>between the tags</span>?";

int openingPosition = message.IndexOf("<span>");
int closingPosition = message.IndexOf("</span>");

openingPosition += 6;
int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length)); */



// !Evitar valores mágicos
// As cadeias de caracteres embutidas em código como "<span>" na lista de códigos anterior são conhecidas como "cadeias de caracteres mágicas", 
// e os valores numéricos embutidos em código como 6 são conhecidos como "números mágicos". Esses valores "Mágicos" não são recomendados por 
// muitos motivos e devem ser evitados sempre que possível.

// Evite valores mágicos codificados. Em vez disso, defina uma variável const. O valor de uma variável constante não pode ser alterado após a inicialização.
// Atualize seu código no Editor do Visual Studio Code da seguinte maneira:

/* string message = "What is the value <span>between the tags</span>?";

const string openSpan = "<span>";
const string closeSpan = "</span>";

int openingPosition = message.IndexOf(openSpan);
int closingPosition = message.IndexOf(closeSpan);

openingPosition += openSpan.Length;
int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length)); */




/* 
*Recapitulação
Esta unidade cobriu muito material. Veja os fatores mais importantes a serem lembrados:

IndexOf() informa a primeira posição de um caractere ou uma cadeia de caracteres dentro de outra cadeia de caracteres.
IndexOf() retornará -1 se não for possível encontrar uma correspondência.
Substring() retorna apenas a parte especificada de uma cadeia de caracteres usando uma posição inicial e um comprimento opcional.
Geralmente, há mais de uma maneira de resolver um problema. Você usou duas técnicas diferentes para localizar todas as instâncias de um determinado caractere ou cadeia de caracteres.
Evite valores mágicos codificados. Em vez disso, defina uma variável const. O valor de uma variável constante não pode ser alterado após a inicialização. */






// *Exercício: use os métodos auxiliares IndexOfAny() e LastIndexOf() da cadeia de caracteres

/* Neste exercício, você usa o método:

=> IndexOfAny() para encontrar a primeira localização de qualquer um dos string da matriz selecionada.

=> LastIndexOf() para encontrar o local final de uma cadeia de caracteres dentro de outra cadeia de caracteres. */


// *Recuperar a última ocorrência de uma subcadeia de caracteres
/* string message = "(What if) I am (only interested) in the last (set of parentheses)?";
int openingPosition = message.LastIndexOf('(');

openingPosition += 1;
int closingPosition = message.LastIndexOf(')');
int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length)); */




// *Recuperar todas as instâncias de subcadeias de caracteres dentro de parênteses
/* string message = "(What if) there are (more than) one (set of parentheses)?";
while (true)
{
    int openingPosition = message.IndexOf('(');
    if (openingPosition == -1) break;

    openingPosition += 1;
    int closingPosition = message.IndexOf(')');
    int length = closingPosition - openingPosition;
    Console.WriteLine(message.Substring(openingPosition, length));

    // Note the overload of the Substring to return only the remaining 
    // unprocessed message:
    message = message.Substring(closingPosition + 1);
} */



// *Trabalhar com diferentes tipos de conjuntos de símbolos
/* 
string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

// The IndexOfAny() helper method requires a char array of characters. 
// You want to look for:

char[] openSymbols = { '[', '{', '(' };

// You'll use a slightly different technique for iterating through 
// the characters in the string. This time, use the closing 
// position of the previous iteration as the starting index for the 
//next open symbol. So, you need to initialize the closingPosition 
// variable to zero:

int closingPosition = 0;

while (true)
{
    int openingPosition = message.IndexOfAny(openSymbols, closingPosition);

    if (openingPosition == -1) break;

    string currentSymbol = message.Substring(openingPosition, 1);

    // Now  find the matching closing symbol
    char matchingSymbol = ' ';

    switch (currentSymbol)
    {
        case "[":
            matchingSymbol = ']';
            break;
        case "{":
            matchingSymbol = '}';
            break;
        case "(":
            matchingSymbol = ')';
            break;
    }

    // To find the closingPosition, use an overload of the IndexOf method to specify 
    // that the search for the matchingSymbol should start at the openingPosition in the string. 

    openingPosition += 1;
    closingPosition = message.IndexOf(matchingSymbol, openingPosition);

    // Finally, use the techniques you've already learned to display the sub-string:

    int length = closingPosition - openingPosition;
    Console.WriteLine(message.Substring(openingPosition, length));
} */



/* 
*Recapitulação
!Aqui estão dois pontos importantes a serem lembrados:

!LastIndexOf() retorna a última posição de um caractere ou uma cadeia de caracteres dentro de outra cadeia de caracteres.
!IndexOfAny() retorna a primeira posição de uma matriz de char que ocorre dentro de outra cadeia de caracteres. */




//* Exercício – Usar os métodos Remove() e Replace()

// O método Remove() funciona de forma semelhante ao método Substring(). Defina uma posição inicial e o comprimento 
// para remover esses caracteres da cadeia de caracteres.
// Remover caracteres em locais específicos de uma cadeia de caracteres
/* string data = "12345John Smith          5000  3  ";
string updatedData = data.Remove(5, 20);
Console.WriteLine(updatedData); */



// O método Replace() é usado quando você precisa substituir um ou mais caracteres por outro (ou nenhum). O método Replace() 
// é diferente dos outros usados até agora, pois substitui todas as instâncias dos caracteres especificados, não apenas a primeira ou a última.
/* string message = "This--is--ex-amp-le--da-ta";
message = message.Replace("--", " ");
message = message.Replace("-", "");
Console.WriteLine(message);
 */

/* 
*Recapitulação
!Aqui estão dois pontos importantes a serem lembrados:

!O método Remove() funciona como o método Substring(), com a diferença de que ele exclui os caracteres especificados na cadeia de caracteres.
!O método Replace() troca todas as instâncias de uma cadeia de caracteres por uma nova cadeia de caracteres. */




//*Exercício: conclua um desafio para extrair, substituir e remover os dados de uma cadeia de caracteres de entrada

/* 
    Comece a adicionar o código da solução ao código inicial sob o comentário // Your work here.

    Defina a variável quantity para o valor obtido extraindo o texto entre as marcas <span> e </span>.

    Defina a variável output com o valor de input e, em seguida, remova as marcas <div> e </div>.

    Substitua o caractere HTML ™ (&trade;) por ® (&reg;) na variável output.

    Execute sua solução e verifique se a saída colocada corresponde à saída esperada. 

    Output:

    Quantity: 5000
    Output: <h2>Widgets &reg;</h2><span>5000</span>
*/


const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

// Your work here
const string openSpan = "<span>";
const string closeSpan = "</span>";

int openingPosition = input.IndexOf(openSpan);
int closingPosition = input.IndexOf(closeSpan);

openingPosition += openSpan.Length;
int length = closingPosition - openingPosition;
quantity = input.Substring(openingPosition, length); 
Console.WriteLine(quantity);


const string openDiv = "<div>";
const string closeDiv = "</div>";

output = input;
openingPosition = output.IndexOf(openDiv);
output = output.Remove(openingPosition, openDiv.Length);

closingPosition = output.IndexOf(closeDiv);
output = output.Remove(closingPosition, closeDiv.Length);

output = output.Replace("&trade", "&reg");

Console.WriteLine(output);