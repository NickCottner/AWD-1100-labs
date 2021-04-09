using System;
using System.Windows.Forms;

/*
 * 
 *          Write a GUI application for a photography business:
 *          
 *          - 8" by 10" photos are $3.99
 *          
 *          - 10" by 12" is $5.99
 *          
 *          - All other sizes are $9.99
 *          
 *          - Customers can add either a Matte or a Frame
 *          
 *          - Matted photos are an additional $10.00
 *          
 *          - Framed photos are an additional $25.00
 *          
 *          - Ovveride the ToString() methods on the Photo,
 *            MattedPhoto, and FramedPhoto classes so they 
 *            display all of the information in the fields.
 *            
 */            

namespace LB2_Photos
{
    public partial class FormPhotos : Form
    { //Global Constants
        const decimal EIGHTBYTEN = 3.99m;       // 8" by 10" cost
        const decimal TENBYTWELVE = 5.99m;      // 10" by 12" cost
        const decimal OTHERSIZES = 9.99m;       // Other sizes cost
        const decimal UNFRAMED = 0.00m;         // Unframed Cost
        const decimal MATTED = 10.00m;          // Matted cost
        const decimal FRAMED = 25.00m;          // Framed Cost

        //Global Variables
        double width = 0.00;                    // Width inputted
        double height = 0.00;                   // Height inputted
        decimal totalCost = 0.00m;              // Total cost for picture
        RadioButton radioButtonFrame;
        RadioButton radioButtonColor;
        RadioButton radioButtonMaterial;
        RadioButton radioButtonStyle;
        string frameStr = " ";                  // Unframed, Matted, or framed
        string colorStr = " ";                  // Black, red, green, blue, or white
        string materialStr = " ";               // Pine, oak, steel, silver, or gold
        string styleStr = " ";                  // simple, modern, antique, vintage, or eclectic


