using AdMunitorumCharacterCreatorForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AdMunitorumCharacterCreatorForms.StatsSingleton;

namespace AdMunitorum
{
    public partial class CharBuilder : Form
    {
        public CharBuilder()
        {
            InitializeComponent();
        }

        private void StatPageConfirmButton_Click(object sender, EventArgs e)
        {
            //we will have to revert this if someone decides to change it later?

            //two part func. Update the stats from the box to the singleton, then update all labels. including skills.
            StatsSingleton.Instance.WeaponSkill = int.Parse(WeaponSkillStatTabBox.Text);
            StatsSingleton.Instance.BallisticsSkill = int.Parse(BallisticsSkillStatTabBox.Text);
            StatsSingleton.Instance.Strength = int.Parse(StrengthStatTabBox.Text);
            StatsSingleton.Instance.Toughness = int.Parse(ToughnessStatTabBox.Text);
            StatsSingleton.Instance.Agility = int.Parse(AgilityStatTabBox.Text);
            StatsSingleton.Instance.Intelligence = int.Parse(IntelligenceStatTabBox.Text);
            StatsSingleton.Instance.Perception = int.Parse(PerceptionStatTabBox.Text);
            StatsSingleton.Instance.Willpower = int.Parse(WillpowerStatTabBox.Text);
            StatsSingleton.Instance.Fellowship = int.Parse(FellowshipStatTabBox.Text);
            StatsSingleton.Instance.EXP = int.Parse(ExperienceStatTabBox.Text);
            UpdateCharacterPanel();
        }

