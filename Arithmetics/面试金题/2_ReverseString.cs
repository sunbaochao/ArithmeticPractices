
using System.Text;

namespace Arithmetics.面试金题
{
    public class _2_ReverseString : AbstractArithmetic
    {
        private string _title = "原串翻转";
        private string _content = @"请实现一个算法，在不使用额外数据结构和储存空间的情况下，
        翻转一个给定的字符串(可以使用单个过程变量)。
        给定一个string iniString，请返回一个string，为翻转后的字符串。保证字符串的长度小于等于5000。
        测试样例：
              This is nowcoder
        返回：redocwon si sihT";

        public _2_ReverseString()
        {
            this.Title = _title;
            this.Content = _content;
        }
        public override string GetResult()
        {
            var iniString = "This is nowcoder";
            return reverseString(iniString);
        }
        private string reverseString(string iniString)
        {
            if (iniString.Length < 1) return "";
            var len = iniString.Length-1;
            var builder= new StringBuilder(iniString.Length);

            for (int i = len; i >=0; i--)
            {
                builder.Append(iniString[i]);
            }

            return builder.ToString();
        }
    }
}
