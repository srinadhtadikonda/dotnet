using System;
class Test
{
 static void Main()
    {
        int[][]a = new int[4][];

        // Initialize the elements
       a[0] = new int[] { 1, 2, 3, 4 };
       a[1] = new int[] { 11, 34, 67 };
       a[2] = new int[] { 89, 23 };
       a[3] = new int[] { 0, 45, 78, 53, 99 };

        // Display the array elements:
        for (int n = 0; n <a.Length; n++) {

            // Print the row number
            System.Console.Write("Row({0}): ", n);

            for (int k = 0; k <a[n].Length; k++) {

                // Print the elements in the row
                System.Console.Write("{0} ",a[n][k]);
            }
            System.Console.WriteLine();
        }
    }
}
