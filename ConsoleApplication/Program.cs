using System;

namespace ConsoleApplication
{
    public class Program
    {
        const int MY_CONST_INT = 5;

        public static void Main(string[] args)
        {
            Console.WriteLine(">>> Rectangle <<<");

            Rectangle rec = new Rectangle();
            rec.Acceptdetails();
            rec.Display();



        }

        class Rectangle
        {
            double length;
            double width;
            
            public void Acceptdetails()
            {
                length = 4.5;
                width = 3.5;
            }

            public double GetArea() 
            {
                return length * width;
            }

            public void Display() 
            {
                // Console.WriteLine("Length: {0}", length);
                // Console.WriteLine("Width: {0}", width);
                // Console.WriteLine("Area: {0}", GetArea());
                // Console.WriteLine("-----------------");
                // Console.WriteLine("Size of int type: {0} bytes", sizeof(int));
                // Console.WriteLine("Size of long type: {0} bytes", sizeof(long));
                
                // decimal num = 213.3428943223248230948200001M;

                // Console.WriteLine("Decimal number -\t {0} - size of decimal type: {1} bytes", num, sizeof(decimal));
                // Console.WriteLine("Double number -\t\t {0} - size of double type: {1} bytes", (double)num, sizeof(double));
                // Console.WriteLine("Float number -\t\t {0} - size of float type: {1} bytes\n\n", (float)num, sizeof(float));

                // int input;
                // input = Convert.ToInt32(Console.ReadLine());
                // Console.WriteLine("Input: {0}", input);

                // num = 314159E-5M;
                // Console.WriteLine("Decimal number - {0}\n\n", num * MY_CONST_INT);

                // Console.WriteLine("Decimal number - {0}\n", num++);
                // Console.WriteLine("Decimal number - {0}\n", ++num);

                // Int32 A = Convert.ToInt32("00111100", 2);
                // Console.WriteLine("A: - {0}\n", Convert.ToString(A,2));
                // int B = Convert.ToInt32("00001101", 2);
                // Console.WriteLine("B: - {0}\n", Convert.ToString(B,2));

                // int C = A&B;
                // Console.WriteLine("C = A&B: - {0}\n", Convert.ToString(C,2));

                // B = B << 2;
                // C = A&B;
                // Console.WriteLine("B << 2 and then C = A&B : - {0}\n", Convert.ToString(C,2));

                // int i = 0, e = 0;

                // while (i<5) {
                //     while (e<7) {
                //         Console.WriteLine("i = {0} e = {1}", i, e);
                //         if (i==3) {
                //             goto foo;
                //         }
                //         e++;
                //     }
                //     i++;
                //     e=0;
                // }

                // foo:

                // Console.WriteLine("When it ends, i = {0}",i);

                // int? num1 = 2;
                // int? num2 = 45;

                // int result = (num1 ?? 0) * (num2 ?? 0);
                // Console.WriteLine("result: {0}", result);

                int[] nums = new int[10];
                // Console.WriteLine("Array length {0}", nums.Length);
                // Console.WriteLine("Array length {0}", nums.ToString());

                nums = new int[3];
                // for (int i=0; i< nums.Length; i++) {
                //     Console.WriteLine(">>> {0}.tem = {1}", i, nums[i]);
                // }

                // Console.WriteLine("\n");

                int num1 = 0;
                int num2 = 0;
                int num3 = 0;

                nums[0] = num1;
                nums[1] = num2;
                nums[2] = num3;
                
                foreach (int current in nums) {
                    Console.WriteLine(">>> Current: {0}", current);
                }

            }

            private static void changeIntRef(ref int i) {
                
            }


        }
    }


}