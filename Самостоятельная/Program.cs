


 static bool IsValid(string s)
        {
                var count = 0;
                foreach (var c in s)
                {
                    if (c == '(')
                        count++;

                    if (c == ')')
                    {
                        if (count == 0) return false;
                        count--;
                    }
                }
                return true;
        }
Console.WriteLine(IsValid("((2+3)*5 - ((7-3) / 3) * 8))"));

