namespace CoreLib;

public class WordInText
{
    public static Func<string, string, bool> containsWord = (txt, word) =>
    {
        txt = txt.ToLower();
        word = word.ToLower();

        string[] words = txt.Split(new char[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

               
        foreach (string w in words)
        {
            if (w == word)
            {
                return true;
            }
        }
        return false;
    };
}