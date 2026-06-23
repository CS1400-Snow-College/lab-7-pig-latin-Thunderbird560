// Cael Howard 6/23/2026 Lab 7
Console.WriteLine("Hello user! Welcome to Pig Latin and an offset word! Please input a phrase you want translated to Pig Latin and offsetted.");
string userPhrase = Console.ReadLine().ToLower();

string[] words = userPhrase.Split(' ');

string pigLatinPhrase = "";

foreach(string word in words)
{
    string vowels = "aeiou";
    int vowelIndex = 0;
   

        while (vowelIndex < word.Length && !vowels.Contains(word[vowelIndex].ToString()))
        {
            vowelIndex++;
        }

        string pigWord;

        if(vowelIndex == 0)
        {
            pigWord = word + "yay";
        }
        else if (vowelIndex == word.Length)
        {
            pigWord = word + "ay";
        }
        else
        {
        pigWord = word.Substring(vowelIndex) + word.Substring(0, vowelIndex) + "ay";
        }

        pigLatinPhrase += pigWord + " ";

    }
Console.WriteLine("\nPig Latin:");
Console.WriteLine(pigLatinPhrase);


