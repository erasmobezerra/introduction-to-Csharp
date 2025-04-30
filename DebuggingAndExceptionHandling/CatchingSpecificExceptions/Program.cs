// =========== Capturar tipos de exceções específicos =================

// Você aprendeu que os objetos de exceção capturados pelo aplicativo C# são instâncias de uma classe de exceção. 
// Em termos gerais, código vai catch um dos seguintes:

// Um objeto de exceção que é uma instância da classe base System.Exception.
// Um objeto de exceção que é uma instância de um tipo de exceção que herda da classe base. 
// Por exemplo, uma instância da classe InvalidCastException.



// ===========  Analisar as propriedades de exceção ===================

// System.Exception é a classe base da qual todos os tipos de exceções derivadas herdam. 
// Cada tipo de exceção herda da classe base por meio de uma hierarquia de classe específica. 

// A maioria das classes que herdam de Exception não implementa membros adicionais nem fornece 
// funcionalidade adicional, apenas herdam de Exception. Portanto, analisar as propriedades da 
// classe Exception permite que você entenda a maioria das exceções e como você pode usar uma 
// exceção no código.

// try
// {
//     Process1();
// }
// catch
// {
//     Console.WriteLine("An exception has occurred");
// }

// Console.WriteLine("Exit program");


// static void Process1()
// {
//     try
//     {
//         WriteMessage();
//     }
//     catch (Exception ex)
//     {
//         Console.WriteLine($"Exception caught in Process1: {ex.Message}");
//     }
// }


// static void WriteMessage()
// {
//     double float1 = 3000.0;
//     double float2 = 0.0;
//     int number1 = 3000;
//     int number2 = 0;

//     Console.WriteLine(float1 / float2);
//     Console.WriteLine(number1 / number2);
// }



// ============ Capturar um tipo de exceção específico =============
// try
// {
//     Process1();
// }
// catch
// {
//     Console.WriteLine("An exception has occurred");
// }

// Console.WriteLine("Exit program");


// static void Process1()
// {
//     try
//     {
//         WriteMessage();
//     }
//     catch (DivideByZeroException ex)
//     {
//         Console.WriteLine($"Exception caught in Process1: {ex.Message}");
//     }
// }


// static void WriteMessage()
// {
//     double float1 = 3000.0;
//     double float2 = 0.0;
//     int number1 = 3000;
//     int number2 = 0;
//     byte smallNumber;

//     Console.WriteLine(float1 / float2);
//     // Console.WriteLine(number1 / number2);


//     // Verificação de estouro em uma conversão entre tipos integrais
//     // Se o valor não couber no tipo de destino, será lançada uma exceção OverflowException.
//     checked
//     {
//         try
//         {
//             smallNumber = (byte)number1;
//         }
//         catch (OverflowException ex)
//         {
//             Console.WriteLine($"Exception caught in WriteMessage: {ex.Message}");
//         }
//     }
// }



// ======== Capturar várias exceções em um bloco de código ==============
// try
// {
//     Process1();
// }
// catch
// {
//     Console.WriteLine("An exception has occurred");
// }

// Console.WriteLine("Exit program");


// static void Process1()
// {
//     try
//     {
//         WriteMessage();
//     }
//     catch (DivideByZeroException ex)
//     {
//         Console.WriteLine($"Exception caught in Process1: {ex.Message}");
//     }
// }
//
// static void WriteMessage()
// {
//     double float1 = 3000.0;
//     double float2 = 0.0;
//     int number1 = 3000;
//     int number2 = 0;
//     byte smallNumber;

//     try
//     {
//         Console.WriteLine(float1 / float2);
//         Console.WriteLine(number1 / number2);
//     }
//     catch (DivideByZeroException ex)
//     {
//         Console.WriteLine($"Exception caught in WriteMessage: {ex.Message}");
//     }
//
//     checked
//     {
//         try
//         {
//             smallNumber = (byte)number1;
//         }
//         catch (OverflowException ex)
//         {
//             Console.WriteLine($"Exception caught in WriteMessage: {ex.Message}");
//         }
//     }
// }





// ========= Capturar tipos de exceções separados em um bloco de código ============

// inputValues is used to store numeric values entered by a user
// Diferentes exceções podem ser capturadas caso o elemento da matriz não possa ser convertido em Inteiro
// string[] inputValues = new string[]{"three", "9999999999", "0", "2" };

// foreach (string inputValue in inputValues)
// {
//     int numValue = 0;
//     try
//     {
//         numValue = int.Parse(inputValue);
//     }
//     catch (FormatException)
//     {
//         Console.WriteLine("Invalid readResult. Please enter a valid number.");
//     }
//     catch (OverflowException)
//     {
//         Console.WriteLine("The number you entered is too large or too small.");
//     }
//     catch(Exception ex)
//     {
//         Console.WriteLine(ex.Message);
//     }
// }


/*
Recapitulação
Estes são alguns pontos importantes desta unidade que você deve se lembrar:

A cláusula catch deve ser configurada para capturar um tipo de exceção específico. Por exemplo, o tipo de exceção DivideByZeroException.
As propriedades de um objeto de exceção podem ser acessadas no bloco catch. Por exemplo, você pode usar a propriedade Message para informar o usuário do aplicativo sobre um problema.
Você poderá especificar duas ou mais cláusulas catch quando precisar capturar mais de um tipo de exceção.
*/





// ============== Concluir uma atividade de desafio para capturar exceções específicas =========================

// Você precisa atualizar o exemplo de código para que cada exceção seja capturada e a mensagem de erro correspondente seja exibida no console.
checked
{
    try
    {
        int num1 = int.MaxValue;
        int num2 = int.MaxValue;
        int result = num1 + num2;
        Console.WriteLine("Result: " + result);
    }
    catch (OverflowException ex)
    {
        Console.WriteLine("Error: The number is too large to be represented as an integer. " + ex.Message);
    }
}

try
{
    string str = null;
    int length = str.Length;
    Console.WriteLine("String Length: " + length);
}
catch (NullReferenceException ex)
{
    Console.WriteLine("Error: The reference is null. " + ex.Message);
}

try
{
    int[] numbers = new int[5];
    numbers[5] = 10;
    Console.WriteLine("Number at index 5: " + numbers[5]);
}
catch (IndexOutOfRangeException ex)
{
    Console.WriteLine("Error: Index out of range. " + ex.Message);
}

try
{
    int num3 = 10;
    int num4 = 0;
    int result2 = num3 / num4;
    Console.WriteLine("Result: " + result2);
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("Error: Cannot divide by zero. " + ex.Message);
}

Console.WriteLine("Exiting program.");