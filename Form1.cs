using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace ApplicationContextDemo
{
    /// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : Form, IMyForm
    {
        public TextBox textBox1;
        public PictureBox pictureBox1;
        public PictureBox pictureBox2;
        public Button cancel;
        public Button nextButton;
        public Button back;

        public bool CheckToExit { get; set; }

        private readonly Exitment exitment;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        public System.ComponentModel.Container components = null;

		public Form1()
		{
            //
            // Required for Windows Form Designer support
            //
            this.exitment = new Exitment(this);
            InitializeComponent();
            OtherInitialize();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cancel = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.textBox1.Location = new System.Drawing.Point(23, 93);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(174, 21);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "THIS IS YOUR WELCOME TEXT";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(487, 63);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1, 298);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(487, 10);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(195, 331);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(68, 24);
            this.cancel.TabIndex = 0;
            this.cancel.Text = "Cancel";
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(384, 331);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(92, 24);
            this.nextButton.TabIndex = 2;
            this.nextButton.Text = "Next>";
            this.nextButton.Click += new System.EventHandler(this.next_Click);
            // 
            // back
            // 
            this.back.Enabled = false;
            this.back.Location = new System.Drawing.Point(287, 331);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(91, 24);
            this.back.TabIndex = 1;
            this.back.Text = "<Back";
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(488, 367);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.back);
            this.Controls.Add(this.cancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Installer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
        #endregion

        public void cancel_Click(object sender, System.EventArgs e)
        {           
            exitment.Show();
            exitment.Left = App.MainFormManager.CurrentForm.Left + 100;
            exitment.Top = App.MainFormManager.CurrentForm.Top + 150;  
        }

        private void OtherInitialize()
        {
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);


        }

        public void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var checkToExit = this.CheckToExit;
            this.CheckToExit = false;
            if (checkToExit)
            {
                e.Cancel = true;
                exitment.Show();
                exitment.Left = App.MainFormManager.CurrentForm.Left + 100;
                exitment.Top = App.MainFormManager.CurrentForm.Top + 150;
                
            }
            else
            {
                e.Cancel = false;
            }
        }

        public void next_Click(object sender, System.EventArgs e)
        {
            this.CheckToExit = false;
            App.MainFormManager.CurrentForm = new Form2();
            App.MainFormManager.CurrentForm.StartPosition = FormStartPosition.Manual;
            App.MainFormManager.CurrentForm.Location = this.Location;
            this.Hide();
            App.MainFormManager.CurrentForm.Show(); 
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            //all the time when form is open again the flag should be reseted.
            CheckToExit = true;
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        public void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            this.CheckToExit = true;
        }
    }
}
