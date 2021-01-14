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
                index++;
                listBox1.Items.Add("element:"+el+", index: "+index);
            }
        }


    }
}
