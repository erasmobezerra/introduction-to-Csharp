using System;

string[] pettingZoo =
{
    "alpacas", "capybaras", "chickens", "ducks", "emus", "geese",
    "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macaws",
    "ostriches", "pigs", "ponies", "rabbits", "sheep", "tortoises",
};

PlanSchoolVisit("School A");
PlanSchoolVisit("School B", 3);
PlanSchoolVisit("School C", 2);

void PlanSchoolVisit(string schoolName, int groups = 6)
{
    RandomizeAnimals();
    string[,] group = AssignGroup(groups);
    Console.WriteLine(schoolName);
    PrintGroup(group);
}

// Sorteia os animais de maneira aleatória
void RandomizeAnimals()
{
    Random random = new Random();

    for (int i = 0; i < pettingZoo.Length; i++)
    {
        int r = random.Next(i, pettingZoo.Length);

        string temp = pettingZoo[r];
        pettingZoo[r] = pettingZoo[i];
        pettingZoo[i] = temp;
    }
}

// Atribui os animais do zoológico de estimação a grupos.
// Retorna uma matriz 2D e tamanho de grupo padrão de 6
string[,] AssignGroup(int groups = 6)
{
    string[,] result = new string[groups, pettingZoo.Length / groups];
    
    int start = 0;
    for (int i = 0; i < groups; i++) // Percorre cada grupo (linha da matriz)
    {
        for (int j = 0; j < result.GetLength(1); j++) // Percorre os índices de cada grupo (coluna da matriz)
        {
            result[i, j] = pettingZoo[start++];
        }
    }
    return result;
}

void PrintGroup(string[,] group) 
{
    for (int i = 0; i < group.GetLength(0); i++) 
    {
        Console.Write($"Group {i + 1}: ");
        for (int j = 0; j < group.GetLength(1); j++) 
        {
            Console.Write($"{group[i,j]}  ");
        }
        Console.WriteLine();
    }
}