string comExit = "exit";
string comHelp = "help";
string comNewAccount = "newaccount";
string comSetUserName = "username";
string comSetEmail = "email";
string comSetPassword = "pasword";
string comEnterAccount = "enter";
string comWriteName = "writename";

string userCommand = string.Empty;
for( ; ;)
{
    userCommand = ReadStr("Введите команду: ");
    if(userCommand.ToLower()==comExit) break;
    if(userCommand.ToLower()==comHelp)
    {
        Console.WriteLine("exit");
        Console.WriteLine("help");
        Console.WriteLine("newaccount");
        Console.WriteLine("username");
        Console.WriteLine("email");
        Console.WriteLine("pasword");
        Console.WriteLine("enter");
        Console.WriteLine("writename");
    }
}

string ReadStr(string msg)
{
    Console.Write(msg);
    return Console.ReadLine();
}
