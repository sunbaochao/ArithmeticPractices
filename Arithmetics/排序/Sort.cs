using System;
using System.Collections.Generic;
using System.Text;

namespace Arithmetics.排序
{
    public class Sort
    {
        public void MainSort()
        {
            int[] nums = { 5, 2, 9, 4, 7, 6, 1, 3, 8 }; // 从小到大快速排序
            QuickSort(nums,0,nums.Length-1);//快速排序
            Console.WriteLine(string.Join(',',nums));
        }

        #region 快速排序
        // 分类 ------------ 内部比较排序
        // 数据结构 --------- 数组
        // 最差时间复杂度 ---- 每次选取的基准都是最大（或最小）的元素，导致每次只划分出了一个分区，需要进行n-1次划分才能结束递归，时间复杂度为O(n^2)
        // 最优时间复杂度 ---- 每次选取的基准都是中位数，这样每次都均匀的划分出两个分区，只需要logn次划分就能结束递归，时间复杂度为O(nlogn)
        // 平均时间复杂度 ---- O(nlogn)
        // 所需辅助空间 ------ 主要是递归造成的栈空间的使用(用来保存left和right等局部变量)，取决于递归树的深度，一般为O(logn)，最差为O(n)       
        // 稳定性 ---------- 不稳定
        private void QuickSort(int[] nums,int left,int right)
        {
            //边界
            if(left>=right)return;
            //基准索引
            var pivotIdx = Partition(nums, left, right);
            QuickSort(nums,pivotIdx+1,right);
            QuickSort(nums,left,pivotIdx-1);
        }

        private int Partition(int[] nums ,int left,int right)
        {
            var pivot = nums[right];//基准
            var tail = left - 1;
            for (int i = left; i < right; i++)
            {
                if (nums[i] < pivot)
                {
                    Swap(nums,i,++tail);
                }
            }

            Swap(nums,tail+1,right);

            return tail + 1;
        }

        private void Swap(int[] nums,int left,int right)
        {
            var tmp = nums[left];
            nums[left] = nums[right];
            nums[right] = tmp;
        }

        #endregion
    }
}
