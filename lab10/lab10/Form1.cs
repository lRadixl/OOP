using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace lab10
{
    public partial class Form1 : Form
    {

        // Семафор для синхронізації доступу до графічного контексту
        private Semaphore semaphore = new Semaphore(1, 1);

        // Об'єкти ManualResetEvent для призупинення потоків
        private ManualResetEvent pauseThreads = new ManualResetEvent(true);
        private ManualResetEvent pauseThread1 = new ManualResetEvent(true);
        private ManualResetEvent pauseThread2 = new ManualResetEvent(true);
        private ManualResetEvent pauseThread3 = new ManualResetEvent(true);

        // Потоки
        Thread thread1;
        Thread thread2;
        Thread thread3;

        public Form1()
        {
            InitializeComponent();

            // Ініціалізація потоків
            thread1 = new Thread(new ThreadStart(draw_rect));
            thread2 = new Thread(new ThreadStart(draw_eclips));
            thread3 = new Thread(new ThreadStart(Rnd_num));
        }

        private void draw_rect()
        {
            try
            {
                Random rnd = new Random();
                Graphics g = panel1.CreateGraphics();
                while (true)
                {
                    semaphore.WaitOne();
                    pauseThread1.WaitOne();
                    Thread.Sleep(40);
                    g.DrawRectangle(Pens.Pink, 0, 0, rnd.Next(this.Width), rnd.Next(this.Height));
                    semaphore.Release();
                }
            }
            catch (Exception) { }
        }

        private void draw_eclips()
        {
            try
            {
                Random rnd = new Random();
                Graphics g = panel2.CreateGraphics();
                while (true)
                {
                    semaphore.WaitOne();
                    pauseThread1.WaitOne();
                    Thread.Sleep(40);
                    g.DrawEllipse(Pens.Pink, 0, 0, rnd.Next(this.Width), rnd.Next(this.Height));
                    semaphore.Release();
                }
            }
            catch (Exception) { }
        }

        private void Rnd_num()
        {
            try
            {
                Random rnd = new Random();
                Parallel.For(0, 500, i =>
                {
                    richTextBox1.Invoke((MethodInvoker)delegate ()
                    {
                        richTextBox1.Text += rnd.Next().ToString();
                    });
                });
            }
            catch (Exception) { }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Запуск усіх потоків
            thread1.Start();
            thread2.Start();
            thread3.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Запуск потоку 1
            thread1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Запуск потоку 2
            thread2.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Запуск потоку 3
            thread3.Start();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Призупинення потоку 1
            pauseThread1.Reset();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Призупинення потоку 2
            pauseThread2.Reset();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Призупинення потоку 3
            pauseThread3.Reset();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // Призупинення всіх потоків
            pauseThreads.Reset();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Завершення потоків при закритті форми
            thread1.Abort();
            thread2.Abort();
            thread3.Abort();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // Відображення форми Form2
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
