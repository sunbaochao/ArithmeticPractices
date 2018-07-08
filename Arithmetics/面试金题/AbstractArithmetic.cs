using System;
using System.Collections.Generic;
using System.Text;

namespace Arithmetics.面试金题
{
    public abstract class AbstractArithmetic
    {
        /// <summary>
        /// 题目
        /// </summary>
        public string Title { set; get; }
        /// <summary>
        /// 内容
        /// </summary>
        public string Content { get; set; }

        public abstract string GetResult();
    }
}
