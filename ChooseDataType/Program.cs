// TIPOS DE VALOR

// Tipos integrais com sinal
// Um tipo com sinal usa seus bytes para representar uma quantidade igual de números positivos e negativos. O exercício a seguir expõe você aos tipos integrais com sinal em C#.

Console.WriteLine("Signed integral types:");

Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");



// Tipos integrais sem sinal
//Um tipo sem sinal usa seus bytes para representar apenas números positivos. O restante do exercício apresenta os tipos integrais sem sinal em C#.
Console.WriteLine("");
Console.WriteLine("Unsigned integral types:");

Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");



// Tipos de ponto flutuante
// Um ponto flutuante é um tipo de valor simples que representa números à direita da casa decimal.
Console.WriteLine("");
Console.WriteLine("Floating point types:");
Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");


/* Quando você precisar de uma resposta mais precisa, deverá usar decimal. Cada valor do tipo decimal tem um volume 
de memória relativamente grande; contudo, efetuar operações matemáticas dá a você um resultado mais preciso. Portanto, 
você deve usar o decimal ao trabalhar com os dados financeiros ou com qualquer cenário em que seja necessário um resultado 
preciso de um cálculo. */










// Os TIPOS DE REFERENCIA

int[] data = new int[3];

string shortenedString = "Hello World!";
Console.WriteLine(shortenedString);



/* 
Recapitulação

Uma variável de tipo de valor armazena os próprios valores diretamente em uma área de armazenamento chamada pilha.
Uma variável de tipo de referência armazena os próprios valores em uma região de memória separada chamada heap.

-> Os tipos de valor podem armazenar valores menores e são armazenados na pilha. Os tipos de referência podem armazenar grandes valores, 
e uma nova instância de um tipo de referência é criada usando o operador new. As variáveis do tipo de referência armazenam uma referência 
(o endereço de memória) para o valor real armazenado no heap.

->Os tipos de referência incluem matrizes, cadeias de caracteres e classes
 */



 /* 
 Escolher o tipo de dados certo
Com tantos tipos de dados para escolher, quais critérios você deve usar para escolher o tipo de dados certo para a situação específica?

Ao avaliar suas opções, é necessário ponderar várias considerações importantes. Geralmente, não há uma única resposta correta, mas algumas delas estão mais corretas do que outras.

1. Escolher o tipo de dados que atende aos requisitos de intervalo de valor de limite do seu aplicativo
2. Comece escolhendo o tipo de dados correto para os dados (não para otimizar o desempenho)
3. Escolher tipos de dados com base nos tipos de dados de entrada e saída das funções de biblioteca usadas
4. Escolher tipos de dados com base no impacto em outros sistemas como um banco de dados específico


Em caso de dúvida, vá pelo caminho mais simples
Embora você tenha feito várias considerações, você está apenas começando. Por isso, para simplificar, você deve preferir um subconjunto de tipos de dados básicos, incluindo:

*int para a maioria dos números inteiros
*decimal para números que representam dinheiro
*bool para valores true ou false
*string para valor alfanumérico

Escolha tipos complexos especializados para situações especiais
Não reinvente os tipos de dados se um ou mais já existirem para uma determinada finalidade. Os seguintes exemplos identificam quando um tipo de dados .NET específico pode ser útil:

*byte: para trabalhar com dados codificados provenientes de outros sistemas de computação ou que usam diferentes conjuntos de caracteres.
*double: para trabalhar com fins geométricos ou científicos. double é usado com frequência ao criar jogos que envolvem movimento.
*System.DateTime para um valor de data e hora específico.
*System.TimeSpan para um intervalo de anos/mês/dias/horas/minutos/segundos/milissegundos.


 
  */