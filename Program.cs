using System;

Main();

void Main() /* "wrapping" code in a function */
{
    Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
    Console.WriteLine("--------------------------------------------");
    Console.WriteLine();

    MooseSays("H I, I'M  E N T H U S I A S T I C !");
    MooseSays("I really am enthusiastic");
    // {message} is replaced with the string that is passed in when function is called

    //call all functions to run
    CanadaQuestion();
    EnthusiasticQuestion();
    LoveCSharpQuestion();
    SecretQuestion();
}



void CanadaQuestion()
{
    bool isTrue = MooseAsks("Is Canada real?");
    // {question} is replaced with string passed into the function
    if (isTrue)// console prints question/boolean
    {
        MooseSays("Really? It seems very unlikely.");
        //Runs MooseSays() with specific string in the {message} field as a response to question being true ('Y' answer)
    }
    else
    {
        MooseSays("I  K N E W  I T !!!");
        //Runs MooseSays() with this string if users answer is 'N'
    }
}



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
        return false;
    }
    //if answer is equal to "y" then return true. If not, return false
}

void EnthusiasticQuestion()
{
    bool isEnthusiastic = MooseAsks("Are you enthusiastic?");
    if (isEnthusiastic)
    {
        MooseSays("Yay!");
    }
    else
    {
        MooseSays("You should try it!");
    }
}

void LoveCSharpQuestion()
{
    bool doesLoveCSharp = MooseAsks("Do you love C# yet?");
    if (doesLoveCSharp)
    {
        MooseSays("Good job sucking up to your instructor!");
    }
    else
    {
        MooseSays("You will...oh, yes, you will...");
    }
}

void SecretQuestion()
{
    bool wantsSecret = MooseAsks("Do you want to know a secret?");
    if (wantsSecret)
    {
        MooseSays("ME TOO!!!! I love secrets...tell me one!");
    }
    else
    {
        MooseSays("Oh, no...secrets are the best, I love to share them!");
    }
}

