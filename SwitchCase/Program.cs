// Criar e testar uma instrução switch
using System.Diagnostics;

int employeeLevel = 201;
string employeeName = "John Smith";

string title = "";

switch (employeeLevel)
{
    case 100:
        title = "Junior Associate";
        break;
    case 200:
        title = "Senior Associate";
        break;
    case 300:
        title = "Manager";
        break;
    case 400:
        title = "Senior Manager";
        break;
    default:
        title = "Associate";
        break;
}

Console.WriteLine($"{employeeName}, {title}");



// Modificar uma seção switch para incluir vários rótulos
int employeeLevel1 = 100;
string employeeName1 = "John Smith";

string title1 = "";

switch (employeeLevel1)
{
    case 100:
    case 200:
        title1 = "Senior Associate";
        break;
    case 300:
        title1 = "Manager";
        break;
    case 400:
        title1 = "Senior Manager";
        break;
    default:
        title1 = "Associate";
        break;
}

Console.WriteLine($"{employeeName1}, {title1}");


/* Recapitulação
Veja as principais novidades que você aprendeu sobre a instrução switch:

Use a instrução switch quando você tiver um valor com várias correspondências possíveis, cada uma delas exigindo um branch em sua lógica de código.
Uma única seção de opção que contém a lógica de código que pode ser correspondida usando um ou mais rótulos definidos pela palavra-chave case.
Use a palavra-chave opcional default para criar um rótulo e uma seção de opção que serão usados quando nenhum outro rótulo de caso corresponder.
 */







// DESAFIO DE CÓDIGO: reescrever if-elseif-else usando uma instrução switch

// Original: 

// SKU = Stock Keeping Unit. 
// SKU value format: <product #>-<2-letter color code>-<size code>
/*
string sku = "01-MN-L";

string[] product = sku.Split('-');

string type = "";
string color = "";
string size = "";

if (product[0] == "01")
{
    type = "Sweat shirt";
} else if (product[0] == "02")
{
    type = "T-Shirt";
} else if (product[0] == "03")
{
    type = "Sweat pants";
}
else
{
    type = "Other";
}

if (product[1] == "BL")
{
    color = "Black";
} else if (product[1] == "MN")
{
    color = "Maroon";
} else
{
    color = "White";
}

if (product[2] == "S")
{
    size = "Small";
} else if (product[2] == "M")
{
    size = "Medium";
} else if (product[2] == "L")
{
    size = "Large";
} else
{
    size = "One Size Fits All";
}

Console.WriteLine($"Product: {size} {color} {type}");
*/


// Reformulado com switch case :

// SKU = Stock Keeping Unit. 
// SKU value format: <product #>-<2-letter color code>-<size code>
string sku = "01-MN-L";

string[] product = sku.Split('-');

string type = "";
string color = "";
string size = "";

switch (product[0]) 
{
    case "01":
        type = "Sweat shirt";
        break;
    case "02":
        type = "T-Shirt";
        break;
    case "03":
        type = type = "Sweat pants";
        break;
    default:
        type = "Other";
        break;
}

switch (product[1])
{
    case "BL":
        color = "Black";
        break;
    case "MN":
        color = "Maroon";
        break;
    default:
        color = "White";
        break;
}


switch (product[2])
{
    case "S":
        size = "Small";
        break;
    case "M":
        size = "Medium";
        break;
    case "L":
        size = "Large";
        break;
    default:
        size = "One Size Fits All";
        break;
}


Console.WriteLine($"Product: {size} {color} {type}");