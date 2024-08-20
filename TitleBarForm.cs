using System;
using System.Windows.Forms;

namespace AdMunitorumCharacterCreatorForms
{
    public partial class TitleBarForm : Form
    {
        public TitleBarForm()
        {
            //InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Top;
            this.Height = 30;

            var statsButton = new Button
            {
                Text = "Stats",
                Location = new System.Drawing.Point(10, 5),
                AutoSize = true
            };

            var originsButton = new Button
            {
                Text = "Origins",
                Location = new System.Drawing.Point(statsButton.Right + 10, 5),
                AutoSize = true
            };

            statsButton.Click += StatsButton_Click;
            originsButton.Click += OriginsButton_Click;

            this.Controls.Add(statsButton);
            this.Controls.Add(originsButton);

        }

        private void TitleBarForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Top;
            this.Height = 30;

            var statsButton = new Button
            {
                Text = "Stats",
                Location = new System.Drawing.Point(10, 5),
                AutoSize = true
            };

            var originsButton = new Button
            {
                Text = "Origins",
                Location = new System.Drawing.Point(statsButton.Right + 10, 5),
                AutoSize = true
            };

            statsButton.Click += StatsButton_Click;
            originsButton.Click += OriginsButton_Click;

            this.Controls.Add(statsButton);
            this.Controls.Add(originsButton);
        }

        private void StatsButton_Click(object sender, EventArgs e)
        {
            //Form currForm = Form.ActiveForm; // Get the reference to the current active form

            //if (currForm.Text == "Character Stats")
            //{
            // Already on the form!
            //    return;
            //}
            // Rest of the code...
            // Clear the current form's controls
            Form _sender = (Form)sender;
            _sender.Parent.Controls.Clear();
            this.Controls.Clear();
            var newForm = new CharacterForm();
            // Add the new form's controls to the current form
            while (newForm.Controls.Count > 0)
            {
                this.Controls.Add(newForm.Controls[0]);
            }
            var titleBarForm = new TitleBarForm();
            // Add the title bar form's controls to the current form
            while (titleBarForm.Controls.Count > 0)
            {
                this.Controls.Add(titleBarForm.Controls[0]);
            }
        }

        private void OriginsButton_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Hide();
            var newForm = new OriginForm();
            while (newForm.Controls.Count > 0)
            {
                this.Controls.Add(newForm.Controls[0]);
            }
        }
    }
}
/*
 *             //Form prevForm = Form.ActiveForm;
            //
            //if (prevForm.Text == "Character Origins")
            //{
                //already on the form!
            //    return;
            //}
            // Clear the current form's controls
            //sender.Parent.Controls.Clear();
            Button button = (Button)sender; //some bullshit
            Form parent = button.Parent as Form;
            //Form _sender = sender as Form;
            //_sender.Parent.Controls.Clear();
            // Add logic for handling Origins button click
            var newForm = new OriginForm();
            // Add the new form's controls to the current form
            while (newForm.Controls.Count > 0)
            {
                parent.Controls.Add(newForm.Controls[0]);
            }
*/