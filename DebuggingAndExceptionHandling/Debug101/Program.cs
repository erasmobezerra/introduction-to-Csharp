/*  
This code instantiates a value and then calls the ChangeValue method
to update the value. The code then prints the updated value to the console.
*/
int x = 5;
x = ChangeValue(x);
Console.WriteLine(x);

int ChangeValue(int value) 
{
    value = 10;
    return value;
}



// bool exit = false;
// var rand = new Random();
// int num1 = 5;
// int num2 = 5;

// do
// {
//     num1 = rand.Next(1, 11);
//     num2 = num1 + rand.Next(1, 51);

// } while (exit == false);



// string? readResult;
// int startIndex = 0;
// bool goodEntry = false;

// int[] numbers = { 1, 2, 3, 4, 5 };

// // Display the array to the console.
// Console.Clear();
// Console.Write("\n\rThe 'numbers' array contains: { ");
// foreach (int number in numbers)
// {
//     Console.Write($"{number} ");
// }

// // To calculate a sum of array elements, 
// //  prompt the user for the starting element number.
// Console.WriteLine($"}}\n\r\n\rTo sum values 'n' through 5, enter a value for 'n':");
// while (goodEntry == false)
// {
//     readResult = Console.ReadLine();
//     goodEntry = int.TryParse(readResult, out startIndex);

//     if (startIndex > 5)
//     {
//         goodEntry = false;
//         Console.WriteLine("\n\rEnter an integer value between 1 and 5");
//     }
// }

// // Display the sum and then pause.
// Console.WriteLine($"\n\rThe sum of numbers {startIndex} through {numbers.Length} is: {SumValues(numbers, startIndex - 1)}");

// Console.WriteLine("press Enter to exit");
// readResult = Console.ReadLine();

// // This method returns the sum of elements n through 5
// static int SumValues(int[] numbers, int n)
// {
//     int sum = 0;
//     for (int i = n; i < numbers.Length; i++)
//     {
//         sum += numbers[i];
//     }
//     return sum;
// }


// // /* 
// // This code uses a names array and corresponding methods to display
// // greeting messages
// // */

// // string[] names = new string[] { "Sophia", "Andrew", "AllGreetings" };

// // string messageText = "";

// // foreach (string name in names)
// // {
// //     if (name == "Sophia")
// //         messageText = SophiaMessage();
// //     else if (name == "Andrew")
// //         messageText = AndrewMessage();
// //     else if (name == "AllGreetings")
// //         messageText = SophiaMessage() + "\n\r" + AndrewMessage();        

// //     Console.WriteLine(messageText + "\n\r");
// // }

// // bool pauseCode = true;
// // while (pauseCode == true);

// // static string SophiaMessage()
// // {
// //     return "Hello, my name is Sophia.";
// // }

// // static string AndrewMessage()
// // {
// //     return "Hi, my name is Andrew. Good to meet you.";
// // }