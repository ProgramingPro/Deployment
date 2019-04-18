using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ApplicationContextDemo
{
    public partial class Exitment : Form
    {
        public Exitment()
        {
            InitializeComponent();
        }

        private void Exitment_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            App.MainFormManager.CurrentForm = new Interripting();
            App.MainFormManager.CurrentForm.Location = this.Location;
            this.Hide();
            App.MainFormManager.CurrentForm.Show();
            App.MainFormManager.CurrentForm.Top = App.MainFormManager.CurrentForm.Top - 150;
            App.MainFormManager.CurrentForm.Left = App.MainFormManager.CurrentForm.Left - 75;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();  
        }
    }
}
