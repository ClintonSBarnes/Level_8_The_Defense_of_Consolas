// See https://aka.ms/new-console-template for more information
//create variables in memory
Console.Title = "HELP DEFEND CONSOLAS!!!";
Console.BackgroundColor= ConsoleColor.Red;
Console.ForegroundColor = ConsoleColor.Black;
Console.Clear();

Console.WriteLine("The Uncoded One has launched an attack on our beloved city, Consolas! We need your help to save our people. \nPlease tell us the targeted location!!!");
double targetRow = 0;
double targetCol = 0;



//Collect target inforamtion from user
Console.Write("\nWhat is the target row? ");
targetRow = Convert.ToDouble( Console.ReadLine());
Console.Write("\nWhat is the target column? ");
targetCol = Convert.ToDouble(Console.ReadLine());



//Output statement with targeting information
Console.WriteLine($"Deploy to: \n({targetRow}, {targetCol -1}) \n({targetRow+1}, {targetCol}) \n({targetRow-1}, {targetCol}) \n({targetRow}, {targetCol+1})");
Console.WriteLine("Press any button to determine what damage has been taken.");
Console.ReadKey();

//Celebrate user's help in the defense.
Console.ForegroundColor = ConsoleColor.Black;
Console.BackgroundColor = ConsoleColor.Cyan;
Console.Clear();
Console.WriteLine("You have SAVED Consolas!!! Thank you for all of your support to our citizens!");
