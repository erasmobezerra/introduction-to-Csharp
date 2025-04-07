// // Método que ajusta horários agendados para um fuso horário GMT diferente
// // 
// int[] schedule = {800, 1200, 1600, 2000};
//
// DisplayAdjustedTimes(schedule, 6, -6);
//
// // Verificar se os valores GMT fornecidos estão entre -12 e 12
// void DisplayAdjustedTimes(int[] times, int currentGMT, int newGMT) 
// {
//     int diff = 0; // Diferença de tempo
//     
//     // Verificar se os valores GMT fornecidos estão entre -12 e 12
//     if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
//     {
//         Console.WriteLine("Invalid GMT");
//     }
//     // Se compartilharem o mesmo sinal (positivo ou ambos negativos)
//     else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0) 
//     {   //  Como as horas são representadas em centenas, você multiplica o resultado por 100
//         diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));     } 
//     else 
//     {   // Se os valores GMT tiverem sinais opostos    
//         diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
//     }
//     
//     for (int i = 0; i < times.Length; i++) 
//     {
//         int newTime = ((times[i] + diff)) % 2400;
//         Console.WriteLine($"{times[i]} -> {newTime}");
//     }
// }

/*  Recapitulação

As informações podem ser passadas para métodos na forma de parâmetros.
Os parâmetros são declarados na assinatura do método.
vários parâmetros são separados por vírgulas.
Os métodos podem aceitar argumentos variáveis ou literais.
 */


// ===== Entender o escopo do método =====

// -> Variáveis de Escopo
// -> Variáveis Globais (declaradas fora do escopo e que podem ser acessadas em qualquer programa por qualquer método
// string[] students = {"Jenna", "Ayesha", "Carlos", "Viktor"};
//
// DisplayStudents(students);
// DisplayStudents(new string[] {"Robert","Vanya"});
//
// void DisplayStudents(string[] students) 
// {
//     foreach (string student in students) 
//     {
//         Console.Write($"{student}, ");
//     }
//     Console.WriteLine();
// }


// double pi = 3.14159;
//
// PrintCircleInfo(12);
// PrintCircleInfo(24);
//
// void PrintCircleInfo(int radius) 
// {
//     Console.WriteLine($"Circle with radius {radius}");
//     PrintCircleArea(radius);
//     PrintCircleCircumference(radius);
// }
// void PrintCircleArea(int radius)
// {
//     double area = pi * (radius * radius);
//     Console.WriteLine($"Area = {area}");
// }
//
// void PrintCircleCircumference(int radius)
// {
//     double circumference = 2 * pi * radius;
//     Console.WriteLine($"Circumference = {circumference}");
// }

/* Recapitulação
Aqui está o que você aprendeu sobre escopo de método até agora:

As variáveis declaradas dentro do método só podem ser acessadas por esse método.
As variáveis declaradas em instruções de nível superior são acessíveis em qualquer programa.
Os métodos não têm acesso a variáveis definidas em métodos diferentes.
Os métodos podem chamar outros métodos.
 */


// ===== Usar parâmetros de tipo de referência e de valor =====

// => Testar passagem por valor
// as variáveis de tipo de valor têm seus valores copiados para o método.
// Cada variável tem a própria cópia do valor, portanto, a variável original não é modificada.
// int a = 3;
// int b = 4;
// int c = 0;
//
// Multiply(a, b, c);
// Console.WriteLine($"global statement: {a} x {b} = {c}");
//
// void Multiply(int a, int b, int c) 
// {
//     c = a * b;
//     Console.WriteLine($"inside Multiply method: {a} x {b} = {c}");
// }


// => Teste aprovado por referência
// O endereço do valor é passado para o método. A variável fornecida ao método faz referência ao valor
// naquele endereço, portanto, as operações nessa variável afetam o valor referenciado pela outra.
// int[] array = {1, 2, 3, 4, 5};
//
// PrintArray(array);
// Clear(array);
// PrintArray(array);
//
// void PrintArray(int[] array) 
// {
//     foreach (int a in array) 
//     {
//         Console.Write($"{a} ");
//     }
//     Console.WriteLine();
// }
//
// void Clear(int[] array) 
// {
//     for (int i = 0; i < array.Length; i++) 
//     {
//         array[i] = 0;
//     }
// }


// => Testes com cadeias de caracteres
// STRING é um tipo de referência, mas é imutável. Isso significa que uma vez atribuído um valor,
// ele não pode ser alterado. Em C#, quando métodos e operadores são usados para modificar uma
// cadeia de caracteres, o resultado retornado é, na verdade, um novo objeto de cadeia de caracteres.

// Os métodos que executam alterações em um parâmetro de cadeia de caracteres não afetam a cadeia de caracteres original
// string status = "Healthy";
//
// Console.WriteLine($"Start: {status}");
// SetHealth(status, false);
// Console.WriteLine($"End: {status}");
//
// void SetHealth(string status, bool isHealthy) 
// {
//  status = (isHealthy ? "Healthy" : "Unhealthy");
//  Console.WriteLine($"Middle: {status}");
// }


// Neste código, você sobrescreve a variável status global com o novo valor de cadeia de caracteres.
// string status = "Healthy";
//
// Console.WriteLine($"Start: {status}");
// SetHealth(false);
// Console.WriteLine($"End: {status}");
//
// void SetHealth(bool isHealthy) 
// {
//  status = (isHealthy ? "Healthy" : "Unhealthy");
//  Console.WriteLine($"Middle: {status}");
// }


//  ====== Métodos com parâmetros opcionais =======

