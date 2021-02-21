using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw06_18022021Skripnik
{
    public partial class Form1 : Form
    { Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }
        void display(int[] arr)
        {   foreach (int el in arr)
            {
                listBox1.Items.Add(el);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            /*Заповнити масив A з n елементів випадковими числами в діапазоні [0; 40].
Створити масив B, який буде складатися тільки з парних елементів масиву A. Наприклад,
елементи масиву A: {7, 16, 21, 5, 32, 24, 21, 12, 8, 10}
елементи масиву B: {16, 32, 24, 12, 8, 10}
*/
            int n = int.Parse(textBox1.Text);
            int[] arra = new int[n];
            int count = 0;
            for (int i =0; i <n;i++)
            {
                arra[i] = rnd.Next(0,41);
                if (arra[i] %2 == 0)
                {
                    count++;
                }
            }
            int[] arrb = new int[count];
            for(int i =0, j= 0; i < n; i++)
            {
                if(arra[i]%2 == 0)
                {
                    arrb[j] = arra[i];
                    j++;
                }
            }
            listBox1.Items.Add("A:");
            display(arra);
            listBox1.Items.Add("B:");
            display(arrb);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            /*Дано два масиви одного розміру, в яких немає нульових елементів. Отримати третій масив, кожен елемент якого дорівнює 1, 
             * якщо елементи заданих масивів з тим же номером мають однаковий знак, і дорівнює нулю в іншому випадку.*/
            int n = int.Parse(textBox1.Text);
            int[] arra = new int[n];
            int[] arrb = new int[n];
            int[] arrс = new int[n];
            bool sim = true;
            for (int i = 0; i < n; i++)
            {
                arra[i] = rnd.Next(-10, 11);
                arrb[i] = rnd.Next(-10, 11);
                if ((arra[i] >= 0 && arrb[i] < 0) || (arra[i] < 0 && arrb[i] >= 0))
                {
                    sim = false;
                }
            }
                for (int i = 0; i < n; i++)
            {
                if (sim == false)
                    {
                        arrс[i] = 0;
                    }
                else
                {
                    arrс[i] = 1;
                }
            }
            
            listBox1.Items.Add("A:");
            display(arra);
            listBox1.Items.Add("B:");
            display(arrb);
            listBox1.Items.Add("C:");
            display(arrс);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            /*У масиві з 30 елементів числа утворюють неспадна послідовність. Знайти кількість різних чисел в масиві.*/

        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            /*Дан масив. Переписати його елементи в інший масив такого ж розміру наступним чином: спочатку повинні йти 
             * всі негативні елементи, а потім всі інші. Використовувати тільки один прохід по початковому масиву*/
            int n = int.Parse(textBox1.Text);
            int[] arra = new int[n];
            int[] arrb = new int[n];
            int count = 0;
            for (int i = 0, j = n - 1, ij = 0; i < n; i++)
            {
                arra[i] = rnd.Next(-100, 101);
                if (arra[i] < 0)
                {
                    arrb[ij] = arra[i];
                    ij++;
                }
                else {
                    arrb[j] = arra[i];
                    j--;
                }
            }
            listBox1.Items.Add("A:");
            display(arra);
            listBox1.Items.Add("B:");
            display(arrb);
        }
    }
}
