using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultipleArraysSkripnik
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        int[] createArray(int n, int xMin, int xMax)//Инициализируется метод который должен возвращать массив целых чисел
        {
            Random rnd = new Random(Guid.NewGuid().GetHashCode());//создается екземпляр класса рандом
            int[] rez = new int[n];//создается пустой массив с количеством елементов н
            for (int i = 0; i < n; i++)
            {
                rez[i] = rnd.Next(xMin, xMax + 1);//значению массива под индексом і присваевается рандомное значение от xMin до xMax+1
            }
            return rez;//возвращает 
        }
        int[] createSortedArray(int n, int xMin, int xMax)//Инициализируется метод который должен возвращать массив целых чисел
        {
            Random rnd = new Random(Guid.NewGuid().GetHashCode());//создается екземпляр класса рандом

            int[] rez = new int[n];//создается пустой массив с количеством елементов н
            rez[0] = rnd.Next(xMin, xMax + 1);
            for (int i = 1; i < n; i++)
            {
                rez[i] = rez[i-1]+rnd.Next(xMin, xMax + 1);//значению массива под индексом і присваевается рандомное значение от xMin до xMax+1
            }
            return rez;//возвращает 
        }
        void printArray(int[] x, ListBox lst)//инициализируется безтиповый метод
        {
            foreach(var temp in x)//цикл который проходится по всему массиву
            {
                lst.Items.Add(temp);//выводится значение массива
            }
            lst.Items.Add(new string('=', 30));//выводится знак = который будет повторятся 30 раз
        }
        int countP(int[] A)
        {
            int rez = 0;
            foreach (int i in A)
            { if (i > 0)
                {
                    rez++;
                }
            }
            return rez;
        }
        int countN(int[] A)
        {
            int rez = 0;
            foreach (int i in A)
            {
                if (i < 0)
                {
                    rez++;
                }
            }
            return rez;
        }
        private void button1_Click(object sender, EventArgs e)
            
        {
            listBox1.Items.Clear();
            /*Заповнити масив A з n елементів випадковими числами в діапазоні [-10; 30],
           * використавши метод creatArray. Створити два масиви: B (складається з елементів 
           * масиву A з парними номерами) і C (складається з елементів масиву A з непарними 
           * номерами). Вивести всі отримані масиви в ListBox, використавши метод printArray з 
           * відповідними параметрами.*/
            int n = Convert.ToInt32(textBox1.Text);
            int[] A = createArray(n, -10, 30);
            int[] B = new int[n%2 ==1? n/2+1:n/2];
            int[] C = new int[n / 2];
            int b = 0, c=0;
            for(int i= 0; i < A.Length; i++)
            {
                if (i % 2 == 0) B[b++] = A[i];
                else C[c++] = A[i];
            }
            printArray(A, listBox1);
            printArray(B, listBox1);
            printArray(C, listBox1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            /*Заповнити масив A з n елементів випадковими числами в діапазоні 
             * [-10; 10], використавши метод creatArray з відповідними параметрами.
             * Створити масив B, який буде складатися тільки з позитивних елементів
             * масиву A, і масив C, що складається з негативних елементів масиву A.
             * Вивести всі отримані масиви в ListBox, використавши метод printArray 
             * з відповідними параметрами*/
            int n = Convert.ToInt32(textBox1.Text);
            int[] A = createArray(n, -10, 10);
            int[] B = new int[countP(A)];
            int[] C = new int[countN(A)];
            int b = 0, c = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > 0) B[b++] = A[i];
                else if (A[i] < 0) C[c++] = A[i];
            }
            printArray(A, listBox1);
            printArray(B, listBox1);
            printArray(C, listBox1);
        }

        private void button6_Click(object sender, EventArgs e)
        {

            listBox1.Items.Clear();
            /*Задача 4_3
Заповнити масиви A і B з n елементів випадковими числами в діапазоні [0; 100], 
використавши метод creatArray з відповідними параметрами.
Створити масив C, перша половина якого буде складатися з елементів масиву A,
а друга половина - з елементів масиву B. Вивести всі отримані масиви в ListBox, використавши метод printArray з відповідними параметрами.
*/
            int n = Convert.ToInt32(textBox1.Text);
            int[] A = createArray(n, 0, 100);
            int[] B = createArray(n, 0, 100);
            int[] C = new int[A.Length + B.Length];
            for (int i = 0; i < A.Length; i++)
            {
                C[i] = A[i];
            }
            for (int i = 0; i < B.Length; i++)
            {
                C[i+ A.Length] = B[i];
            }
            printArray(A, listBox1);
            printArray(B, listBox1);
            printArray(C, listBox1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            /*Задача 4_4
            Заповнити масиви A з n1 елементів і B з n2 елементів випадковими числами в діапазоні [0; 100], використавши метод creatArray з відповідними параметрами.
            Створити масив C, на початку якого будуть перебувати елементи масиву A, а в кінці - елементи масиву B. Вивести всі отримані масиви в ListBox, використавши метод printArray з відповідними параметрами.
            */
            int n1 = Convert.ToInt32(textBox2.Text);
            int n2 = Convert.ToInt32(textBox3.Text);

            int[] A = createArray(n1, 0, 100);
            int[] B = createArray(n2, 0, 100);
            int[] C = new int[A.Length + B.Length];
            for (int i = 0; i < A.Length; i++)
            {
                C[i] = A[i];
            }
            for (int i = 0; i < B.Length; i++)
            {
                C[i + A.Length] = B[i];
            }
            printArray(A, listBox1);
            printArray(B, listBox1);
            printArray(C, listBox1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            /*
Задача 4_5
Заповнити масив A з n елементів випадковими числами в діапазоні [0; 40].
Створити масив B, який буде складатися з елементів масиву A, записаних в зворотному порядку. наприклад,
елементи масиву A: {7, 16, 21, 5, 31}
елементи масиву B: {31, 5, 21, 16, 7}
Вивести всі отримані масиви в ListBox, використавши метод printArray з відповідними параметрами.

*/
            int n = Convert.ToInt32(textBox1.Text);
            int[] A = createArray(n, 0, 40);
            int[] B = new int[n];
            for (int i = 0; i < n; i++)
            {
                B[i] = A[(A.Length - i - 1)];
            }
            printArray(A, listBox1);
            printArray(B, listBox1);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
