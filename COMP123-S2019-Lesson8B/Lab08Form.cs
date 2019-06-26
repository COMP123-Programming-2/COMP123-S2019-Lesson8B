using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Lesson8B
{
    public partial class Lab08Form : Form
    {
        public string UserName { get; set; }
        public float UserAge { get; set; }
        /// <summary>
        /// This is the Constructor for Label08Form
        /// </summary>
        public Lab08Form()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This is the Event Handler for the SubmitButton Click Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            UserName = NameTextBox.Text;
            // option A
            //float floatResult;
            //bool result;
            //result = float.TryParse(AgeTextBox.Text, out floatResult);
            //UserAge = floatResult;

            // option B
            UserAge = float.Parse(AgeTextBox.Text);

            // option C
            //UserAge = Convert.ToSingle(AgeTextBox);

            OutputLabel.Text = NameTextBox.Text + " " + AgeTextBox.Text;

            // option A
            ClearForm();

            // option B
            NameTextBox.Text = string.Empty;
            AgeTextBox.Text = string.Empty;
        }
        /// <summary>
        /// This method clears the text boxes on the form
        /// </summary>
        private void ClearForm()
        {
            NameTextBox.Clear();
            AgeTextBox.Clear();
            SubmitButton.Enabled = false;
        }

        /// <summary>
        /// This it the Event Handler for the AgeTextBox TextChanged Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AgeTextBox_TextChanged(object sender, EventArgs e)
        {
            //if(AgeTextBox.Text.Length > 0)
            //{
                try
                {
                    float.Parse(AgeTextBox.Text);
                    SubmitButton.Enabled = true;
                }
                catch (Exception)
                {
                    SubmitButton.Enabled = false;
                    //throw;
                }
            //}
            //else
            //{
            //    SubmitButton.Enabled = false;
            //}
        }
        /// <summary>
        /// This is the Event Handler for the Lab08For Load Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Lab08Form_Load(object sender, EventArgs e)
        {
            //SubmitButton.Enabled = false;
            ClearForm();
        }
        /// <summary>
        /// This is the Event Handler for the NameTextBox TextChanged Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            SubmitButton.Enabled = (NameTextBox.Text.Length < 2) ? false : true;
        }
    }
}
