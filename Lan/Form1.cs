using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace Lan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }
        int index;

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem items in listView1.SelectedItems) {
                index = items.Index;
                txtManv.Text = items.SubItems[0].Text;
                txtHoten.Text = items.SubItems[1].Text;
                txtLuong.Text = items.SubItems[2].Text;

            }
        }

        ArrayList nv = new ArrayList();

        private void btnThem_Click(object sender, EventArgs e)
        {
            Nhanvien ob = new Nhanvien(txtManv.Text, txtHoten.Text, float.Parse(txtLuong.Text));
            nv.Add(ob);
            txtManv.Clear();
            txtHoten.Clear();
            txtLuong.Clear();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("Ma nhan vien" , 70);
            listView1.Columns.Add("Ho ten", 100);
            listView1.Columns.Add("Luong", 60);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Nhanvien ob = new Nhanvien(txtManv.Text, txtHoten.Text, float.Parse(txtLuong.Text));
            nv.RemoveAt(index);
            nv.Insert(index, ob);
            txtManv.Clear();
            txtHoten.Clear();
            txtLuong.Clear();

        }

        private void btnHienthi_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            string[] arr = new string[4];
            ListViewItem lvitem;
            foreach (Nhanvien item in nv)
            { 
                arr[0] = item.Manv;
                arr[1] = item.Hoten;
                arr[2] = item.Luong.ToString();
                lvitem = new ListViewItem(arr);
                listView1.Items.Add(lvitem);

            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            nv.RemoveAt(index);
            txtManv.Clear();
            txtHoten.Clear();
            txtLuong.Clear();
        }

        private void btnSapxep_Click(object sender, EventArgs e)
        {
            nv.Sort(new Sort_Luong());
        }




    }
}
