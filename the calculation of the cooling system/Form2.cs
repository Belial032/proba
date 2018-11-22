using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace the_calculation_of_the_cooling_system
{
     public partial class Form2 : Form
    {
        public static double pi, nox, Gг, Gx, p0, T0, wx, dг, dx, a, alfa, siст, siрг, siрх, nкад, cрг, cрх, Lx, Lг, z, D;
        //высота каналов
        public static double a1, hг, hx, ob, cos;
        //длина половины гофра
        public static double sin, lx, lг;
        //шаг гофра
        public static double tг, tx;
        //Коэф. проходного сечения
        public static double fix, fiг;
        //Коэф. оребрения
        public static double Eорг, Eорх;
        //теплофизические параметры теплоносителей при средних температурах
        //горячего теплоносителя
        public static double lambг, nyг, Prг;
        //холодного теплоносителя
        public static double lambx, nyx, Prx;
        //удельная работа компрессора
        public static double lk, k;
        //температура горячего теплоносителя на выходе из компрессора
        public static double Tг, Tгг;
        //количество теплоты, отводимой от горячего теплоносителя в секунду
        public static double Q;
        //изменение температуры холодного теплоносителя 
        public static double delTx;
        //температура холодного теплоносителя на выходе из охладителя
        public static double Tx, Txx;
        //средние температуры теплоносителя
        public static double Tгср, Txcp;
        //средние плотности теплоносителя
        public static double roг, rox, R;
        //скорость движения горячего теплоносителя
        public static double wг;
        //число Рейнольдса 
        public static double Rex, Reг;
        //числа Нуссельта
        public static double Nux, Nuг;
        //коэф. теплоотдачи
        public static double alfax, alfaг;
        //коэф. теплопередачи при расчетной площади
        public static double kг;
        //средний температурный напор
        public static double delT1;
        //площадь теплопередающей поверхности со стороны горячего теплоносителя
        public static double Aг;
        //площадь теплопередающей поверхности стенок
        public static double Aст;
        //площадь теплопередающей поверхности со стороны холодного теплоносителя
        public static double Ax;
        //Высота охладителя 
        public static double Hг, Hx;




        public static double errorr;






        public Form2()
        {
            InitializeComponent();

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e) //Закрытие программы
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)//Закрытие программы
        {
            Application.Exit();
        }
        
        public void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text==""||textBox2.Text=="" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == ""
                || textBox8.Text == "" || textBox9.Text == "" || textBox10.Text == "" || textBox11.Text == "" || textBox12.Text == "" || textBox13.Text == ""
                || textBox14.Text == "" || textBox15.Text == "" || textBox16.Text == "")
            {
                MessageBox.Show("Не все поля были заполнены",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
             else
            {
                //Расчет всего
           //     double pi, nox, Gг, Gx, p0, T0, wx, dг, dx, a, alfa, siст, siрг, siрх, nкад, cрг, cрх, Lx, Lг;
           
                //перевод из сис string в сис double
                
                //pi = Convert.ToDouble(textBox1.Text);
                double.TryParse(textBox1.Text, out pi);//2
                //nox = Convert.ToDouble(textBox2.Text);
                double.TryParse(textBox2.Text, out nox);//0.7
                //Gг = Convert.ToDouble(textBox3.Text);
                double.TryParse(textBox3.Text, out Gг);//0.36
                //Gx = Convert.ToDouble(textBox4.Text);
                double.TryParse(textBox4.Text, out Gx);//3.6
                //p0 = Convert.ToDouble(textBox5.Text);
                double.TryParse(textBox5.Text, out p0);//0.1
                //T0 = Convert.ToDouble(textBox6.Text);
                double.TryParse(textBox6.Text, out T0);//300
                //wx = Convert.ToDouble(textBox7.Text);
                double.TryParse(textBox7.Text, out wx);//15
                //dг = Convert.ToDouble(textBox8.Text);
                double.TryParse(textBox8.Text, out dг);//3
                //dx = Convert.ToDouble(textBox9.Text);
                double.TryParse(textBox9.Text, out dx);//2.5
                //a = Convert.ToDouble(textBox10.Text);
                double.TryParse(textBox11.Text, out a);//53
                //alfa = Convert.ToDouble(textBox11.Text);
                double.TryParse(textBox10.Text, out alfa);//180
                //siст = siрх = siрг = Convert.ToDouble(textBox12.Text);
                double.TryParse(textBox12.Text, out siст);//0.1
                //nкад = Convert.ToDouble(textBox13.Text);
                double.TryParse(textBox13.Text, out nкад);//0.6
                //cрг = cрх = Convert.ToDouble(textBox14.Text);
                double.TryParse(textBox14.Text, out cрх);//1.005
                //Lx = Convert.ToDouble(textBox15.Text);
                double.TryParse(textBox15.Text, out Lx);//60
                //Lг = Convert.ToDouble(textBox16.Text);
                double.TryParse(textBox16.Text, out Lг);//900
                D = p0 * Math.Pow(10, 6);
                z = siст* Math.Pow(10, -3);

                //высота каналов
                a1 = a * 3.14 / 180;
                cos = Math.Cos(a1);
                ob = 1 / cos;
                hг = ((dг * (ob + 1)) / 2 )+ siст * ob;
                hx = ((dx * (ob + 1)) / 2 )+ siст * ob;

                //длина половины гофра
                sin = Math.Sin(a1);
                lx = hx / sin;
                lг = hг / sin;

                //шаг гофра
                tx = 2 * lx * cos;
                tг = 2 * lг * cos;

                //Коэф. проходного сечения
                fix = (hx - ob * siрх) / (hг + hx + 2 * siрх);
                fiг = (hг - ob * siрг) / (hг + hx + 2 * siрх);

                //Коэф. оребрения
                Eорг = Eорх = 1 + ob;
                
                //теплофизические параметры теплоносителей при средних температурах
                //горячего теплоносителя
                cрг = 1.009;
                lambг = 3.19 * Math.Pow(10, -2);
                nyг = 22.9 * Math.Pow(10, -6);
                Prг = 0.688;

                //холодного теплоносителя
                lambx = 2.67 * Math.Pow(10, -2);
                nyx = 16 * Math.Pow(10, -6);
                Prx = 0.701;

                //удельная работа компрессора!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                
                k = 1.4;
                lk = ((cрх* T0 / nкад) * (-1 + Math.Pow(pi, ((k - 1) / k))));
                //температура горячего теплоносителя на выходе из компрессора
                Tг = T0 + (lk / cрх);

                //температура горячего теплоносителя на выходе из холадителя

                Tгг = Tг - nox * (Tг - T0);

                //количество теплоты, отводимой от горячего теплоносителя в секунду
                Q = Gг * cрх * (Tг - Tгг);

                //изменение температуры холодного теплоносителя 
                delTx = Q / (cрх * Gx);

                //температура холодного теплоносителя на выходе из охладителя
                Tx = T0;
                Txx = Tx + delTx;

                //средние температуры теплоносителя
                Tгср = (Tг + Tгг) / 2;
                Txcp = (Tx + Txx) / 2;

                //средние плотности теплоносителя
                R = 287;
                rox = D / (R * Txcp);
                roг = (pi * D) / (R * Tгср);

                //скорость движения горячего теплоносителя
                wг = wx * ((Gг * Lг * rox * fix) / (Gx * Lx * roг * fiг));

                //число Рейнольдса 
                Reг = (dг * Math.Pow(10, -3) * wг) / nyг;
                Rex = (dx * Math.Pow(10, -3) * wx) / nyx;

                //числа Нуссельта
                Nuг = 1.4*Math.Pow((Reг * (dг / Lг)), 0.4) * Math.Pow(Prг, 0.33);
                Nux = 1.4 * Math.Pow((Rex * (dx / Lx)), 0.4) * Math.Pow(Prx, 0.33);

                //коэф. теплоотдачи
                alfaг = (Nuг * lambг) / (dг * Math.Pow(10, -3));
                alfax = (Nux * lambx) / (dx * Math.Pow(10, -3));

                //коэф. теплопередачи при расчетной площади
                kг = 1 / (Eорг * ((1 / (alfaг * Eорг)) + (z / alfa) + (1 / (alfax * Eорг))));

                //средний температурный напор
                delT1 = Tгср - Txcp;

                //площадь теплопередающей поверхности со стороны горячего теплоносителя
                Aг = Q * Math.Pow(10, 3) / (kг * delT1);

                //площадь теплопередающей поверхности стенок
                Aст = Aг / Eорг;

                //площадь теплопередающей поверхности со стороны холодного теплоносителя
                Ax = Aст * Eорх;

                //Высота охладителя 
                Hг = Aг * (tг * Math.Pow(10, -3) * (hг + hx + 2 * z) * Math.Pow(10, -3) / (Lx * Math.Pow(10, -3) * Lг * Math.Pow(10, -3) * (2 * tг + 4 * lг) * Math.Pow(10, -3)));
                Hx = Ax * (tx * Math.Pow(10, -3) * (hг + hx + 2 * z) * Math.Pow(10, -3) / (Lx * Math.Pow(10, -3) * Lг * Math.Pow(10, -3) * (2 * tx + 4 * lx) * Math.Pow(10, -3)));

                //переход к другой форме
                Form forms3 = new Form3();
                forms3.ShowDialog();
                this.Hide();
            }
        }
    }
}
