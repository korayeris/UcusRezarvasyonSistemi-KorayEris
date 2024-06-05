using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ucusrezarvasyonsistemi.Forms
{
    public partial class FlightForm : Form
    {
        public FlightForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            checkBox1 = new CheckBox();
            label2 = new Label();
            label3 = new Label();
            seriNo = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(126, 290);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(274, 290);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(156, 31);
            label1.Name = "label1";
            label1.Size = new Size(93, 20);
            label1.TabIndex = 2;
            label1.Text = "ucus bilgileri";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(228, 145);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(101, 24);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 95);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 4;
            label2.Text = "ucakmodeli";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 131);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 5;
            label3.Text = "marka";
            // 
            // seriNo
            // 
            seriNo.AutoSize = true;
            seriNo.Location = new Point(26, 178);
            seriNo.Name = "seriNo";
            seriNo.Size = new Size(46, 25);
            seriNo.TabIndex = 6;
            seriNo.Text = "label4";
            seriNo.UseCompatibleTextRendering = true;
            seriNo.Click += seriNo_Click;
            // 
            // FlightForm
            // 
            ClientSize = new Size(396, 331);
            Controls.Add(seriNo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(checkBox1);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "FlightForm";
            Load += FlightForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private Button button1;
        private Button button2;
        private Label label1;
        private CheckBox checkBox1;
        private Label label2;
        private Label label3;

        private void FlightForm_Load(object sender, EventArgs e)
        {

        }

        private Label seriNo;

        private void seriNo_Click(object sender, EventArgs e)
        {

        }
    }
}
