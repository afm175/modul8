using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
  
        public Form1()
        {
            InitializeComponent();
            Input.ReadOnly = true;
            Input.Text = String.Empty;
            
        }
        public static string ans = String.Empty;



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //tombol backspace
        private void Backspace_Click(object sender, EventArgs e)
        {
            {
                if (Input.Text.Length > 0)
                    Input.Text = (Input.Text.Substring(0, Input.Text.Length - 1));
            }

        }
        //tombol CE
        private void clear_Click(object sender, EventArgs e)
        {
            Input.Text = ans = String.Empty;
        }

        //kurung
        private void kurbuka_Click(object sender, EventArgs e)
        {
            Input.Text += kurawal.Text;
        }
        private void kurtutup_Click(object sender, EventArgs e)
        {
            Input.Text += kurtutup.Text;
        }

        //phi
        private void phi_Click(object sender, EventArgs e)
        {
            Input.Text += " \u03C0 ";
        }

        //angka
        private void angka0_Click(object sender, EventArgs e)
        {
            Input.Text += angka0.Text;
        }
        private void angka1_Click(object sender, EventArgs e)
        {
            Input.Text += angka1.Text;
        }
        private void angka4_Click(object sender, EventArgs e)
        {
            Input.Text += angka4.Text;
        }
        private void angka7_Click(object sender, EventArgs e)
        {
            Input.Text += angka7.Text;
        }

        //sin
        private void sin_Click(object sender, EventArgs e)
        {
            Input.Text += sin.Text;
        }

        //angka
        private void angka8_Click(object sender, EventArgs e)
        {
            Input.Text += angka8.Text;
        }

        private void angka5_Click(object sender, EventArgs e)
        {
            Input.Text += angka5.Text;
        }

        private void angka2_Click(object sender, EventArgs e)
        {
            Input.Text += angka2.Text;
        }

        //mengirim dan mengambil hasil, tombol samadengan
        private void samadengan_Click(object sender, EventArgs e)
        {
            try { Input.Text = penghitung.hitung(Input.Text).ToString(); }
            catch (MyException ex) { Input.Text = ex.type; }
        }

        //angka
        private void angka3_Click(object sender, EventArgs e)
        {
            Input.Text += angka3.Text;
        }

        private void angka6_Click(object sender, EventArgs e)
        {
            Input.Text += 6;
        }

        private void angka9_Click(object sender, EventArgs e)
        {
            Input.Text += 9;
        }

        //cos
        private void cos_Click(object sender, EventArgs e)
        {
            Input.Text += "cos(";
        }
        //tan
        private void tan_Click(object sender, EventArgs e)
        {
            Input.Text += "tg(";
        }

        //operator
        private void bagi_Click(object sender, EventArgs e)
        {
            Input.Text += " / ";
        }
        private void kali_Click(object sender, EventArgs e)
        {
            Input.Text += " * ";
        }
        private void kurang_Click(object sender, EventArgs e)
        {
            Input.Text += " - ";
        }
        private void tambah_Click(object sender, EventArgs e)
        {
            Input.Text += " + ";
        }
        private void akar_Click(object sender, EventArgs e)
        {
            Input.Text += "sqrt(";
        }
        //ln
        private void ln_Click(object sender, EventArgs e)
        {
            Input.Text += "ln(";
        }
        //log
        private void log_Click(object sender, EventArgs e)
        {
            Input.Text += "lg(";
        }
        //1/x
        private void satubagi_Click(object sender, EventArgs e)
        {
            Input.Text += "(1/";
        }
        //%
        private void persen_Click(object sender, EventArgs e)
        {
            Input.Text += " % ";
        }
        //koma
        private void koma_Click(object sender, EventArgs e)
        {
            Input.Text += koma.Text;
        }
        //pangkat
        private void pangkat2_Click(object sender, EventArgs e)
        {
            Input.Text += " ^2 ";

        }
        private void pangkat3_Click(object sender, EventArgs e)
        {
            Input.Text += " ^3 ";
        }
        private void pangkat_Click(object sender, EventArgs e)
        {
            Input.Text += " ^ ";
        }

        //kombinasi
        private void kombinasi_Click(object sender, EventArgs e)
        {
            Input.Text += "C";
        }
        //permutasi
        private void permutasi_Click(object sender, EventArgs e)
        {
            Input.Text += "P";
        }
        //faktorial
        private void faktorial_Click(object sender, EventArgs e)
        {
            Input.Text += "!";
        }
        //arcs
        private void arcsin_Click(object sender, EventArgs e)
        {
            Input.Text += "asin(";
        }
        private void arccos_Click(object sender, EventArgs e)
        {
            Input.Text += "acos(";
        }
        private void arctan_Click(object sender, EventArgs e)
        {
            Input.Text += "atg(";
        }

        private void e_Click(object sender, EventArgs e)
        {
            Input.Text += " e ";
        }

        private void Input_TextChanged(object sender, EventArgs e)
        {

        }
    }
} 