        private void UpdateCharacterPanel()
        {
            StatsSingleton.Instance.WeaponSkill = int.Parse(WeaponSkillStatTabBox.Text) + (StatsSingleton.Instance.AllStatAdvances[(int)StatsEnum.WeaponSkill] * 5);
            WeaponSkillStatDisplay.Text = StatsSingleton.Instance.WeaponSkill.ToString();
            StatsSingleton.Instance.BallisticsSkill = int.Parse(BallisticsSkillStatTabBox.Text) + (StatsSingleton.Instance.AllStatAdvances[(int)StatsEnum.BallisticsSkill] * 5);
            BallisticsSkillStatDisplay.Text = StatsSingleton.Instance.BallisticsSkill.ToString();
            StatsSingleton.Instance.Strength = int.Parse(StrengthStatTabBox.Text) + (StatsSingleton.Instance.AllStatAdvances[(int)StatsEnum.Strength] * 5);
            StrengthStatDisplay.Text = StatsSingleton.Instance.Strength.ToString();
            StatsSingleton.Instance.Toughness = int.Parse(ToughnessStatTabBox.Text) + (StatsSingleton.Instance.AllStatAdvances[(int)StatsEnum.Toughness] * 5);
            ToughnessStatDisplay.Text = StatsSingleton.Instance.Toughness.ToString();
            StatsSingleton.Instance.Agility = int.Parse(AgilityStatTabBox.Text) + (StatsSingleton.Instance.AllStatAdvances[(int)StatsEnum.Agility] * 5);
            AgilityStatDisplay.Text = StatsSingleton.Instance.Agility.ToString();
            StatsSingleton.Instance.Intelligence = int.Parse(IntelligenceStatTabBox.Text) + (StatsSingleton.Instance.AllStatAdvances[(int)StatsEnum.Intelligence] * 5);
            IntelligenceStatDisplay.Text = StatsSingleton.Instance.Intelligence.ToString();
            StatsSingleton.Instance.Perception = int.Parse(PerceptionStatTabBox.Text) + (StatsSingleton.Instance.AllStatAdvances[(int)StatsEnum.Perception] * 5);
            PerceptionStatDisplay.Text = StatsSingleton.Instance.Perception.ToString();
            StatsSingleton.Instance.Willpower = int.Parse(WillpowerStatTabBox.Text) + (StatsSingleton.Instance.AllStatAdvances[(int)StatsEnum.Willpower] * 5);
            WillpowerStatDisplay.Text = StatsSingleton.Instance.Willpower.ToString();
            StatsSingleton.Instance.Fellowship = int.Parse(FellowshipStatTabBox.Text) + (StatsSingleton.Instance.AllStatAdvances[(int)StatsEnum.Fellowship] * 5);
            FellowshipStatDisplay.Text = StatsSingleton.Instance.Fellowship.ToString();

            //update skills. we do the actual skill calculation here.
            StatsSingleton.Instance.Athletics = StatsSingleton.Instance.Strength + StatsSingleton.Instance.AllSkillAdvances[(int)SkillEnum.Athletics] * 5;
            AthleticsTotalDisplay.Text = StatsSingleton.Instance.Athletics.ToString();
            StatsSingleton.Instance.Awareness = StatsSingleton.Instance.Perception + StatsSingleton.Instance.AllSkillAdvances[(int)SkillEnum.Awareness] * 5;
            AwarenessTotalDisplay.Text = StatsSingleton.Instance.Awareness.ToString();
            StatsSingleton.Instance.Dexterity = StatsSingleton.Instance.Agility + StatsSingleton.Instance.AllSkillAdvances[(int)SkillEnum.Dexterity] * 5;
            DexterityTotalDisplay.Text = StatsSingleton.Instance.Dexterity.ToString();
            StatsSingleton.Instance.Discipline = StatsSingleton.Instance.Willpower + StatsSingleton.Instance.AllSkillAdvances[(int)SkillEnum.Discipline] * 5;
            DisciplineTotalDisplay.Text = StatsSingleton.Instance.Discipline.ToString();
            StatsSingleton.Instance.Fortitude = StatsSingleton.Instance.Toughness + StatsSingleton.Instance.AllSkillAdvances[(int)SkillEnum.Fortitude] * 5;
            FortitudeTotalDisplay.Text = StatsSingleton.Instance.Fortitude.ToString();
            StatsSingleton.Instance.Intuition = StatsSingleton.Instance.Perception + StatsSingleton.Instance.AllSkillAdvances[(int)SkillEnum.Intuition] * 5;
            IntuitionTotalDisplay.Text = StatsSingleton.Instance.Intuition.ToString();
            StatsSingleton.Instance.Linguistics = StatsSingleton.Instance.Intelligence + StatsSingleton.Instance.AllSkillAdvances[(int)SkillEnum.Linguistics] * 5;
            LinguisticsTotalDisplay.Text = StatsSingleton.Instance.Linguistics.ToString();
            StatsSingleton.Instance.Logic = StatsSingleton.Instance.Intelligence + StatsSingleton.Instance.AllSkillAdvances[(int)SkillEnum.Logic] * 5;
            LogicTotalDisplay.Text = StatsSingleton.Instance.Logic.ToString();
            StatsSingleton.Instance.Lore = StatsSingleton.Instance.Intelligence + StatsSingleton.Instance.AllSkillAdvances[(int)SkillEnum.Lore] * 5;
            LoreTotalDisplay.Text = StatsSingleton.Instance.Lore.ToString();
            StatsSingleton.Instance.Medicae = StatsSingleton.Instance.Intelligence + StatsSingleton.Instance.AllSkillAdvances[(int)SkillEnum.Medicae] * 5;
            MedicaeTotalDisplay.Text = StatsSingleton.Instance.Medicae.ToString();
            StatsSingleton.Instance.Melee = StatsSingleton.Instance.WeaponSkill + StatsSingleton.Instance.AllSkillAdvances[(int)SkillEnum.Melee] * 5;
            MeleeTotalDisplay.Text = StatsSingleton.Instance.Melee.ToString();
            StatsSingleton.Instance.Navigation = StatsSingleton.Instance.Intelligence + StatsSingleton.Instance.AllSkillAdvances[(int)SkillEnum.Navigation] * 5;
            NavigationTotalDisplay.Text = StatsSingleton.Instance.Navigation.ToString();
            StatsSingleton.Instance.Presence = StatsSingleton.Instance.Fellowship + StatsSingleton.Instance.AllSkillAdvances[(int)SkillEnum.Presence] * 5;
            PresenceTotalDisplay.Text = StatsSingleton.Instance.Presence.ToString();
            StatsSingleton.Instance.Piloting = StatsSingleton.Instance.Agility + StatsSingleton.Instance.AllSkillAdvances[(int)SkillEnum.Piloting] * 5;
            PilotingTotalDisplay.Text = StatsSingleton.Instance.Piloting.ToString();
            StatsSingleton.Instance.PsychicMastery = StatsSingleton.Instance.Willpower + StatsSingleton.Instance.AllSkillAdvances[(int)SkillEnum.PsychicMastery] * 5;
            PsychicMasteryTotalDisplay.Text = StatsSingleton.Instance.PsychicMastery.ToString();
            StatsSingleton.Instance.Ranged = StatsSingleton.Instance.BallisticsSkill + StatsSingleton.Instance.AllSkillAdvances[(int)SkillEnum.Ranged] * 5;
            RangedTotalDisplay.Text = StatsSingleton.Instance.Ranged.ToString();
            StatsSingleton.Instance.Rapport = StatsSingleton.Instance.Fellowship + StatsSingleton.Instance.AllSkillAdvances[(int)SkillEnum.Rapport] * 5;
            RapportTotalDisplay.Text = StatsSingleton.Instance.Rapport.ToString();
            StatsSingleton.Instance.Reflexes = StatsSingleton.Instance.Agility + StatsSingleton.Instance.AllSkillAdvances[(int)SkillEnum.Reflexes] * 5;
            ReflexesTotalDisplay.Text = StatsSingleton.Instance.Reflexes.ToString();
            StatsSingleton.Instance.Stealth = StatsSingleton.Instance.Agility + StatsSingleton.Instance.AllSkillAdvances[(int)SkillEnum.Stealth] * 5;
            StealthTotalDisplay.Text = StatsSingleton.Instance.Stealth.ToString();
            StatsSingleton.Instance.Tech = StatsSingleton.Instance.Intelligence + StatsSingleton.Instance.AllSkillAdvances[(int)SkillEnum.Tech] * 5;
            TechTotalDisplay.Text = StatsSingleton.Instance.Tech.ToString();

            //update skill advances
            AthleticsAdvancesDisplay.Text = StatsSingleton.Instance.AllSkillAdvances[(int)SkillEnum.Athletics].ToString();
            AwarenessAdvancesDisplay.Text = StatsSingleton.Instance.AllSkillAdvances[(int)SkillEnum.Awareness].ToString();
            DexterityAdvancesDisplay.Text = StatsSingleton.Instance.AllSkillAdvances[(int)SkillEnum.Dexterity].ToString();
            DisciplineAdvancesDisplay.Text = StatsSingleton.Instance.AllSkillAdvances[(int)SkillEnum.Discipline].ToString();
            FortitudeAdvancesDisplay.Text = StatsSingleton.Instance.AllSkillAdvances[(int)SkillEnum.Fortitude].ToString();
            IntuitionAdvancesDisplay.Text = StatsSingleton.Instance.AllSkillAdvances[(int)SkillEnum.Intuition].ToString();
            LinguisticsAdvancesDisplay.Text = StatsSingleton.Instance.AllSkillAdvances[(int)SkillEnum.Linguistics].ToString();
            LogicAdvancesDisplay.Text = StatsSingleton.Instance.AllSkillAdvances[(int)SkillEnum.Logic].ToString();
            LoreAdvancesDisplay.Text = StatsSingleton.Instance.AllSkillAdvances[(int)SkillEnum.Lore].ToString();
            MedicaeAdvancesDisplay.Text = StatsSingleton.Instance.AllSkillAdvances[(int)SkillEnum.Medicae].ToString();
            MeleeAdvancesDisplay.Text = StatsSingleton.Instance.AllSkillAdvances[(int)SkillEnum.Melee].ToString();
            NavigationAdvancesDisplay.Text = StatsSingleton.Instance.AllSkillAdvances[(int)SkillEnum.Navigation].ToString();
            PresenceAdvancesDisplay.Text = StatsSingleton.Instance.AllSkillAdvances[(int)SkillEnum.Presence].ToString();
            PilotingAdvancesDisplay.Text = StatsSingleton.Instance.AllSkillAdvances[(int)SkillEnum.Piloting].ToString();
            PsychicMasteryAdvancesDisplay.Text = StatsSingleton.Instance.AllSkillAdvances[(int)SkillEnum.PsychicMastery].ToString();
            RangedAdvancesDisplay.Text = StatsSingleton.Instance.AllSkillAdvances[(int)SkillEnum.Ranged].ToString();
            RapportAdvancesDisplay.Text = StatsSingleton.Instance.AllSkillAdvances[(int)SkillEnum.Rapport].ToString();
            ReflexesAdvancesDisplay.Text = StatsSingleton.Instance.AllSkillAdvances[(int)SkillEnum.Reflexes].ToString();
            StealthAdvancesDisplay.Text = StatsSingleton.Instance.AllSkillAdvances[(int)SkillEnum.Stealth].ToString();
            TechAdvancesDisplay.Text = StatsSingleton.Instance.AllSkillAdvances[(int)SkillEnum.Tech].ToString();

            int totalXP = int.Parse(ExperienceStatTabBox.Text) + int.Parse(OriginTabExpBox.Text);//just update the total xp
            ExperienceDisplay.Text = string.Format("{0}", totalXP);


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

            UpdateStatTabLabels();
        }

