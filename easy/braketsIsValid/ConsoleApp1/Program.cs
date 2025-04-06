internal class Program
{
    private static void Main(string[] args)
    {
        string a = "()[]{}";
        Console.Write(IsValid(a));
    }
    public static bool IsValid(string s)
    {
        Stack<byte> brackets = new(s.Length / 2 + 1);

        int res = -1;
        for(int i = 0; i < s.Length; i++)
        {
            switch (s[i]){
                case '(':
                    brackets.Push(0);
                    break;
                case '[':
                    brackets.Push(1);
                    break;
                case '{':
                    brackets.Push(2);
                    break;
                case ')':
                    if (brackets.Count > 0)
                        if (brackets.Pop() == 0)
                            continue;
                        else
                            return false;
                    else 
                        return false;
                case ']':
                    if (brackets.Count > 0)
                        if (brackets.Pop() == 1)
                            continue;
                        else
                            return false;
                    else
                        return false;
                case '}':
                    if (brackets.Count > 0)
                        if (brackets.Pop() == 2)
                            continue;
                        else
                            return false;
                    else
                        return false;
            }
        }
        if (brackets.Count > 0)
            return false;
        return true;
    }
}