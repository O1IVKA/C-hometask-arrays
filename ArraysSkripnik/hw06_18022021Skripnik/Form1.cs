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
    }
}
