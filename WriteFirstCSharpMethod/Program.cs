/* 
*Como os métodos funcionam

O processo de desenvolvimento do método começa com a criação da assinatura do método. 
A assinatura do método declara os parâmetros de entrada, nome e tipo de retorno do método.
Por exemplo, considere a seguinte assinatura de método: 

*void SayHello();
*/




/* 
O nome do método é SayHello. O tipo de retorno é void, o que significa que o método não retorna dados. 
No entanto, os métodos podem retornar um valor de qualquer tipo de dado, como bool, int, double e também 
matrizes. Os parâmetros do método, se houverem, devem ser incluídos no parêntese (). Os métodos podem aceitar 
vários parâmetros de qualquer tipo de dados. Neste exemplo, o método não tem parâmetros.

Antes de executar o método, você precisa adicionar uma definição. A definição de método usa colchetes {} para 
conter o código que é executado quando o método é chamado. */

// O método pode ser chamado antes ou depois de sua definição. Por exemplo, o método SayHello pode ser definido e chamado usando a seguinte sintaxe:

/* SayHello();

void SayHello() 
{
    Console.WriteLine("Hello World!");
} */





// Observe que não é necessário ter o método definido antes de chamá-lo. Essa flexibilidade permite que você organize o código conforme achar melhor. 
// Normalmente definimos todos os métodos no final do programa. Por exemplo:

/* int[] a = {1,2,3,4,5};

Console.WriteLine("Contents of Array:");
PrintArray();

void PrintArray()
{
    foreach (int x in a)
    {
        Console.Write($"{x} ");
    }
    Console.WriteLine();
} */


/* 
*Práticas recomendadas
Ao escolher o nome de método, é importante mantê-lo conciso e deixar claro qual tarefa o método executa. Os nomes de métodos devem iniciar as 
palavras sempre com a primeira letra maiúscula e o restante minúsculas no estilo Pascal e geralmente não devem começar com dígitos. Os nomes 
dos parâmetros devem descrever o tipo de informação que o parâmetro representa. Considere as seguintes assinaturas de método: 

*void ShowData(string a, int b, int c);
*void DisplayDate(string month, int day, int year);
*/



// Criar um método para exibir números aleatórios
/* void DisplayRandomNumbers() 
{
    Random random = new Random();

    for (int i = 0; i < 5; i++) 
    {
        Console.Write($"{random.Next(1, 100)} ");
    }

    Console.WriteLine();
} */



/* 
*Recapitulação
Aqui está o que você aprendeu sobre métodos até agora:

Crie um método declarando o tipo de retorno, o nome, os parâmetros de entrada e o corpo do método.
Os nomes de método devem refletir claramente a tarefa que o método executa.
Use um método chamando seu nome e incluindo parênteses (). */




// *Aplicativo que acompanha os tempos de medicação em diferentes fusos horários.

/* int[] times = {800, 1200, 1600, 2000};
int diff = 0;

Console.WriteLine("Enter current GMT");
int currentGMT = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Current Medicine Schedule:");
DisplayTimes();

Console.WriteLine("Enter new GMT");
int newGMT = Convert.ToInt32(Console.ReadLine());

if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
{
    Console.WriteLine("Invalid GMT");
}
else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0) 
{
    diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
    AdjustTimes();
} 
else 
{
    diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
    AdjustTimes();
}

Console.WriteLine("New Medicine Schedule:");
DisplayTimes();

void DisplayTimes()
{
    // Format and display medicine times 
    foreach (int val in times)
    {
        string time = val.ToString();
        int len = time.Length;

        if (len >= 3)
        {
            time = time.Insert(len - 2, ":");
        }
        else if (len == 2)
        {
            time = time.Insert(0, "0:");
        }
        else
        {
            time = time.Insert(0, "0:0");
        }

        Console.Write($"{time} ");
    }
    Console.WriteLine();
}

void AdjustTimes() 
{
    // Adjust the times by adding the difference, keeping the value within 24 hours 
    for (int i = 0; i < times.Length; i++) 
    {
        times[i] = ((times[i] + diff)) % 2400;
    }
}
 */


 // * Compilar código com métodos
/* 
Usar métodos para estruturar código
Vamos supor que você seja um candidato em uma entrevista de codificação. O entrevistador deseja que você escreva um programa 
que verifique se um endereço IPv4 é válido ou inválido. Você recebe as seguintes regras:

1) Um endereço IPv4 válido consiste em quatro números separados por ponto
2) Cada número não deve conter zeros à esquerda
3) Cada número deve variar de 0 a 255 */

