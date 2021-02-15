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
                int n = arr[k];
                arr[k] = arr[p];
                arr[p] = n;

            }
            catch (IndexOutOfRangeException e) { }
            }
        private void button1_Click(object sender, EventArgs e)
        {/*Симетрично відобразити елементи масиву. Знов отриманий масив вивести в список.

Наприклад, елементи початкового масиву:

3, 6, 10, 16, 11, 7, 12, 8, 16, 13

Масив після перестановки:

13, 16, 8, 12, 7, 11, 16, 10, 6, 3*/
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
            Попарно поміняти в масиві два елементи,
            що стоять
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
        {/*Задача 5.3

Симетрично відобразити елементи масиву, розташовані між максимальним і мінімальним елементами, включаючи їх. (Вважати, що всі елементи масиву різні). Знов отриманий масив вивести в список.

Наприклад, елементи початкового масиву:

3, 6, 10, 16, 11, 7, 12, 2, 13, 16

Масив після перестановки:

3, 6, 10, 2, 7, 12, 11, 16 13, 16*/
            listBox1.Items.Clear();
            int n = Convert.ToInt32(textBox1.Text);
            int[] c = new int[n];
            int p, k;
            createArray(ref c);
            int maxi=0, mini=0,max=c[0],min=c[0];
            int biggeri, smalleri;
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
            if (mini > maxi)
            {
                biggeri = mini;
                smalleri = maxi;
            }
            else
            {
                biggeri = maxi;
                smalleri = mini;
            }
            int n1 = biggeri - smalleri;
            for (int i = smalleri,j=0; i < (biggeri - (n1 / 2)); i++,j++)
            {

                p = biggeri - j;
                k = i + 1;
                swap(k, p, ref c);
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
            for (int i = n; i >= 0 ; i--)
            {
                p = n-1;
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
