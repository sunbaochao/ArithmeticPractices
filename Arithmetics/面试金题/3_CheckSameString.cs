using System;
using System.Collections.Generic;
using System.Text;

namespace Arithmetics.面试金题
{
    public class _3_CheckSameString:AbstractArithmetic
    {
        private string _title = "确定两串乱序同构";
        private string _content = @"给定两个字符串，请编写程序，确定其中一个字符串的字符重新排列后，
    能否变成另一个字符串。这里规定大小写为不同字符，且考虑字符串重点空格。
    给定一个string stringA和一个string stringB，请返回一个bool，
    代表两串是否重新排列后可相同。保证两串的长度都小于等于5000。
    测试样例：
        This is nowcoder , is This nowcoder
        返回：true
            Here you are , Are you here
        返回：false";

        public _3_CheckSameString()
        {
            this.Title = _title;
            this.Content = _content;
        }
        public override string GetResult()
        {
            var stringA = "This is nowcoder";
            var stringB = "is This nowcoder";

            return checkSam(stringA,stringB).ToString();
        }
        private bool checkSam(string stringA, string stringB)
        {
            if (stringA.Length != stringB.Length) return false;
            int[] numA = new int[256];
            int[] numB = new int[256];

            for (int i = 0; i < stringA.Length; i++)
            {
                numA[stringA[i]]++;
                numB[stringB[i]]++;
            }

            for (int i = 0; i < numA.Length; i++)
            {
                if (numA[i] != numB[i]) return false;
            }

            return true;
        }
    }
}
