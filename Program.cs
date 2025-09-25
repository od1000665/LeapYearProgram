/* Leap Year Program
    Created by: Owen Douglas
    The program will ask the user for a year and decide if its a leap year through 
    several operations
*/

//Asks the user for a 4 digit year
Console.WriteLine("Please enter a FOUR digit year");
int year = Convert.ToInt32(Console.ReadLine());

//Line for spacing
Console.WriteLine("");

//decide if the year/number is divisible by 4
if (year % 4 == 0)
{
    Console.WriteLine("Divisible by 4: Yes");
    //If it is then move on
}
else
{
    Console.WriteLine("Divisible by 4: No");
    //If not then its not a leap year
}
//Then decide if the year/number is divisible by 100
if (year % 100 == 0)
{
    Console.WriteLine("Divisible by 100: Yes");
    //If it is then move on
}
else
{
    Console.WriteLine("Divisible by 100: No");
//If not then its not a leap year
}
//Finally decide if the year/number is divisible by 400
if (year % 400 == 0)
{
    Console.WriteLine("Divisible by 400: Yes");
    //If it is then report the findings as a leap year
}
else
{
    Console.WriteLine("Divisible by 400: No");
    //If not then its not a leap year
}

//Else if statements used to display final report on leap year
if (year % 400 == 0)
{
    Console.WriteLine("Leap year: Yes");
}
else if (year % 100 == 0)
{
    Console.WriteLine("Leap year: No");
}
else if (year % 4 == 0)
{
    Console.WriteLine("Leap year: Yes");
}
else
{
    Console.WriteLine("Leap year: No");
}
//end