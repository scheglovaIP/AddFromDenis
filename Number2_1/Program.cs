// Есть программа с бесконечным циклом. Когда пользователь вводит exit программа заканчивается
// Версия в которой регистр ключевого слова не учитывается


string truePassword = "exit";


while(true)
{
    string userPassword = ReadStr("Введите пароль: ");
    if(userPassword.ToLower()==truePassword)
    break;
}

string ReadStr(string msg)
{
    Console.Write(msg);
    return Console.ReadLine();
}
