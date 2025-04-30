/*
Visão geral do projeto
Você faz parte de uma equipe que está trabalhando em aplicativos de suporte de varejo. 
O código que você está desenvolvendo, o método MakeChange, gerencia a gaveta de dinheiro 
para um aplicativo de caixa registradora. Seu aplicativo deve atender às seguintes especificações:

    ->Um aplicativo de console C# que simula transações de compra diárias.

    ->O aplicativo chama o método MakeChange para gerenciar a gaveta de dinheiro durante transações. MakeChange aceita pagamentos em dinheiro e retorna troco.

    ->O aplicativo de chamada verifica independentemente o saldo da gaveta após cada transação.

    ->Um padrão try-catch é implementado para gerenciar exceções da seguinte maneira:
        ->As exceções são usadas para relatar e lidar com qualquer problema que impeça que uma transação seja concluída com êxito.
        ->As exceções são criadas e geradas no método MakeChange.
        ->As exceções são capturadas e tratadas no aplicativo de chamada.


PREPARAR
Neste projeto guiado, você usa Visual Studio Code para atualizar um aplicativo C# existente. 
Suas atualizações se concentram na depuração de código e na adição de tratamento de exceções ao aplicativo. 
Examine e depure o aplicativo, implemente um padrão try-catch em instruções de nível superior e, em seguida,
gere exceções de dentro de um método que é capturado nas instruções de nível superior.
*/

string? readResult = null;
bool useTestData = false;

Console.Clear();

// o array de 4 elementos representa 4 espaços da gaveta do caixa, onde cada espaço guarda um tipo de cédula
int[] cashTill = new int[] { 0, 0, 0, 0 };
int registerCheckTillTotal = 0;

// registerDailyStartingCash: $1 x 50, $5 x 20, $10 x 10, $20 x 5 => ($350 total)
int[,] registerDailyStartingCash = new int[,] { { 1, 50 }, { 5, 20 }, { 10, 10 }, { 20, 5 } };

// valores de ítens para simulação de transacao
int[] testData = new int[] { 6, 10, 17, 20, 31, 36, 40, 41 };
int testCounter = 0;

// Chamada do método para inicializar a gaveta do caixa. Notas de $1 fica no int[0], $5 no int[1], $10 no int[2] e $20 no int[3]
LoadTillEachMorning(registerDailyStartingCash, cashTill);

// registrar o valor total do caixa
registerCheckTillTotal = registerDailyStartingCash[0, 0] * registerDailyStartingCash[0, 1] + registerDailyStartingCash[1, 0] * registerDailyStartingCash[1, 1] + registerDailyStartingCash[2, 0] * registerDailyStartingCash[2, 1] + registerDailyStartingCash[3, 0] * registerDailyStartingCash[3, 1];

// exibir o valor total de cada tipo de cédula atualmente no caixa
LogTillStatus(cashTill);

// exibir uma mensagem mostrando o valor total em dinheiro no caixa
Console.WriteLine(TillAmountSummary(cashTill));

// exibir o valor total esperado no caixa 
Console.WriteLine($"Expected till value: {registerCheckTillTotal}\n\r");

var valueGenerator = new Random((int)DateTime.Now.Ticks);

int transactions = 40;

if (useTestData)
{
    transactions = testData.Length;
}

