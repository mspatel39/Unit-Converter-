using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unit_Converter
{
    public partial class unitConverter : Form
    {
        public unitConverter()
        {
            InitializeComponent();
        }

        private void convertLength()
         {
             if (fromComboBox.SelectedIndex == toComboBox.SelectedIndex)
             {
                 MessageBox.Show("Please select a valid unit for conversion");
             }
             else if (fromComboBox.SelectedIndex == 0 && toComboBox.SelectedIndex == 1)
             {
                 toTextBox.Text = Convert.ToString(Convert.ToDouble(fromTextBox.Text) / 1000);
             }
             else if (fromComboBox.SelectedIndex == 0 && toComboBox.SelectedIndex == 2)
             {
                 toTextBox.Text = Convert.ToString(Convert.ToDouble(fromTextBox.Text) * 100);
             }
             else if (fromComboBox.SelectedIndex == 1 && toComboBox.SelectedIndex == 0)
             {
                 toTextBox.Text = Convert.ToString(Convert.ToDouble(fromTextBox.Text) * 1000);
             }
             else if (fromComboBox.SelectedIndex == 1 && toComboBox.SelectedIndex == 2)
             {
                 toTextBox.Text = Convert.ToString(Convert.ToDouble(fromTextBox.Text) * 100000);
             }
             else if (fromComboBox.SelectedIndex == 2 && toComboBox.SelectedIndex == 0)
             {
                 toTextBox.Text = Convert.ToString(Convert.ToDouble(fromTextBox.Text) / 100);
             }
             else if (fromComboBox.SelectedIndex == 2 && toComboBox.SelectedIndex == 1)
             {
                 toTextBox.Text = Convert.ToString(Convert.ToDouble(fromTextBox.Text) / 100000);
             }
         }
        private void convertTemperature()
        {
            if (fromComboBox.SelectedIndex == toComboBox.SelectedIndex)
            {
                MessageBox.Show("Please select a valid unit for conversion");
            }
            else if ((fromComboBox.SelectedIndex == 1) && (toComboBox.SelectedIndex == 0))
            {
                double result = Convert.ToDouble(fromTextBox.Text);
                toTextBox.Text = Convert.ToString((result - 32) / 1.8);
            }
            else if ((fromComboBox.SelectedIndex == 0) && (toComboBox.SelectedIndex == 1))
            {
                double result = Convert.ToDouble(fromTextBox.Text);
                toTextBox.Text = Convert.ToString((result * 1.8) + 32);
            }
            else if ((fromComboBox.SelectedIndex == 2) && (toComboBox.SelectedIndex == 0))
            {
                double result = Convert.ToDouble(fromTextBox.Text);
                toTextBox.Text = Convert.ToString(result - 273.15);
            }
            else if ((fromComboBox.SelectedIndex == 0) && (toComboBox.SelectedIndex == 2))
            {
                double result = Convert.ToDouble(fromTextBox.Text);
                toTextBox.Text = Convert.ToString(result + 273.15);
            }
            else if ((fromComboBox.SelectedIndex == 2) && (toComboBox.SelectedIndex == 1))
            {
                double result = Convert.ToDouble(fromTextBox.Text);
                toTextBox.Text = Convert.ToString((result - 273.15) * 9/5 + 32);
            }

            else if ((fromComboBox.SelectedIndex == 1) && (toComboBox.SelectedIndex == 2))
            {
                double result = Convert.ToDouble(fromTextBox.Text);
                toTextBox.Text = Convert.ToString((result - 32) * 5 / 9 + 273.15);
            }
        }
        private void convertWeight()
        {
            if (fromComboBox.SelectedIndex == toComboBox.SelectedIndex)
            {
                MessageBox.Show("Please select a valid unit for conversion");
            }
            else if ((fromComboBox.SelectedIndex == 1) && (toComboBox.SelectedIndex == 0))
            {
                double result = Convert.ToDouble(fromTextBox.Text);
                toTextBox.Text = Convert.ToString(result * 1000);
            }
            if ((fromComboBox.SelectedIndex == 0) && (toComboBox.SelectedIndex == 1))
            {
                double result = Convert.ToDouble(fromTextBox.Text);
                toTextBox.Text = Convert.ToString(result / 1000);
            }
            else if ((fromComboBox.SelectedIndex == 2) && (toComboBox.SelectedIndex == 0))
            {
                double result = Convert.ToDouble(fromTextBox.Text);
                toTextBox.Text = Convert.ToString(result * 453.59);
            }
            else if ((fromComboBox.SelectedIndex == 0) && (toComboBox.SelectedIndex == 2))
            {
                double result = Convert.ToDouble(fromTextBox.Text);
                toTextBox.Text = Convert.ToString(result / 453.59);
            }
            else if ((fromComboBox.SelectedIndex == 2) && (toComboBox.SelectedIndex == 1))
            {
                double result = Convert.ToDouble(fromTextBox.Text);
                toTextBox.Text = Convert.ToString(result / 2.205);
            }

            else if ((fromComboBox.SelectedIndex == 1) && (toComboBox.SelectedIndex == 2))
            {
                double result = Convert.ToDouble(fromTextBox.Text);
                toTextBox.Text = Convert.ToString(result * 2.205);
            }
        }
        private void convertAngle()
        {
            if (fromComboBox.SelectedIndex == toComboBox.SelectedIndex)
            {
                MessageBox.Show("Please select a valid unit for conversion");
            }
            else if ((fromComboBox.SelectedIndex == 1) && (toComboBox.SelectedIndex == 0))
            {
                double result = Convert.ToDouble(fromTextBox.Text);
                toTextBox.Text = Convert.ToString(result * 3.14 /180);
            }
            if ((fromComboBox.SelectedIndex == 0) && (toComboBox.SelectedIndex == 1))
            {
                double result = Convert.ToDouble(fromTextBox.Text);
                toTextBox.Text = Convert.ToString(result * 180 / 3.14);
            }
            else if ((fromComboBox.SelectedIndex == 2) && (toComboBox.SelectedIndex == 0))
            {
                double result = Convert.ToDouble(fromTextBox.Text);
                toTextBox.Text = Convert.ToString(result * 3.14 / 200);
            }
            else if ((fromComboBox.SelectedIndex == 0) && (toComboBox.SelectedIndex == 2))
            {
                double result = Convert.ToDouble(fromTextBox.Text);
                toTextBox.Text = Convert.ToString(result * 200 / 3.14);
            }
            else if ((fromComboBox.SelectedIndex == 2) && (toComboBox.SelectedIndex == 1))
            {
                double result = Convert.ToDouble(fromTextBox.Text);
                toTextBox.Text = Convert.ToString(result * 0.9);
            }

            else if ((fromComboBox.SelectedIndex == 1) && (toComboBox.SelectedIndex == 2))
            {
                double result = Convert.ToDouble(fromTextBox.Text);
                toTextBox.Text = Convert.ToString(result * 1.111);
            }
        }

        private void Length_Checked(object sender, EventArgs e)
        {
            fromComboBox.Items.Clear();
            fromComboBox.Items.Add("Meter");
            fromComboBox.Items.Add("Kilometer");
            fromComboBox.Items.Add("Centimeter");
            toComboBox.Items.Clear();
            toComboBox.Items.Add("Meter");
            toComboBox.Items.Add("Kilometer");
            toComboBox.Items.Add("Centimeter");
        }
        private void Weight_Checked(object sender, EventArgs e)
        {
            fromComboBox.Items.Clear();
            fromComboBox.Items.Add("Gram");
            fromComboBox.Items.Add("Kilogram");
            fromComboBox.Items.Add("Pound");
            toComboBox.Items.Clear();
            toComboBox.Items.Add("Gram");
            toComboBox.Items.Add("Kilogram");
            toComboBox.Items.Add("Pound");
        }

        private void angle_CheckedChanged(object sender, EventArgs e)
        {
            fromComboBox.Items.Clear();
            fromComboBox.Items.Add("Radian");
            fromComboBox.Items.Add("Degree");
            fromComboBox.Items.Add("Gradian");
            toComboBox.Items.Clear();
            toComboBox.Items.Add("Radian");
            toComboBox.Items.Add("Degree");
            toComboBox.Items.Add("Gradian");
        }
        private void temperature_CheckedChanged(object sender, EventArgs e)
        {
            fromComboBox.Items.Clear();
            fromComboBox.Items.Add("Celsius");
            fromComboBox.Items.Add("Fehrenheit");
            fromComboBox.Items.Add("Kelvin");
            toComboBox.Items.Clear();
            toComboBox.Items.Add("Celsius");
            toComboBox.Items.Add("Fehrenheit");
            toComboBox.Items.Add("Kelvin");
        }
        private void unitConverter_Load(object sender, EventArgs e)
        {
            this.fromComboBox.Text = "--Select Unit--";
            this.toComboBox.Text = "--Select Unit--";
        }

        private void fromComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toComboBox_ItemSelected(object sender, EventArgs e)
        {
            try
            {
                if (temperature.Checked == true)
                {
                    convertTemperature();
                }
                else if (weight.Checked == true)
                {
                    convertWeight();
                }
                else if (length.Checked == true)
                {
                    convertLength();
                }
                else if (angle.Checked == true)
                {
                    convertAngle();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
