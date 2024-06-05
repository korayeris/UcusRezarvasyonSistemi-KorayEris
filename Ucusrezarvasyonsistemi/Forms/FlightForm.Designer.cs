using System;
using System.Drawing;
using System.Windows.Forms;
using UcusRezarvasyonSistemi.Data;
using UcusRezarvasyonSistemi.Models;


namespace UçuşRezervasyonSistemi.Forms
{
    public partial class FlightForm : Form
    {
        public FlightForm()
        {
            InitializeComponent();
            InitializeFormDesign();
        }

        private void InitializeFormDesign()
        {
           
            Label lblTitle = new Label();
            lblTitle.Text = "Uçuş Bilgileri";
            lblTitle.Font = new Font("Arial", 16, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Dock = DockStyle.Top;
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblTitle.BackColor = Color.DarkBlue;
            lblTitle.Height = 50;
            this.Controls.Add(lblTitle);

            
            this.BackColor = Color.LightGray;

            
            Label lblModel = new Label();
            lblModel.Text = "Uçak Modeli:";
            lblModel.AutoSize = true;
            lblModel.Location = new Point(20, 80);
            this.Controls.Add(lblModel);

            TextBox txtModel = new TextBox();
            txtModel.Location = new Point(150, 80);
            txtModel.Size = new Size(200, 20);
            this.Controls.Add(txtModel);

            Label lblMarka = new Label();
            lblMarka.Text = "Marka:";
            lblMarka.AutoSize = true;
            lblMarka.Location = new Point(20, 120);
            this.Controls.Add(lblMarka);

            TextBox txtMarka = new TextBox();
            txtMarka.Location = new Point(150, 120);
            txtMarka.Size = new Size(200, 20);
            this.Controls.Add(txtMarka);


            
            Button btnKaydet = new Button();
            btnKaydet.Text = "Kaydet";
            btnKaydet.Location = new Point(20, 200);
            btnKaydet.Size = new Size(100, 30);
            btnKaydet.BackColor = Color.DarkBlue;
            btnKaydet.ForeColor = Color.White;
            btnKaydet.Click += BtnKaydet_Click;
            this.Controls.Add(btnKaydet);

            Button btnListele = new Button();
            btnListele.Text = "Listele";
            btnListele.Location = new Point(150, 200);
            btnListele.Size = new Size(100, 30);
            btnListele.BackColor = Color.DarkBlue;
            btnListele.ForeColor = Color.White;
            btnListele.Click += BtnListele_Click;
            this.Controls.Add(btnListele);
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
         
            MessageBox.Show("Uçuş bilgileri kaydedildi.");
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Uçuşlar listelendi.");
        }
    }
}
