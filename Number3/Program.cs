string truePassword = "exit";

while(true)
{
    string userPassword = ReadStr("Введите пароль: ");
    if(userPassword==truePassword)
    break;
}

string ReadStr(string msg)
{
    Console.Write(msg);
    return Console.ReadLine();
}
