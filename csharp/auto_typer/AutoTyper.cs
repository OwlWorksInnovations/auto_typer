using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace auto_typer
{
    public partial class AutoTyper : Form
    {
        public AutoTyper()
        {
            InitializeComponent();
            inputBox.Text = "";
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
                MessageBox.Show("Program will start typing in 5 seconds.");

                await Task.Delay(5000);

                SendKeys.Send(inputBoxText);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
            finally
            {
                typeBtn.Enabled = true;
                inputBox.Text = "";
            }
        }
    }
}