        public FormPhotos()
        {
            InitializeComponent();

            // Set up framed groupbox radioButtons
            radioButtonUnframed.CheckedChanged += new EventHandler(framed_Checked_Changed);
            radioButtonMatted.CheckedChanged += new EventHandler(framed_Checked_Changed);
            radioButtonFramed.CheckedChanged += new EventHandler(framed_Checked_Changed);

            //Set up color GroupBox radioButtons
            radioButtonBlack.CheckedChanged += new EventHandler(color_Checked_Changed);
            radioButtonRed.CheckedChanged += new EventHandler(color_Checked_Changed);
            radioButtonGreen.CheckedChanged += new EventHandler(color_Checked_Changed);
            radioButtonBlue.CheckedChanged += new EventHandler(color_Checked_Changed);
            radioButtonWhite.CheckedChanged += new EventHandler(color_Checked_Changed);

            //Set up material radioButtons
            radioButtonPine.CheckedChanged += new EventHandler(material_Checked_Changed);
            radioButtonOak.CheckedChanged += new EventHandler(material_Checked_Changed);
            radioButtonSteel.CheckedChanged += new EventHandler(material_Checked_Changed);
            radioButtonSilver.CheckedChanged += new EventHandler(material_Checked_Changed);
            radioButtonGold.CheckedChanged += new EventHandler(material_Checked_Changed);

            //Set up style radioButtons
            radioButtonSimple.CheckedChanged += new EventHandler(style_Checked_Changed);
            radioButtonModern.CheckedChanged += new EventHandler(style_Checked_Changed);
            radioButtonAntique.CheckedChanged += new EventHandler(style_Checked_Changed);
            radioButtonVintage.CheckedChanged += new EventHandler(style_Checked_Changed);
            radioButtonEclectic.CheckedChanged += new EventHandler(style_Checked_Changed);
        }
        private void framed_Checked_Changed(object sender, EventArgs e)
        {
            if (sender is RadioButton)
            {
                radioButtonFrame = (RadioButton)sender;
                frameStr = radioButtonFrame.Name.Substring(11);
                MessageBox.Show("The Current switch value is: " + frameStr);

                switch (frameStr)
                {
                    case "Unframed":
                        groupBoxColor.Enabled = false;
                        groupBoxMaterial.Enabled = false;
                        groupBoxStyle.Enabled = false;
                        break;

                    case "Matted":
                        groupBoxColor.Enabled = true;
                        radioButtonBlack.Checked = true;
                        groupBoxMaterial.Enabled = false;
                        groupBoxStyle.Enabled = false;
                        break;

                    case "Framed":
                        groupBoxColor.Enabled = false;
                        groupBoxMaterial.Enabled = true;
                        radioButtonPine.Checked = true;
                        groupBoxStyle.Enabled = true;
                        radioButtonSimple.Checked = true;
                        break;

                    default:
                        groupBoxColor.Enabled = false;
                        groupBoxMaterial.Enabled = false;
                        groupBoxStyle.Enabled = false;
                        break;

                }

            }
        }
        private void color_Checked_Changed(object sender, EventArgs e)
        {
            if (sender is RadioButton)
            {
                radioButtonColor = (RadioButton)sender;
                colorStr = radioButtonColor.Name.Substring(11);
            }
        }
        private void material_Checked_Changed(object sender, EventArgs e)
        {
            if (sender is RadioButton)
            {
                radioButtonMaterial = (RadioButton)sender;
                materialStr = radioButtonMaterial.Name.Substring(11);
            }
        }
        private void style_Checked_Changed(object sender, EventArgs e)
        {
            if (sender is RadioButton)
            {
                radioButtonStyle = (RadioButton)sender;
                styleStr = radioButtonStyle.Name.Substring(11);
            }
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            bool keepGoing = validateWidth();

            if (keepGoing)
            {
                keepGoing = validateHeight();
            }
            else
            {
                return;
            }
            if (keepGoing)
            {
                calculateCost();
            }
            else
            {
                return;
            }
        }
        private bool validateWidth()
        {
            try
            {
                width = Convert.ToDouble(textBoxWidth.Text);
                return true;
            }
            catch (FormatException fe)
            {
                showMessage("Width Inputted Was Not Numeric. \n Please Enter A Numeric Width." + fe.Message,
                            "NON NUMERIC WIDTH INPUTTED!");
                textBoxWidth.Text = " ";
                textBoxWidth.Focus();
                return false;
            }
            catch (ArgumentOutOfRangeException aoore)
            {
                showMessage("Inputted Width Was <= 0. \n Please Enter a Width > 0." + aoore.Message,
                            "NEGATIVE WIDTH INPUTTED");
                textBoxWidth.Text = " ";
                textBoxWidth.Focus();
                return false;

            }
        }
        private bool validateHeight()
        {
            try
            {
                height = Convert.ToDouble(textBoxHeight.Text);
                return true;
            }
            catch (FormatException fe)
            {
                showMessage("Height Inputted Was Not Numeric. \n Please Enter A Numeric Height." + fe.Message,
                            "NON NUMERIC Height INPUTTED!");
                textBoxHeight.Text = " ";
                textBoxHeight.Focus();
                return false;
            }
            catch (ArgumentOutOfRangeException aoore)
            {
                showMessage("Inputted Height Was <= 0. \n Please Enter a Height > 0." + aoore.Message,
                            "NEGATIVE WIDTH INPUTTED");
                textBoxHeight.Text = " ";
                textBoxHeight.Focus();
                return false;
            }
        }
        private void calculateCost()
        {
            decimal areaCost = calculateAreaCost();
            decimal frameCost = calculateFrameCost();
            totalCost = areaCost + frameCost;

            labelTheCost.Text = totalCost.ToString("c");
        }
        private decimal calculateAreaCost()
        {
            double area = width * height;
            decimal ac = 0.00m;

            switch (area)
            {
                case 80.0:
                    ac = EIGHTBYTEN;
                    break;

                case 120.0:
                    ac = TENBYTWELVE;
                    break;

                default:
                    ac = OTHERSIZES;
                    break;
            }
            return ac;
        }
        private decimal calculateFrameCost()
        {
            decimal fc = 0.0m;

            MessageBox.Show("The value of Frame is: " + radioButtonFrame.Name.Substring(11));

            switch (radioButtonFrame.Name.Substring(11))
            {
                case "Unframed":
                    fc = UNFRAMED;
                    Photo p = new Photo(width, height);
                    labelTotals.Text = p.ToString();
                    break;

                case "Matted":
                    fc = MATTED;
                    MattedPhoto.Color colorEnum = (MattedPhoto.Color)Enum.Parse(typeof(MattedPhoto.Color),
                        radioButtonColor.Text);
                    MattedPhoto mp = new MattedPhoto(width, height, colorEnum);
                    labelTotals.Text = mp.ToString();
                    break;

                case "Framed":
                    fc = FRAMED;
                    FramedPhoto.Material materialEnum = (FramedPhoto.Material)Enum.Parse(
                                                        typeof(FramedPhoto.Material),
                                                        radioButtonMaterial.Text);
                    FramedPhoto.Style styleEnum = (FramedPhoto.Style)Enum.Parse(
                                                   typeof(FramedPhoto.Style), radioButtonStyle.Text);
                    FramedPhoto fp = new FramedPhoto(width, height, materialEnum, styleEnum);
                    labelTotals.Text = fp.ToString();
                    break;

                default:
                    break;
                    
            }
            return fc;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
        private void ClearAll()
        {
            width = 0.0;
            height = 0.0;
            textBoxWidth.Text = " ";
            textBoxHeight.Text = " ";
            radioButtonUnframed.Checked = true;
            radioButtonBlack.Checked = true;
            radioButtonPine.Checked = true;
            radioButtonSimple.Checked = true;
            labelTheCost.Text = " ";
            labelTotals.Text = " ";
            textBoxWidth.Focus();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do You Really Want To Exit?", "EXIT NOW?",
                                  MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void showMessage(string msg, string title)
        {
            MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
