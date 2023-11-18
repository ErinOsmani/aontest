namespace AonExercise
{
    public static class ArrayUtility
    {
        /// <summary>
        /// Return the merged sorted array of the inputs
        /// </summary>
        /// <param name="array1">Sorted array of numbers</param>
        /// <param name="array2">Sorted array of numbers </param>
        /// <returns>Sorted merged array of the inputs</returns>
        public static int[] MergeSortedArrays(int[] array1, int[] array2)
        {
            if ((array1 == null || array1.Length == 0) && (array2 == null || array2.Length == 0))
                return Array.Empty<int>();
            else if (array1 == null || array1.Length == 0)
                return array2;
            else if (array2 == null || array2.Length == 0)
                return array1;

            int[] mergedArray = new int[array1.Length + array2.Length];
            int i = 0, j = 0, k = 0;


            // iterate through both arrays and compare the elements
            while (i < array1.Length && j < array2.Length)
            {
                if (array1[i] < array2[j])
                {
                    mergedArray[k] = array1[i];
                    i++;
                }
                else
                {
                    mergedArray[k] = array2[j];
                    j++;
                }
                k++;
            }


            //if the array1 is longest one, add the remaining elements to the merged array
            while (i < array1.Length)
            {
                mergedArray[k] = array1[i];
                i++;
                k++;
            }

            //if the array2 is longest one, add the remaining elements to the merged array
            while (j < array2.Length)
            {
                mergedArray[k] = array2[j];
                j++;
                k++;
            }

            return mergedArray;
        }
    }
}
