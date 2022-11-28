string comExit = "e";
string comHelp = "h";
string comNewAccount = "na";
string comEnterAccount = "en";
string comWriteName = "wn";
string[] names = { "Иван", "Варвара", "Василий", "Ирина" };
string[] emails = { "ivan@mail.ru", "varvara@mail.ru", "vasilii@mail.ru", "irina@mail.ru" };
string[] passwords = { "30bdfy12", "12dfhdfhf01", "09dfcbkbq03", "17bhbyf10" };

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
        Console.WriteLine($"{comEnterAccount} enter");
        Console.WriteLine($"{comWriteName} writename");
    }
    if (userCommand.ToLower() == comNewAccount)
    {
        names = AddNewStr(names, "Введите имя пользователя: ");
        emails = AddNewStr(emails, "Введите логин (адрес электронной почты): ");

        while (true)
        {
            string newPassword = ReadStr("Введите пароль: ");
            string repeatPassword = ReadStr("Повторите пароль: ");
            if (newPassword == repeatPassword)
            {
                Array.Resize(ref passwords, passwords.Length + 1);
                passwords[passwords.Length - 1] = repeatPassword;
                break;
            }
            else Console.WriteLine("Пароли не совпадают. Попробуйте еще раз!");
        }
    }
    if (userCommand.ToLower() == comEnterAccount)
    {
        string login = ReadStr("Введите логин (email): ");
        string pass = ReadStr("Введите пароль: ");
        bool exist = false;
        for (int i = 0; i < names.Length; i++)
        {
            if (emails[i] == login && passwords[i] == pass)
            {
                Console.WriteLine($"{names[i]}, Добро пожаловать!");
                exist = true;
                break;
            }
        }
        if (exist)
        {
            Console.WriteLine("Вы вошли в систему!");
        }
        else Console.WriteLine("Введены неверные имя пользователя или пароль!");
    }
    if (userCommand.ToLower() == comWriteName)
    {
        string searchLogin = ReadStr("Введите логин (адрес электронной почты, указанный при регистрации): ");
        string output = "Пользователь с указанным логином не найден";

        for (int i = 0; i < emails.Length; i++)
        {
            if (searchLogin == emails[i])
            {
                output = "Вас зовут " + names[i];
                break;
            }
        }
        Console.WriteLine(output);
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
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}


string[] AddNewStr(string[] array, string msg)
{
    Array.Resize(ref array, array.Length + 1);
    array[array.Length - 1] = ReadStr(msg);
    return array;
}
