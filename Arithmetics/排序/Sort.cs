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
            QuickSort(nums,0,nums.Length-1);
            Console.WriteLine(string.Join(',',nums));
        }

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
    }
}
