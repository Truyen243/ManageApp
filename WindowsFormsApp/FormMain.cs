﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class FormMain : Form
    {

        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            formKhoa1.Visible = false;
            formSinhVien1.Visible = true;
            formMonHoc1.Visible = false;
            formDiem1.Visible = false;
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            formKhoa1.Visible = false;
            formSinhVien1.Visible = false;
            formMonHoc1.Visible = false;
            formDiem1.Visible = true;
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            formKhoa1.Visible = false;
            formSinhVien1.Visible = false;
            formMonHoc1.Visible = true;
            formDiem1.Visible = false;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            formKhoa1.Visible = false;
            formSinhVien1.Visible = true;
            formMonHoc1.Visible = false;
            formDiem1.Visible = false;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            formKhoa1.Visible = true;
            formSinhVien1.Visible = false;
            formMonHoc1.Visible = false;
            formSinhVien1.Visible = false;
        }

        private void formMonHoc1_Load(object sender, EventArgs e)
        {

        }

        private void gunaContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