        private void UpdateStatTabLabels()
        {
            WeaponSkillStatTabBox.Text = StatsSingleton.Instance.WeaponSkill.ToString();
            BallisticsSkillStatTabBox.Text = StatsSingleton.Instance.BallisticsSkill.ToString();
            StrengthStatTabBox.Text = StatsSingleton.Instance.Strength.ToString();
            ToughnessStatTabBox.Text = StatsSingleton.Instance.Toughness.ToString();
            AgilityStatTabBox.Text = StatsSingleton.Instance.Agility.ToString();
            IntelligenceStatTabBox.Text = StatsSingleton.Instance.Intelligence.ToString();
            PerceptionStatTabBox.Text = StatsSingleton.Instance.Perception.ToString();
            WillpowerStatTabBox.Text = StatsSingleton.Instance.Willpower.ToString();
            FellowshipStatTabBox.Text = StatsSingleton.Instance.Fellowship.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AgriWorldTabPage_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) //origin tab drowpdown
        {
            //hell yes. this is the event that will change the origin of the character.
            //Shrine World
            //Shrine Wold
            Origin selectedOrigin = StatsSingleton.Instance.AllOrigins.Origins.Find(x => x.Name == OriginTabOriginDropdown.SelectedItem.ToString());
            //OriginTabDescriptionBox.Text = selectedOrigin.Description;
            //OriginTabBonusesBox.Text = selectedOrigin.StatBonuses;
            Form currentForm = Form.ActiveForm;
            OriginStatBoostBox.Text = selectedOrigin.StatBonuses;
            if (OriginStatBoostLabel.Text == "Ballistics Skill")
            {
                OriginStatBoostLabel.Text = "Ballistics Skill";
            }
            else if (OriginStatBoostLabel.Text == "Weapon Skill")
            {
                OriginStatBoostLabel.Text = "Weapon Skill";
            }
            OriginDescriptionBox.Text = selectedOrigin.Description;
            OriginItemBox.Text = selectedOrigin.Item;
            OriginExamplePlanetBox.Text = ""; //clear the box
            foreach (string planet in selectedOrigin.Example)
            {
                OriginExamplePlanetBox.Text += planet;
                OriginExamplePlanetBox.Text += "    ";
            }

            //currentForm.Controls.Find("OriginTabBonusesBox", true)[0].Text = selectedOrigin.StatBonuses;
            //currentForm.Controls.Find("OriginTabDescriptionBox", true)[0].Text = selectedOrigin.Description;
            List<string> originSkills = selectedOrigin.Choice;
            ComboBox choiceDropdown = OriginBoostChoiceDropdown;//currentForm.Controls.Find("OriginBoostChoiceDropdown", true)[0];
            choiceDropdown.Items.Clear();
            //choiceDropdown.SelectedIndex = 0;
            foreach (string skill in originSkills)
            {
                //choiceDropdown.Items.Add(skill);
                if (skill == "BallisticsSkill")
                {
                    choiceDropdown.Items.Add("Ballistics Skill");
                }
                else if (skill == "WeaponSkill")
                {
                    choiceDropdown.Items.Add("Weapon Skill");
                }
                else
                {
                    choiceDropdown.Items.Add(skill);
                }
                //choiceDropdown.Items.Add(skill);
            }
            choiceDropdown.SelectedIndex = 0;
        }

