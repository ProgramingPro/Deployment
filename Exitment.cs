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
        private readonly IMyForm form;

        public Exitment()
        {
            InitializeComponent();
          
        }

        public Exitment(IMyForm form)
            :this()
        {
            this.form = form;
        }

        public void Exitment_Load(object sender, EventArgs e)
        {

        }
        
        public void yes_Click(object sender, EventArgs e)
        {
            this.form.CheckToExit = false;
            this.Close();
            App.MainFormManager.CurrentForm = new Interripting();
            this.Hide();
            App.MainFormManager.CurrentForm.Left = App.MainFormManager.CurrentForm.Left + 700;
            App.MainFormManager.CurrentForm.Top = App.MainFormManager.CurrentForm.Top + 300;
        }

        public void no_Click(object sender, EventArgs e)
        {
            this.Hide();  
        }
    }
}