// A linguagem C# permite o uso de parâmetros nomeados e opcionais: 
// => Os argumentos nomeados permitem que você especifique o valor de um parâmetro usando seu nome em vez de posição.
// => Os parâmetros opcionais permitem omitir esses argumentos ao chamar o método.
// => Os argumentos posicionais precisam estar na mesma ordem original

// ARGUMENTOS NOMEADOS
// string[] guestList = { "Rebecca", "Nadia", "Noor", "Jonte" };
// string[] rsvps = new string[10];
// int count = 0;
//
// void RSVP(string name, int partySize, string allergies, bool inviteOnly)
// {
//     if (inviteOnly)
//     {
//         bool found = false;
//         foreach (string guest in guestList)
//         {
//             if (guest.Equals(name))
//             {
//                 found = true;
//                 break;
//             }
//         }
//
//         if (!found)
//         {
//             Console.WriteLine($"Sorry, {name} is not on the guest list");
//             return;
//         }
//     }
//
//     rsvps[count] = $"Name: {name}, \tParty Size: {partySize}, \tAllergies: {allergies}";
//     count++;
// }
//
// // Usar argumentos nomeados em métodos com muitos argumentos, facilita a legibilidade
// RSVP("Rebecca", 1, "none", true); // ==> Argumentos Posicionais (precisam estar na ordem original)
// RSVP("Nadia", 2, "Nuts", true);
// RSVP(name: "Linh", partySize: 2, allergies: "none", inviteOnly: false); // ==> Argumentos Nomeados (podem estar fora da ordem original
// RSVP("Tony", inviteOnly: true, allergies: "Jackfruit",  partySize: 1); // ==> Argumento Posicional (na ordem original) e Argumentos Nomeados fora de ordem. 
// RSVP("Noor", 4, "none", false);
// RSVP("Jonte", 2, "Stone fruit", false);
// ShowRSVPs();
//
// void ShowRSVPs()
// {
//     Console.WriteLine("\nTotal RSVPs:");
//     for (int i = 0; i < count; i++)
//     {
//         Console.WriteLine(rsvps[i]);
//     }
// }


// PARÂMETROS OPCIONAIS
// Um parâmetro se torna opcional quando é atribuído um valor padrão. Se um parâmetro opcional for
// omitido dos argumentos, o valor padrão será usado quando o método for executado. Nesta etapa,
// você tornará os parâmetros partySize, allergies e inviteOnly opcionais.
// string[] guestList = { "Rebecca", "Nadia", "Noor", "Jonte" };
// string[] rsvps = new string[10];
// int count = 0;
//
// void RSVP(string name, int partySize = 1, string allergies = "none", bool inviteOnly = true) // parâmetros opcionais
// {
//  if (inviteOnly)
//  {
//   bool found = false;
//   foreach (string guest in guestList)
//   {
//    if (guest.Equals(name))
//    {
//     found = true;
//     break;
//    }
//   }
//
//   if (!found)
//   {
//    Console.WriteLine($"Sorry, {name} is not on the guest list");
//    return;
//   }
//  }
//
//  rsvps[count] = $"Name: {name}, \tParty Size: {partySize}, \tAllergies: {allergies}";
//  count++;
// }
//
// RSVP("Rebecca");
// RSVP("Nadia", 2, "Nuts");
// RSVP(name: "Linh", partySize: 2, inviteOnly: false);
// RSVP("Tony", allergies: "Jackfruit", inviteOnly: true);
// RSVP("Noor", 4, inviteOnly: false);
// RSVP("Jonte", 2, "Stone fruit", false);
// ShowRSVPs();
//
// void ShowRSVPs()
// {
//  Console.WriteLine("\nTotal RSVPs:");
//  for (int i = 0; i < count; i++)
//  {
//   Console.WriteLine(rsvps[i]);
//  }
// }

/* Recapitulação

Os parâmetros são declarados como opcionais definindo um valor padrão na assinatura do método.
Os argumentos nomeados são especificados com o nome do parâmetro, seguidos por dois-pontos e o valor do argumento.
Ao combinar argumentos nomeados e posicionais, você deve usar a ordem correta dos parâmetros.

 */


// ======== DESAFIO DE CÓDIGO ========
// Adicionar um método para exibir endereços de e-mail

// string[,] -> Matriz Bidimensional (é retangular e tem um númer ofixo de linhas e colunas

string[,] corporate =
{
    { "Robert", "Bavin" }, { "Simon", "Bright" },
    { "Kim", "Sinclair" }, { "Aashrita", "Kamath" },
    { "Sarah", "Delucchi" }, { "Sinan", "Ali" }
};

string[,] external =
{
    { "Vinnie", "Ashton" }, { "Cody", "Dysart" },
    { "Shay", "Lawrence" }, { "Daren", "Valdes" }
};

string externalDomain = "@hayworth.com";


for (int i = 0; i < corporate.GetLength(0); i++)
{
    CreateEmailAddress($"{corporate[i, 0]} {corporate[i, 1]}");
}


for (int i = 0; i < external.GetLength(0); i++)
{
    CreateEmailAddress($"{external[i, 0]} {external[i, 1]}", externalDomain);
}


void CreateEmailAddress(string fullname, string email = "@contoso.com")
{
    string firstTwoLetters = fullname.Substring(0, 2);
    string lastName = fullname.Substring(fullname.IndexOf(' ') + 1);
    string username = (firstTwoLetters + lastName).ToLower();
    string emailDomain = (username + email).ToLower();
    Console.WriteLine(emailDomain);
}



