using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VigenereCipher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public String encrypt(String word, String key)
        {
            String encrypted = "";
            word = word.ToUpper();
            key = key.ToUpper();
            int z = 0;
            while (key.Length < word.Length)
            {
                key += key.ToCharArray()[z];
                z++;
            }
            for (int i = 0; i < word.Length; i++)
            {
                char c = word.ToCharArray()[i];
                if (c + (key.ToCharArray()[i] - 65) > 90)
                {
                    c -= (char)26;
                }
                c += (char)(key.ToCharArray()[i] - 65);
                encrypted += c;
            }
            return encrypted;
        }
        public String decrypt(String word, String key)
        {
            String decrypted = "";
            word = word.ToUpper();
            key = key.ToUpper();
            int z = 0;
            while (key.Length < word.Length)
            {
                key += key.ToCharArray()[z];
                z++;
            }
            for (int i = 0; i < word.Length; i++)
            {
                char c = word.ToCharArray()[i];
                if (c - (key.ToCharArray()[i] - 65) < 65)
                {
                    c += (char)26;
                }
                c -= (char)(key.ToCharArray()[i] - 65);
                decrypted += c;
            }
            return decrypted;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = encrypt(textBox1.Text, textBox2.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = decrypt(textBox1.Text, textBox2.Text);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://jumboperson.github.io/");
        }
    }
}
