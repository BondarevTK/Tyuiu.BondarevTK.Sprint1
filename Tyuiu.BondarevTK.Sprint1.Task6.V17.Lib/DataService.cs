using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.BondarevTK.Sprint1.Task6.V17.Lib
{
    public class DataService : ISprint1Task6V17
    {
        public bool CheckPalindrome(string value)
        {
            return DataService.Reverse(value) == value;
        }
        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}


       