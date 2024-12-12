using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace auto_typer
{
    public partial class AutoTyper : Form
    {
        public AutoTyper()
        {
            InitializeComponent();
        }

        private void AutoTyper_Load(object sender, EventArgs e)
        {

        }

        private void inputBox_TextChanged(object sender, EventArgs e)
        {
   
        }

        private async void typeBtn_Click(object sender, EventArgs e)
        {
            string inputBoxText = inputBox.Text;

            if (string.IsNullOrEmpty(inputBoxText))
            {
                MessageBox.Show("Please enter some text to type.");
                return;
            }

            typeBtn.Enabled = false;

            try
            {
                await Task.Delay(5000);

                SendKeys.SendWait(inputBoxText);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
            finally
            {
                typeBtn.Enabled = true;
            }
        }
    }
}
