using iDiablo.Units;
using System;
using System.Linq;
using System.Text;
using System.Media;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;


namespace iDiablo
{
    /// <summary>
    /// Логика взаимодействия для SinglePlayer.xaml
    /// </summary>
    public partial class SinglePlayer : Page
    {
        public SinglePlayer()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            //NavigationService.GoBack();
        }

        void ResetStats()
        {
            //if (Title.Content == "Warrior")
            //{

            //    App.Current.Resources["Strenght"] = StrenghLabel.Content;
            //    App.Current.Resources["Dexterity"] = DexterityLabel.Content;
            //    App.Current.Resources["Intelegence"] = IntelegenceLabel.Content;
            //    App.Current.Resources["Vitality"] = VitalityLabel.Content;
            //    App.Current.Resources["Health"] = HealtLabel.Content;
            //    App.Current.Resources["PhysycalDamage"] = PhysycalDamageLabel.Content;
            //    App.Current.Resources["MagicDamage"] = MagicDamageLabel.Content;
            //    App.Current.Resources["CritDamage"] = CritDamageLabel.Content;
            //    App.Current.Resources["Mana"] = ManaLabel.Content;
            //    App.Current.Resources["Armor"] = ArmorLabel.Content;
            //    App.Current.Resources["MagicDefence"] = MagicDefenceLabel.Content;
            //    App.Current.Resources["CritChance"] = CritChanceLabel.Content;
            //}
            //else if (Title.Content == "Rogue")
            //{

            //    App.Current.Resources["Strenght"] = StrenghLabel.Content;
            //    App.Current.Resources["Dexterity"] = DexterityLabel.Content;
            //    App.Current.Resources["Intelegence"] = IntelegenceLabel.Content;
            //    App.Current.Resources["Vitality"] = VitalityLabel.Content;
            //    App.Current.Resources["Health"] = HealtLabel.Content;
            //    App.Current.Resources["PhysycalDamage"] = PhysycalDamageLabel.Content;
            //    App.Current.Resources["MagicDamage"] = MagicDamageLabel.Content;
            //    App.Current.Resources["CritDamage"] = CritDamageLabel.Content;
            //    App.Current.Resources["Mana"] = ManaLabel.Content;
            //    App.Current.Resources["Armor"] = ArmorLabel.Content;
            //    App.Current.Resources["MagicDefence"] = MagicDefenceLabel.Content;
            //    App.Current.Resources["CritChance"] = CritChanceLabel.Content;
            //}
            //else if (Title.Content == "Wizard")
            //{
            App.Current.Resources["Strenght"] = Wizard.Strenght;
            App.Current.Resources["Dexterity"] = Wizard.Dexterity;
            App.Current.Resources["Intelegence"] = Wizard.Inteligence;
            App.Current.Resources["Vitality"] = Wizard.Vitality;
            App.Current.Resources["Health"] = Wizard.Health;
            App.Current.Resources["PhysycalDamage"] = Wizard.PhysycalDamage;
            App.Current.Resources["MagicDamage"] = Wizard.MagicDefence;
            App.Current.Resources["CritDamage"] = Wizard.CritDamage;
            App.Current.Resources["Mana"] = Wizard.Mana;
            App.Current.Resources["Armor"] = Wizard.Armor;
            App.Current.Resources["MagicDefence"] = Wizard.MagicDefence;
            App.Current.Resources["CritChance"] = Wizard.CritChance;
            ////}

        }
        private void DoubleAnimation_Completed_Back(object sender, EventArgs e)
        {
            App.Current.Resources["HeroStats"] = "WizardKeep";
            ResetStats();
            NavigationService.GoBack();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            if (App.Current.Resources["HeroStats"] == "WizardKeep" || App.Current.Resources["HeroStats"] == "RogueKeep" || App.Current.Resources["HeroStats"] == "WarriorKeep")
            {
                LoadSave.Visibility = Visibility.Visible;
            }
            else
            {
                LoadSave.Visibility = Visibility.Hidden;
            }
            title.Content = App.Current.Resources["HeroClass"];
            if ((string)App.Current.Resources["HeroClass"] == "Warrior")
            {
                Uri uri = new Uri("/Images/Warrior.jpg", UriKind.Relative);
                ImageHero.Source = new BitmapImage(uri);
                Warrior.PhysycalDamage = Warrior.Strenght * 1; //Получаем значения
                Warrior.Armor = Warrior.Dexterity * 1;
                Warrior.MagicDamage = (int)(Warrior.Inteligence * 0.2);
                Warrior.MagicDefence = (int)(Warrior.Inteligence * 0.5);
                Warrior.CritChance = (int)(Warrior.Dexterity * 0.2);
                Warrior.CritDamage = (int)(Warrior.Dexterity * 0.1);
                Warrior.Mana = Warrior.Inteligence * 1;
                Warrior.Health = Warrior.Vitality * 2 + Warrior.Strenght * 1;
                HealtLabel.Content = Warrior.Strenght; //Заполняем лейблы
                ManaLabel.Content = Warrior.Mana;
                StrenghLabel.Content = Warrior.Strenght + "/" + 250;
                DexterityLabel.Content = Warrior.Dexterity + "/" + 80;
                IntelegenceLabel.Content = Warrior.Inteligence + "/" + 50;
                VitalityLabel.Content = Warrior.Vitality + "/" + 100;
                PhysycalDamageLabel.Content = Warrior.PhysycalDamage;
                ArmorLabel.Content = Warrior.Armor;
                MagicDefenceLabel.Content = Warrior.MagicDefence;
                MagicDamageLabel.Content = Warrior.MagicDamage;
                CritChanceLabel.Content = Warrior.CritChance;
                CritDamageLabel.Content = Warrior.CritDamage;
            }
            else if ((string)App.Current.Resources["HeroClass"] == "Rogue")
            {
                Uri uri = new Uri("/Images/Rogue.jpg", UriKind.Relative);
                ImageHero.Source = new BitmapImage(uri);
                Rogue.PhysycalDamage = (int)(Rogue.Strenght * 0.5);
                Rogue.Armor = (int)(Rogue.Dexterity * 1.5);
                Rogue.MagicDamage = (int)(Rogue.Inteligence * 0.2);
                Rogue.MagicDefence = (int)(Rogue.Inteligence * 0.5);
                Rogue.CritChance = (int)(Rogue.Dexterity * 0.2);
                Rogue.CritDamage = (int)(Rogue.Dexterity * 0.1);
                Rogue.Mana = Rogue.Inteligence * 1;
                Rogue.Health = Rogue.Vitality * 2;
                StrenghLabel.Content = Rogue.Strenght + "/" + 65;
                DexterityLabel.Content = Rogue.Dexterity + "/" + 250;
                IntelegenceLabel.Content = Rogue.Inteligence + "/" + 70;
                VitalityLabel.Content = Rogue.Vitality + "/" + 80;
                HealtLabel.Content = Rogue.Vitality * 1.4;
                ManaLabel.Content = Rogue.Inteligence * 1.5;
                PhysycalDamageLabel.Content = Rogue.PhysycalDamage;
                ArmorLabel.Content = Rogue.Armor;
                MagicDefenceLabel.Content = Rogue.MagicDefence;
                MagicDefenceLabel.Content = Rogue.MagicDamage;
                CritChanceLabel.Content = Rogue.CritChance;
                CritDamageLabel.Content = Rogue.CritDamage;
            }
            else if ((string)App.Current.Resources["HeroClass"] == "Wizard")
            {
                Uri uri = new Uri("/Images/Wizard.jpg", UriKind.Relative);
                ImageHero.Source = new BitmapImage(uri);
                Wizard.PhysycalDamage = (int)(Wizard.Strenght * 0.5);
                Wizard.Armor = Wizard.Dexterity * 1;
                Wizard.MagicDamage = Wizard.Inteligence * 1;
                Wizard.MagicDefence = Wizard.Inteligence * 1;
                Wizard.CritChance = (int)(Wizard.Dexterity * 0.2);
                Wizard.CritDamage = (int)(Wizard.Dexterity * 0.1);
                Wizard.Mana = Wizard.Inteligence * 1;
                Wizard.Health = Wizard.Vitality * 2;
                StrenghLabel.Content = Wizard.Strenght + "/" + 45;
                DexterityLabel.Content = Wizard.Dexterity + "/" + 80;
                IntelegenceLabel.Content = Wizard.Inteligence + "/" + 250;
                VitalityLabel.Content = Wizard.Vitality + "/" + 70;
                HealtLabel.Content = Wizard.Vitality * 1.5;
                ManaLabel.Content = Wizard.Inteligence * 1.2;
                PhysycalDamageLabel.Content = Wizard.PhysycalDamage;
                ArmorLabel.Content = Wizard.Armor;
                MagicDefenceLabel.Content = Wizard.MagicDefence;
                MagicDamageLabel.Content = Wizard.MagicDamage;
                CritChanceLabel.Content = Wizard.CritChance;
                CritDamageLabel.Content = Wizard.CritDamage;
            }
        }

