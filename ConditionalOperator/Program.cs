
/* 
// Operador Conficional ?:

int saleAmount = 1001;
int discount = saleAmount > 1000 ? 100 : 50;
Console.WriteLine($"Discount: {discount}");




// Usar o operador condicional embutido

saleAmount = 1001;
Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");
 */


/* 
// Desafio de código: escrever um código para exibir o resultado de um lançamento de moeda

Random random = new Random();
int sorteio = random.Next(0, 2);
Console.WriteLine(sorteio == 0 ? "heads" : "tails");
 */



// Desafio de lógica de decisão

string permission = "Admin";
//string permission = "Manager";
int level = 55;

if (permission == "Admin" && level > 55) 
{
    // Se o usuário for um administrador com um nível maior que 55, exiba a mensagem:
    Console.WriteLine("Welcome, Super Admin user.");
}

else if (permission == "Admin" && level <= 55)
{
    // Se o usuário for um administrador com um nível menor ou igual a 55, exiba a mensagem:
    Console.WriteLine("Welcome, Admin user.");
}

else if (permission == "Manager" && level >= 20)
{
    // Se o usuário for um gerente com um nível maior ou igual a 20, exiba a mensagem:
    Console.WriteLine("Contact an Admin for access.");
}

else if (permission == "Manager" && level < 20)
{
    // Se o usuário for um gerente com um nível menor que 20, exiba a mensagem:
    Console.WriteLine("You do not have sufficient privileges.");
}

else 
{
    // Se o usuário não for um administrador nem um gerente, exiba a mensagem:
    Console.WriteLine("You do not have sufficient privileges.");
}


/* 
//O código a seguir é uma solução possível para o desafio da unidade anterior.
string permission = "Admin|Manager";
int level = 53;

if (permission.Contains("Admin"))
{
    if (level > 55)
    {
        Console.WriteLine("Welcome, Super Admin user.");
    }
    else
    {
        Console.WriteLine("Welcome, Admin user.");
    }
}
else if (permission.Contains("Manager"))
{
    if (level >= 20)
    {
        Console.WriteLine("Contact an Admin for access.");
    }
    else
    {
        Console.WriteLine("You do not have sufficient privileges.");
    }
}
else
{
    Console.WriteLine("You do not have sufficient privileges.");
}
 */



