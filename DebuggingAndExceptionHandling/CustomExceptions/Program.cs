// ============ Analisar como criar e gerar exceções em C# ==============
/*
    O .NET fornece uma hierarquia de classes de exceção derivada da classe base System.Exception. 
    1) Os aplicativos C# podem criar e gerar exceções de qualquer tipo de exceção. 
    2) Os desenvolvedores também podem personalizar os objetos de exceção com informações específicas 
    do aplicativo atribuindo valores de propriedade.
*/



// ============ 1) Criar um objeto de exceção ==================

/*
    O tipo de exceção criado depende do problema de codificação e deve corresponder à finalidade pretendida 
    da exceção o mais próximo possível.

    Estes são alguns tipos de exceções comuns que você pode usar ao criar uma exceção:

    -> ArgumentException ou ArgumentNullException: use esses tipos de exceções quando um método ou um construtor for chamado com um valor de argumento inválido ou uma referência nula.
    -> InvalidOperationException: use esse tipo de exceção quando as condições operacionais de um método não derem suporte à conclusão bem-sucedida de uma chamada de método específica.
    -> NotSupportedException: use esse tipo de exceção quando não houver suporte para uma operação ou um recurso.
    -> IOException: use esse tipo de exceção em caso de falha de uma operação de entrada/saída.
    -> FormatException: use esse tipo de exceção quando o formato de uma cadeia de caracteres ou de dados estiver incorreto

    A palavra-chave new é usada para criar uma instância de uma exceção. Por exemplo, você pode criar uma instância 
    do tipo de exceção ArgumentException da seguinte maneira:

    ArgumentException invalidArgumentException = new ArgumentException();
*/



// ============ 2) Configurar e gerar exceções personalizadas ==================

/*
    O processo usado para gerar um objeto de exceção envolve a criação de uma instância de uma classe derivada de exceção, 
    opcionalmente configurando as propriedades da exceção e gerando o objeto com a palavra-chave throw.

    É útil personalizar uma exceção com informações contextuais antes de gerá-la. Você pode fornecer informações específicas 
    do aplicativo no objeto de exceção configurando as propriedades dele.

    -> cria um objeto de exceção chamado invalidArgumentException com uma propriedade Message personalizada 
     < ArgumentException invalidArgumentException = new ArgumentException("ArgumentException: The 'GraphData' method received data outside the expected range."); >
    -> e, em seguida, gera a exceção:
     < throw invalidArgumentException; >

    Um objeto de exceção também pode ser criado diretamente em uma instrução throw. Por exemplo:
     < throw new FormatException("FormatException: Calculations in process XYZ have been cancelled due to invalid data format."); >

    Algumas considerações a serem feitas ao gerar uma exceção incluem:

    -> A propriedade Message deve explicar o motivo da exceção. No entanto, as informações confidenciais ou que representam 
       uma preocupação de segurança não devem ser colocadas no texto da mensagem.

    -> A propriedade StackTrace geralmente é usada para rastrear a origem da exceção. 
*/

// Neste exemplo de código, as instruções de nível superior chamam o método BusinessProcess1, 
// transmitindo uma matriz de cadeia de caracteres que contém valores inseridos pelo usuário. 
// O método BusinessProcess1 espera valores de entrada de usuário que possam ser convertidos 
// em um inteiro. Quando o método encontra dados com um formato inválido, ele cria uma instância 
// do tipo de exceção FormatException usando uma propriedade Message personalizada. Em seguida, 
// o método gera a exceção. A exceção é capturada nas instruções de nível superior como um objeto 
// chamado ex. As propriedades do objeto ex são analisadas antes da exibição da mensagem de exceção 
// para o usuário. Primeiro, o código analisa a propriedade StackTrace para ver se ela contém "BusinessProcess1". 
// Em segundo lugar, o objeto de exceção ex é verificado como sendo do tipo FormatException.

// string[][] userEnteredValues = new string[][]
// {
//         new string[] { "1", "two", "3"},
//         new string[] { "0", "1", "2"}
// };

// foreach (string[] userEntries in userEnteredValues)
// {
//     try
//     {
//         BusinessProcess1(userEntries);
//     }
//     catch (Exception ex)
//     {
//         if (ex.StackTrace.Contains("BusinessProcess1") && (ex is FormatException))
//         {
//             Console.WriteLine(ex.Message);
//         }
//     }
// }

// static void BusinessProcess1(string[] userEntries)
// {
//     int valueEntered;

//     foreach (string userValue in userEntries)
//     {
//         try
//         {
//             valueEntered = int.Parse(userValue);

//             // completes required calculations based on userValue
//             // ...
//         }
//         catch (FormatException)
//         {
//             FormatException invalidFormatException = new FormatException("FormatException: User input values in 'BusinessProcess1' must be valid integers");
//             throw invalidFormatException;
//         }
//     }
// }




// ==== Como gerar exceções novamente =====

// Além de gerar uma nova exceção, THROW pode ser usado para gerar uma exceção novamente dentro de um bloco de código catch. 
// Nesse caso, THROW não usa um operando de exceção.

// Quando você gera novamente uma exceção, o objeto de exceção original é usado, para que você não perca nenhuma informação
// sobre a exceção. Caso você deseje criar um objeto de exceção que encapsula a exceção original, transmita a exceção original 
// como um argumento para o construtor de um novo objeto de exceção

// try
// {
//     OperatingProcedure1();
// }
// catch (Exception ex)
// {
//     Console.WriteLine(ex.Message);
//     Console.WriteLine("Exiting application.");
// }

// static void OperatingProcedure1()
// {
//     string[][] userEnteredValues = new string[][]
//     {
//         new string[] { "1", "two", "3"},
//         new string[] { "0", "1", "2"}
//     };

