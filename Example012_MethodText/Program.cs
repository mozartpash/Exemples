//Работа с текстом
//Дан текст. В тексте все пробелы нужно заменаить чёрточками, маленькие буквы "к" заменить большими "К",
//а большие "С" заменить маленькими "с".

string text = "- Я думаю, сказал князь, улыбаясь, - что,"
            + "ежели бы вас послали вместо нашего милого Винценгероде"
            + "вы бы взяли приступом согласие пруссого короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";

//string s = "qwery"
//            01234
//s[3] //- r

string Replace(string text, char oldValue, char newValue)
{
    string result = string.Empty;//Присваевание пустой строки

    int length = text.Length;// показываем кол-во символов в строке
    for (int i = 0; i < length; i++)// Спомощью цикла for пробигаемся от 0-го символа, до конца строки
    {
        if(text[i]==oldValue) result = result + $"{newValue}";//Если символ в тексте = oldValue, то в result положим новое значение в виде строки {newValue}
        else result = result + $"{text[i]}";//если нет совпадений, то добавлеем символ, корорый был
    }

    return result;
}
string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'С', 'с');
Console.WriteLine(newText);
