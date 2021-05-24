using System;


Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
Console.WriteLine("--------------------------------------------");
Console.WriteLine();

void MooseSays(string message)
{
    // @ is added in front of the string to allow a multi line string
    // $ enables string interpolation
    Console.WriteLine($@"

                                      _.--^^^--,
                                    .'          `\
  .-^^^^^^-.                      .'              |
 /          '.                   /            .-._/
|             `.                |             |
 \              \          .-._ |          _   \
  `^^'-.         \_.-.     \   `          ( \__/
        |             )     '=.       .,   \
       /             (         \     /  \  /
     /`               `\        |   /    `'
     '..-`\        _.-. `\ _.__/   .=.
          |  _    / \  '.-`    `-.'  /
          \_/ |  |   './ _     _  \.'
               '-'    | /       \ |
                      |  .-. .-.  |
                      \ / o| |o \ /
                       |   / \   |    {message}
                      / `^`   `^` \
                     /             \
                    | '._.'         \
                    |  /             |
                     \ |             |
                      ||    _    _   /
                      /|\  (_\  /_) /
                      \ \'._  ` '_.'
                       `^^` `^^^`
                       
                    ");
}


bool MooseAsks(string question)
{
    Console.Write($"{question} (Y/N): ");
    // prints interpolated question + (Y/N)
    string answer = Console.ReadLine().ToLower();
    // read users answer, and converts to lowercase string
    while (answer != "y" && answer != "n")
    // while/when the users answer doesnt equal "y" or "n"

    {
        Console.Write($"{question} (Y/N): ");
        answer = Console.ReadLine().ToLower();
        // print question once more and read users answer again
    }

    if (answer == "y")
    {
        return true;
    }
    else
    {
        return  false;
    }
    //if answer is equal to "y" then return true. If not, return false
}


MooseSays("H I, I'M  E N T H U S I A S T I C !");
MooseSays("I really am enthusiastic");
// {message} is replaced with the string that is passed in when function is called

bool isTrue = MooseAsks("Is Canada real?");
// {question} is replaced with string passed into the function
Console.WriteLine(isTrue);
// console prints question/boolean