// В переменной string есть секретное сообщение, во второй есть пароль.
//Пользователю программы даётся 3 попытки ввести пароль и увидеть секретное сообщение

string secret = "СЕКРЕТНОЕ СООБЩЕНИЕ";
string truePassword = "Qwerty123";

for(int i=1; i<=4; i++)
{
    if(i>3) Console.WriteLine("Ваш аккаунт заблокирован");
    else
    {
        string userPassword = ReadStr("Введите пароль: ");
        if(userPassword==truePassword)
        {
            Console.WriteLine(secret);
            break;
        }
    }    
    
    
}


string ReadStr(string msg)
{
    Console.Write(msg);
    return Console.ReadLine();
}