        private void ApplyOriginButton_Click(object sender, EventArgs e)
        {
            if (OriginTabOriginDropdown.SelectedItem == null)
            {
                return;
            }
            Instance.CurrentOrigin = Instance.AllOrigins.Origins.Find(x => x.Name == OriginTabOriginDropdown.SelectedItem.ToString());

            //we will need to track the previous boost, and revert it...
            //update the origin in the stats singleton, and redraw whatever needs to be redrawn.
            if (Instance.PreviousOrigin.Name != "None")
            {
                List<string> statstoremove = new List<string> //all stat boosts for this action.
                {
                    Instance.PreviousOrigin.StatBonuses,
                    Instance.PreviousOrigin.SelectedChoice.ToString()

                };
                foreach (string boost in statstoremove)
                {
                    //revert the previous origin
                    switch (boost)
                    {
                        case "Ballistics Skill":
                            Instance.AllStatAdvances[(int)StatsEnum.BallisticsSkill] -= 1;
                            break;
                        case "Weapon Skill":
                            Instance.AllStatAdvances[(int)StatsEnum.WeaponSkill] -= 1;
                            break;
                        case "BallisticsSkill": //string formatting is dumb. do either.
                            Instance.AllStatAdvances[(int)StatsEnum.BallisticsSkill] -= 1;
                            break;
                        case "WeaponSkill":
                            Instance.AllStatAdvances[(int)StatsEnum.WeaponSkill] -= 1;
                            break;
                        case "Strength":
                            Instance.AllStatAdvances[(int)StatsEnum.Strength] -= 1;
                            break;
                        case "Toughness":
                            Instance.AllStatAdvances[(int)StatsEnum.Toughness] -= 1;
                            break;
                        case "Agility":
                            Instance.AllStatAdvances[(int)StatsEnum.Agility] -= 1;
                            break;
                        case "Intelligence":
                            Instance.AllStatAdvances[(int)StatsEnum.Intelligence] -= 1;
                            break;
                        case "Perception":
                            Instance.AllStatAdvances[(int)StatsEnum.Perception] -= 1;
                            break;
                        case "Willpower":
                            Instance.AllStatAdvances[(int)StatsEnum.Willpower] -= 1;
                            break;
                        case "Fellowship":
                            Instance.AllStatAdvances[(int)StatsEnum.Fellowship] -= 1;
                            break;
                        default:
                            break;
                    }
                }
            }

            List<string> statboostsLocal = new List<string> //all stat boosts for this action.
            {
                Instance.CurrentOrigin.StatBonuses,
                OriginBoostChoiceDropdown.SelectedItem.ToString()

            };

            foreach (string boost in statboostsLocal)
            {
                //apply the new origin
                switch (boost)
                {
                    case "Ballistics Skill":
                        StatsSingleton.Instance.AllStatAdvances[(int)StatsEnum.BallisticsSkill] += 1;
                        break;
                    case "Weapon Skill":
                        StatsSingleton.Instance.AllStatAdvances[(int)StatsEnum.WeaponSkill] += 1;
                        break;
                    case "BallisticsSkill": //string formatting is dumb. do either.
                        StatsSingleton.Instance.AllStatAdvances[(int)StatsEnum.BallisticsSkill] += 1;
                        break;
                    case "WeaponSkill":
                        StatsSingleton.Instance.AllStatAdvances[(int)StatsEnum.WeaponSkill] += 1;
                        break;
                    case "Strength":
                        StatsSingleton.Instance.AllStatAdvances[(int)StatsEnum.Strength] += 1;
                        break;
                    case "Toughness":
                        StatsSingleton.Instance.AllStatAdvances[(int)StatsEnum.Toughness] += 1;
                        break;
                    case "Agility":
                        StatsSingleton.Instance.AllStatAdvances[(int)StatsEnum.Agility] += 1;
                        break;
                    case "Intelligence":
                        StatsSingleton.Instance.AllStatAdvances[(int)StatsEnum.Intelligence] += 1;
                        break;
                    case "Perception":
                        StatsSingleton.Instance.AllStatAdvances[(int)StatsEnum.Perception] += 1;
                        break;
                    case "Willpower":
                        StatsSingleton.Instance.AllStatAdvances[(int)StatsEnum.Willpower] += 1;
                        break;
                    case "Fellowship":
                        StatsSingleton.Instance.AllStatAdvances[(int)StatsEnum.Fellowship] += 1;
                        break;
                    default:
                        break;
                }
            }
            Instance.CurrentOrigin.SelectedChoice = OriginBoostChoiceDropdown.SelectedItem.ToString();
            Instance.PreviousOrigin = new Origin
            {
                Name = Instance.CurrentOrigin.Name,
                Description = Instance.CurrentOrigin.Description,
                StatBonuses = Instance.CurrentOrigin.StatBonuses,
                SelectedChoice = Instance.CurrentOrigin.SelectedChoice,
                Item = Instance.CurrentOrigin.Item,
                Example = new List<string>(Instance.CurrentOrigin.Example)
            };

            //update the previous origin
            //Instance.PreviousOrigin = Instance.
            Instance.EXP += int.Parse(OriginTabExpBox.Text);

            UpdateCharacterPanel();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void OriginBoostChoiceDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this will be the event that changes the skill that the player gets to choose from the origin.

        }

