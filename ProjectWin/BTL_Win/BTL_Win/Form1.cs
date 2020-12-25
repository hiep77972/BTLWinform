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
        int thaotac = 0;
        double x, ep;
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
        void KhoiTao()
        {
            
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
            thaotac = 1;
            KhoiTao();
            txtkq.Text = tinhsin(x,ep).ToString();
            txtkqHam.Text = Math.Sin(x).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            thaotac = 1;
            KhoiTao();
            txtkq.Text = tinhcos(x, ep).ToString();
            txtkqHam.Text = Math.Cos(x).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            thaotac = 1;
            KhoiTao();
            if (tinhcos(x, ep) != 0)
            {
            txtkq.Text = (tinhsin(x, ep) / tinhcos(x, ep)).ToString();
            txtkqHam.Text = (Math.Sin(x)/Math.Cos(x)).ToString();
            }
                
            else
                MessageBox.Show("Nhập dữ liệu sai", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            thaotac = 1;
            KhoiTao();
            if (tinhsin(x, ep) != 0)
            {
            txtkq.Text = (tinhcos(x, ep) / tinhsin(x, ep)).ToString();
            txtkqHam.Text = (Math.Cos(x) / Math.Sin(x)).ToString();
            }
            else
                MessageBox.Show("Nhập dữ liệu sai", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtx.Text = "";
            txtep.Text = "";
            txtkq.Text = "";
            txtkqHam.Text = "";
            thaotac = 0;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (txtkq.Text.Trim()=="" && txtkqHam.Text.Trim()=="") return;
            else
            {
                if (Double.Parse(txtkq.Text) > Double.Parse(txtkqHam.Text))
                    MessageBox.Show("Kết quả bài toán lớn hơn hàm lượng giác có sẵn","So Sánh", MessageBoxButtons.OK);
                else if (Double.Parse(txtkq.Text) < Double.Parse(txtkqHam.Text))
                    MessageBox.Show("Kết quả bài toán nhỏ hơn hàm lượng giác có sẵn","So Sánh", MessageBoxButtons.OK);
                else
                    MessageBox.Show("Kết quả bài toán bằng hàm lượng giác có sẵn","So Sáng", MessageBoxButtons.OK);
            }

        }
    }
}