//     foreach(string[] userEntries in userEnteredValues)
//     {
//         try
//         {
//             BusinessProcess1(userEntries);
//         }
//         catch (Exception ex)
//         {
//             if (ex.StackTrace.Contains("BusinessProcess1"))
//             {
//                 if (ex is FormatException)
//                 {
//                     Console.WriteLine(ex.Message);
//                     Console.WriteLine("Corrective action taken in OperatingProcedure1");
//                 }
//                 else if (ex is DivideByZeroException)
//                 {
//                     Console.WriteLine(ex.Message);
//                     Console.WriteLine("Partial correction in OperatingProcedure1 - further action required");

//                     // re-throw the original exception
//                     throw;
//                 }
//                 else
//                 {
//                     // create a new exception object that wraps the original exception
//                     throw new ApplicationException("An error occurred - ", ex);
//                 }
//             }
//         }

//     }
// }

// static void BusinessProcess1(string[] userEntries)
// {
//     int valueEntered;

//     foreach (string userValue in userEntries)
//     {
//         try
//         {
//             valueEntered = int.Parse(userValue);

//             checked
//             {
//                 int calculatedValue = 4 / valueEntered;
//             }
//         }
//         catch (FormatException)
//         {
//             FormatException invalidFormatException = new FormatException("FormatException: User input values in 'BusinessProcess1' must be valid integers");
//             throw invalidFormatException;
//         }
//         catch (DivideByZeroException)
//         {
//             DivideByZeroException unexpectedDivideByZeroException = new DivideByZeroException("DivideByZeroException: Calculation in 'BusinessProcess1' encountered an unexpected divide by zero");
//             throw unexpectedDivideByZeroException;

//         }
//     }
// }



// ====== Exercício – Criar e gerar uma exceção =========

// Prompt the user for the lower and upper bounds
// Console.Write("Enter the lower bound: ");
// int lowerBound = int.Parse(Console.ReadLine());

// Console.Write("Enter the upper bound: ");
// int upperBound = int.Parse(Console.ReadLine());

// decimal averageValue = 0;

// bool exit = false;
// do
// {
//     try
//     {
//         // Calculate the sum of the even numbers between the bounds
//         averageValue = AverageOfEvenNumbers(lowerBound, upperBound);

//         // Display the result to the user
//         Console.WriteLine($"The average of even numbers between {lowerBound} and {upperBound} is {averageValue}.");

//         // Wait for user input
//         Console.ReadLine();

//         exit = true;
//     }
//     catch (ArgumentOutOfRangeException ex)
//     {
//         Console.WriteLine("An error has occurred.");
//         Console.WriteLine(ex.Message);
//         Console.WriteLine($"The upper bound must be greater than {lowerBound}");
//         Console.Write($"Enter a new upper bound (or enter Exit to quit): ");
//         string? userResponse = Console.ReadLine();
//         if (userResponse.ToLower().Contains("exit"))
//         {
//             exit = true;
//         }
//         else
//         {
//             exit = false;
//             upperBound = int.Parse(userResponse);
//         }
//     }
// } while (exit == false);


// static decimal AverageOfEvenNumbers(int lowerBound, int upperBound)
// {
//     if (lowerBound >= upperBound)
//     {
//         throw new ArgumentOutOfRangeException("upperBound", "ArgumentOutOfRangeException: upper bound must be greater than lower bound.");
//     }

//     int sum = 0;
//     int count = 0;
//     decimal average = 0;

//     for (int i = lowerBound; i <= upperBound; i++)
//     {
//         if (i % 2 == 0)
//         {
//             sum += i;
//             count++;
//         }
//     }

//     average = (decimal)sum / count;

//     return average;
// }



// ========= Exercício – Concluir uma atividade de desafio para criar e gerar exceções ============
string[][] userEnteredValues = new string[][]
{
            new string[] { "1", "2", "3"},
            new string[] { "1", "two", "3"},
            new string[] { "0", "1", "2"}
};

string overallStatusMessage = "";

overallStatusMessage = Workflow1(userEnteredValues);

if (overallStatusMessage == "operating procedure complete")
{
    Console.WriteLine("'Workflow1' completed successfully.");
}
else
{
    Console.WriteLine("An error occurred during 'Workflow1'.");
    Console.WriteLine(overallStatusMessage);
}

static string Workflow1(string[][] userEnteredValues)
{
    string operationStatusMessage = "good";
    string processStatusMessage = "";

    foreach (string[] userEntries in userEnteredValues)
    {
        processStatusMessage = Process1(userEntries);

        if (processStatusMessage == "process complete")
        {
            Console.WriteLine("'Process1' completed successfully.");
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("'Process1' encountered an issue, process aborted.");
            Console.WriteLine(processStatusMessage);
            Console.WriteLine();
            operationStatusMessage = processStatusMessage;
        }
    }

    if (operationStatusMessage == "good")
    {
        operationStatusMessage = "operating procedure complete";
    }

    return operationStatusMessage;
}

static string Process1(String[] userEntries)
{
    string processStatus = "clean";
    string returnMessage = "";
    int valueEntered;

    foreach (string userValue in userEntries)
    {
        bool integerFormat = int.TryParse(userValue, out valueEntered);

        if (integerFormat == true)
        {
            if (valueEntered != 0)
            {
                checked
                {
                    int calculatedValue = 4 / valueEntered;
                }
            }
            else
            {
                returnMessage = "Invalid data. User input values must be non-zero values.";
                processStatus = "error";
            }
        }
        else
        {
            returnMessage = "Invalid data. User input values must be valid integers.";
            processStatus = "error";
        }
    }

    if (processStatus == "clean")
    {
        returnMessage = "process complete";
    }

    return returnMessage;
}