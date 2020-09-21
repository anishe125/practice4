using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class BubbleSort: StrategySort
    {
            public BubbleSort()
            {
                Title = "Сортировка пузырьком";
            }
        public override string ToString()
        {
            return Title;
        }

        public override void Sort(int[] array)
            {
                for (int j = 1; j < array.Length; j++)
                {
                    for (int i = 0; i < array.Length - j; i++)
                    {
                        if (array[i] > array[i + 1])
                        {
                            int buffer = array[i];
                            array[i] = array[i + 1];
                            array[i + 1] = buffer;
                        }
                    }
                }
            }
        }
    
}