        Warrior Warrior = new Warrior();
        Rogue Rogue = new Rogue();
        Wizard Wizard = new Wizard();
        int lvl = 1;

        private void StrenghtPlus_Click(object sender, RoutedEventArgs e)
        {
            if (StatPoints.Text != "0")
            {
                lvl++;
                LevelLabel.Content = lvl;
                if ((string)title.Content == Warrior.Name)
                {
                    if (Warrior.Strenght != 250)
                    {
                        int Points = Convert.ToInt32(StatPoints.Text);
                        Points--;
                        StatPoints.Text = Convert.ToString(Points);
                        Warrior.Strenght++;
                        StrenghLabel.Content = Math.Round((double)Warrior.Strenght, 1) + "/250";
                        HealtLabel.Content = Math.Round((double)Warrior.Strenght * 1, 1);
                        PhysycalDamageLabel.Content = Math.Round((double)Warrior.Strenght * 1, 1);
                    }
                    else MessageBox.Show("You have max Strenght!");

                }
                else if ((string)title.Content == Rogue.Name)
                {
                    if (Rogue.Strenght != 65)
                    {
                        int Points = Convert.ToInt32(StatPoints.Text);
                        Points--;
                        StatPoints.Text = Convert.ToString(Points);
                        Rogue.Strenght++;
                        StrenghLabel.Content = Math.Round((double)Rogue.Strenght, 1) + "/65";
                        HealtLabel.Content = Math.Round((double)Rogue.Strenght * 0.5, 1);
                        PhysycalDamageLabel.Content = Math.Round((double)Rogue.Strenght * 0.5, 1);
                    }
                    else MessageBox.Show("You have max Strenght!");
                }
                else if ((string)title.Content == Wizard.Name)
                {
                    if (Wizard.Strenght != 45)
                    {
                        int Points = Convert.ToInt32(StatPoints.Text);
                        Points--;
                        StatPoints.Text = Convert.ToString(Points);
                        Wizard.Strenght++;
                        //СДЕЛАТЬ ТАК ВЕЗДЕ Wizard.Strenght = Math.Round((double)Wizard.Strenght, 1); StrenghLabel.Content = Wizard.Strenght + "/45";
                        Wizard.Health = Math.Round((double)Wizard.Strenght * 0.2, 1);
                        Wizard.PhysycalDamage = Math.Round((double)Wizard.Strenght * 0.5, 1);
                        StrenghLabel.Content = Wizard.Strenght + "/45";
                        HealtLabel.Content = Wizard.Health;
                        PhysycalDamageLabel.Content = Wizard.PhysycalDamage;
                    }
                    else MessageBox.Show("You have max Strenght!");
                }
            }
            else { MessageBox.Show("You don't have any stat point!"); }
            ResetStats();
        }

