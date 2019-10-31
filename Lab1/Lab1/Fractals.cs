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
using System.IO;
using System.Drawing.Imaging;

namespace Lab1
{
    public partial class Fractals : Form
    {
        private Bitmap Bmp;
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

            Bmp = new Bitmap(Picture.Width, Picture.Height);

            Graphics g = Graphics.FromImage(Bmp);

            //Вызов функции отрисовки фрактала
            //int mx =1026, my = 428;
            int mx = Picture.Width, my = Picture.Height;
            if (CheckDoubleTextBox(cRealField) && CheckDoubleTextBox(cImagineField))
            {
                Complex constant = new Complex(Double.Parse(cRealField.Text), Double.Parse(cImagineField.Text));
                Draw(mx, my, g, myPen, constant);
                Picture.Image = Bmp;
     
            }

            Picture.Image = Bmp;//show the bitmap in a picture box control
            
        }        
        public void Draw(int mx1, int my1, Graphics g, Pen pen, Complex c)
        {
            int n, mx, my;        

            mx = mx1 / 2;
            my = my1 / 2;
            // Це я пробував масштаб міняти на основі тої шкали
            int scale = TrackBar1.Value;
            double koef = 0.005;
            if (scale < 100)
            {
                scale = (100 - scale) / 20;
                for(int i = 0; i < scale; ++i)
                {
                    koef *= 10;
                    MessageBox.Show(koef.ToString());
                }                
            }
            else if(scale > 100)
            {
                scale /= 100;
                for (int i = 0; i < scale; ++i)
                {
                    koef /= 10;
                    MessageBox.Show(koef.ToString());
                }
            }
            MessageBox.Show(koef.ToString());
            for (int y = -my; y < my; y++)
            {
                for (int x = -mx; x < mx; x++)
                {
                    n = NewonsMethod(new Complex(x * koef, y * koef), c, 0.1, Int32.Parse(RankCombobox.SelectedItem.ToString()));
                    pen.Color = FormColor(ColorSchemaCombobox.SelectedItem.ToString(), n);
                    g.DrawRectangle(pen, mx + x, my + y, 1, 1);
                }
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
                //z = 2.0 / 3 * z + 1.0 / 3 * c / (z * z);
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
                WrongComplexLabel.Visible = true;
                (sender as TextBox).Text = "";
            }
        }

        private void TrackBar1_ValueChanged(object sender, EventArgs e)
        {
            if(TrackBar1.Value > 100)
            {
                if (TrackBar1.Value % 100 != 0)
                {
                    TrackBar1.Value = (TrackBar1.Value / 100) * 100;
                }
            }
            else
            {
                if (TrackBar1.Value % 20 != 0)
                {
                    TrackBar1.Value = (TrackBar1.Value / 20) * 20;
                }
            }
            ScaleLabel.Text = string.Format($"Масштаб: {TrackBar1.Value}%");
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            
            sfd.Filter = "Images|*.png;*.bmp;*.jpg";
            sfd.FilterIndex = 1;
            ImageFormat format = ImageFormat.Png;
            if (Bmp != null && sfd.ShowDialog() == DialogResult.OK)
            {
                string ext = System.IO.Path.GetExtension(sfd.FileName).ToLower();
                switch (ext)
                {
                    case ".jpg":
                        format = ImageFormat.Jpeg;
                        break;
                    case ".bmp":
                        format = ImageFormat.Bmp;
                        break;
                }
                
                Bmp.Save(sfd.FileName, format);// save the bitmap  
            }
            //  Picture.Image.Save(@"C:\Users\Ihor\Documents\3 курс\Графіка\Lab1", ImageFormat.Bmp);


        }
    }
}
