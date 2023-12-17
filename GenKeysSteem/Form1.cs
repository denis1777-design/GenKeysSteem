using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace GenKeysSteem
{
    public partial class Form1 : Form
    {
        private const string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

        private const string characters2 =
            "ABCDEFGHIJKLMNOPQRSTUVWXYZzyxwvutsrqponmlkjihgfedcba@!#$%^&<>{}[]*()_-=+`~0123456789";

        private const string numb = "0123456789";

        private const string glasnie = "aeuoyi";

        private const string soglasnie = "qwrtpsdfghjklzxcvbnm";

        // это массив из char, т.е. эл.с индексом 0 будет соответствовать буква А
        Random random = new Random(); //создаем экземпляр класса Random

        string GenerateKeyPart()
        {

            string keyPart = string.Empty;
            for (int i = 0; i < 5; i++)
            {
                keyPart += characters[random.Next(1, characters.Length)];
            }

            return keyPart;
        }

        string GeneratePass()
        {

            string keyPart = string.Empty;
            for (int i = 0; i < 9; i++)
            {
                keyPart += characters2[random.Next(1, characters2.Length)];
            }

            return keyPart;
        }

        string GeneratePin()
        {
            string keyPart = string.Empty;
            for (int i = 0; i < 4; i++)
            {
                keyPart += numb[random.Next(1, numb.Length)];
            }

            return keyPart;
        }

        string GenerateLogin()
        {

            string keyPart = string.Empty;
            for (int i = 0; i < 3; i++)
            {
                keyPart += glasnie[random.Next(1, glasnie.Length)];
            }

            for (int i = 0; i < 3; i++)
            {

                keyPart += soglasnie[random.Next(1, soglasnie.Length)];
            }

            byte nameLen = 6;

            return keyPart;


        }

        string GenerateLogin2()
        {

            string keyPart = string.Empty;
            for (int i = 0; i < 3; i++)
            {
                keyPart += glasnie[random.Next(1, glasnie.Length)];
            }

            for (int i = 0; i < 3; i++)
            {

                keyPart += soglasnie[random.Next(1, soglasnie.Length)];
            }


            /*
            byte nameLen = 6;
            bool firstChar = true;

            while (keyPart.Length < nameLen)
            {
                var charArray = keyPart.ToCharArray();
                charArray = new char[6];
                if (charArray ="") {
                }
            }
            */
            return keyPart;

        }


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //textBox1.Text += GenerateKeyPart();  если написать эту строку без цикла то ключи будут генерироваться в одну строку

            textBox1.Text = string.Empty;

            for (int i = 0; i < numOfKey.Value; i++)
            {
                textBox1.Text += $"{GenerateKeyPart()}-{GenerateKeyPart()}-{GenerateKeyPart()}\r\n";
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;

            for (int i = 0; i < numOfKey.Value; i++)
            {
                textBox1.Text += $"{GeneratePass()}\r\n";
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;

            for (int i = 0; i < numOfKey.Value; i++)
            {
                textBox1.Text += $"{GeneratePin()}\r\n";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            textBox1.Text = string.Empty;

            for (int i = 0; i < numOfKey.Value; i++)
            {
                textBox1.Text += $"{GenerateLogin()}\r\n";
            }
            for (int i = 0; i < numOfKey.Value; i++)
            {
                textBox2.Text += $"{GenerateLogin2()}\r\n";
            }

        }
    }
}
