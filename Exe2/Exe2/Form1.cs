using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exe2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
        InitializeComponent();
            IsMdiContainer = true;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void клиентToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {



        }

        private void сотрудникToolStripMenuItem_Click(object sender, EventArgs e)
        {
              
                // Создать объект FEmployee класса FormEmployee
                FormEmployee FEmployee = new FormEmployee();
                // Установить родительское окно для дочернего
                FEmployee.MdiParent = this;
                // Вывести на экран дочерее окно
                FEmployee.Show();
            
        }

        private void клиентToolStripMenuItem_Click_1(object sender, EventArgs e)
        {



        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox = new AboutBox1();
            aboutBox.ShowDialog(this);

        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
