using AdMunitorumCharacterCreatorForms;
using System;
using System.Windows.Forms;

public class OriginForm : Form
{
    public OriginForm()
    {
        this.Text = "Character Origins";


        var randomizeOrigin = new Button
        {
            Text = "Emperor Take the Wheel",
            Location = new System.Drawing.Point(10, 10 + Text.Length * 30),
            AutoSize = true
        };
        randomizeOrigin.Click += RandomizeOriginButton_Click;

        this.Controls.Add(randomizeOrigin);
        var confirmButton = new Button
        {
            Text = "Confirm Origin",
            Location = new System.Drawing.Point(10, 10 + (Text.Length + 1) * 30),
            AutoSize = true
        };

        confirmButton.Click += ConfirmOriginButton_Click;

        this.Controls.Add(confirmButton);
    }

    private void ConfirmOriginButton_Click(object sender, EventArgs e)
    {
        Form currForm = Form.ActiveForm;
        StatsSingleton.Instance.WeaponSkill = int.Parse(currForm.Controls["WeaponSkillTextBox"].Text);
        StatsSingleton.Instance.BallisticsSkill = int.Parse(currForm.Controls["BallisticsSkillTextBox"].Text);
        StatsSingleton.Instance.Strength = int.Parse(currForm.Controls["StrengthTextBox"].Text);
        StatsSingleton.Instance.Toughness = int.Parse(currForm.Controls["ToughnessTextBox"].Text);
        StatsSingleton.Instance.Agility = int.Parse(currForm.Controls["AgilityTextBox"].Text);
        StatsSingleton.Instance.Intelligence = int.Parse(currForm.Controls["IntelligenceTextBox"].Text);
        StatsSingleton.Instance.Perception = int.Parse(currForm.Controls["PerceptionTextBox"].Text);
        StatsSingleton.Instance.Willpower = int.Parse(currForm.Controls["WillpowerTextBox"].Text);
        StatsSingleton.Instance.Fellowship = int.Parse(currForm.Controls["FellowshipTextBox"].Text);
    }

    private void RandomizeOriginButton_Click(object sender, EventArgs e)
    {
        var random = new Random();
    }

}