while (transactions > 0)
{
    transactions -= 1;
    // Custo do Item
    int itemCost = valueGenerator.Next(2, 50);

    if (useTestData)
    {
        // Custo do Item
        itemCost = testData[testCounter];
        testCounter += 1;
    }

    int paymentOnes = itemCost % 2;                 // value is 1 when itemCost is odd, value is 0 when itemCost is even
    int paymentFives = (itemCost % 10 > 7) ? 1 : 0; // value is 1 when itemCost ends with 8 or 9, otherwise value is 0
    int paymentTens = (itemCost % 20 > 13) ? 1 : 0; // value is 1 when 13 < itemCost < 20 OR 33 < itemCost < 40, otherwise value is 0
    int paymentTwenties = (itemCost < 20) ? 1 : 2;  // value is 1 when itemCost < 20, otherwise value is 2

    // exibir mensagens descrevendo a transação atual
    Console.WriteLine($"Customer is making a ${itemCost} purchase"); // custo do item que o cliente está comprando
    Console.WriteLine($"\t Using {paymentTwenties} twenty dollar bills"); // usando _ notas de 20 dolares
    Console.WriteLine($"\t Using {paymentTens} ten dollar bills"); // usando _ notas de 10 dolares
    Console.WriteLine($"\t Using {paymentFives} five dollar bills"); // usando _ notas de 5 dolares
    Console.WriteLine($"\t Using {paymentOnes} one dollar bills"); // usando _ notas de 1 dolar

    try
    {
        // MakeChange gerencia a transação e atualiza o caixa 
        MakeChange(itemCost, cashTill, paymentTwenties, paymentTens, paymentFives, paymentOnes);
        Console.WriteLine($"Transaction successfully completed.");
        registerCheckTillTotal += itemCost;
    }
    catch (InvalidOperationException ex)
    {
        Console.WriteLine($"Could not complete transaction: {ex.Message}");
    }

    Console.WriteLine(TillAmountSummary(cashTill));
    Console.WriteLine($"Expected till value: {registerCheckTillTotal}\n\r");
    Console.WriteLine();

}

Console.WriteLine("Press the Enter key to exit");
do
{
    readResult = Console.ReadLine();

} while (readResult == null);


static void LoadTillEachMorning(int[,] registerDailyStartingCash, int[] cashTill)
{
    cashTill[0] = registerDailyStartingCash[0, 1];
    cashTill[1] = registerDailyStartingCash[1, 1];
    cashTill[2] = registerDailyStartingCash[2, 1];
    cashTill[3] = registerDailyStartingCash[3, 1];
}


static void MakeChange(int cost, int[] cashTill, int twenties, int tens = 0, int fives = 0, int ones = 0)
{
    cashTill[3] += twenties;
    cashTill[2] += tens;
    cashTill[1] += fives;
    cashTill[0] += ones;

    int amountPaid = twenties * 20 + tens * 10 + fives * 5 + ones;
    int changeNeeded = amountPaid - cost;

    if (changeNeeded < 0)
        throw new InvalidOperationException("InvalidOperationException: Not enough money provided to complete the transaction.");

    Console.WriteLine("Cashier Returns:");

    while ((changeNeeded > 19) && (cashTill[3] > 0))
    {
        cashTill[3]--;
        changeNeeded -= 20;
        Console.WriteLine("\t A twenty");
    }

    while ((changeNeeded > 9) && (cashTill[2] > 0))
    {
        cashTill[2]--;
        changeNeeded -= 10;
        Console.WriteLine("\t A ten");
    }

    while ((changeNeeded > 4) && (cashTill[1] > 0))
    {
        cashTill[1]--;
        changeNeeded -= 5;
        Console.WriteLine("\t A five");
    }

    while ((changeNeeded > 0) && (cashTill[0] > 0))
    {
        cashTill[0]--;
        changeNeeded--;
        Console.WriteLine("\t A one");
    }

    if (changeNeeded > 0)
        throw new InvalidOperationException("InvalidOperationException: The till is unable to make the correct change.");
}

static void LogTillStatus(int[] cashTill)
{
    Console.WriteLine("The till currently has:");
    Console.WriteLine($"{cashTill[3] * 20} in twenties");
    Console.WriteLine($"{cashTill[2] * 10} in tens");
    Console.WriteLine($"{cashTill[1] * 5} in fives");
    Console.WriteLine($"{cashTill[0]} in ones");
    Console.WriteLine();
}

static string TillAmountSummary(int[] cashTill)
{
    return $"The till has {cashTill[3] * 20 + cashTill[2] * 10 + cashTill[1] * 5 + cashTill[0]} dollars";

}
