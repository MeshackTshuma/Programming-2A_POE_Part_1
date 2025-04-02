
//creating instance for the class
Console.ForegroundColor = ConsoleColor.Green;
DisplayLogo();
PlaywelcomeMessage();
//color formatting and method to get use name
Console.ResetColor();
Console.ForegroundColor= ConsoleColor.Blue;
string user_name = Getuser_name();
string input;
Console.WriteLine($"Hello {user_name} how can i help you today");
// method to start the conversation
chatbotloop();

void chatbotloop()

{ 
    string input;
    do
    {//user input
        Console.Write("You: ");
        input = Console.ReadLine()?.Trim().ToLower();

        if (string.IsNullOrEmpty(input))
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Invalid entry: Please ttpe in something");
            Console.ForegroundColor = ConsoleColor.Green;

            continue;
            throw new NotImplementedException();
        }

        if (input == "exit")
            {
                Console.WriteLine("Thank you and goodbye");

                break;

          }
        RespondToUser(input);
    
    }
     while (true);
    
    }

void RespondToUser(string input)
{// knowledge base dictionary
    switch (input)
    {
        case "how do i protect my personal data online:?":
            Console.WriteLine("Use strong password and do not click on links you do not recognize");
            break;
        case "What is phishing?":
            Console.WriteLine("Using of fake emails,masseges or websitesto trick victims to reveal sensitive information");
            break;

        case "What is ransomware?":
            Console.WriteLine("Malware that encrypts avictim's  files and demand payment in exchange for decryption key");
            break;
            default: 
            Console.WriteLine("Im not sure about that, try to ask somthing else");
            break ;
    }
    throw new NotImplementedException();
}

string Getuser_name()
{
    string user_name;
    do
    {
        Console.Write("Please enter your name:  ");
        user_name = Console.ReadLine()?.Trim();
        if (string.IsNullOrEmpty(user_name)) 
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("invalid input. Please enter a valid name");
            Console.ForegroundColor = ConsoleColor.Green;
        }
        while (string.IsNullOrEmpty(user_name)) ;

        return user_name;

    }
}

   

void PlaywelcomeMessage()
{
    string filepath = "welcome.wav";
    SoundPlayer player = new SoundPlayer(filepath);
    player.PlaySync();
    
    throw new NotImplementedException();
}

void DisplayLogo()
{
    Console.WriteLine(@"                      
                                                 

             ________                        __________      _____________
             ||            /   \           |                |
             |            /     \          |                |
             |           /       \         |__________      |
             |_____     /-------- \        |                |___________
                   |   /           \       |                |
                   |  /             \      |                |
            _______| /               \     |                |____________



                               " );

    throw new NotImplementedException();











}










