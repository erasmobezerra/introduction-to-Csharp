/* 
    *O que é a Formatação Composta?
    A formatação composta usa espaços reservados numerados dentro de uma cadeia de caracteres. No runtime, 
    tudo o que está dentro das chaves é resolvido para um valor que também é transmitido com base na posição. 
*/

/* string first = "Hello";
string second = "World";
Console.WriteLine("{0} {1}!", first, second);
Console.WriteLine("{1} {0}!", first, second);
Console.WriteLine("{0} {0} {0}!", first, second);  */



/* 
    *O que é interpolação de cadeia de caracteres?
    Interpolação de cadeia de caracteres é uma técnica que simplifica a formatação composta.

    Em vez de usar um token numerado e incluir o valor literal ou nome da variável em uma lista de argumentos em 
    String.Format() ou Console.WriteLine(), você pode apenas usar o nome da variável dentro das chaves. 
*/

/* string first = "Hello";
string second = "World";
Console.WriteLine($"{first} {second}!");
Console.WriteLine($"{second} {first}!");
Console.WriteLine($"{first} {first} {first}!"); */



/* 
    *Moeda de formatação
    A formatação composta e a interpolação de cadeia de caracteres podem ser usadas para formatar valores para 
    exibição considerando uma linguagem e cultura específicas. No exemplo a seguir, o especificador de formato 
    de moeda :C é usado para apresentar as variáveis price e discount como moeda. Atualize seu código desta maneira:

    ! Se você tiver executado esse código em um computador com o idioma de exibição do Windows definido para "Português (Brasil)", confira a saída a seguir.
*/

/* decimal price = 123.45m;
int discount = 50;
Console.WriteLine($"Price: {price:C} (Save {discount:C})"); */



/* 
    *Formatar números
    O especificador de formato numérico N torna os números mais legíveis. Atualize seu código desta maneira: */

/* decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N} units"); */


/* 
    ! Por padrão, o especificador de formato numérico N exibe apenas dois dígitos após o ponto decimal.
    Se desejar mostrar mais precisão, adicione um número após o especificador. O código a seguir exibirá quatro dígitos 
    após o ponto decimal que usa o especificador N4. Atualize seu código desta maneira: */

/* decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N4} units"); */




/* 
    *Formatar percentuais
    Use o especificador de formato P para formatar percentuais. Adicione um número posteriormente para controlar o 
    número de valores exibidos após o ponto decimal. Atualize seu código desta maneira:

    ! O especificador realizará arredondamento para cima caso seja necessário
*/
/* decimal tax = .12051m ;
Console.WriteLine($"Tax rate: {tax:P2}"); */


// *Combinar abordagens de formatação

/* decimal price = 67.55m;
decimal salePrice = 59.99m;

string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price - salePrice), price);

Console.WriteLine(yourDiscount);
 */

/* 
    *RECAPITULAÇÃO 

! Aqui estão as informações mais importantes desta unidade sobre a formatação da cadeia de caracteres:

! 1. Você pode usar a formatação composta ou a interpolação de cadeia de caracteres para formatar cadeias de caracteres.
! 2. Com a formatação composta, você usa um modelo de cadeia de caracteres que contém um ou mais tokens de substituição no formato {0}. 
! 3. Forneça também uma lista de argumentos correspondidos com os tokens de substituição baseados em sua ordem. A formatação composta 
!    funciona ao usar string.Format() ou Console.WriteLine().

! 4. Com a interpolação de cadeia de caracteres, você usa um modelo de cadeia de caracteres que contém os nomes de variável que você deseja 
!    substituir entre chaves. Use a diretiva $ antes do modelo de cadeia de caracteres para indicar que você deseja que a cadeia de caracteres 
!    seja interpolada.

! 5. Formate a moeda usando um especificador :C.

! 6. Formate os números usando um especificador :N. Controle a precisão (número de valores após o ponto decimal) usando um número após o :N, 
!    como {myNumber:N3}.

! 7. Formate as porcentagens usando o especificador de formato :P.

! 8. A formatação de moedas e números depende da cultura do usuário final, um código de cinco caracteres que inclui o país/região e o idioma 
!    do usuário (de acordo com as configurações do computador). */




