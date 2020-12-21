using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace BTL_Win
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        long taithua(long n)
        {
            if (n == 0 || n == 1)
                return 1;
            else return n*taithua(n - 1);
        }
        double tinhsin(double x,double ep)
        {
            double tong = 0;
            int i = 1;
            do
            {
                tong += Math.Pow(-1, i - 1) * ((Math.Pow(x, 2 * i - 1) / taithua(2 * i - 1)));
                i++;
            } while ((Math.Pow(x, 2 * i - 1) / taithua(2 * i - 1)) >= ep);
            return tong;
        }
        double tinhcos(double x, double ep)
        {
            double tong = 0;
            int i = 0;
            do
            {
                tong += Math.Pow(-1, i) * ((Math.Pow(x, 2 * i) / taithua(2 * i)));
                i++;
            } while ((Math.Pow(x, 2 * i) / taithua(2 * i)) >= ep);
            return tong;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x, ep;
            try
            {
                x = Double.Parse(txtx.Text);
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập số thực", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtx.Select();
                return;
            }
            try
            {
                ep = Double.Parse(txtep.Text);
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập số thực", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtep.Select();
                return;
            }
            txtkq.Text = tinhsin(x,ep).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double x, ep;
            try
            {
                x = Double.Parse(txtx.Text);
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập số thực", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtx.Select();
                return;
            }
            try
            {
                ep = Double.Parse(txtep.Text);
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập số thực", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtep.Select();
                return;
            }
            txtkq.Text = tinhcos(x, ep).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double x, ep;
            try
            {
                x = Double.Parse(txtx.Text);
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập số thực", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtx.Select();
                return;
            }
            try
            {
                ep = Double.Parse(txtep.Text);
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập số thực", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtep.Select();
                return;
            }
            txtkq.Text = (tinhsin(x, ep)/ tinhcos(x, ep)).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double x, ep;
            try
            {
                x = Double.Parse(txtx.Text);
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập số thực", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtx.Select();
                return;
            }
            try
            {
                ep = Double.Parse(txtep.Text);
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập số thực", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtep.Select();
                return;
            }
            txtkq.Text = (tinhcos(x, ep) / tinhsin(x, ep)).ToString();
        }
    }
}
