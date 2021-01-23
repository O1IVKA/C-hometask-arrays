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
    {   Random rnd = new Random();
        int n_user =0;
        int[] arr1;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            label1.Text = "Заполнить массив из n элементов случайными \nцелыми числами в диапазоне [10; 50].\n Определить, в какой половине массива больше \nчетных чисел: в первой или второй.";
            int n = int.Parse(textBox1.Text);
            int[] arr = new int[n];
            int n1 = 0, n2 = 0;
            for (int i = 0; i < n; i++)
            {
                arr[i] = rnd.Next(10, 51);
            }

            for (int i = 0; i < n/2; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    n1++;

                }
                if (arr[((n-n / 2) +i)] % 2 == 0)
                {
                    n2++;
                }
            }

            var index = 0;
            foreach (var el in arr)
            {
                listBox1.Items.Add("el: " + el + " index: " + index);


                index++;
            }
            if (n1 != n2) 
            {

                if (n1 > n2)
                {
                    listBox1.Items.Add("in first part of array amount of odd numbers bigger");

                }
                else
                {
                    listBox1.Items.Add("in second part of array amount of odd numbers bigger");
                }
            }
            else
            {
                listBox1.Items.Add(" amount of odd numbers the same");

            }
            if (n % 2 == 1) {listBox1.Items.Add("The middle number of the array is ignored"); }
            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            label1.Text = "Заполнить массив из n элементов (n кратно трем) случайными \nвещественными числами в диапазоне [10; 20] с\n точностью до одного знака после запятой.\n Определить максимальное значение в средней трети массива?\n Eсть ли во всем массиве числа, больше\n найденного максимального?";
            int n = int.Parse(textBox1.Text);
            double[] arr = new double[n];
            arr[0]= Math.Round(rnd.NextDouble() * (20 - 10) + 10, 1); 
            double max = arr[0];
            for (int i = 1; i < n; i++)
            {
                arr[i] = Math.Round(rnd.NextDouble() * (20 - 10) + 10,1);
                if (max<arr[i])
                {
                    max=arr[i];

                }
            }
            listBox1.Items.Add("max of all: " + max);
            max = arr[n/3];
            for (int i = n/3+1; i < 2*n / 3; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];

                }
            }

            var index = 0;
            foreach (var el in arr)
            {
                listBox1.Items.Add("el: " + el + " index: " + index);


                index++;
            }
            listBox1.Items.Add("max of 2/3: " + max );

        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool sorted = true;
            listBox1.Items.Clear();
            label1.Text = "Заполнить массив из n элементов \nс клавиатуры. Определить, является\n ли он упорядоченным по возрастанию.";
            int n = int.Parse(textBox1.Text);
            if (arr1==null)
            {
                arr1 = new int[n];

            }

            if (n <= n_user)
            {               
                 n_user = 0;
                arr1 = new int[n];

            }
            arr1[n_user] = int.Parse(textBox2.Text);
                listBox1.Items.Add("added: " + arr1[n_user] + " index: " + n_user);
                n_user++;
                var index = 0;
                foreach (var el in arr1)
                {
                    listBox1.Items.Add("el: " + el + " index: " + index);
                    index++;
                }

            for (int i = 1; i < n; i++)
            {
                if (arr1[i]<arr1[i-1])
                {
                    sorted =false;

                }
            }
            listBox1.Items.Add("sorted: " + sorted);


        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            label1.Text = "Заполнить массив A из n элементов случайными целыми\n числами в диапазоне [-10; 10]. Определить, сколько\n раз элементы массива при просмотре от его\n начала меняют знак. Например, в\n массиве { 10, –4, 2, 5, –4, –8}знак меняется 3 аза.";
            int n = int.Parse(textBox1.Text);
            int[] arr = new int[n];
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                arr[i] = rnd.Next(-10, 11);
            }
            for (int i = 1; i < n; i++)
            {
                if ((arr[i]<0 & arr[i-1]>0)|| (arr[i] > 0 & arr[i - 1] < 0))
                {
                    count++;

                }
            }

            var index = 0;
            foreach (var el in arr)
            {
                listBox1.Items.Add("el: " + el + " index: " + index);
                index++;
            }
                listBox1.Items.Add("count of sign changing: " + count);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            label1.Text = "На уроке валеологии лицеисту 9 класса \nзадали провести наблюдения за температурой воздуха\n за последние 2 недели. Ученик измерял \nтемпературу днем (в 14:00) и утром (в 6:00). \nВам необходимо написать программу, с \nпомощью которой: – сформировать 2 массива наблюдений, \nзаполнив данные с помощью датчика \nслучайных в интервале от -5 до \n10 градусов; – массивы наблюдений\n вывести на форму при помощи элементов\n управления ListBox; – определить, в какие дни \nбыла минимальная дневная температура\n и вывести номера этих дней на форму при\n помощи элемента управления ListBox;\n – определить, в какой день утренняя температура\n первый раз опустилась ниже 0;\n – определить день, утренняя температура в который \nбыла наиболее близкой к среднему значению утренней температуры\n за весь период наблюдений;\n – сформировать третий массив, который будет содержать \nразность между дневной и утренней температурами \nи вывести полученный массив на форму \nпри помощи элемента управления ListBox;\n – определить, сколько раз за первую неделю наблюдалось \nповышение дневной температуры по сравнению\n с предыдущим днем; – определить, количество \nдней за последнюю неделю, когда утренняя температура \nбыла выше, чем t градусов \n(температура t вводится с клавиатуры).";
            int n = 14;
            int[] arr1 = new int[n];
            int[] arr2 = new int[n];
            int[] arr3 = new int[n];
            double t = double.Parse(textBox3.Text);
            arr2[0] = rnd.Next(-5, 11);
            arr1[0] = rnd.Next(-5, 11);
            arr3[0] = Math.Abs(arr1[0] - arr2[0]);
            int min1 = arr1[0];
            int zero2=-1;
            double av = arr2[0];
            int count_increase1 = 0;
            int count2 = 0;
            double lowest = 15;
            int min2 = 0;
            for (int i = 1; i < n; i++)
            {
                arr2[i] = rnd.Next(-5, 11);
                arr1[i] = rnd.Next(-5, 11);
                arr3[i] = Math.Abs(arr1[i] - arr2[i]);

                av += arr2[i];
                if (min1 > arr1[i])
                {
                min1 = arr1[i];
                
                }
                if (i<n/2 && arr1[i]>arr1[i-1])
                {
                    count_increase1++;

                }
                if (arr2[i] > t && i>n/2)
                {
                    count2++;
                }
            }            av /= n;

            while (zero2 == -1)
            {
                for (int i = 0; i < n; i++)
                {

                    if (0 > arr2[i])
                    {
                        zero2 = i;
                        break;
                    }
                }
                
            }

            for (int i = 0; i < n; i++)
            {
                    int el = arr1[i];
                    listBox1.Items.Add("ARR 1(14) el: " + el + " day: " + (i+1));
                    el = arr2[i];
                    listBox1.Items.Add("ARR2(6)  el: " + el + " day: " + (i+1));
                    el = arr3[i];
                    listBox1.Items.Add("ARR3(absolute number of arr1 -arr2)  el: " + el + " day: " + (i+1));
                if (lowest>Math.Abs((double)arr2[i]-av))
                {
                    min2 = i;
                    lowest = Math.Abs((double)arr2[i] - av);
                }
            }
            listBox1.Items.Add("lowest day temp: " + min1);
            listBox1.Items.Add("first time when t was lower than o is day number: " + (zero2+1)%7+" week:" +((zero2+1)/7+1));
            listBox1.Items.Add("day when t the closest to avarage t: day: " + (min2 + 1) % 7 + " week:" + ((min2 + 1) / 7 + 1)+" avarage t: " +av);
            listBox1.Items.Add("day t grew up: " + count_increase1 + " times");
            listBox1.Items.Add("morming temp. was bigger than 't': " + count2 + " times");


        }
    }
}
