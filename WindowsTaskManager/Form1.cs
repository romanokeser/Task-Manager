using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace WindowsTaskManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void getProcesses()     //get process
        {
            Process[] task = Process.GetProcesses();
            var list = task.Cast<Process>().OrderBy(item => item.ProcessName).ToList();
            ListaProcesa.Items.Clear();
            foreach (Process listItem in list)
            {
                ListaProcesa.Items.Add(listItem);
            }
        }
        private void BtnOtvoriProces_Click(object sender, EventArgs e)  //button otvori proces
        {
            DialogResult dialogResult1 = openFileDialog1.ShowDialog();
            if (dialogResult1 == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
                using (Process myProcess = new Process())           
                {
                    myProcess.StartInfo.FileName = openFileDialog1.FileName;
                    myProcess.StartInfo.CreateNoWindow = true;
                    myProcess.Start();
                }
            }
            else
            {
                ListaProcesa.Text = "Direktorij nije odabran!";
            }
        }
        private void zatvoriProces_Click(object sender, EventArgs e)     //button zatvori proces iz liste
        {
            Process[] proc = Process.GetProcessesByName(Path.GetFileNameWithoutExtension(textBox1.Text));
            foreach (Process item in proc)
            {
                item.Kill();
            }
        }

        private void BtnPrikaziListuProcesa_Click(object sender, EventArgs e) // button prikazi listu procesa
        {
            getProcesses();
        }

        private void ListaProcesa_SelectedIndexChanged(object sender, EventArgs e)  //lista procesa i karakteristike
        {
            Process proc = (Process)ListaProcesa.SelectedItem;
            ListKarakteristikeProcesa.Items.Clear();
            ListKarakteristikeProcesa.Items.Add("Ime: " + proc.ProcessName);
            ListKarakteristikeProcesa.Items.Add("ID: " + proc.Id);
            ListKarakteristikeProcesa.Items.Add("Virtual Memory: " + proc.VirtualMemorySize64);
            try
            {
                ListKarakteristikeProcesa.Items.Add("Start Time: " + proc.StartTime);
            }
            catch (Exception)
            {
                ListKarakteristikeProcesa.Items.Add(" Start time: access denied ");     //catch ako nije moguce iscitati virtual memory
            }

        }

        private void BtnZatvoriProces_Click(object sender, EventArgs e)     //button zatvori proces iz liste
        {
            try
            {
                Process proc = (Process)ListaProcesa.SelectedItem;
                proc.Kill();
            }
            catch (Exception)
            {
                ListKarakteristikeProcesa.Items.Add("Nije odabran proces!");        //catch ako process nije odabran
            }
            
        }
        private void ListaDirektorij_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ListKarakteristikeProcesa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

