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
                if (arr[(n-n / 2 + i)] % 2 == 0)
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

            if (n > n_user)
            {
                arr1[n_user] = int.Parse(textBox2.Text);
                listBox1.Items.Add("added: " + arr1[n_user] + " index: " + n_user);
                n_user++;

            }

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
    }
}