        private void RandomOriginButton_Click(object sender, EventArgs e)
        {
            //select a random origin!
            var random = new Random();
            int originIndex = random.Next(0, StatsSingleton.Instance.AllOrigins.Origins.Count);
            OriginTabOriginDropdown.SelectedIndex = originIndex;
        }

        private void RandomFactionButton_Click(object sender, EventArgs e)
        {
            if (StatsSingleton.Instance.CurrentOrigin.Name == "None")
            {
                return;
            }

            //there is a fuckin chart for each origin
            int d100 = RNGesusD100();
            int factionIndex = 0;

            switch (Instance.CurrentOrigin.Name) //this is a sin.
            {
                case "Agri World":
                    if (d100 <= 26)
                    {
                        factionIndex = 0;
                    }
                    else if (d100 <= 27)
                    {
                        factionIndex = 1;
                    }
                    else if (d100 <= 37)
                    {
                        factionIndex = 2;
                    }
                    else if (d100 <= 51)
                    {
                        factionIndex = 3;
                    }
                    else if (d100 <= 65)
                    {
                        factionIndex = 4;
                    }
                    else if (d100 <= 77)
                    {
                        factionIndex = 5;
                    }
                    else if (d100 <= 96)
                    {
                        factionIndex = 6;
                    }
                    else if (d100 <= 98)
                    {
                        factionIndex = 7;
                    }
                    else if (d100 <= 100)
                    {
                        factionIndex = 8;
                    }
                    break;
                case "Hive World":
                    if (d100 <= 26)
                    {
                        factionIndex = 0;
                    }
                    else if (d100 <= 27)
                    {
                        factionIndex = 1;
                    }
                    else if (d100 <= 29)
                    {
                        factionIndex = 2;
                    }
                    else if (d100 <= 45)
                    {
                        factionIndex = 3;
                    }
                    else if (d100 <= 79)
                    {
                        factionIndex = 4;
                    }
                    else if (d100 <= 83)
                    {
                        factionIndex = 5;
                    }
                    else if (d100 <= 96)
                    {
                        factionIndex = 6;
                    }
                    else if (d100 <= 98)
                    {
                        factionIndex = 7;
                    }
                    else if (d100 <= 100)
                    {
                        factionIndex = 8;
                    }
                    break;
                case "Forge World":
                    if (d100 <= 20)
                    {
                        factionIndex = 0;
                    }
                    else if (d100 <= 21)
                    {
                        factionIndex = 1;
                    }
                    else if (d100 <= 71)
                    {
                        factionIndex = 2;
                    }
                    else if (d100 <= 73)
                    {
                        factionIndex = 3;
                    }
                    else if (d100 <= 74)
                    {
                        factionIndex = 4;
                    }
                    else if (d100 <= 84)
                    {
                        factionIndex = 5;
                    }
                    else if (d100 <= 98)
                    {
                        factionIndex = 6;
                    }
                    else if (d100 <= 99)
                    {
                        factionIndex = 7;
                    }
                    else if (d100 <= 100)
                    {
                        factionIndex = 8;
                    }
                    break;
                case "Voidborn":
                    if (d100 <= 14)
                    {
                        factionIndex = 0;
                    }
                    else if (d100 <= 24)
                    {
                        factionIndex = 1;
                    }
                    else if (d100 <= 34)
                    {
                        factionIndex = 2;
                    }
                    else if (d100 <= 38)
                    {
                        factionIndex = 3;
                    }
                    else if (d100 <= 52)
                    {
                        factionIndex = 4;
                    }
                    else if (d100 <= 82)
                    {
                        factionIndex = 5;
                    }
                    else if (d100 <= 87)
                    {
                        factionIndex = 6;
                    }
                    else if (d100 <= 89)
                    {
                        factionIndex = 7;
                    }
                    else if (d100 <= 100)
                    {
                        factionIndex = 8;
                    }
                    break;
                case "Shrine World":
                    if (d100 <= 14)
                    {
                        factionIndex = 0;
                    }
                    else if (d100 <= 15)
                    {
                        factionIndex = 1;
                    }
                    else if (d100 <= 17)
                    {
                        factionIndex = 2;
                    }
                    else if (d100 <= 57)
                    {
                        factionIndex = 3;
                    }
                    else if (d100 <= 71)
                    {
                        factionIndex = 4;
                    }
                    else if (d100 <= 83)
                    {
                        factionIndex = 5;
                    }
                    else if (d100 <= 97)
                    {
                        factionIndex = 6;
                    }
                    else if (d100 <= 99)
                    {
                        factionIndex = 7;
                    }
                    else if (d100 <= 100)
                    {
                        factionIndex = 8;
                    }
                    break;
                case "Feral World":
                    if (d100 <= 14)
                    {
                        factionIndex = 0;
                    }
                    else if (d100 <= 15)
                    {
                        factionIndex = 1;
                    }
                    else if (d100 <= 17)
                    {
                        factionIndex = 2;
                    }
                    else if (d100 <= 30)
                    {
                        factionIndex = 3;
                    }
                    else if (d100 <= 82)
                    {
                        factionIndex = 4;
                    }
                    else if (d100 <= 92)
                    {
                        factionIndex = 5;
                    }
                    else if (d100 <= 97)
                    {
                        factionIndex = 6;
                    }
                    else if (d100 <= 99)
                    {
                        factionIndex = 7;
                    }
                    else if (d100 <= 100)
                    {
                        factionIndex = 8;
                    }
                    break;
                case "Schola Progenium":
                    if (d100 <= 20)
                    {
                        factionIndex = 0;
                    }
                    else if (d100 <= 21)
                    {
                        factionIndex = 1;
                    }
                    else if (d100 <= 23)
                    {
                        factionIndex = 2;
                    }
                    else if (d100 <= 45)
                    {
                        factionIndex = 3;
                    }
                    else if (d100 <= 67)
                    {
                        factionIndex = 4;
                    }
                    else if (d100 <= 74)
                    {
                        factionIndex = 5;
                    }
                    //6 is intentionally missing.
                    else if (d100 <= 94)
                    {
                        factionIndex = 7;
                    }
                    else if (d100 <= 100)
                    {
                        factionIndex = 8;
                    }
                    break;
            } //end switch
            FactionSelectionDropdown.SelectedIndex = factionIndex;
        }

