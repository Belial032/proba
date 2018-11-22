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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            this.Activated += Form3_Activated;
        }
        //активация формы
        private void Form3_Activated(object sender, EventArgs e)
        {

            //Результат
            //label5.Text = Form2.a1.ToString("#.####");//String.Format("{0:0.000}", Form2.errorr);
            label7.Text = Form2.Hг.ToString("0.###");//String.Format("{0:0.000}", Form2.Hг);
            label6.Text = Form2.Hx.ToString("0.###");
            label8.Text = Form2.Ax.ToString("0.##");
            label9.Text = Form2.Aст.ToString("0.##");
            label10.Text = Form2.Aг.ToString("0.##");
            //Гидравлический
            label85.Text = Form2.delT1.ToString("#");
            label86.Text = Form2.kг.ToString("0.##");
            label87.Text = Form2.alfax.ToString("0.##");
            label88.Text = Form2.alfaг.ToString("0.##");
            label89.Text = Form2.Nux.ToString("0.##");
            label90.Text = Form2.Nuг.ToString("0.##");
            label91.Text = Form2.Reг.ToString("0");
            label92.Text = Form2.Rex.ToString("#");
            label93.Text = Form2.wг.ToString("0.##");
            //теплофизические параметры
            label38.Text = Form2.rox.ToString("0.##");
            label39.Text = Form2.roг.ToString("0.##");
            label40.Text = Form2.Prx.ToString("0.###");
            label41.Text = Form2.nyx.ToString();
            label42.Text = Form2.lambx.ToString();
            label43.Text = Form2.cрх.ToString("0.###");
            label44.Text = Form2.Prг.ToString("0.###");
            label45.Text = Form2.nyг.ToString();//String.Format("{0:0.000}", Form2.rox);
            label46.Text = Form2.lambг.ToString();
            label47.Text = Form2.cрг.ToString("0.###");
            //температура и работа
            label67.Text = Form2.Txcp.ToString("#");
            label68.Text = Form2.Tгср.ToString("#");
            label69.Text = Form2.Txx.ToString("0.#");
            label70.Text = Form2.delTx.ToString("0.#");
            label72.Text = Form2.Q.ToString("0.#");
            label73.Text = Form2.Tгг.ToString("#");
            label71.Text = Form2.Tг.ToString("0.#");
            label74.Text = Form2.lk.ToString("#");
            //String.Format("{0:0.000}", Form2.lk);
            //Геометрические параметры
            label22.Text = Form2.Eорг.ToString("0.##");
            label21.Text = Form2.fix.ToString("0.##");
            label20.Text = Form2.fiг.ToString("0.##");
            label19.Text = Form2.tx.ToString("0.##");
            label18.Text = Form2.tг.ToString("0.##");
            label4.Text = Form2.lx.ToString("0.##");
            label3.Text = Form2.lг.ToString("0.##");
            label25.Text = Form2.hx.ToString("0.##");
            label24.Text = Form2.hг.ToString("0.##");
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        

        private void button3_Click(object sender, EventArgs e)
        {
            Form forms2 = new Form2();
            forms2.Show();
            this.Hide();
        }
    }
}
