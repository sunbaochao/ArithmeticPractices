using System;
using System.Collections.Generic;
using System.Text;

namespace Arithmetics.面试金题
{
    public class _1_CheckDifferent:AbstractArithmetic
    {
        private string _title = "确定字符串互异";

        private string _content  = @"请实现一个算法，确定一个字符串的所有字符是否全都不同。
                                   这里我们要求不允许使用额外的存储结构。给定一个string iniString，
                                   请返回一个bool值,True代表所有字符全都不同，False代表存在相同的字符。
                                   保证字符串中的字符为ASCII字符。字符串的长度小于等于3000。";

        public _1_CheckDifferent()
        {
            Title = _title;
            Content = _content;
        }

        public override string GetResult()
        {
            return CheckDifferent("aeiou").ToString();
        }

        public bool CheckDifferent(string iniString)
        {
            var strs = iniString.ToCharArray();
            var len = strs.Length;
            var result = true;
            for (int i = 0; i < len; i++)
            {
                if (len - iniString.Replace(strs[i].ToString(),"").Length >1)
                {
                    result = false;
                    return result;
                }                
                    
            }

            return result;
        }

    }
}
