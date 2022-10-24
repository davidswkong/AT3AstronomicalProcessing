using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AstronomicalProcessing
{
    public partial class Form1 : Form
    {
        List<string> NeutrinoInteractions = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void UpdateList()
        {

            
            foreach (string Neutrinos in NeutrinoInteractions)
            {             
                ListBox.Items.Add(Neutrinos);               
            }
    
            
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            NeutrinoInteractions.Add(textBox1.Text);
            textBox1.Clear();
            UpdateList();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateList();
                int Index = ListBox.SelectedIndex;
                ListBox.Items.RemoveAt(Index);
                ListBox.Items.Insert(Index, textBox1.Text);
                textBox1.Clear();
                
            }
            catch
            {
                MessageBox.Show("Please select a value to edit.");
            }
        }

        private void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = ListBox.SelectedItem.ToString();
            }
            catch
            {

            }
        }
    }
}
