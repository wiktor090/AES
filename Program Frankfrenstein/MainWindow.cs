using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_Frankfrenstein
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Otworzorzono pomyślnie.", "Otwieranie" , MessageBoxButtons.OK,MessageBoxIcon.Information );
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            _ = MessageBox.Show("Błąd Zapisywania. Kod Blędu 0x110", "Zapisano Błędnie",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
        }
    }
}
