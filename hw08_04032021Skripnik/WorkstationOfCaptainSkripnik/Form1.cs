using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkstationOfCaptainSkripnik
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
        void swap(int k, int p, ref char[] arr)
        {
            
                char n = arr[k];
                arr[k] = arr[p];
                arr[p] = n;

                    }
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int m = int.Parse(textBox1.Text);
            int count = 0;
            double miless = Math.Round((double)m/ 1852,2);
            miles.Text = miless + " миль";
        }
        double Price(int w)
        {
            double price = Math.Round((0.68 * (double)w),2);
            return price;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            int sum = 0;
            int sumkg = 0;
            int countsum = 0;
            double avs = 0;
            double avb =0;
            int[] Fish = new int[20];//иницыализируем массив
            string standart = "";
            int count = 0;
            double countb = 0;
            double counts = 0;
            for(int i = 0; i < Fish.Length; i++)//с помощью цыкла заполняем массив
            {
                Fish[i] = rnd.Next(6,20);
                if(Fish[i] >=10 && Fish[i] <= 15)
                {
                    standart += (i+1) + ", ";
                }
                if(Fish[i] >= 10)
                {
                    sumkg += Fish[i];
                }
                if (sum <= 100)//если вес вылова меньше ста то мы добавляем вес следуйщей рыбы
                {
                    sum += Fish[i];
                    countsum++;
                }
                if (i<4 || i>15)//проверяем чем равен индекс рыбины и в зависимости от него добавляем значение к разным переменным
                {
                    avb+= (double)Fish[i];
                    countb++;
                }
                else
                {
                    avs += (double)Fish[i];
                    counts++;
                }
                try {
                    if (Fish[i - 1] < 10 && Fish[i]>15)
                    {
                        count++;
                    } }
                catch (IndexOutOfRangeException ev) { }
            }
            avs /= counts;//назоди средний вес
            avb /= countb;
            avs = Math.Round(avs, 2);//округляем
            avb = Math.Round(avb, 2);
            listBox3.Items.Add("ср. кг у берега = "+avb);
            listBox3.Items.Add("ср. кг в открытом море = "+avs);
            if (avb>avs)//проверяем где средний вес больше
            {
                listBox3.Items.Add("лучше ловить у берега");
            }
            else if(avb < avs)
            {
                listBox3.Items.Add("лучше ловить в открытом море");

            }
            else
            {
                listBox3.Items.Add("нет разницы где ловить");

            }
            foreach (var el in Fish)
            {
                listBox1.Items.Add(el + "кг");
            }
            foreach (var el in standart.Split())//С помощью цыкла выводим массив
            {   if (el != "") {
                    listBox2.Items.Add("номер " + el); }
            }
            coun.Text = ""+count;
            label8.Text = ""+countsum;
            label9.Text = "вартість усього вилову = " + Price(sumkg);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            char[] key = textBox2.Text.ToArray();
            int p;
            int k;
            string keystr = "";
            for (int i = key.Length-1; i>0; i--)
            {
                p =0;
                k = i;
                swap(k, p, ref key);
            }
            foreach (var el in key)
            {
                keystr += "" + el;
            }
            textBox2.Text = keystr;
        }
    }
}
