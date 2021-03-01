using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;


namespace ArrayGUI
{
    public partial class FormArrayGUI : Form
    {
        public FormArrayGUI()
        {
            InitializeComponent();
        }

        const int LEN = 25;


        int[] original = new int[LEN];
        int[] modified = new int[LEN];
        int sum = 0;
        double average = 0.0;

        private void buttonNewNumbers_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            ClearListBox();

            for (int lcv = 0; lcv < original.Length; ++lcv)
            {
                // fill up both arrays
                original[lcv] = rand.Next(1, 100);
                modified[lcv] = original[lcv];

                // copy current array value to listBox
                listBoxArray.Items.Add(original[lcv]);
            }
        }
        private void ClearListBox()
        {
            listBoxArray.Items.Clear();
        }

        private void buttonClearListBox_Click(object sender, EventArgs e)
        {
            ClearListBox();
        }

        private void buttonSortAscending_Click(object sender, EventArgs e)
        {
            SortAscending();
        }
        private void SortAscending()
        {
            ClearListBox();

            Array.Sort(modified);
            for (int lcv = 0; lcv < modified.Length; ++lcv)
            {
                // copy current array value to listBox
                listBoxArray.Items.Add(modified[lcv]);
            }

        }

        private void buttonSortDescending_Click(object sender, EventArgs e)
        {
            SortDescending();
        }
        private void SortDescending()
        {
            ClearListBox();
            Array.Reverse(modified);
            for (int lcv = 0; lcv < modified.Length; ++lcv)
            {
                // copy current array value to listBox
                listBoxArray.Items.Add(modified[lcv]);
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            findArrayElement();
        }
        private void findArrayElement()
        {
            SortAscending();
            string value = Interaction.InputBox("Number to Search For?",
                                                "SEARCH", "50", 770, 455);
            int theValue = Convert.ToInt32(value);

            int result = Array.BinarySearch(modified, theValue);

            if (result < 0)
            {
                MessageBox.Show("The Element " + theValue.ToString() + 
                                "Was NOT Found In The Array",
                                "ELEMENT NOT FOUND", 
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("The Element " + theValue.ToString() +
                                "Was Found In The Array",
                                "ELEMENT FOUND",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            ExitApplication();
        }
        private void ExitApplication()
        {
            if (MessageBox.Show("Exit Program?", "EXIT PROGRAM???", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }

        private void buttonSum_Click(object sender, EventArgs e)
        {
            sumArrayElements(true);
        }
        private void sumArrayElements( bool printSumMessageBox)
        {
            for(int lcv = 0; lcv < modified.Length; ++lcv)
            {
                sum += modified[lcv];
            }
            if (printSumMessageBox)
            {
                MessageBox.Show("The sum of all array elements is " + sum.ToString(),
                                 "SUM OF ARRAY ELEMENTS",
                                 MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void buttonAverage_Click(object sender, EventArgs e)
        {
            averageArrayElements();
        } 
        private void averageArrayElements()
        {
            sumArrayElements(false);

            average = (double)sum / modified.Length;

            MessageBox.Show("The average of all array elements is " + average.ToString("f2"),
                                           "AVERAGE OF ARRAY ELEMENTS",
                                           MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonLowest_Click(object sender, EventArgs e)
        {
            findTheLowest();
        }
        private void findTheLowest()
        {
            SortAscending();

            MessageBox.Show("The smallest of all array elements is " +
                                modified[0].ToString(),
                               "SMALLEST OF ARRAY ELEMENTS",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonHighest_Click(object sender, EventArgs e)
        {
            findTheHighest();
        }
        private void findTheHighest()
        {
            SortDescending();

            MessageBox.Show("The largest of all array elements is " +
                                modified[0].ToString(),
                               "LARGEST OF ARRAY ELEMENTS",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonMedian_Click(object sender, EventArgs e)
        {
            findTheMedian();
        }
        private void findTheMedian()
        {
            SortAscending();

            int median = LEN / 2;

            MessageBox.Show("The median of all array elements is " +
                                modified[median].ToString(),
                               "MEDIAN OF ARRAY ELEMENTS",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonRange_Click(object sender, EventArgs e)
        {
            findTheRange();
        }
        private void findTheRange()
        {
            SortAscending();

            int highValue = modified[LEN - 1];
            int lowValue = modified[0];
            int range = highValue - lowValue;
            
            MessageBox.Show("The range of all array elements is " +
                                range.ToString() + "\nwith high value of : " + highValue.ToString() + 
                                "and \nlow value of: " + lowValue.ToString(),
                               "RANGE OF ARRAY ELEMENTS",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
