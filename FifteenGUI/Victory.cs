using GameLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FifteenGUI
{
    public partial class Victory : Form
    {
        int count;
        TimeSpan time;
        public Victory(int count, TimeSpan time)
        {
            InitializeComponent();
            this.count = count;
            this.time = time;   
        }

        private void Victory_Load(object sender, EventArgs e)
        {
            step.Text += count.ToString();
            duration.Text += time.ToString(@"hh\:mm\:ss");
        }
        private void Victory_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(this, "Начать новую игру?", "Уведомление!", buttons);
            if (result == DialogResult.Yes) 
            { 
                e.Cancel = false;
            }
            else Application.Exit();
        }
    }
}
