using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomDesk
{
    public partial class FormCustomDesk : Form
    {
        public FormCustomDesk()
        {
            InitializeComponent();
        }
        const double PINECOST = 100.0;
        const double OAKCOST = 140.0;
        const double OTHERCOST = 180.0;
        const double DRAWERCOST = 30.0;
        string woodType = "";
        int numberOfDrawers = 0;
        double drawerCost = 0.0;
        double woodCost = 0.0;



        private void buttonEstimate_Click(object sender, EventArgs e)
        {
            
            string woodType = "";
            int numberOfDrawers = 0;
            numberOfDrawers = GetDrawers();
            woodCost = CalculateWoodCost(woodType);
            drawerCost = CalculateDrawerCost(numberOfDrawers);
            woodType = GetWood();
            double totalCost = 0.0;
            totalCost = CalculateTotalCost(woodType , numberOfDrawers);
            labelTheWoodCost.Text = woodCost.ToString("c");
            labelTheDrawerCost.Text = drawerCost.ToString("c");
            labelTheTotalCost.Text = totalCost.ToString("c");
        }
        private string GetWood()
        {
            woodType = textBoxWoodType.Text.ToLower();
            if (woodType[0] == 'm')
            {
                return "Mahogany";
            }
            else if (woodType[0] == 'o')
            {
                return "Oak";
            }
            else if (woodType[0] == 'p')
            {
                return "Pine";
            }
            else
            {
                return "Other";
            }


        }
        private int GetDrawers ()
        {
            numberOfDrawers = Convert.ToInt32(textBoxNumOfDrawers.Text);
            return numberOfDrawers;
        }
        private double CalculateWoodCost (string wood)
        {
            if (wood == "Mahogany")
            {
                return OTHERCOST;
            }
            if (wood == "Oak")
            {
                return OAKCOST;
            }
            if (wood == "Pine")
            {
                return PINECOST;
            }
            else
            {
                return OTHERCOST;
            }

        }
        private double CalculateDrawerCost (int drawers)
        {
            return drawers * DRAWERCOST;
        }
        private double CalculateTotalCost (string wood , int drawers)
        {
            double woodCost = 0.0;
            double drawerCost = 0.0;
            
            woodCost = CalculateWoodCost(wood);
            drawerCost = CalculateDrawerCost(drawers);
            return woodCost + drawerCost;
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            clearAndSetFocus();
        }
        private void clearAndSetFocus()
        {
            textBoxWoodType.Text = "";
            textBoxNumOfDrawers.Text = "";
            labelTheWoodCost.Text = "";
            labelTheDrawerCost.Text = "";
            labelTheTotalCost.Text = "";
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            ExitApplication();
        }
        private void ExitApplication()
        {

        }
    }
}