/*
if ipAddress consists of 4 numbers
and
if each ipAddress number has no leading zeroes
and
if each ipAddress number is in range 0 - 255

then ipAddress is valid

else ipAddress is invalid
*/


/* string[] ipv4Input = {"107.31.1.5", "255.0.0.255", "555..0.555", "255...255"};
string[] address;
bool validLength = false;
bool validZeroes = false;
bool validRange = false;

foreach (string ip in ipv4Input) 
{
    address = ip.Split(".", StringSplitOptions.RemoveEmptyEntries);

    ValidateLength(); 
    ValidateZeroes(); 
    ValidateRange();

    if (validLength && validZeroes && validRange) 
    {
        Console.WriteLine($"{ip} is a valid IPv4 address");
    } 
    else 
    {
        Console.WriteLine($"{ip} is an invalid IPv4 address");
    }
}

void ValidateLength() 
{
    validLength = address.Length == 4;
};

void ValidateZeroes() 
{
    foreach (string number in address) 
    {
        if (number.Length > 1 && number.StartsWith("0")) 
        {
            validZeroes = false;
            return;
        }
    }

    validZeroes = true;
}

void ValidateRange() 
{
    foreach (string number in address) 
    {
        int value = int.Parse(number);
        if (value < 0 || value > 255) 
        {
            validRange = false;
            return;
        }
    }
    validRange = true;
} */



/* 
*Recapitulação
Aqui está o que você aprendeu sobre como usar métodos até agora:

Os métodos podem ser usados para estruturar aplicativos rapidamente
A palavra-chave return pode ser usada para encerrar a execução do método
Cada etapa de um problema geralmente pode ser convertida em seu próprio método
Usar métodos para resolver pequenos problemas para criar sua solução */






// *Concluir o desafio de criar um método reutilizável

/* 

*Desafio de código: criar um método reutilizável
No momento, o jogo tem código para gerar a sorte de um jogador, mas não é reutilizável. Sua tarefa é criar um método tellFortune 
que pode ser chamado a qualquer momento e substituir a lógica existente por uma chamada ao seu método.

No código com o qual você começará, há uma matriz de texto genérica, seguida por matrizes de texto para boa, ruim e neutra. 
Dependendo do valor de luck, uma das matrizes é selecionada para ser exibida junto com o texto genérico.

Seu desafio é criar um método reutilizável que imprimirá a sorte de um jogador a qualquer momento. O método deve conter a 
lógica que já está presente no código fornecido. 


Random random = new Random();
int luck = random.Next(100);

string[] text = {"You have much to", "Today is a day to", "Whatever work you do", "This is an ideal time to"};
string[] good = {"look forward to.", "try new things!", "is likely to succeed.", "accomplish your dreams!"};
string[] bad = {"fear.", "avoid major decisions.", "may have unexpected outcomes.", "re-evaluate your life."};
string[] neutral = {"appreciate.", "enjoy time with friends.", "should align with your values.", "get in tune with nature."};

Console.WriteLine("A fortune teller whispers the following words:");
string[] fortune = (luck > 75 ? good : (luck < 25 ? bad : neutral));
for (int i = 0; i < 4; i++) 
{
    Console.Write($"{text[i]} {fortune[i]} ");
} */




Console.WriteLine("To draw your luck, enter an integer value:");
int luck = Convert.ToInt32(Console.ReadLine());
TellFortune();

void TellFortune()
{
    //Random random = new Random();
    //int luck = random.Next(100);

    string[] text = {"You have much to", "Today is a day to", "Whatever work you do", "This is an ideal time to"};
    string[] good = {"look forward to.", "try new things!", "is likely to succeed.", "accomplish your dreams!"};
    string[] bad = {"fear.", "avoid major decisions.", "may have unexpected outcomes.", "re-evaluate your life."};
    string[] neutral = {"appreciate.", "enjoy time with friends.", "should align with your values.", "get in tune with nature."};

    Console.WriteLine("A fortune teller whispers the following words:");
    string[] fortune = (luck > 75 ? good : (luck < 25 ? bad : neutral));
    for (int i = 0; i < 4; i++) 
    {
        Console.Write($"{text[i]} {fortune[i]} ");
    }
}