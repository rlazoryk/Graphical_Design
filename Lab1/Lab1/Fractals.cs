using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
using System.Text.RegularExpressions;

namespace Lab1
{
    public partial class Fractals : Form
    {
        public Fractals()
        {
            InitializeComponent();            
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            //Создаем перо цвета - Черный(Black)
            //Толщина - 1 пиксель:
            Pen myPen = new Pen(Color.Black, 1);
            //Объявляем объект "g" класса Graphics и предоставляем
            //ему возможность рисования на pictureBox1:
            Graphics g = Graphics.FromHwnd(Picture.Handle);
            //Вызов функции отрисовки фрактала
            //int mx =1026, my = 428;
            int mx = Picture.Width, my = Picture.Height;               
            Complex constant = new Complex(Double.Parse(cRealField.Text), Double.Parse(cImagineField.Text));
            Draw(mx, my, g, myPen, constant);           
        }        
        public void Draw(int mx1, int my1, Graphics g, Pen pen, Complex c)
        {
            int n, mx, my;        

            mx = mx1 / 2;
            my = my1 / 2;

            for (int y = -my; y < my; y++)
                for (int x = -mx; x < mx; x++)
                {
                    n = NewonsMethod(new Complex(x * 0.05, y * 0.05), c, 0.01, Int32.Parse(RankCombobox.SelectedItem.ToString()));
                    pen.Color = FormColor(ColorSchemaCombobox.SelectedItem.ToString(), n);
                    g.DrawRectangle(pen, mx + x, my + y, 1, 1);                    
                }           
        }
        public Color FormColor(string color, int n)
        {
            switch(color)
            {
                case "Фіолетова":
                    return Color.FromArgb(255, (n * 9) % 255, 0, (n * 9) % 255);
                case "Жовта":
                    return Color.FromArgb(255, (n * 9) % 255, (n * 9) % 255, 0);
                case "Зелена":
                    return Color.FromArgb(255, 0, (n * 9) % 255, 0);
                case "Блакитна":
                    return Color.FromArgb(255, 0, 0, (n * 9) % 255);
                case "Червона":
                    return Color.FromArgb(255, (n * 9) % 255, 0, 0);                    
                default: return Color.FromArgb(255, 0, (n * 9) % 255, (n * 9) % 255);
            }
        }
        public int NewonsMethod(Complex z0, Complex c, double eps, int rank)
        {
            Complex z = z0;
            double zR = z.Real;
            double zI = z.Imaginary;
            Complex oldZ;
            int iter = 0;
            do
            {
                oldZ = z;
                z = (double)(rank - 1) / rank * z + 1.0 / rank * c / Complex.Pow(z, rank - 1);               
                iter++;
            } while (Complex.Abs(z - oldZ) > eps);
            return iter;
        }
        public bool CheckDoubleTextBox(TextBox textBox)
        {
            if (textBox.Text == "") return false;
            foreach (var i in textBox.Text)
            {
                if (!char.IsDigit(i) && i != ',')  
                {
                    return false;
                }
            }
            return true;
        }
        private void cRealField_TextChanged(object sender, EventArgs e)
        {
            if (!CheckDoubleTextBox((TextBox)sender))
            {
                MessageBox.Show("Only digits and \",\" can be used in this field");
                (sender as TextBox).Text = "";
            }
        }
        
    }
}