        private static int RNGesusD100()
        {
            var rand = new Random();
            return rand.Next(1, 101);
        }

        private void FactionSelectionDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            //update the DutyChoiceDropdown with the duties of the selected faction.
            Instance.CurrentFaction = StatsSingleton.Instance.AllFactions.Factions.Find(x => x.Name == FactionSelectionDropdown.SelectedItem.ToString());
            DutyChoiceDropdown.Items.Clear();
            DutyChoiceDropdown.Items.Add("Custom Duty"); //every faction has a custom duty.
            foreach (Duty duty in Instance.CurrentFaction.Duties)
            {
                DutyChoiceDropdown.Items.Add(duty.Name);
            }
            DutyChoiceDropdown.SelectedIndex = 0; //populate the fields.
            FactionTabDefaultStatBonusBox.Text = Instance.CurrentFaction.DefaultStatBonus;
            FactionTabInfluenceBox.Text = Instance.CurrentFaction.Influence;
            if (Instance.CurrentFaction.Name == "Infractionist")
            {
                var rand = new Random();
                Instance.CurrentFaction.Solars = RNGesus5d10();
                FactionTabSolarsBox.Text = Instance.CurrentFaction.Solars.ToString();
            }


        }

        private int RNGesus5d10()
        {
            var rand = new Random();
            int total = 0;
            for (int i = 0; i < 5; i++)
            {
                total += rand.Next(1, 11);
            }
            return total;
        }