//* Formatar cadeias de caracteres adicionando um espaço em branco antes ou depois
// O método PadLeft() e PadRight() adiciona espaços em branco ao lado esquerdo e direito, respectivamente, da cadeia de caracteres para que 
// o número total de caracteres seja igual ao argumento enviado por você

// Aqui o input possui Count() = 8
// string input = "Pad this";
// com PadLeft(12), passará a conter Count() = 12, com quatro espaços à esquerda
// Console.WriteLine(input.PadLeft(12));
// com PadLeft(12), passará a conter Count() = 12, com quatro espaços à direita
// Console.WriteLine(input.PadRight(12));



// Você também pode chamar uma segunda versão sobrecarregada do método e passar qualquer caractere que você queira usar em vez de um espaço. 
// Nesse caso, você preenche o espaço extra com o caractere de traço.

// Console.WriteLine(input.PadLeft(12, '-'));
// Console.WriteLine(input.PadRight(12, '-'));



/* Adicionar a ID de Pagamento à saída
Para começar, imprima a ID do Pagamento nas primeiras seis colunas. Você escolherá alguns dados de pagamento aleatórios que devem ser adequados aos fins.  */

/* string paymentId = "769C";

var formattedLine = paymentId.PadRight(6);

Console.WriteLine(formattedLine); */


// Adicionar o nome do favorecido à saída

/* string paymentId = "769C";
 string payeeName = "Mr. Stephen Ortega";

 var formattedLine = paymentId.PadRight(6);
 formattedLine += payeeName.PadRight(24);

 Console.WriteLine(formattedLine); */


// Adicionar o valor do pagamento à saída
/*  string paymentId = "769C";
 string payeeName = "Mr. Stephen Ortega";
 string paymentAmount = "$5,000.00";

 var formattedLine = paymentId.PadRight(6);
 formattedLine += payeeName.PadRight(24);
 formattedLine += paymentAmount.PadLeft(10);

 Console.WriteLine(formattedLine); */




// Adicionar uma linha de números acima da saída para confirmar mais facilmente o resultado
// Como é difícil contar as colunas exatas em que cada elemento de dados é exibido, você adiciona uma linha diretamente 
// acima da saída que ajuda você a contar as colunas.
/* 
 string paymentId = "769C";
 string payeeName = "Mr. Stephen Ortega";
 string paymentAmount = "$5,000.00";

 var formattedLine = paymentId.PadRight(6);
 formattedLine += payeeName.PadRight(24);
 formattedLine += paymentAmount.PadLeft(10);

 Console.WriteLine("1234567890123456789012345678901234567890");
 Console.WriteLine(formattedLine); */


/* 
*Recapitulação
Veja algumas informações importantes desta unidade.

1.O tipo de dados string, cadeias de caracteres literais e variáveis do tipo String implementam muitos métodos auxiliares para formatar, modificar e executar outras operações nas cadeias de caracteres.
2.Os métodos PadLeft() e PadRight() adicionam espaço em branco (ou, opcionalmente, outro caractere) ao comprimento total de uma cadeia de caracteres.
3.Use PadLeft() para alinhar uma cadeia de caracteres à direita.
4.Alguns métodos são sobrecarregados, o que significa que eles têm várias versões do método com diferentes argumentos que afetam sua funcionalidade.
6.O operador += concatena uma nova cadeia de caracteres à direita para a cadeia de caracteres existente à esquerda. */




// *Concluir um desafio em que é preciso aplicar a interpolação de cadeias de caracteres a uma carta-modelo

string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

Console.Clear();
Console.WriteLine($"Dear {customerName},");
Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n");
Console.WriteLine($"Currently, you own {currentShares:N2} shares at a return of {currentReturn:P2}.\n");
Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P2}.  Given your current volume, your potential profit would be {newProfit:C}.\n");
Console.WriteLine("Here's a quick comparison:\n");

string comparisonMessage = "";

 comparisonMessage = currentProduct.PadRight(20);
 comparisonMessage += currentReturn.ToString("P2").PadRight(10);
 comparisonMessage += currentProfit.ToString("C").PadLeft(10);
 Console.WriteLine(comparisonMessage);

 comparisonMessage = newProduct.PadRight(20);
 comparisonMessage += newReturn.ToString("P2").PadRight(10);
 comparisonMessage += newProfit.ToString("C").PadLeft(10);
 Console.WriteLine(comparisonMessage);




/* 

 */