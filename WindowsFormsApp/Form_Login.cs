﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp.Data;
namespace WindowsFormsApp
{
    public partial class Form_Login : Form
    {   
        
        public Form_Login()
        {
            InitializeComponent();
        }
        
        private void Form_Login_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
            WebRequestPostExample rq = new WebRequestPostExample();
            //rq.Request();
            //rq.post();
            //rq.delete("4e596539-342e-44e6-b554-faaec514f4ad");
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMain formMain = new FormMain();
            formMain.ShowDialog();
            this.Close();
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2CustomCheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMain formMain = new FormMain();
          
           
            formMain.ShowDialog();
            this.Close();
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            AdminDow ad = new AdminDow();

            if(ad.login(guna2TextBox2.Text, guna2TextBox4.Text))
            {
                this.Hide();
                FormMain formMain = new FormMain();
                formMain.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Nhập sai tài khoản hoặc mật khẩu");
            } 
            
            
        }
    }
}