        private void DexterityPlus_Click(object sender, RoutedEventArgs e)
        {
            if (StatPoints.Text != "0")
            {
                lvl++;
                LevelLabel.Content = lvl;
                if ((string)title.Content == Warrior.Name)
                {
                    if (Warrior.Dexterity != 80)
                    {
                        int Points = Convert.ToInt32(StatPoints.Text);
                        Points--;
                        StatPoints.Text = Convert.ToString(Points);
                        Warrior.Dexterity++;
                        DexterityLabel.Content = Math.Round((double)Warrior.Dexterity, 1) + "/80";
                        ArmorLabel.Content = Math.Round((double)Warrior.Dexterity * 1, 1);
                        CritChanceLabel.Content = Math.Round((double)Warrior.Dexterity * 0.2, 1);
                        CritDamageLabel.Content = Math.Round((double)Warrior.Dexterity * 0.1, 1);
                    }
                    else MessageBox.Show("You have max Dexterity!");

                }
                else if ((string)title.Content == Rogue.Name)
                {
                    if (Rogue.Dexterity != 250)
                    {
                        int Points = Convert.ToInt32(StatPoints.Text);
                        Points--;
                        StatPoints.Text = Convert.ToString(Points);
                        Rogue.Dexterity++;
                        DexterityLabel.Content = Math.Round((double)Rogue.Dexterity, 1) + "/250";
                        ArmorLabel.Content = Math.Round((double)Rogue.Dexterity * 1.5, 1);
                        CritChanceLabel.Content = Math.Round((double)Rogue.Dexterity * 0.2, 1);
                        CritDamageLabel.Content = Math.Round((double)Rogue.Dexterity * 0.1, 1);
                    }
                    else MessageBox.Show("You have max Dexterity!");
                }
                else if ((string)title.Content == Wizard.Name)
                {
                    if (Wizard.Dexterity != 80)
                    {
                        int Points = Convert.ToInt32(StatPoints.Text);
                        Points--;
                        StatPoints.Text = Convert.ToString(Points);
                        Wizard.Dexterity++;
                        DexterityLabel.Content = Math.Round((double)Wizard.Dexterity, 1) + "/80";
                        ArmorLabel.Content = Math.Round((double)Wizard.Dexterity * 1, 1);
                        CritChanceLabel.Content = Math.Round(Wizard.Dexterity * 0.2, 1);
                        CritDamageLabel.Content = Math.Round(Wizard.Dexterity * 0.1, 1);
                    }
                    else MessageBox.Show("You have max Dexterity!");
                }
            }
            else { MessageBox.Show("You don't have any stat point!"); }
            ResetStats();
        }

