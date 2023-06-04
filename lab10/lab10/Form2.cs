using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace lab10
{
    public partial class Form2 : Form
    {
        private byte[] key;
        public Form2()
        {
            key = GenerateKey();
            InitializeComponent();
        }

        private async void encryptButton_Click(object sender, EventArgs e)
        {
            string input = inputTextBox.Text;

            // Запускаємо три асинхронні методи шифрування одночасно
            Task<string> skipjackTask = EncryptSkipjackAsync(input);
            Task<string> snefruTask = HashSnefruAsync(input);
            Task<string> pkzipTask = GenerateRandomPKZIPAsync(input);

            // Очікуємо завершення всіх трьох задач
            await Task.WhenAll(skipjackTask, snefruTask, pkzipTask);

            // Отримуємо результати і відображаємо їх
            string skipjackResult = skipjackTask.Result;
            string snefruResult = snefruTask.Result;
            string pkzipResult = pkzipTask.Result;

            skipjackTextBox.Text = skipjackResult;
            snefruTextBox.Text = snefruResult;
            pkzipTextBox.Text = pkzipResult;
        }

        private async Task<string> EncryptSkipjackAsync(string input)
        {
            byte[][] sBoxes = GenerateSBoxes();

            byte[] inputBytes = Encoding.UTF8.GetBytes(input);
            byte[] encryptedBytes = new byte[inputBytes.Length];

            for (int i = 0; i < inputBytes.Length; i++)
            {
                byte inputByte = inputBytes[i];
                int sBoxIndex = i % sBoxes.Length;
                byte[] sBox = sBoxes[sBoxIndex];
                byte encryptedByte = sBox[inputByte];
                encryptedBytes[i] = encryptedByte;
            }

            string encryptedText = Encoding.UTF8.GetString(encryptedBytes);

            await Task.Delay(1000); // Симуляція обчислень

            return encryptedText;
        }

        private byte[][] GenerateSBoxes()
        {
            byte[][] sBoxes = new byte[numSBoxes][];

            for (int i = 0; i < numSBoxes; i++)
            {
                byte[] sBoxBytes = new byte[256];
                using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
                {
                    rng.GetBytes(sBoxBytes);
                }

                sBoxes[i] = sBoxBytes;
            }
            return sBoxes;
        }

        private async Task<string> HashSnefruAsync(string input)
        {
            using ( var snefru = new acryptohashnet.Snefru())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = await Task.Run(() => snefru.ComputeHash(inputBytes));
                return BitConverter.ToString(hashBytes).Replace("-", "");
            }
        }

        private async Task<string> GenerateRandomPKZIPAsync(string input)
        {
            byte[] inputBytes = Encoding.UTF8.GetBytes(input);
            byte[] encryptedBytes = new byte[inputBytes.Length];

            using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(encryptedBytes);
            }

            string encryptedText = Encoding.UTF8.GetString(encryptedBytes);

            await Task.Delay(1000); // Симуляція обчислень

            return encryptedText;
        }

        private byte[] GenerateKey()
        {
            byte[] keyBytes = new byte[10];
            using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(keyBytes);
            }
            return keyBytes;
        }

        // Кількість таблиць S-блоків
        private const int numSBoxes = 128;
    }
}
