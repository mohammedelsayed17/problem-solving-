using System.Text;

namespace problem_solving_using_c_;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        // string x = reverse("mohammed");
        // char[] arr = x.ToCharArray();
        // bool x = IsPalindrome("1234321");
        // Console.WriteLine(x);
        // CountVowelsConsonants("mohammed");
        // string text1 = "mohammed";
        // string text2 = "demmahom";
        // bool result = towstring(text1, text2);
        // Console.WriteLine(result);
        // Console.WriteLine(CompressString("aaabbcddd"));
        // string s = "abc";
        // char[] arr = s.ToCharArray();
        // permutation(arr, 0, arr.Length - 1);
        // Arrayes.MoveZero([0, 0, 70, 100]);
        // Console.WriteLine(Arrayes.MissingNumber([1, 2, 4, 5]));
        int[] arr = { 2, 7, 4, 5, 1, 3 };
        int[] arr1 = { 2, 7, 4, 5, 1, 3 };
        int i = 0, j = 0, k = 0;
        int[] result = new int[arr.Length + arr1.Length];

        while (i < arr.Length && j < arr1.Length)
        {
            if (arr[i] < arr1[j]) result[k++] = arr[i++];
            else result[k++] = arr1[j++];
        }
        foreach(int n in result)
        {
            Console.WriteLine(n);
        }
        // Arrayes.FindPairs(arr, 6);
    }
    // reverse string 
    static string reverse(string str)
    {
        char[] arr = str.ToCharArray();
        // Array.Reverse(arr);
        // char[] pp= arr.Reverse();
        int left = 0;
        int right = arr.Length - 1;
        while (left < right)
        {
            char temp = arr[left];
            arr[left] = arr[right];
            arr[right] = temp;
            left++;
            right--;
        }
        return new string(arr);
    }
    // check is palindrome 
    static bool IsPalindrome(string str)
    {
        int left = 0, right = str.Length - 1;
        while (left < right)
        {
            if (str[left] != str[right]) return false;
            left++;
            right--;
        }
        return true;
    }
    // count of vowels and consonants
    static void CountVowelsConsonants(string str)
    {
        int vcount = 0, Conscount = 0;
        string v = "aeiouAEIOU";
        foreach (char c in str)
        {
            if (char.IsLetter(c))
            {
                if (v.Contains(c))
                {
                    vcount++;
                }
                else
                {
                    Conscount++;
                }
            }
        }
        Console.WriteLine($"{vcount}  {Conscount}");
    }
    // frist non repeate char 
    static char fristNonreapte(string str)
    {
        Dictionary<char, int> freq = new Dictionary<char, int>();
        foreach (char c in str)
        {
            if (freq.ContainsKey(c)) freq[c]++;
            else freq[c] = 1;
        }
        foreach (char c in freq.Keys)
        {
            if (freq[c] == 1) return c;

        }
        return '\0';
    }
    //remove duplicates from string
    static string Removeduplicate(string s)
    {
        HashSet<char> set = new HashSet<char>();// cons : unique and not order 
        StringBuilder sb = new StringBuilder();// using to make string imutibule 
        foreach (char c in s)
        {
            if (!set.Contains(c))
            {
                sb.Append(c);
                set.Add(c);
            }
        }
        return sb.ToString();

    }
    //7. Check if two strings are anagrams
    static bool towstring(string str1, string str2)
    {

        if (str1.Length != str2.Length) return false;
        char[] arr1 = str1.ToCharArray();
        char[] arr2 = str2.ToCharArray();
        Array.Sort(arr1);
        Array.Sort(arr2);
        return new string(arr1) == new string(arr2);

    }

    // 9. String compression
    static string CompressString(string s)
    {
        if (string.IsNullOrEmpty(s)) return s;
        StringBuilder comp = new StringBuilder();
        int count = 1;
        for (int i = 1; i < s.Length; i++)
        {
            if (s[i] == s[i - 1])
            {
                count++;
            }
            else
            {
                comp.Append(s[i - 1]).Append(count);
                count = 1;
            }
        }
        comp.Append(s[s.Length - 1]).Append(count);
        return comp.Length < s.Length ? comp.ToString() : s;
    }
    // permutation 
    static void permutation(char[] arr, int l, int r)
    {
        if (l == r)
        {
            Console.WriteLine(new string(arr));
        }
        else
        {
            for (int i = l; i <= r; i++)
            {
                swap(ref arr[l], ref arr[i]);
                permutation(arr, l + 1, r);
                swap(ref arr[l], ref arr[i]);
            }

        }
    }
    static void swap(ref char a, ref char b)
    {
        char temp = a;
        a = b;
        b = temp;
    }
}
