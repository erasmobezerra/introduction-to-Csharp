// Conhecer as funções Sort() e Reverse()

//Criar uma matriz de paletes, depois classificá-los
/* string[] pallets = { "B14", "A11", "B12", "A13" };
Console.WriteLine("Sorted...");
Array.Sort(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
} */



//Inverter a ordem dos paletes
/* string[] pallets = { "B14", "A11", "B12", "A13" };

Console.WriteLine("Sorted...");
Array.Sort(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Console.WriteLine("Reversed...");
Array.Reverse(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
} */


/* Recapitulação
Estes são alguns conceitos importantes que você abordou nesta unidade:

A classe Array tem métodos que podem manipular o tamanho e o conteúdo de uma matriz.
Use o método Sort() para manipular a ordem com base no tipo de dados fornecido da matriz.
Use o método Reverse() para inverter a ordem dos elementos na matriz. */




// Explorar os métodos Clear() e Resize()

// Usar métodos de matriz para limpar e redimensionar uma matriz
/* string[] pallets = { "B14", "A11", "B12", "A13" };
Console.WriteLine("");

Array.Clear(pallets, 0, 2);
Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
} */



// Cadeia de caracteres vazia versus nula
//
// Quando você usa Array.Clear(), os elementos que foram limpos não referenciam mais uma cadeia de caracteres na memória. Na verdade, o elemento não aponta para nada.

/* string[] pallets = { "B14", "A11", "B12", "A13" };
Console.WriteLine("");

Console.WriteLine($"Before: {pallets[0]}");
Array.Clear(pallets, 0, 2);
Console.WriteLine($"After: {pallets[0]}");

Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
} */


// Se você se concentrar na linha de saída After: , poderá achar que o valor armazenado em pallets[0] é uma cadeia de caracteres vazia. No entanto, o compilador C# 
// converte implicitamente o valor nulo em uma cadeia de caracteres vazia para apresentação.




// Redimensionar a matriz para adicionar mais elementos
// Aqui, você está chamando o método Resize() passando a matriz pallets por referência, usando a palavra-chave ref.
// Nesse caso, você está redimensionando a matriz pallets de quatro elementos para 6. Os novos elementos são adicionados ao final dos elementos atuais. 
// Os dois novos elementos serão nulos até você atribuir um valor a eles.
/* string[] pallets = { "B14", "A11", "B12", "A13" };
Console.WriteLine("");

Array.Clear(pallets, 0, 2);
Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Array.Resize(ref pallets, 6);
Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

pallets[4] = "C01";
pallets[5] = "C02";

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
} */






// Redimensionar a matriz para remover elementos
// Observe que a chamada de Array.Resize() não eliminou os dois primeiros elementos nulos. Em vez disso, 
// ele removeu os últimos três elementos. Observe que os últimos três elementos foram removidos, embora 
// estivessem preenchidos com cadeias de caracteres.

/* string[] pallets = { "B14", "A11", "B12", "A13" };
Console.WriteLine("");

Array.Clear(pallets, 0, 2);
Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Array.Resize(ref pallets, 6);
Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

pallets[4] = "C01";
pallets[5] = "C02";

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Array.Resize(ref pallets, 3);
Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
} */



/* Recapitulação
Estes são alguns conceitos importantes que você abordou nesta unidade:

Use o método Clear() para esvaziar os valores dos elementos na matriz.
Use o método Resize() para alterar o número de elementos na matriz, removendo ou adicionando elementos do final da matriz.
Os novos elementos da matriz e os elementos limpos são nulos, o que significa que eles não apontam para um valor na memória. */





// Use o ToCharArray() para reverter um string
// Aqui você usa o método ToCharArray() para criar um matriz de char, cada elemento da matriz tem um caractere da cadeia de caracteres original.
/* string value = "abc123";
char[] valueArray = value.ToCharArray(); */



// Inverter e, em seguida, combinar a matriz char em uma nova cadeia de caracteres
// A expressão new string(valueArray) cria uma instância vazia da classe System.String (que é a mesma do tipo de dados string em C#) e passa a matriz char como um construtor.
/* string value = "abc123";
char[] valueArray = value.ToCharArray();
Array.Reverse(valueArray);
string result = new string(valueArray);
Console.WriteLine(result); */




// Combine todos os caracteres em uma nova cadeia de caracteres com valor separado por vírgula usando Join()
/* string value = "abc123";
char[] valueArray = value.ToCharArray();
Array.Reverse(valueArray);
string result = String.Join(",", valueArray);
Console.WriteLine(result); */


// Split() a nova cadeia de caracteres de valor separado por vírgula em uma matriz de cadeias de caracteres
// A matriz items criada usando string[] items = result.Split(','); é usada no loop foreach e exibe os caracteres individuais do string original contido na variável value.
/* string value = "abc123";
char[] valueArray = value.ToCharArray();
Array.Reverse(valueArray);
// string result = new string(valueArray);
string result = String.Join(",", valueArray);
Console.WriteLine(result);

string[] items = result.Split(',');
foreach (string item in items)
{
    Console.WriteLine(item);
} */



/* Recapitulação
Estas são algumas considerações a serem feitas ao trabalhar com cadeias de caracteres e matrizes:

Usar métodos como ToCharArray() e Split() para criar uma matriz
Use métodos como Join() ou crie uma cadeia de caracteres passando uma matriz de char para transformar a matriz novamente em uma única cadeia de caracteres */




// Escrever código para inverter cada palavra de uma mensagem // 
// 
// Como deve aparecer no output: ehT kciuq nworb xof spmuj revo eht yzal god

/* string pangram = "The quick brown fox jumps over the lazy dog";
string newPangram = "";
string[] wordArray = pangram.Split(" ");


foreach (string word in wordArray)
{
    char[] wordChar = word.ToCharArray();
    Array.Reverse(wordChar);
    string wordReverse = new string(wordChar);
    newPangram += wordReverse + " ";
}
Console.WriteLine(newPangram.Trim()); */



// Concluir um desafio em que é preciso analisar uma cadeia de caracteres de pedidos, classificá-los e marcar possíveis erros
/*
    Adicione o código abaixo do código anterior para analisar as "IDs de pedido" do de pedidos de 
    entrada string e armazenar as "IDs do pedido" em uma matriz. 
    
    Adicione o código para gerar cada "ID do pedido" na ordem classificada e marque os pedidos que
    não tiverem exatamente quatro caracteres como "- Erro"
 
    Seu código deverá produzir a seguinte saída:
    A345
    B123
    B177
    B179
    C15     - Error
    C234
    C235
    G3003   - Error
*/

string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179"; 

string[] IDsArray = orderStream.Split(',');
Array.Sort(IDsArray);

foreach (string id in IDsArray)
{
    if (id.Length != 4)
        Console.WriteLine(id + "\t - Error");
    else 
        Console.WriteLine(id);
}