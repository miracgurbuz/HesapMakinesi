using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hesapMakinesiii
{
    public partial class Form1 : Form
    {
        char _islem;
        bool _ekranTemizle;
        int _ilksayi;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_ekranTemizle)
            {
                ekran.Text = "";
                _ekranTemizle = false;  
            }
            if(ekran.Text=="0") ekran.Text="";
            ekran.Text += "1";

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (_ekranTemizle)
            {
                ekran.Text = "";
                _ekranTemizle = false;
            }
            if (ekran.Text == "0") ekran.Text = "";
            ekran.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (_ekranTemizle)
            {
                ekran.Text = "";
                _ekranTemizle = false;
            }
            if (ekran.Text == "0") ekran.Text = "";
            ekran.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (_ekranTemizle)
            {
                ekran.Text = "";
                _ekranTemizle = false;
            }
            if (ekran.Text == "0") ekran.Text = "";
            ekran.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (_ekranTemizle)
            {
                ekran.Text = "";
                _ekranTemizle = false;
            }
            if (ekran.Text == "0") ekran.Text = "";
            ekran.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (_ekranTemizle)
            {
                ekran.Text = "";
                _ekranTemizle = false;
            }
            if (ekran.Text == "0") ekran.Text = "";
            ekran.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (_ekranTemizle)
            {
                ekran.Text = "";
                _ekranTemizle = false;
            }
            if (ekran.Text == "0") ekran.Text = "";
            ekran.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (_ekranTemizle)
            {
                ekran.Text = "";
                _ekranTemizle = false;
            }
            if (ekran.Text == "0") ekran.Text = "";
            ekran.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (_ekranTemizle)
            {
                ekran.Text = "";
                _ekranTemizle = false;
            }
            if (ekran.Text == "0") ekran.Text = "";
            ekran.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (_ekranTemizle)
            {
                ekran.Text = "";
                _ekranTemizle = false;
            }
            if (ekran.Text == "0") ekran.Text = "";
            ekran.Text += "0";
        }

        private void btnT_Click(object sender, EventArgs e)
        {
            _islem = '+';
            _ekranTemizle = true;
            _ilksayi = Convert.ToInt32(ekran.Text);
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            int ikincisayi = Convert.ToInt32(ekran.Text);
            int sonuc;

            switch (_islem)
            {
                case '+':
                    sonuc = _ilksayi + ikincisayi;
                    break;
                case '-':
                    sonuc = _ilksayi - ikincisayi;
                    break;
                case '/':
                    sonuc = _ilksayi / ikincisayi;
                    break;
                case '*':
                    sonuc = _ilksayi * ikincisayi;
                    break;
                default: 
                    sonuc = 0;
                    break;
            }
            ekran.Text  = Convert.ToString(sonuc);
        }

        private void btnCcc_Click(object sender, EventArgs e)
        {
            _islem = '-';
            _ekranTemizle = true;
            _ilksayi = Convert.ToInt32(ekran.Text);
        }

        private void btnCc_Click(object sender, EventArgs e)
        {
            _islem = '*';
            _ekranTemizle = true;
            _ilksayi = Convert.ToInt32(ekran.Text);
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            _islem = '/';
            _ekranTemizle = true;
            _ilksayi = Convert.ToInt32(ekran.Text);
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            ekran.Text = "0";
        }
    }
}