        private void DutyChoiceDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {


            Instance.CurrentDuty = Instance.CurrentFaction.Duties.Find(x => x.Name == DutyChoiceDropdown.SelectedItem.ToString());

            //wipe all of the dropdowns
            FactionTabSkillAdvDropdown0.Items.Clear();
            FactionTabSkillAdvDropdown0.Text = "";
            FactionTabSkillAdvDropdown1.Items.Clear();
            FactionTabSkillAdvDropdown1.Text = "";
            FactionTabSkillAdvDropdown2.Items.Clear();
            FactionTabSkillAdvDropdown2.Text = "";
            FactionTabSkillAdvDropdown3.Items.Clear();
            FactionTabSkillAdvDropdown3.Text = "";
            FactionTabSkillAdvDropdown4.Items.Clear();
            FactionTabSkillAdvDropdown4.Text = "";
            FactionPageTalentDropdown.Items.Clear();
            FactionPageTalentDropdown.Text = "";
            FactionPageItemDropdown0.Items.Clear();
            FactionPageItemDropdown0.Text = "";
            FactionPageItemDropdown1.Items.Clear();
            FactionPageItemDropdown1.Text = "";
            FactionPageItemDropdown2.Items.Clear();
            FactionPageItemDropdown2.Text = "";
            FactionTabAugmeticsDropdown0.Items.Clear();
            FactionTabAugmeticsDropdown0.Text = "";
            FactionTabAugmeticsDropdown1.Items.Clear();
            FactionTabAugmeticsDropdown1.Text = "";
            FactionTabStatDropdown.Items.Clear();
            FactionTabStatDropdown.Text = "";
            FactionPageTalentDropdown.Items.Clear();
            FactionPageTalentDropdown.Text = "";

            //wipe all boxes
            SecondTalentBonusBox.Text = "";
            FactionPageItemBox0.Text = "";
            FactionPageItemBox1.Text = "";
            FactionPageItemBox2.Text = "";
            FactionPageItemBox3.Text = "";
            DutyDescriptionBox.Text = "";
            FactionTabSolarsBox.Text = "0";

            //make temproary lists for the dropdowns for easy iteration
            List<ComboBox> skillDropdowns = new List<ComboBox> { FactionTabSkillAdvDropdown0, FactionTabSkillAdvDropdown1, FactionTabSkillAdvDropdown2, FactionTabSkillAdvDropdown3, FactionTabSkillAdvDropdown4 };
            List<ComboBox> ItemDropdowns = new List<ComboBox> { FactionPageItemDropdown0, FactionPageItemDropdown1, FactionPageItemDropdown2 };
            List<ComboBox> AugmeticDropdowns = new List<ComboBox> { FactionTabAugmeticsDropdown0, FactionTabAugmeticsDropdown1 };

            List<Label> ItemBoxes = new List<Label> { FactionPageItemBox0, FactionPageItemBox1, FactionPageItemBox2, FactionPageItemBox3 };




            if (DutyChoiceDropdown.SelectedItem.ToString() == "Custom Duty")
            {
                //there are so many custom things my god
                //custom duties let the player choose from skills. they can do as many as they want.
                foreach (string skill in Instance.CurrentFaction.DefaultAdvances)
                {
                    FactionTabSkillAdvDropdown0.Items.Add(skill);
                    FactionTabSkillAdvDropdown1.Items.Add(skill);
                    FactionTabSkillAdvDropdown2.Items.Add(skill);
                    FactionTabSkillAdvDropdown3.Items.Add(skill);
                    FactionTabSkillAdvDropdown4.Items.Add(skill);

                }
                FactionTabSkillAdvDropdown0.Text = Instance.CurrentFaction.DefaultAdvances[0];
                FactionTabSkillAdvDropdown1.Text = Instance.CurrentFaction.DefaultAdvances[1];
                FactionTabSkillAdvDropdown2.Text = Instance.CurrentFaction.DefaultAdvances[2];
                FactionTabSkillAdvDropdown3.Text = Instance.CurrentFaction.DefaultAdvances[3];
                FactionTabSkillAdvDropdown4.Text = Instance.CurrentFaction.DefaultAdvances[4];

                foreach (string talent in Instance.CurrentFaction.DefaultTalents)
                {
                    FactionPageTalentDropdown.Items.Add(talent);
                    FactionPageTalentDropdown.Text = Instance.CurrentFaction.DefaultTalents[0];
                }
                
                for (int i = 0; i < Instance.CurrentFaction.Equipment.Count; i++)
                {

                    ItemBoxes[i].Text = Instance.CurrentFaction.Equipment[i];

                }

                for (int i = 0; i < Instance.CurrentFaction.DefaultEquipmentChoice.Count; i++) //you get a choice sometimes
                {
                    List<string> itemChoices = Listify(Instance.CurrentFaction.DefaultEquipmentChoice[i]);
                    foreach (string item in itemChoices)
                    {
                        ItemDropdowns[i].Items.Add(item);
                    }
                    ItemDropdowns[i].Text = itemChoices[0];
                }
                foreach (string stat in Instance.CurrentFaction.DefaultStatBonusChoice)
                {
                    FactionTabStatDropdown.Items.Add(stat);
                    FactionTabStatDropdown.Text = Instance.CurrentFaction.DefaultStatBonusChoice[0];
                }
                
                for (int i = 0; i < Instance.CurrentFaction.DefaultAugmeticChoice.Count; i++)
                {
                    List<string> augmeticChoices = Listify(Instance.CurrentFaction.DefaultAugmeticChoice[i]);
                    foreach (string augmetic in augmeticChoices)
                    {
                        AugmeticDropdowns[i].Items.Add(augmetic);
                    }
                    AugmeticDropdowns[i].Text = augmeticChoices[0];

                }
                FactionTabSolarsBox.Text = (Instance.CurrentFaction.Solars + Instance.CurrentFaction.OptionalSolars).ToString();
                SecondTalentBonusBox.Text = Instance.CurrentFaction.Talent;
                //done!
            }
            else
            {
                //less player choice, but there is still some.
                DutyDescriptionBox.Text = Instance.CurrentDuty.Description;
                FactionTabStatDropdown.Items.Add(Instance.CurrentDuty.StatBonuses[0]);
                FactionTabStatDropdown.Text = Instance.CurrentDuty.StatBonuses[0];
                FactionTabDefaultStatBonusBox.Text = Instance.CurrentDuty.StatBonuses[1];
                FactionTabSolarsBox.Text = (Instance.CurrentDuty.Solars + Instance.CurrentFaction.Solars).ToString();

                for (int i = 0; i < Instance.CurrentDuty.Advances.Count; i++)
                {
                    skillDropdowns[i].Items.Add(Instance.CurrentDuty.Advances[i]);
                    skillDropdowns[i].Text = Instance.CurrentDuty.Advances[i];
                }

                for (int i = 0; i < Instance.CurrentDuty.Augmetics.Count; i++)
                {
                    AugmeticDropdowns[i].Items.Add(Instance.CurrentDuty.Augmetics[i]);
                    AugmeticDropdowns[i].Text = Instance.CurrentDuty.Augmetics[i];
                }
                if(Instance.CurrentDuty.Talents.Count == 1)
                {
                    FactionPageTalentDropdown.Items.Add(Instance.CurrentDuty.Talents[0]);
                    FactionPageTalentDropdown.Text = Instance.CurrentDuty.Talents[0];
                }
                else if (Instance.CurrentDuty.Talents.Count >= 2)
                {
                    FactionPageTalentDropdown.Items.Add(Instance.CurrentDuty.Talents[0]);
                    FactionPageTalentDropdown.Text = Instance.CurrentDuty.Talents[0];
                    SecondTalentBonusBox.Text = Instance.CurrentDuty.Talents[1];
                }
                else //0
                {
                    SecondTalentBonusBox.Text = Instance.CurrentFaction.Talent;
                }
                for (int i = 0; i < Instance.CurrentDuty.Equipment.Count; i++) //you get a choice sometimes
                {
                    List<string> itemChoices = Listify(Instance.CurrentDuty.Equipment[i]);
                    foreach (string item in itemChoices)
                    {
                        if (i == 3) //to avoid an out of bounds.
                        {
                            FactionPageItemBox0.Text = item; //imperial navy hits this.
                        }
                        else
                        {
                            ItemDropdowns[i].Items.Add(item);
                            ItemDropdowns[i].Text = itemChoices[0];
                        }
                    }
                    
                }
                for (int i = 0; i < Instance.CurrentFaction.Equipment.Count; i++)
                {

                    ItemBoxes[i].Text = Instance.CurrentFaction.Equipment[i];

                }

                //ES! TODO: Infractionists take more items than we have spots.
                //There is also another one that has defualt items it shouldnt in some duties.

            }

        }

