/*
Este aplicativo gerencia transações no caixa de uma loja. O caixa possui uma caixa registradora, e o caixa possui um caixa eletrônico
que é preparado com diversas notas todas as manhãs. O caixa inclui notas de quatro valores: R$ 1, R$ 5, R$ 10 e R$ 20. O caixa eletrônico é usado
para fornecer troco ao cliente durante a transação. O custo do item é um número gerado aleatoriamente entre 2 e 49. O cliente oferece o pagamento 
com base em um algoritmo que determina um número de notas em cada valor.

Diariamente, o caixa eletrônico é abastecido no início do dia. Conforme as transações ocorrem, o caixa eletrônico é gerenciado por um método 
chamado "MakeChange" (os pagamentos do cliente entram e o troco devolvido ao cliente sai). Um cálculo separado de "verificação de segurança" 
usado para verificar a quantidade de dinheiro no caixa eletrônico é realizado no "programa principal". Esta verificação de segurança
é usada para garantir que a lógica no método MakeChange esteja funcionando conforme
o esperado.


ESPECIFICAÇÃO: 

Os seguintes requisitos de especificação se aplicam às transações simuladas:

instruções de nível superior simulam transações usando custos de item gerados aleatoriamente.
as instruções de nível superior geram valores aleatórios para itemCost no intervalo 2 - 49.
as instruções de nível superior simulam 100 transações.

A saída da transação relatada precisa incluir:

Um registro de 100 tentativas de transações.
Instâncias de uma mensagem informando: "Não foi possível fazer a transação: InvalidOperationException: não foi fornecido dinheiro suficiente para concluir a transação."
Instâncias de uma mensagem informando: "Não foi possível fazer a transação: InvalidOperationException: a gaveta do caixa não pode trocar o dinheiro fornecido."
Um valor de gaveta do caixa relatado igual ao valor de gaveta do caixa esperado.
*/


string? readResult = null;
bool useTestData = false;

Console.Clear();

int[] cashTill = new int[] { 0, 0, 0, 0 };
int registerCheckTillTotal = 0;

// registerDailyStartingCash: $1 x 50, $5 x 20, $10 x 10, $20 x 5 => ($350 total)
int[,] registerDailyStartingCash = new int[,] { { 1, 50 }, { 5, 20 }, { 10, 10 }, { 20, 5 } };

int[] testData = new int[] { 6, 10, 17, 20, 31, 36, 40, 41 };
int testCounter = 0;

LoadTillEachMorning(registerDailyStartingCash, cashTill);

registerCheckTillTotal = registerDailyStartingCash[0, 0] * registerDailyStartingCash[0, 1] + registerDailyStartingCash[1, 0] * registerDailyStartingCash[1, 1] + registerDailyStartingCash[2, 0] * registerDailyStartingCash[2, 1] + registerDailyStartingCash[3, 0] * registerDailyStartingCash[3, 1];

// display the number of bills of each denomination currently in the till
LogTillStatus(cashTill);

// display a message showing the amount of cash in the till
Console.WriteLine(TillAmountSummary(cashTill));

// display the expected registerDailyStartingCash total
Console.WriteLine($"Expected till value: {registerCheckTillTotal}");
Console.WriteLine();

var valueGenerator = new Random((int)DateTime.Now.Ticks);

int transactions = 100;

if (useTestData)
{
    transactions = testData.Length;
}

while (transactions > 0)
{
    transactions -= 1;
    int itemCost = valueGenerator.Next(2, 50);

    if (useTestData)
    {
        itemCost = testData[testCounter];
        testCounter += 1;
    }

    int paymentOnes = itemCost % 2;                 // value is 1 when itemCost is odd, value is 0 when itemCost is even
    int paymentFives = (itemCost % 10 > 7) ? 1 : 0; // value is 1 when itemCost ends with 8 or 9, otherwise value is 0
    int paymentTens = (itemCost % 20 > 13) ? 1 : 0; // value is 1 when 13 < itemCost < 20 OR 33 < itemCost < 40, otherwise value is 0
    int paymentTwenties = (itemCost < 20) ? 1 : 2;  // value is 1 when itemCost < 20, otherwise value is 2

    // display messages describing the current transaction
    Console.WriteLine($"Customer is making a ${itemCost} purchase");
    Console.WriteLine($"\t Using {paymentTwenties} twenty dollar bills");
    Console.WriteLine($"\t Using {paymentTens} ten dollar bills");
    Console.WriteLine($"\t Using {paymentFives} five dollar bills");
    Console.WriteLine($"\t Using {paymentOnes} one dollar bills");

    try
    {
        // MakeChange manages the transaction and updates the till 
        MakeChange(itemCost, cashTill, paymentTwenties, paymentTens, paymentFives, paymentOnes);

        // Backup Calculation - each transaction adds current "itemCost" to the till
        registerCheckTillTotal += itemCost;
    }
    catch (InvalidOperationException e)
    {
        Console.WriteLine($"Could not complete transaction: {e.Message}");
    }

    Console.WriteLine(TillAmountSummary(cashTill));
    Console.WriteLine($"Expected till value: {registerCheckTillTotal}");
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
    // o array fictionalCashTill armazenará a copia o valor do caixa antes da abertura do mesmo.
    int[] fictionalCashTill = new int[4];
    // O método Array.Copy garante que os elementos sejam copiados, não a referência do array
    Array.Copy(cashTill, fictionalCashTill, fictionalCashTill.Length);

    // Valor pago pelo comprador 
    int amountPaid = twenties * 20 + tens * 10 + fives * 5 + ones;

    // Valor do Troco -> Diferença entre valor pago e valor do produto
    int changeNeeded = amountPaid - cost;

    // Se o comprador não possui dinheiro suficiente para comprar o produto
    if (changeNeeded < 0)
    {   // o método MakeChange é finalizado com o lançamento da exceção InvalidOperationException
        throw new InvalidOperationException("InvalidOperationException: Not enough money provided to complete the transaction.");
    }

    // Inserindo no caixa o dinheiro do cliente
    cashTill[3] += twenties;
    cashTill[2] += tens;
    cashTill[1] += fives;
    cashTill[0] += ones;

    // O caixa prepara o seguinte troco:
    Console.WriteLine("Cashier prepares the following change:");
    // Se changeNeeded > 0, o vendendor deve preparar para retirar o troco do caixa.      
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
        changeNeeded -= 1;
        Console.WriteLine("\t A one");
    }
    // Se até aqui changeNeeded = 0, o método é finalizado pois foi possível dar o troco correto ao comprador

    // Se mesmo assim changeNeeded > 0, é porque o caixa não tem como dar troco ao dinheiro fornecido, então o programa lança uma exceção
    if (changeNeeded > 0)
    {
        // Restabelece o valor do caixa para o montante existente antes da abertura.
        Array.Copy(fictionalCashTill, cashTill, cashTill.Length);
        throw new InvalidOperationException("InvalidOperationException: The till is unable to make change for the cash provided.");
    }

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
