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
    }
}
