namespace LeetCode.LeetCode150.ArrayString;

public class IntegerToRoman
{
    public class Solution
    {
        public string IntToRomanSwitch(int num)
        {
            int x1 = num % 10;
            num /= 10;

            int x10 = num % 10;
            num /= 10;

            int x100 = num % 10;
            num /= 10;

            int x1000 = num % 10;

            string result = "";

            for (int i = 0; i < x1000; i++)
            {
                result += ToRomanNum(1000);
            }

            return result + ToRomanNum(x100 * 100) + ToRomanNum(x10 * 10) + ToRomanNum(x1);
        }

        public string IntToRoman(int num)
        {
            string result = "";

            while (num >= 1000 )
            {
                result += ToRomanNum(1000);
                num -= 1000;
            }

            while(num >= 900)
            {
                result += ToRomanNum(900);
                num -= 900;
            }

            while(num >= 500)
            {
                result += ToRomanNum(500);
                num -= 500;
            }

            while(num >= 400)
            {
                result += ToRomanNum(400);
                num -= 400;
            }

            while(num >= 100)
            {
                result += ToRomanNum(100);
                num -= 100;
            }

            while(num >= 90)
            {
                result += ToRomanNum(90);
                num -= 90;
            }

            while(num >= 50)
            {
                result += ToRomanNum(50);
                num -= 50;
            }

            while(num >= 40)
            {
                result += ToRomanNum(40);
                num -= 40;
            }

            while(num >= 10)
            {
                result += ToRomanNum(10);
                num -= 10;
            }

            while(num >= 9)
            {
                result += ToRomanNum(9);
                num -= 9;
            }

            while(num >= 5)
            {
                result += ToRomanNum(5);
                num -= 5;
            }

            while(num >= 4)
            {
                result += ToRomanNum(4);
                num -= 4;
            }

            while (num >= 1)
            {
                result += ToRomanNum(1);
                num -= 1;
            }

            return result;
        }

        private static string ToRomanNum(int num) => num switch
        {
            1 => "I",
            2 => "II",
            3 => "III",
            4 => "IV",
            5 => "V",
            6 => "VI",
            7 => "VII",
            8 => "VIII",
            9 => "IX",
            10 => "X",
            20 => "XX",
            30 => "XXX",
            40 => "XL",
            50 => "L",
            60 => "LX",
            70 => "LXX",
            80 => "LXXX",
            90 => "XC",
            100 => "C",
            200 => "CC",
            300 => "CCC",
            400 => "CD",
            500 => "D",
            600 => "DC",
            700 => "DCC",
            800 => "DCCC",
            900 => "CM",
            1000 => "M",
            _ => ""
        };
    }
}
