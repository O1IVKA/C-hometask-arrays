using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayFilling
{
    public partial class Form1 : Form
    { Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }




        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int[] arr = { 37, 0, 50, 46,34,46,0,13 };
            int index  = 0;
            label1.Text+="Заповнити масив з вісьми \nэлементів наступними значеннями: \nперший элемент масиву дорівнює\n 37, другий — 0, третій — 50,\n четвертий — 46, п’ятий — 34, шостий — 46,\n сьомий — 0, восьмий —13.";
            //Здесь использую метод добавления индекса по единице, т.к. метод Array.IndexOf(array, item); будет работать не правольно, потому что в массиве два нуля
            foreach (int el  in arr) {
                listBox1.Items.Add("element:"+el+", index: "+index);
                index++;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        { 
            int n = int.Parse(textBox1.Text);
            int[] arr = new int[n];
            for (int i = 0; i < n/2; i++)
            {
                    arr[i] = rnd.Next(1, 21);

            }
            int index_arr = 0;
            for (int i = n/2; i < n ; i++)
            {
                arr[i] = arr[index_arr];
                index_arr++;


            }
            int index = 0;
            label1.Text += "Заповнити першу половину масиву, який містить n \nелементів (n – парне) випадковими числами в \nдіапазоні [1;20]. Другу половину масиву \nотримати як копію першой \nполовини масиву.Наприклад, \nелементи масиву A(n = 10):\n 3, 6, 10, 16, 11, 3, 6, \n10, 16, 11";
            //Здесь использую тот же метод
            foreach (int el in arr)
            {
                listBox1.Items.Add("element:" + el + ", index: " + index);
                index++;

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);
            int[] arr = new int[n];
                for (int i = 0; i < (n+1)/2; i++)
                {
                    arr[i] = rnd.Next(20, 101);

                } 
            int index_arr = (n-1)/2;
            for (int i = (n/2) ; i < n; i++)
            {              

                arr[i] = arr[index_arr];
                index_arr--;

            }
            int index = 0;
            label1.Text += "Заповнити першу половину масиву, який\n містить n елементів випадковими числами в\n діапазоні [20;100]. Другу половину масиву \nотримати як как дзеркальне \nвідображення першої половини масиву.\nНаприклад, елементи масиву(парна кількість):\n 31, 62, 99, 46, 77, 77, 46,\n 99, 62, 31\nНаприклад, елементи масиву \nA(непарна кількість): 31, 62, 99, 46, 77, 46,\n 99, 62, 31";
            //Здесь использую тот же метод
            foreach (int el in arr)
            {
                listBox1.Items.Add("element:" + el + ", index: " + index);
                index++;

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);
            int[] arr = new int[n];
            arr[0] = rnd.Next(1, 101);
            int last=arr[0];
            for (int i = 1; i < n ; i++)
            {   if (i % 2 == 0)
                {
                arr[i] = rnd.Next(1, 101);
                    last = arr[i];
                }
                else
                {
                    arr[i] = last;
                }

            }


            int index = 0;
            label1.Text += "Заповнити масив, який містить n елементів таким \nчином, щоб елементи з парними номерами були випадковими \nчислами в діапазоні [1;100], а з непарними – \nдорівнювали попередньому. Наприклад, елементи масиву \nA(n = 10): 13, 13, 56, 56, 70, 70, 89,\n 89, 41, 41";
            //Здесь использую тот же метод
            foreach (int el in arr)
            {
                listBox1.Items.Add("element:" + el + ", index: " + index);
                index++;

            }
        }





    }
}
