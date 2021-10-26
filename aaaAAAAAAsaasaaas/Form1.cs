using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aaaAAAAAAsaasaaas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int[,] matrix = new int[20, 20];
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    PictureBox pic = new PictureBox
                    {
                        Name = $"{j}_{i}",
                        Size = new Size(35, 35),
                        Location = new Point(35 * i, 35 * j),
                        BackColor = Color.White,
                        SizeMode = PictureBoxSizeMode.StretchImage,
                };
                    panel1.Controls.Add(pic);
                }
            }
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    if ((i == 1) && (j < 2 || j == 4 || j == 7 || j == 8 || (j > 10 && j < 16) || j == 18 || j == 19)||(i == 6) && (j < 2 || j == 4 || j == 5 || j == 8 || (j > 12 && j < 16) || j == 18 || j == 19)|| (i == 12) && (j < 2 || j == 4 || j == 5 || j == 10 || (j > 12 && j < 16))||(i == 16) && (j >3&&j<8 || j > 9 && j < 16 || j == 18 || j == 19))
                    {
                        matrix[i, j] = 3;
                    }
                    if ((i == 2) && (j < 2 || j == 4 || j == 7 || j == 8 || (j > 10 && j < 16) || j == 18 || j == 19) || (i == 7) && (j < 2 || j == 4 || j == 5 || j == 8 || (j > 12 && j < 16) || j == 18 || j == 19) || (i == 13) && (j < 2 || j == 4 || j == 5 || j == 10 || (j > 12 && j < 16)) || (i == 17) && (j > 3 && j < 8 || j > 9 && j < 16 || j == 18 || j == 19))
                    {
                        matrix[i, j] = 4;
                    }


                    if (((i == 1 || i == 2) && (j == 2 || j == 3 || j == 5 || j == 6 || j == 16 || j == 17 || j == 9 || j == 10)) || ((i == 6 || i == 7 || i == 12 || i == 13 || i == 16 || i == 17) && (j == 2 || j == 3 || j == 16 || j == 17)) || ((i == 6 || i == 7 || i == 12 || i == 13) && (j == 6 || j == 7 || j == 11 || j == 12)) || ((i == 6 || i == 7) && (j == 9 || j == 10)) || ((i == 16 || i == 17 || i == 12 || i == 13) && (j == 9 || j == 8))) 
                    {
                        matrix[i, j] = 5;
                    }
                    if ((i == 0 && (j == 5 || j == 16))||(i == 3 || i == 4 || i == 5) && (j == 2 || j == 9 || j == 16) || (i == 8 || i == 9 || i == 10 || i == 11) &&(j == 2 || j == 6 || j == 11 || j == 16) || ( i == 14 || i == 15 || i == 18 || i == 19) && (j == 2 || j == 8 ||  j == 16))
                    {
                        matrix[i, j] = 1;
                    }
                    if ((i == 0 && (j == 6 || j == 17)) || (i == 3 || i == 4 || i == 5) && (j == 3 || j == 10 || j == 17) || (i == 8 || i == 9 || i == 10 || i == 11) && (j == 3 || j == 7 || j == 12 || j == 17) || (i == 14 || i == 15 || i == 18 || i == 19) && (j == 3 || j == 9 || j == 17))
                    {
                        matrix[i, j] = 2;
                    }
                }
            }
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    switch (matrix[i, j])
                    {
                        
                        case 1:
                            PictureBox pic1 = panel1.Controls[$"{i}_{j}"] as PictureBox;
                            pic1.Image = Image.FromFile(@"C:\Users\alecs\Desktop\prodjectAAA\AAAAAAAAAAAAAAA-main\АИСУ\Resources\RSvertical1.png");
                            break;
                        case 2:
                            PictureBox pic2 = panel1.Controls[$"{i}_{j}"] as PictureBox;

                            pic2.Image = Image.FromFile(@"C:\Users\alecs\Desktop\prodjectAAA\AAAAAAAAAAAAAAA-main\АИСУ\Resources\RSvertical2.png");
                            break;
                        case 3:
                            PictureBox pic3 = panel1.Controls[$"{i}_{j}"] as PictureBox;

                            pic3.Image = Image.FromFile(@"C:\Users\alecs\Desktop\prodjectAAA\AAAAAAAAAAAAAAA-main\АИСУ\Resources\RSvertical3.png");
                            break;
                        case 4:
                            PictureBox pic4 = panel1.Controls[$"{i}_{j}"] as PictureBox;

                            pic4.Image = Image.FromFile(@"C:\Users\alecs\Desktop\prodjectAAA\AAAAAAAAAAAAAAA-main\АИСУ\Resources\RSvertical4.png");
                            break; 
                                case 5:
                            PictureBox pic5 = panel1.Controls[$"{i}_{j}"] as PictureBox;

                            pic5.Image = Image.FromFile(@"C:\Users\alecs\Desktop\prodjectAAA\AAAAAAAAAAAAAAA-main\АИСУ\Resources\Rcrossroads.png");
                            break;
                    }
                }
            }
            
        }
    }
}
