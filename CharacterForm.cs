using AdMunitorumCharacterCreatorForms;
using System;
using System.Windows.Forms;

public class CharacterForm : Form
{
    public CharacterForm()
    {
        this.Text = "Character Stats";

        var stats = new string[]
        {
            "WeaponSkill",
            "BallisticsSkill",
            "Strength",
            "Toughness",
            "Agility",
            "Intelligence",
            "Perception",
            "Willpower",
            "Fellowship"
        };

        for (int i = 0; i < stats.Length; i++)
        {

            var statName = new Label
            {
                Name = stats[i] + "Label",
                Text = stats[i],
                Location = new System.Drawing.Point(10, 40 + i * 30),
                AutoSize = true
            };

            var statValue = new TextBox
            {
                Text = "0",
                Name = stats[i] + "TextBox",
                Location = new System.Drawing.Point(120, 40 + i * 30),
                Width = 100
            };

            this.Controls.Add(statName);
            this.Controls.Add(statValue);
        }
        var randomizeStats = new Button
        {
            Text = "Emperor Take the Wheel",
            Location = new System.Drawing.Point(10, 40 + stats.Length * 30),
            AutoSize = true
        };
        randomizeStats.Click += RandomizeStatsButton_Click;


        this.Controls.Add(randomizeStats);
        var confirmButton = new Button
        {
            Text = "Confirm Stats",
            Location = new System.Drawing.Point(10, 40 + (stats.Length + 1) * 30),
            AutoSize = true
        };

        confirmButton.Click += ConfirmStatsButton_Click;

        this.Controls.Add(confirmButton);
    }

    private void ConfirmStatsButton_Click(object sender, EventArgs e)
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

    private void UpdateStats()
    {
        Form currForm = Form.ActiveForm;
        foreach (Control control in currForm.Controls)
        {
            if (control is TextBox textBox)
            {
                switch (textBox.Name)
                {
                    case "WeaponSkillTextBox":
                        textBox.Text = StatsSingleton.Instance.WeaponSkill.ToString();
                        break;
                    case "BallisticsSkillTextBox":
                        textBox.Text = StatsSingleton.Instance.BallisticsSkill.ToString();
                        break;
                    case "StrengthTextBox":
                        textBox.Text = StatsSingleton.Instance.Strength.ToString();
                        break;
                    case "ToughnessTextBox":
                        textBox.Text = StatsSingleton.Instance.Toughness.ToString();
                        break;
                    case "AgilityTextBox":
                        textBox.Text = StatsSingleton.Instance.Agility.ToString();
                        break;
                    case "IntelligenceTextBox":
                        textBox.Text = StatsSingleton.Instance.Intelligence.ToString();
                        break;
                    case "PerceptionTextBox":
                        textBox.Text = StatsSingleton.Instance.Perception.ToString();
                        break;
                    case "WillpowerTextBox":
                        textBox.Text = StatsSingleton.Instance.Willpower.ToString();
                        break;
                    case "FellowshipTextBox":
                        textBox.Text = StatsSingleton.Instance.Fellowship.ToString();
                        break;
                }
            }
        }
    }

    private int RNGesusStats(object sender, EventArgs e)
    {
        var random = new Random();
        int statSkill = random.Next(1, 11) + random.Next(1, 11) + 20;
        return statSkill;

    }

    private void RandomizeStatsButton_Click(object sender, EventArgs e)
    {
        var random = new Random();

        StatsSingleton.Instance.WeaponSkill = RNGesusStats(sender, e);
        StatsSingleton.Instance.BallisticsSkill = RNGesusStats(sender, e);
        StatsSingleton.Instance.Strength = RNGesusStats(sender, e);
        StatsSingleton.Instance.Toughness = RNGesusStats(sender, e);
        StatsSingleton.Instance.Agility = RNGesusStats(sender, e);
        StatsSingleton.Instance.Intelligence = RNGesusStats(sender, e);
        StatsSingleton.Instance.Perception = RNGesusStats(sender, e);
        StatsSingleton.Instance.Willpower = RNGesusStats(sender, e);
        StatsSingleton.Instance.Fellowship = RNGesusStats(sender, e);


        UpdateStats();
    }
}
