
using AdMunitorum;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace AdMunitorumCharacterCreatorForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.Text = "AdMunitorum";

            var charsheetButton = new Button
            {
                Text = "Open New Character Sheet",
                Location = new System.Drawing.Point(10, 10),
                AutoSize = true
            };

            charsheetButton.Click += NewChar_Button_Click;

            this.Controls.Add(charsheetButton);
            InitializeComponent();

        }

        private void btnGenerateCharacter_Click(object sender, EventArgs e)
        {
            // Add AdMunitorum character generation logic here
            // For now, let's just show a message box
            MessageBox.Show("AdMunitorum Character generated successfully!");
        }
        private void NewChar_Button_Click(object sender, EventArgs e)
        {
            // Create an instance of the form you want to load
            var newForm = new CharBuilder();
            //var titleBarForm = new TitleBarForm();
            newForm.Show();
            /*
            // Clear the current form's controls
            this.Controls.Clear();

            // Add the new form's controls to the current form
            while (newForm.Controls.Count > 0)
            {
                this.Controls.Add(newForm.Controls[0]);
            }

            // Add the title bar form's controls to the current form
            while (titleBarForm.Controls.Count > 0)
            {
                this.Controls.Add(titleBarForm.Controls[0]);
            }

            // Copy the new form's properties to the current form
            this.Text = newForm.Text;
            //this.ClientSize = newForm.ClientSize;
            */
        }
    }

}

/*

namespace AdMunitorum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    }
}
*/