string comExit = "exit";
string comHelp = "help";
string comNewAccount = "na";
string comSetUserName = "username";
string comSetEmail = "email";
string comSetPassword = "pasword";
string comEnterAccount = "enter";
string comWriteName = "writename";
string[] names = {"Иван", "Варвара", "Василий", "Ирина"};
string[] emails = {"ivav@mail.ru", "varvara@mail.ru", "vasilii@mail.ru", "irina@mail.ru"};
string[] passwords = {"30bdfy12", "12dfhdfhf01", "09dfcbkbq03", "17bhbyf10"};

string userCommand = string.Empty;

for (; ; )
{
    userCommand = ReadStr("Введите команду: ");
    if (userCommand.ToLower() == comExit) break;
    if (userCommand.ToLower() == comHelp)
    {
        Console.WriteLine($"{comExit} exit");
        Console.WriteLine($"{comHelp} help");
        Console.WriteLine($"{comNewAccount} newaccount");
        Console.WriteLine($"{comSetUserName} username");
        Console.WriteLine($"{comSetEmail} email");
        Console.WriteLine($"{comSetPassword} pasword");
        Console.WriteLine($"{comEnterAccount} enter");
        Console.WriteLine($"{comWriteName} writename");
    }
    if (userCommand.ToLower() == comNewAccount)
    {
        names = AddNewStr(names, "Введите имя пользователя: ");
        emails = AddNewStr(emails, "Введите адрес электронной почты: ");
        
        while(true)
        {
            string newPassword = ReadStr("Введите пароль: ");
            string repeatPassword = ReadStr("Повторите пароль: ");
            if(newPassword==repeatPassword)
            {
                Array.Resize(ref passwords, passwords.Length+1);
                passwords[passwords.Length-1] = repeatPassword;
                break;
            }
            else Console.WriteLine("Пароли не совпадают. Попробуйте еще раз!");
        }
    }
}





//используемые методы
string ReadStr(string msg)
{
    Console.Write(msg);
    return Console.ReadLine();
}

void WriteArray(string[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}


string[] AddNewStr(string[] array, string msg)
{
    Array.Resize(ref array, array.Length+1);
    array[array.Length-1] = ReadStr(msg);
    return array;
}
