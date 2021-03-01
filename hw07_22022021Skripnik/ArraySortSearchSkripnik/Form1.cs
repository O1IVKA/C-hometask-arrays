using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArraySortSearchSkripnik
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }
        void display(int[] arr)
        {

            foreach (int el in arr)
            {
                listBox1.Items.Add("el = " + el);
            }
        }
        void Swap(ref int p, ref int k, ref int c)
        {
            c = p;
            p = k;
            k = c;
        }
        void BubbleSortToLow(ref int[] arr, int k, int p)
        {
            int c = 0;
            for (int i = k; i < p; i++)
            {
                for (int j = k; j < p - 1; j++)
                {
                    if (arr[j] < arr[j + 1])
                    {
                        Swap(ref arr[j + 1], ref arr[j], ref c);
                    }
                }
            }
        }
        void BubbleSortToHigh(ref int[] arr, int k, int p)
        {
            int c = 0;
            for (int i = k; i < p; i++)
            {
                for (int j = k; j < p - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        Swap(ref arr[j + 1], ref arr[j], ref c);
                    }
                }
            }
        }
        void Count(int el, int[] arr, ref string max, ref int maxc)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == el)
                {
                    count++;
                }
            }
            listBox1.Items.Add("el = " + el + " times: " + count);

            if (count > maxc)
            {
                max = el + ", ";
                maxc = count;
            }
            else if (count == maxc)
            {
                max += el + ", ";

            }
        }
        void BinarySearch(int[] arr, int num,int min, int max)
        {

            if (min > max)
            {   
                listBox1.Items.Add("there isn't element with this num");
            }
            else
            {
                int mid = (min + max) / 2;
                if (num == arr[mid])
                {
                    listBox1.Items.Add("index of element you searched = "+(mid));
                }
                else if (num < arr[mid])
                {
                    BinarySearch(arr, num, min, mid - 1);
                }
                else
                {
                    BinarySearch(arr, num, mid + 1, max);
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {/*Задача 7.1
Відсортувати методом бульбашки першу половину масиву за спаданням, а другу - по зростанню.
Знову отриманий масив вивести в список.*/
            listBox1.Items.Clear();
            int n = int.Parse(textBox1.Text);
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = rnd.Next(0,101);
            }
            listBox1.Items.Add("BEFORE SORTING");
            display(arr);
            BubbleSortToLow(ref arr, 0, arr.Length / 2);
            BubbleSortToHigh(ref arr, arr.Length / 2, arr.Length);
            listBox1.Items.Add("AFTER SORTING");
            display(arr);


        }

        private void button2_Click(object sender, EventArgs e)
        {/*Задача 7.2

Написати процедуру, яка міняє значення двох чисел.

Написати процедуру, яка сортує елементи масиву з номерами від k1 до k2 методом бульбашки по спаданню.

Використовуючи цю процедуру, впорядкувати обидві половини масиву за спаданням. Знову отриманий масив вивести в список.*/
            listBox1.Items.Clear();
            int n = int.Parse(textBox1.Text);
            int[] arr = new int[n];
            int c = 0;
            for (int i = 0; i < n; i++)
            {
                arr[i] = rnd.Next(0, 101);
            }
            listBox1.Items.Add("BEFORE SORTING");
            display(arr);
            BubbleSortToLow(ref arr, 0, arr.Length/2);
            BubbleSortToLow(ref arr, arr.Length / 2,arr.Length );
            listBox1.Items.Add("AFTER SORTING");
            display(arr);


        }

        private void button3_Click(object sender, EventArgs e)
        {/*Задача 7.3

Відсортувати масив по спадаючій і визначити:

- скільки в масиві різних елементів;

- скільки кожних елементів в масиві;({5, 5, 4, 1, 3, 2, 3, 3, 1} 5 в масиві зустрічається 2 рази, 4 – 1, 3 – 3, 2 – 1, 1 - 2)

- яких чисел в масиві найбільше;

- три самих маленьких числа.*/
            listBox1.Items.Clear();
            int n = int.Parse(textBox1.Text);
            int[] arr = new int[n];
            int c = 0;
            int countd = 1;
            string max="";
            int maxc=0;
            for (int i = 0; i < n; i++)
            {
                arr[i] = rnd.Next(0, 11);
            }
            listBox1.Items.Add("BEFORE SORTING");
            display(arr);
            BubbleSortToLow(ref arr, 0, arr.Length);
            listBox1.Items.Add("AFTER SORTING");
            display(arr);
            Count(arr[0], arr, ref max, ref maxc);
            for (int i = 1; i < n; i++)
            {
                if (arr[i] < arr[i - 1])
                {
                    countd++;
                    Count(arr[i] ,arr, ref max, ref maxc);

                }
            }
            listBox1.Items.Add("different numbers = " + countd);
            listBox1.Items.Add("max count = " + maxc+" num = " + max);
            int counts = 0;

            for (int i =n-1; i > 1; i--)
            {
                if (arr[i] < arr[i - 1] && counts < 3)
                {
                    listBox1.Items.Add("one of 3 smallest = " + arr[i]);
                    counts++;
                }
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {/*Задача 7.4

Відсортувати масив за зростанням. Ввести в текстове поле число. Використовуючи метод бінарного пошуку, знайти в масиві елемент з введенним значенням і вивести його номер. Якщо такого елемента немає, вивести відповідне повідомлення.*/
            listBox1.Items.Clear();
            int n = int.Parse(textBox1.Text);
            int[] arr = new int[n];
            int num = int.Parse(textBox2.Text);
            for (int i = 0; i < n; i++)
            {
                arr[i] = rnd.Next(0, 11);
            }
            listBox1.Items.Add("BEFORE SORTING");
            display(arr);
            BubbleSortToHigh(ref arr, 0, arr.Length);
            listBox1.Items.Add("AFTER SORTING");
            display(arr);
            int min = 0;
            int max = arr.Length - 1;
            BinarySearch(arr, num, min, max);

        }
    }
}