        private void IntelegencePlus_Click(object sender, RoutedEventArgs e)
        {
            if (StatPoints.Text != "0")
            {
                lvl++;
                LevelLabel.Content = lvl;
                if ((string)title.Content == Warrior.Name)
                {
                    if (Warrior.Inteligence != 50)
                    {
                        int Points = Convert.ToInt32(StatPoints.Text);
                        Points--;
                        StatPoints.Text = Convert.ToString(Points);
                        Warrior.Inteligence++;
                        IntelegenceLabel.Content = Math.Round((double)Warrior.Inteligence, 1) + "/50";
                        ManaLabel.Content = Math.Round((double)Warrior.Inteligence * 1, 1);
                        MagicDamageLabel.Content = Math.Round((double)Warrior.Inteligence * 0.2, 1);
                        MagicDefenceLabel.Content = Math.Round((double)Warrior.Inteligence * 0.5, 1);
                    }
                    else MessageBox.Show("You have max Inteligence!");
                }
                else if ((string)title.Content == Rogue.Name)
                {
                    if (Rogue.Inteligence != 70)
                    {
                        int Points = Convert.ToInt32(StatPoints.Text);
                        Points--;
                        StatPoints.Text = Convert.ToString(Points);
                        Rogue.Inteligence++;
                        IntelegenceLabel.Content = Math.Round((double)Rogue.Inteligence, 1) + "/70";
                        ManaLabel.Content = Math.Round((double)Rogue.Inteligence * 1.2, 1);
                        MagicDamageLabel.Content = Math.Round((double)Rogue.Inteligence * 0.2, 1);
                        MagicDefenceLabel.Content = Math.Round((double)Rogue.Inteligence * 0.5, 1);
                    }
                    else MessageBox.Show("You have max Inteligence!");
                }
                else if ((string)title.Content == Wizard.Name)
                {
                    if (Rogue.Inteligence != 250)
                    {
                        int Points = Convert.ToInt32(StatPoints.Text);
                        Points--;
                        StatPoints.Text = Convert.ToString(Points);
                        Wizard.Inteligence++;
                        IntelegenceLabel.Content = Math.Round((double)Wizard.Inteligence, 1) + "/250";
                        ManaLabel.Content = Math.Round((double)Wizard.Inteligence * 1.5, 1);
                        MagicDamageLabel.Content = Math.Round((double)Wizard.Inteligence * 1, 1);
                        MagicDefenceLabel.Content = Math.Round((double)Wizard.Inteligence * 1, 1);
                    }
                }
                else MessageBox.Show("You have max Inteligence!");
            }
            else { MessageBox.Show("You don't have any stat point!"); }
            ResetStats();
        }
        private void VitalityPlus_Click(object sender, RoutedEventArgs e)
        {
            if (StatPoints.Text != "0")
            {
                lvl++;
                LevelLabel.Content = lvl;
                if ((string)title.Content == Warrior.Name)
                {
                    if (Warrior.Vitality != 100)
                    {
                        int Points = Convert.ToInt32(StatPoints.Text);
                        Points--;
                        StatPoints.Text = Convert.ToString(Points);
                        Warrior.Vitality++;
                        VitalityLabel.Content = Math.Round((double)Warrior.Vitality, 1) + "/100";
                        HealtLabel.Content = Math.Round((double)Warrior.Vitality * 2, 1);
                    }
                    else MessageBox.Show("You have max Inteligence!");
                }
                else if ((string)title.Content == Rogue.Name)
                {
                    if (Rogue.Vitality != 80)
                    {
                        int Points = Convert.ToInt32(StatPoints.Text);
                        Points--;
                        StatPoints.Text = Convert.ToString(Points);
                        Rogue.Vitality++;
                        VitalityLabel.Content = Math.Round((double)Rogue.Vitality, 1) + "/80";
                        HealtLabel.Content = Math.Round((double)Rogue.Vitality * 1.5, 1);
                    }
                    else MessageBox.Show("You have max Inteligence!");
                }
                else if ((string)title.Content == Wizard.Name)
                {
                    if (Wizard.Vitality != 70)
                    {
                        int Points = Convert.ToInt32(StatPoints.Text);
                        Points--;
                        StatPoints.Text = Convert.ToString(Points);
                        Wizard.Vitality++;
                        VitalityLabel.Content = Math.Round((double)Wizard.Vitality, 1) + "/70";
                        HealtLabel.Content = Math.Round(Wizard.Vitality * 1.4, 1);
                    }
                }
                else MessageBox.Show("You have max Inteligence!");
            }
            else { MessageBox.Show("You don't have any stat point!"); }
            ResetStats();
        }

