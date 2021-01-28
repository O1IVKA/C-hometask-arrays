using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SearchАrraySkripnik
{
    public partial class Form1 : Form
    {   
        
        
        Random rnd = new Random();
        double[] arr, arr1, arr2;


        public Form1()
        {
            InitializeComponent();
        }

         public void fillArray(int n, int max,int min,ref double[] arr)
        { arr = new double[n];
            for(int i = 0; i < n; i++)
            {
                arr[i]= Math.Round(rnd.NextDouble() * (20 - 10) + 10, 1);
            }
        }



        public void displayArray(ref double[] arr)
        {
            var index = 0;
            foreach (var el in arr)
            {
                listBox1.Items.Add("el: " + el + " index: " + index);
                index++;
            }
        }


        public void halfBiggerArray(int n, ref double[] arr)
        {
            int n1 = 0, n2 = 0;
            for (int i = 0; i < n / 2; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    n1++;

                }
                if (arr[((n - n / 2) + i)] % 2 == 0)
                {
                    n2++;
                }
            }
            if (n1 != n2)
            {
                listBox1.Items.Add("amount of odd numbers the same");
            }

            else if (n1 > n2)
            {
                listBox1.Items.Add("in first part of array amount of odd numbers bigger");
            }
            else
            {
                listBox1.Items.Add("in second part of array amount of odd numbers bigger");
            }
            if (n % 2 == 1)
            {
                listBox1.Items.Add("The middle number of the array is ignored");
            };
        }


        public void maxArray(int n, double[] arr, ref double max,int gmin,int gmax)
        {
            for (int i = gmin; i < gmax; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                }
            }
        }


        public void maxBiggerArray(int n, double[] arr, ref Boolean all_bigger, double max, int gmin, int gmax)
        {   double max_all = arr[0];
            maxArray(n, arr, ref max_all, gmin, gmax);
            if (max_all> max)
            {
                all_bigger = true;
            }
            listBox1.Items.Add("max of all bigger than max of 2/3: " + all_bigger);
        }


        public void sortedArray(int n, double[] arr, ref Boolean sorted)
        {
            for (int i = 1; i < n; i++)
            {
                if (arr[i] < arr[i - 1])
                {
                    sorted = false;
                }
            }
            listBox1.Items.Add("sorted: " + sorted);
        }


        public void signChanges(int n, double[] arr, ref int count)
        {
            for (int i = 1; i < n; i++)
            {
                if ((arr[i] < 0 & arr[i - 1] > 0) || (arr[i] > 0 & arr[i - 1] < 0))
                {
                    count++;

                }
            }
            listBox1.Items.Add("count of sign changing: " + count);
        }


        public void Changes(int n, double[] arr, ref int count)
        {
            for (int i = 1; i < n; i++)
            {
                if ((arr[i] < 0 & arr[i - 1] > 0) || (arr[i] > 0 & arr[i - 1] < 0))
                {
                    count++;

                }
            }
            listBox1.Items.Add("count of sign changing: " + count);
        }
        public void minT(int n, ref double min1,double[] arr1)
        {
            for (int i = 1; i < n; i++)
            {
                if (min1 > arr1[i])
                {
                    min1 = arr1[i];
                }
            }
            listBox1.Items.Add("lowest day temp: " + min1);
        }


        public void minTDisplay(int n, ref double min1, double[] arr1)
        {
            listBox1.Items.Add("lowest day temp: " + min1);
        }


        public void LowerZero(int n, ref int zero2)
        {
            for (int i = 0; i < n; i++)
            {
                if (zero2 == -1)
                {
                    if (0 > arr2[i])
                    {
                        zero2 = i;
                    }
                }
            }
            if (zero2 != -1)
            {
                listBox1.Items.Add("first time when morning t was lower than o is day index: "+zero2);
            }
            else {
                listBox1.Items.Add("it wasn't t lower than zero");
            }
        }

        public void avT(int n, ref double av, double[] arr2)
        {
            for (int i = 1; i < n; i++)
            {
                av += arr2[i];
            }
            av /= n;
            listBox1.Items.Add("avarage morning t: " + av);
        }

        public void closeToAvT(int n, ref double min2, double[] arr2,ref double lowest,double av)
        {
            for (int i = 0; i < n; i++)
            {
                if (lowest > Math.Abs((double)arr2[i] - av))
                {
                    min2 = i;
                    lowest = Math.Abs((double)arr2[i] - av);
                }
            }
            listBox1.Items.Add("day when morning t the closest to avarage t: day index : " + min2);
        }


        public void dif(int n, double[] arr1, double[] arr2)
        {
            double[] arr3=new double[n];
            for (int i = 0; i < n; i++)
            {
                arr3[i] = Math.Abs(arr1[i] - arr2[i]);
            }
            listBox1.Items.Add("ARR3(absolute number of arr1 -arr2): ");
            displayArray(ref arr3);
        }

        public void tGrewUp(int n, double[] arr1,ref int count_increase1)
        {
            for (int i = 1; i < n; i++)
            {
                if (i < n / 2 && arr1[i] > arr1[i - 1])
                {
                    count_increase1++;

                }
            }
            listBox1.Items.Add("day t grew up: " + count_increase1 + " times");
        }

        public void biggerT(int n, double t, ref int count2)
        {
            for (int i = 1; i < n; i++)
            {
                if (arr2[i] > t && i > n / 2)
                {
                    count2++;
                }
            }
            listBox1.Items.Add("morming temp. was bigger than 't': " + count2 + " times");

        }


        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            /*Заповнити масив з n елементів випадковими цілими числами в діапазоні 
             * [10; 50]. Написати метод, що визначає, в якій половині масиву більше 
             * парних чисел: в першій або другій. Продемонструвати його роботу.*/
            int n = int.Parse(textBox1.Text);
            fillArray(n,51,10, ref arr);
            displayArray(ref arr);
            halfBiggerArray(n,ref arr);
        }


        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            /*Заповнити масив з n елементів (n кратно трьом) випадковими дійсними
             * числами в діапазоні [10; 20] з точністю до одного знака після коми.
             * Написати методи та продемонструвати їх роботу:
             * Визначити максимальне значення в середній третині масиву.
             * Чи є в усьому масиві числа, більше знайденого максимального?*/
            ;
            int n = int.Parse(textBox1.Text);
            fillArray(n,21,10, ref arr);
            double max = arr[n / 3];
            Boolean all_bigger = false;
            maxArray(n,arr,ref max,(n/3),(n/3*2));
            displayArray(ref arr);
            maxBiggerArray(n,arr,ref all_bigger,max,0,n);
        }


        private void button3_Click(object sender, EventArgs e)
        {
            bool sorted = true;
            listBox1.Items.Clear();
            /*Заповнити масив з n елементів випадковими цілими числами в діапазоні [-10; 10].
             * Написати метод та продемонструвати його роботу:
             * Визначити, чи є він упорядкованим за зростанням.*/
            ;
            int n = int.Parse(textBox1.Text);
            fillArray(n, 11, -10, ref arr);
            displayArray(ref arr);
            sortedArray(n,arr,ref sorted);
        }


        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            /*Заповнити масив A з n елементів випадковими цілими числами в діапазоні [-10; 10].
             * Написати метод та продемонструвати його роботу:
             * Визначити, скільки разів елементи масиву при перегляді від його початку змінюють знак.
             * Наприклад, в масиві {10, -4, 2, 5, -4, -8} знак змінюється 3 рази.*/
            ;
            int n = int.Parse(textBox1.Text);
            int count = 0;
            fillArray(n, 11, -10, ref arr);
            displayArray(ref arr);
            signChanges(n, arr, ref count);
        }



    }
}
