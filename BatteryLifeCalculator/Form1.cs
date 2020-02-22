using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BatteryLifeCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            //Jameson Sullivan
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //setting up ComboBoxes, lables
            CBBCUnit.SelectedIndex = 1;
            CBCUnit.SelectedIndex = 1;
            CBChangeLaw.SelectedIndex = 0;
            NUDBatteryCap.Controls[0].Enabled = false;
            LBLUserCheckCap.Text = "Battery Capacity: NA";
            LBLUserCheckCurrent.Text = "Current: NA";
            LBLSeconds.Text = "Seconds: NA";
            LBLMinutes.Text = "Minutes: NA";
            LBLHours.Text = "Hours: NA";
            LBLDays.Text = "Days: NA";
            LBLMonths.Text = "Months: NA";
            LBLYears.Text = "Years: NA";
            GBBLC.Left = (this.ClientSize.Width - GBBLC.Width) / 2;
            BTNOLSubmit.Left = (GBOhmsLaw.Width - BTNOLSubmit.Width) / 2;
            BTNSubmit.Left = (GBBLC.Width - BTNSubmit.Width) / 2;
            GBOhmsLaw.Left = (this.ClientSize.Width - GBOhmsLaw.Width) / 2;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //initializing variables
            double batteryCapacity = 0;
            double current = 0;
            double seconds = 0;
            double minutes = 0;
            double hours = 0;
            double days = 0;
            double months = 0;
            double years = 0;
            
            //getting battery capacity based on what combobox index was selected and converting to milliamps
            if(CBBCUnit.SelectedIndex == 0)
            {
                batteryCapacity = double.Parse(NUDBatteryCap.Value.ToString()) * 1000;
            }
            if (CBBCUnit.SelectedIndex == 1)
            {
                batteryCapacity = double.Parse(NUDBatteryCap.Value.ToString());
            }
            if(CBBCUnit.SelectedIndex == 2)
            {
                batteryCapacity = double.Parse(NUDBatteryCap.Value.ToString()) / 1000;
            }

            //getting current draw from battery based on what combobox index was selected and converting to milliamps
            if (CBCUnit.SelectedIndex == 0)
            {
                current = double.Parse(NUDCurrent.Value.ToString()) * 1000;
            }
            if (CBCUnit.SelectedIndex == 1)
            {
                current = double.Parse(NUDCurrent.Value.ToString());
            }
            if (CBCUnit.SelectedIndex == 2)
            {
                current = double.Parse(NUDCurrent.Value.ToString()) / 1000;
            }

            //displaying users inputs
            LBLUserCheckCap.Text = "Battery Capacity: " + batteryCapacity.ToString() + " mA";
            LBLUserCheckCurrent.Text = "Current: " + current.ToString() + " mA";

            //doing math
            hours = (batteryCapacity / current) * 0.85;
            minutes = hours * 60;
            seconds = minutes * 60;
            days = hours / 24;
            months = days / 30;
            years = months / 12;

            //calling to update the lables 
            updateLBLs(seconds, minutes, hours, days, months, years);
        }

        public void updateLBLs(double s, double m, double h, double d, double mm, double y)
        {
            //updating labels to display calculated figures up to the 6th decimal point
            LBLSeconds.Text = "Seconds: " + s.ToString("0");
            LBLMinutes.Text = "Minutes: " + m.ToString("0.##");
            LBLHours.Text = "Hours: " + h.ToString("0.##");
            LBLDays.Text = "Days: " + d.ToString("0.##");
            LBLMonths.Text = "Months: " + mm.ToString("0.##");
            LBLYears.Text = "Years: " + y.ToString("0.####");
        }

        private void CBChangeLaw_SelectedIndexChanged(object sender, EventArgs e)
        {
            string current = "Current ( I )";
            string resistance = "Resistance ( R )";
            string voltage = "Voltage ( V )";
            if(CBChangeLaw.SelectedIndex == 0)
            {
                LBLValueOne.Text = current;
                LBLValueTwo.Text = resistance;
                LBLValueThree.Text = voltage;
                LBLOLMathSign.Text = "*";
                BTNOLSubmit.PerformClick();
            }
            if (CBChangeLaw.SelectedIndex == 1)
            {
                LBLValueOne.Text = voltage;
                LBLValueTwo.Text = resistance;
                LBLValueThree.Text = current;
                LBLOLMathSign.Text = "/";
                BTNOLSubmit.PerformClick();
            }
            if (CBChangeLaw.SelectedIndex == 2)
            {
                LBLValueOne.Text = voltage;
                LBLValueTwo.Text = current;
                LBLValueThree.Text = resistance;
                LBLOLMathSign.Text = "/";
                BTNOLSubmit.PerformClick();
            }
        }

        private void BTNOLSubmit_Click(object sender, EventArgs e)
        {
            double valueOne = 0;
            double valueTwo = 0;
            double valueThree = 0;
            valueOne = double.Parse(NUDValueOne.Value.ToString());
            valueTwo = double.Parse(NUDValueTwo.Value.ToString());

            if (CBChangeLaw.SelectedIndex == 0)
            {
                NUDValueThree.Text = (valueOne * valueTwo).ToString("0.##") + "v";
            }
            if (CBChangeLaw.SelectedIndex == 1)
            {
                NUDValueThree.Text = (valueOne / valueTwo).ToString("0.###") + "A";
            }
            if (CBChangeLaw.SelectedIndex == 2)
            {
                NUDValueThree.Text = (valueOne / valueTwo).ToString("0.##") + "ohm";
            }
        }

        private void BTNRSubmit_Click(object sender, EventArgs e)
        {
            double ohms = 0;
            double temp1, temp2, temp3, temp4;
            temp1 = double.Parse(NUDRSV.Value.ToString());
            temp2 = double.Parse(NUDRFV.Value.ToString());
            temp3 = double.Parse(NUDRFC.Value.ToString());
            temp4 = temp1 - temp2;
            ohms = temp4 / temp3;
            ohms *= 1000;

            LBLROutput.Text = ohms.ToString() + " Ohms";
        }

        private void BTNCCSubmit_Click(object sender, EventArgs e)
        {
            double sourceVoltage = 0;
            double sourceCurrent = 0;
            double outputVoltage = 0;
            double outputCurrent = 0;
            double watt = 0;

            sourceVoltage = double.Parse(NUDCCSourceVoltage.Value.ToString());
            outputVoltage = double.Parse(NUDCCOutputVoltage.Value.ToString());
            outputCurrent = double.Parse(NUDCCOutputCurrent.Value.ToString());

            outputCurrent /= 1000;
            watt = outputVoltage * outputCurrent;

            sourceCurrent = watt / sourceVoltage;
            sourceCurrent *= 1000;

            LBLCCWattage.Text = watt.ToString("0.##") + "w";
            LBLCCSourceCurrent.Text = sourceCurrent.ToString("0.##") + "mA";
           

        }
    }
}
