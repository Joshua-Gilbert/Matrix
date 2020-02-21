using System;
using System.IO;





namespace Matrix_Multiply
{
    class Program
    {
          

        /* This method performs a dgemm operation
        *  C := C + A * B
        * where A, B, and C are lda-by-lda matrices stored in column-major format.
        * On exit, A and B maintain their input values. */

       public static double [] square_dgemm(int n, double [] A, double [] B, double [] C)
        {

           // double[] D = new double[100000];
                    for (int k = 0; k <= n; k++)
                    {
                      C[k] += C[k] + A[k] * B[k];
                    }


            foreach (int element in C)
            {
                Console.WriteLine(element);
            }   
            return C;
           
        }


        static void Main(string[] args)
        {
            Console.Write("Please enter matrix size:");
            string input = Console.ReadLine();
            int size = Convert.ToInt32(input);
            
            
            //Row < #
            int n = size;
            //Setting Array Length
            double[] A = new double [size];
            double[] B = new double [size];
            double[] C = new double[size * size];

             //Filling Rows and columns from one to set length
            for (int i = 1; i < A.Length; i++)
            {
                A[i] += i;
                i++;
            }
            for (int k = 1; k < B.Length; k++)
            {
                B[k] += k;
                k++;
            }
            

            square_dgemm(n, A, B,C);
           
            
        }
    }
}
