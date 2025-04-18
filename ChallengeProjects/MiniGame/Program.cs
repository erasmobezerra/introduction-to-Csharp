﻿Random random = new Random();
Console.CursorVisible = false;
int height = Console.WindowHeight - 1;
int width = Console.WindowWidth - 5;
bool shouldExit = false;

// Console position of the player
int playerX = 0;
int playerY = 0;

// Console position of the food
int foodX = 0;
int foodY = 0;

// Available player and food strings
string[] states = {"('-')", "(^-^)", "(X_X)"};
string[] foods = {"@@@@@", "$$$$$", "#####"};

// Current player string displayed in the Console
string player = states[0];

// Index of the current food
int food = 0;



InitializeGame();
while (!shouldExit)
{
    if (PlayerAppearanceIsStates2())
        FreezePlayer();
    
    Move(closeTerminalOnNonDirectionalKey: true, increaseMovementSpeed: PlayerAppearanceIsStates1());
    
    if (CheckIfPlayerConsumedFood())
    {
        ChangePlayer();
        ShowFood();
    }
    
    ExitWhenResizingTerminal();
}


// Terminates the program if the terminal is resized
void ExitWhenResizingTerminal()
{
    if (TerminalResized())
    {
        Console.Clear();
        Console.WriteLine("Console was resized. Program exiting.");
        Environment.Exit(0);
    }
}

// Returns true if the Terminal was resized 
bool TerminalResized() 
{
    return height != Console.WindowHeight - 1 || width != Console.WindowWidth - 5;
}

// Displays random food at a random location
void ShowFood() 
{
    // Update food to a random index
    food = random.Next(0, foods.Length);

    // Update food position to a random location
    foodX = random.Next(0, width - player.Length);
    foodY = random.Next(0, height - 1);

    // Display the food at the location
    Console.SetCursorPosition(foodX, foodY);
    Console.Write(foods[food]);
}

// If the positions of the player and the food are the same, the player has consumed the food
bool CheckIfPlayerConsumedFood()
{
    // Quando player estiver com movimento opcional de 3, ao chegar na comida, deve andar
    // playerY 
    return (playerX == foodX && playerY == foodY);
}

// Changes the player to match the food consumed
void ChangePlayer() 
{
    player = states[food];
    Console.SetCursorPosition(playerX, playerY);
    Console.Write(player);
}

bool PlayerAppearanceIsStates1()
{
    return player == "(^-^)";
}

bool PlayerAppearanceIsStates2()
{
    return player == "(X_X)";
}

// Temporarily stops the player from moving
void FreezePlayer() 
{
    System.Threading.Thread.Sleep(1000);
    player = states[0];
}

// Reads directional input from the Console and moves the player
// Default value closeTerminalOnNonDirectionalKey = false. If true, Quit Terminal on non-directional key
// Default value increaseMovementSpeed = false. If true, increase or decrease the speed of movement to the right and left by 3 units
void Move(bool closeTerminalOnNonDirectionalKey = false, bool increaseMovementSpeed = false)
{
    int lastX = playerX;
    int lastY = playerY;
    
    // Captura o tecla pressionada sem imprimir no console
    switch (Console.ReadKey(true).Key) 
    {
        case ConsoleKey.UpArrow:
            playerY--; 
            break;
		case ConsoleKey.DownArrow: 
            playerY++; 
            break;
        case ConsoleKey.LeftArrow:
            playerX -= increaseMovementSpeed ? 3 : 1;
            break;
        case ConsoleKey.RightArrow:
            playerX += increaseMovementSpeed ? 3 : 1;
            break;
        default:
            if (closeTerminalOnNonDirectionalKey)
                Environment.Exit(0);
            break;
    }

    // Clear the characters at the previous position
    Console.SetCursorPosition(lastX, lastY);
    for (int i = 0; i < player.Length; i++) 
    {
        Console.Write(" ");
    }

    // Keep player position within the bounds of the Terminal window
    playerX = (playerX < 0) ? 0 : (playerX >= width ? width : playerX);
    playerY = (playerY < 0) ? 0 : (playerY >= height ? height : playerY);

    // Draw the player at the new location
    Console.SetCursorPosition(playerX, playerY);
    Console.Write(player);
}

// Clears the console, displays the food and player
void InitializeGame() 
{
    Console.Clear();
    ShowFood();
    Console.SetCursorPosition(0, 0);
    Console.Write(player);
}