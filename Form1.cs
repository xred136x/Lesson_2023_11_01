using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Xml;

namespace Lesson_2023_11_01
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SQLiteConnection conn;
        DataTable dtAutor;
        DataTable dtBoocks;
        SQLiteDataAdapter adAutor;
        SQLiteDataAdapter adBoock;

        private void выбратьБдToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string fileName;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileName = openFileDialog1.FileName;
                conn = new SQLiteConnection("Data Source=" +fileName);
                conn.Open();
                string sqltext = "select name from sqlite_master where type='table';";
                SQLiteCommand cmd = new SQLiteCommand(sqltext, conn);
                SQLiteDataReader reader = cmd.ExecuteReader();
                создатьТаблицыToolStripMenuItem.Enabled = !reader.HasRows;
                conn.Close();
                DatagridFill();
            }
            
        }

        private void создатьТаблицыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sqltext = "create table Autors (id int primary key, name varchar(20), description varchar(100)) ;" +
                "create table Biblios(id int primary key, id_autor int, name varchar(20), description varchar(100)) ;";
            SQLiteCommand cmd = new SQLiteCommand(sqltext, conn);
            //cmd.Connection = conn; можно так
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            создатьТаблицыToolStripMenuItem.Enabled = false;
        }
        public void DatagridFill()
        {
            string sqltext = "select * from Autors";
            adAutor = new SQLiteDataAdapter(sqltext,conn);
            SQLiteCommandBuilder cb = new SQLiteCommandBuilder(adAutor);
            dtAutor = new DataTable();
            dtBoocks = new DataTable();
            adAutor.Fill(dtAutor);
            DGAutor.DataSource = dtAutor;

            
        }

        public void DgBoock()
        {
            string sqltext = "select * from Biblios";
            SQLiteCommandBuilder cb1 = new SQLiteCommandBuilder(adBoock);
            dtBoocks = new DataTable();
            adBoock = new SQLiteDataAdapter(sqltext, conn);
            adBoock.Fill(dtBoocks);
            DGBoocks.DataSource = dtBoocks;
        }
        private void сохранитьИзмененияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //dtAutor.AcceptChanges();
            adAutor.Update(dtAutor);
           //dtBoocks.AcceptChanges();
            adBoock.Update(dtBoocks);
        }
    }

}
