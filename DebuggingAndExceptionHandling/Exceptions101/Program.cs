// ======== Implementar o tratamento de exceção try-catch ============

//Implementar um try-catch simples
// double float1 = 3000.0;
// double float2 = 0.0;
// int number1 = 3000;
// int number2 = 0;

// try
// {
//     Console.WriteLine(float1 / float2);
//     Console.WriteLine(number1 / number2);
// }
// catch
// {
//     Console.WriteLine("An exception has been caught");
// }

// Console.WriteLine("Exit program");


// Capturar exceções geradas nos métodos chamados
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
//     WriteMessage();
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



// ============= Concluir uma atividade de desafio para try-catch  =====================

// 1) Atualize o método Process1 para capturar a exceção gerada no método WriteMessage.
// 2) O método Process1 imprimirá a seguinte mensagem no console quando a exceção for capturada: "Exception caught in Process1"
// 3) Não altere nenhum código fora do método Process1.
// 4) Quando você executar o aplicativo atualizado, ele vai gerar a seguinte saída:
// ∞
// Exception caught in Process1
// Exit program
try
{
    Process1();
}
catch
{
    Console.WriteLine("An exception has occurred");
}

Console.WriteLine("Exit program");

// O método WriteMessage é chamado no bloco de código try, que permite que Process1 
// capture a exceção antes de ser capturada pela cláusula catch nas instruções de nível superior.
static void Process1()
{
    try
    {
        WriteMessage();    
    }
    catch 
    {        
        Console.WriteLine("Exception caught in Process1");
    }
    
}

static void WriteMessage()
{
    double float1 = 3000.0;
    double float2 = 0.0;
    int number1 = 3000;
    int number2 = 0;

    Console.WriteLine(float1 / float2);
    Console.WriteLine(number1 / number2);
}

// Observe que, como a exceção é capturada dentro de Process1, o bloco de código catch
// nas instruções de nível superior não é executado. Os benefícios obtidos com a captura 
// de exceções em diferentes níveis na pilha de chamadas se tornam mais evidentes quando 
// tipos de exceção específicos são capturados. Você analisará os tipos de exceções na próxima unidade.