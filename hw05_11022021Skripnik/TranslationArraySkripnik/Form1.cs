using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TranslationArraySkripnik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void createArray(ref int[] arr)
        {
            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(1,101);
            }
        }
        void printArray(int[] arr)
        {
            foreach(int el in arr)
            {
                listBox1.Items.Add(el);
            }
        }
        void swap(int k,int p,ref int[] arr)
        {
            k--;
            try
            {
                listBox1.Items.Add("swap: " + k + "and " + p);
                int n = arr[k];
                arr[k] = arr[p];
                arr[p] = n;

            }
            catch (IndexOutOfRangeException e) { }
            }
        private void button1_Click(object sender, EventArgs e)
        {/*Написати метод-функцію, що створює масив з n елементів, заповнюючи його випадковими числами з
            указаного діапазону, метод-процедуру, що виводить масив у ListBox. Написати метод-процедуру, 
            яка міняє значення двох чисел*/
            listBox1.Items.Clear();
            int n = Convert.ToInt32(textBox1.Text);
            int[] c = new int[n];
            int p, k;
            createArray(ref c);
            listBox1.Items.Add("before swaping = ");
            printArray(c);
            for(int i=0; i <= ((n / 2)); i++)

            {   p = n - i;
                swap(i, p,ref c);
            }
            listBox1.Items.Add("after swap = ");
            printArray(c);
        }

        private void button2_Click(object sender, EventArgs e)
        {/*Задача 5.2
            Попарно поміняти в масиві два елементи, що стоять
            поруч. Знов отриманий масив вивести в список.
            */
            listBox1.Items.Clear();
            int n = Convert.ToInt32(textBox1.Text);
            int[] c = new int[n];
            int p, k;
            createArray(ref c);
            listBox1.Items.Add("before swaping = ");
            printArray(c);
            for (int i = 0; i <= n-1; i++)

            {
                p = i++ +1;
                swap(i, p, ref c);
            }
            listBox1.Items.Add("after swap = ");
            printArray(c);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int n = Convert.ToInt32(textBox1.Text);
            int[] c = new int[n];
            int p, k;
            createArray(ref c);
            int maxi=0, mini=0,max=c[0],min=c[0];

            listBox1.Items.Add("before swaping = ");
            printArray(c);
            for (int i = 1; i < n; i++)
            { 
                if (c[i] > max)
                {
                    max = c[i];
                    maxi = i;
                }
                else if(c[i] < min)
                {
                    min = c[i];
                    mini = i;
                }
            }
            listBox1.Items.Add("max = " +max);
            listBox1.Items.Add("min = " + min);
            listBox1.Items.Add("maxi = " + maxi);
            listBox1.Items.Add("mini = " + mini);
            int n1 = Math.Abs(mini-maxi);
            if (mini > maxi)
            {
                for (int i = maxi; i <= (mini-(n1/2)+1); i++)
                {
                    listBox1.Items.Add("i " + i);

                    p = i;
                    k = i + 1;

                    swap(k, p, ref c);
                    listBox1.Items.Add("i " + i);
                    listBox1.Items.Add("p " + p);
                }
            }
            else
            {
                for (int i = mini; i <= (maxi - (n1 / 2)+1); i++)
                {


                    p = i;
                    k = i + 1;
                    swap(k, p, ref c);
                    listBox1.Items.Add("i " +i);
                    listBox1.Items.Add("p " + p);
                }
            }
            listBox1.Items.Add("after swap = ");
            printArray(c);
        }

        private void button3_Click(object sender, EventArgs e)
        {/*Задача 5.4

Зсунути всі елементи масиву на один в початок, а перший елемент переставити в кінець. Знов отриманий масив вивести в список.

Наприклад, елементи початкового масиву:

13, 3, 6, 10, 16, 11, 7, 12, 8, 16

Масив після перестановки:

3, 6, 10, 16, 11, 7, 12, 8, 16, 13*/
            listBox1.Items.Clear();
            int n = Convert.ToInt32(textBox1.Text);
            int[] c = new int[n];
            int p, k;
            createArray(ref c);
            listBox1.Items.Add("before swaping = ");
            printArray(c);
            for (int i = 0; i <= n ; i++)
            {
                p = 0;
                k = i + 1;
                swap(k, p, ref c);
            }
            listBox1.Items.Add("after swap = ");
            printArray(c);
        }

        private void button5_Click(object sender, EventArgs e)
        {/*Задача 5.5

Переставити останній елемент масиву на місце k-го елемента. При цьому k-й, (k + 1) -й, ..., передостанній елементи зсунути вправо на 1 позицію.*/
            listBox1.Items.Clear();
            int n = Convert.ToInt32(textBox1.Text);
            int l = Convert.ToInt32(textBox2.Text);

            int[] c = new int[n];
            int p, k;
            createArray(ref c);
            listBox1.Items.Add("before swaping = ");
            printArray(c);
            p = l;
            k = c.Length;
            swap(k, p, ref c);
            for (int i = l+1; i <= n-1; i++)
            {
                p = l+1;
                k = i + 1;
                swap(k, p, ref c);
            }
            listBox1.Items.Add("after swap = ");
            printArray(c);
        }
    }
}
