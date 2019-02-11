using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCommand1_Click(object sender, EventArgs e)
        {
            lblNumber.Text = (Doubler.NowNumber += 1).ToString();
            lblDoubler.Text = (Doubler.NuberCommand += 1).ToString();
            Back.Push(Doubler.NowNumber);
            
        }

        private void btnCommand2_Click(object sender, EventArgs e)
        {
            lblNumber.Text = (Doubler.NowNumber *= 2).ToString();
            lblDoubler.Text = (Doubler.NuberCommand += 1).ToString();
            Back.Push(Doubler.NowNumber);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblNumber.Text = (Doubler.NowNumber=1).ToString();
            lblDoubler.Text = (Doubler.NuberCommand = 0).ToString();
            Back.Clear();
            Back.Push(Doubler.NowNumber);
        }
       

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (Doubler.NuberCommand != 0)
            {
            lblDoubler.Text = (Doubler.NuberCommand -= 1).ToString();
                Back.Pop();
            lblNumber.Text=(Doubler.NowNumber=Back.Peek()).ToString();
            }
        }

        private void btnGame_Click(object sender, EventArgs e)
        {
            int Geni = Doubler.Gen();
            lblFinish.Text = Geni.ToString();
            lblDoubler.Text = (Doubler.NuberCommand = 0).ToString();
            lblNumber.Text = (Doubler.NowNumber = 1).ToString();
            Back.Clear();
            Back.Push(Doubler.NowNumber);
            MessageBox.Show($"Начнем играть. Ваша задача достигнуть числа {Geni} за минимальное количество попыток");
        }

       
    }
}