        public List<string> Listify(string str)
        {
            List<string> list = new List<string>();
            string[] words = str.Split('|');
            foreach (string word in words)
            {
                list.Add(word);
            }
            return list;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void FactionPageTalentDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if we select Psyker, we add Sanctioned Psyker to the second talent box.
            if (FactionPageTalentDropdown.SelectedItem.ToString() == "Psyker")
            {
                SecondTalentBonusBox.Text = "Sanctioned Psyker";
            }
            //if we select Condemn the Witch, we get Mental Fortress for free.
            else if (FactionPageTalentDropdown.SelectedItem.ToString() == "Condemn the Witch")
            {
                SecondTalentBonusBox.Text = "Mental Fortress";
            }
            else
            {
                SecondTalentBonusBox.Text = "";
            }
        }

        private void FactionPageItemDropdown1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(FactionPageItemDropdown1.SelectedItem.ToString() == "Flak Vest")
            {
                FactionPageItemBox0.Text = "Mag Boots";
            }
        }
    }
}

/*
            foreach (Origin o in StatsSingleton.Instance.AllOrigins.Origins) //wordy but i dont wanna make an enumerator
            {
                TabPage tabPage = new TabPage();
                tabPage.Text = o.Name;
                OriginPageTabs.Controls.Add(tabPage);
            }
*/