        private void StatPoints_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (StatPoints.Text == "0" || StatPoints.Text == null)
            {
                StrenghtPlus.Visibility = Visibility.Hidden;
                DexterityPlus.Visibility = Visibility.Hidden;
                IntelegencePlus.Visibility = Visibility.Hidden;
                VitalityPlus.Visibility = Visibility.Hidden;
            }
            else
            {
                StrenghtPlus.Visibility = Visibility.Visible;
                DexterityPlus.Visibility = Visibility.Visible;
                IntelegencePlus.Visibility = Visibility.Visible;
                VitalityPlus.Visibility = Visibility.Visible;

            }
        }

        private void Inventory_Click(object sender, RoutedEventArgs e)
        {
            //ResetStats();
            //NavigationService.Navigate(new InventoryPage());
        }

        private void LoadSave_Click(object sender, RoutedEventArgs e)
        {
            //if (App.Current.Resources["HeroStats"] == "WizardKeep")
            //{
            //    Wizard.Strenght = Convert.ToInt32(App.Current.Resources["Strenght"]);//Получение данных
            //    Wizard.Dexterity = Convert.ToInt32(App.Current.Resources["Dexterity"]);
            //    Wizard.Inteligence = Convert.ToInt32(App.Current.Resources["Intelegence"]);
            //    Wizard.Vitality = Convert.ToInt32(App.Current.Resources["Vitality"]);
            //    Wizard.Health = Convert.ToInt32(App.Current.Resources["Health"]);
            //    Wizard.PhysycalDamage = Convert.ToInt32(App.Current.Resources["PhysycalDamage"]);
            //    Wizard.MagicDamage = Convert.ToInt32(App.Current.Resources["MagicDamage"]);
            //    Wizard.CritDamage = Convert.ToInt32(App.Current.Resources["CritDamage"]);
            //    Wizard.Mana = Convert.ToInt32(App.Current.Resources["Mana"]);
            //    Wizard.Armor = Convert.ToInt32(App.Current.Resources["Armor"]);
            //    Wizard.MagicDefence = Convert.ToInt32(App.Current.Resources["MagicDefence"]);
            //    Wizard.CritChance = Convert.ToInt32(App.Current.Resources["CritChance"]);
            //    StrenghLabel.Content = Wizard.Strenght + "/" + 45;
            //    DexterityLabel.Content = Wizard.Dexterity + "/" + 80;
            //    IntelegenceLabel.Content = Wizard.Inteligence + "/" + 250;
            //    VitalityLabel.Content = Wizard.Vitality + "/" + 70;
            //    HealtLabel.Content = Wizard.Vitality * 1.5;
            //    ManaLabel.Content = Wizard.Inteligence * 1.2;
            //    PhysycalDamageLabel.Content = Wizard.PhysycalDamage;
            //    ArmorLabel.Content = Wizard.Armor;
            //    MagicDefenceLabel.Content = Wizard.MagicDefence;
            //    MagicDamageLabel.Content = Wizard.MagicDamage;
            //    CritChanceLabel.Content = Wizard.CritChance;
            //    CritDamageLabel.Content = Wizard.CritDamage;
            //}
        }
    }
}
