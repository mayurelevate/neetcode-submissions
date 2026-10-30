public class Solution {
    public bool IsPalindrome(string s) {
        bool isPalindrome = true;
         string new_value = s.Replace(" ", "").ToLower();
 int len = new_value.Length-1;
        int left = 0;
int right = len;

while(left < right)
{

    if (!char.IsLetterOrDigit(new_value[left]))
    {
        left++;
        continue;
    }

    if (!char.IsLetterOrDigit(new_value[right]))
    {
        right--;
        continue;
    }


    if (char.ToLowerInvariant(new_value[left]) != char.ToLowerInvariant(new_value[right]))
    {
        isPalindrome = false;
    }

    left++;
    right--;
}

 return isPalindrome;
    }
}
