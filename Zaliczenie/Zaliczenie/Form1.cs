using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Zaliczenie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sweetDataSet2.Smak' table. You can move, or remove it, as needed.
            this.smakTableAdapter.Fill(this.sweetDataSet2.Smak);
            // TODO: This line of code loads data into the 'sweetDataSet1.Praca' table. You can move, or remove it, as needed.
            this.pracaTableAdapter.Fill(this.sweetDataSet1.Praca);
            // TODO: This line of code loads data into the 'sweetDataSet.Klient' table. You can move, or remove it, as needed.
            this.klientTableAdapter.Fill(this.sweetDataSet.Klient);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sweetEntities MojModel = new sweetEntities();
            Smak mojSmak = new Smak(); mojSmak.idSmak = 10;
            mojSmak.NazwaSmaku = textBox1.Text;
            MojModel.Smak.Add(mojSmak);
            MojModel.SaveChanges();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            sweetEntities MojModel = new sweetEntities();
            dataGridView1.DataSource = MojModel.Smak.Where(k => k.NazwaSmaku.StartsWith(textBox1.Text)).ToList();
        }
    }
}
