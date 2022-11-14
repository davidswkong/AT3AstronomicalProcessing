using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Alexander Doig, Team1, Sprint2
// 31/10/2022
// Version: 01
// AstronomicalProcessing
// 24 random integers are added to an array, array can be displayed in listbox and interacted with by user with methods for editing, binary search and sorting
namespace AstronomicalProcessing
{
    public partial class Form1 : Form
    {
        int[] NeutrinoInteractions = new int[24];

        public Form1()
        {
            InitializeComponent();

        }

        // 24 random integers are generated
        private void Random()
        {
            // For the length of NeutrinoInteractions (24), random integers between 1 and 100 are added
            Random rnd = new Random();
            for (int i = 0; i < NeutrinoInteractions.Length; i++)
            {
                NeutrinoInteractions[i] = rnd.Next(1, 100);
            }
            UpdateList();


        }

        // Neutrino Interactions items are added to ListBox
        private void UpdateList()
        {
            ListBox.Items.Clear();
            // Neutrinos in array NeutrinoInteractions are added to ListBox
            foreach (int Neutrinos in NeutrinoInteractions)
            {
                ListBox.Items.Add(Neutrinos);
            }


        }
        // Neutrino Interactions items are added to ListBox
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            // When user clicks button 24 different random values are added into an array
            Random();
        }

        // Selected item can be edited by user and returned to list
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            // Selected index is assigned to variable, item at selected index is removed
            // Edited text in textBox1 is inserted
            // textBox1 is cleared


            var Index = ListBox.SelectedIndex;
            int temp = 0;

            if (Int32.TryParse(textBox1.Text, out temp) && Index != -1)
            {
                NeutrinoInteractions[Index] = temp;
                textBox1.Clear();
                UpdateList();
            }
        }


        // Performs method if selectedindex is changed
        private void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (ListBox.SelectedIndex >= 0)
                textBox1.Text = NeutrinoInteractions[ListBox.SelectedIndex].ToString();

        }

        // Sorts values in ListBox into Ascending order
        private void BtnSort_Click(object sender, EventArgs e)
        /* For the length of NeutrinoInteractions - 2, if current iteration is greater than next iteration 
           values swap places,
           ListBox is cleared and List is updated */
        {
            int temp;
            for (int j = 0; j <= NeutrinoInteractions.Length - 2; j++)
            {
                for (int i = 0; i <= NeutrinoInteractions.Length - 2 - j; i++)
                {
                    if (NeutrinoInteractions[i] > NeutrinoInteractions[i + 1])
                    {
                        temp = NeutrinoInteractions[i + 1];
                        NeutrinoInteractions[i + 1] = NeutrinoInteractions[i];
                        NeutrinoInteractions[i] = temp;
                    }
                }
            }

            UpdateList();
        }

        // Takes user input and uses it in BinarySearch, displays confirmation or error message
        private void BtnBinarySearch_Click(object sender, EventArgs e)
        /* Text in textBox1 is converted to integer,
           BinarySearch method is called, properties are assigned users List and Input 
           if index is greater than -1, Confirmation message, else, error message.
           */
        {

            try
            {
                int userInput = int.Parse(textBox1.Text);
                int x = BinarySearch(NeutrinoInteractions, userInput);
                if (x >= 0)
                {
                    MessageBox.Show("Neutrino Interaction found at " + x);
                    ListBox.SelectedIndex = x;
                }
                else
                {
                    MessageBox.Show("Neutrino Interaction not found");
                }
            }
            catch
            {
                MessageBox.Show("Neutrino Interaction not found");
            }
        }

        // Binary search method, finds if entered value in textBox1 exists in list
        public static int BinarySearch(int[] arr, int val)
        /* variables are defined
           while min is less than or equal to max loop continues
           if users input is equal to middle number in array it is returned
           if input isn't, loop continues */
        {
            int min = 0;
            int max = arr.Length - 1;

            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (val == arr[mid])
                {
                    return mid;
                }
                else if (val < arr[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            return -1;

        }

        private void BtnMean_Click(object sender, EventArgs e)
        /*finding average of data set*/
        {
            double avg = 0, sum = 0;
            int lstCount = ListBox.Items.Count; //Get Count of Listbox Items
            for (int i = 0; i < lstCount; i++)
            {
                sum += Convert.ToDouble(ListBox.Items[i]);
            }
            avg = sum / lstCount;

            textBox2.Text = avg.ToString("0.00");//2 decimal places


        }

        private void BtnMode_Click(object sender, EventArgs e)
        {
            var groups = NeutrinoInteractions.GroupBy(v => v);
            int maxCount = groups.Max(g => g.Count());
            int mode = groups.First(g => g.Count() == maxCount).Key;
            textBox2.Text = mode.ToString();
        }

        private void BtnRange_Click(object sender, EventArgs e)
        {
            //range of data set 
            int smallestValue = int.MaxValue;
            int largestValue = int.MinValue;
            double range = 0;
            foreach (var item in ListBox.Items)
            {
                int value = int.Parse(item.ToString());

                if (value > largestValue)
                    largestValue = value;

                if (value < smallestValue)
                    smallestValue = value;
            }
            range = largestValue - smallestValue; // custom calculation
            textBox2.Text = range.ToString();


        }

        private void BtnMidExtreme_Click(object sender, EventArgs e)
        {
            //mid extreme button
            int smallestValue = int.MaxValue;
            int largestValue = int.MinValue;
            double midxtreme = 0;
            foreach (var item in ListBox.Items)
            {
                int value = int.Parse(item.ToString());

                if (value > largestValue)
                    largestValue = value;

                if (value < smallestValue)
                    smallestValue = value;
            }
            midxtreme = (largestValue + smallestValue) / 2;
            textBox2.Text = midxtreme.ToString();
        }

        private void btnSSearch_Click(object sender, EventArgs e)
        {
            var counter = 0;

            for (int i = 0; i < this.ListBox.Items.Count; i++)
            {
                var item = this.ListBox.Items[i];
                if (string.Equals(item.ToString(), this.textBox1.Text, StringComparison.InvariantCultureIgnoreCase))
                {
                    this.ListBox.SelectedItems.Add(item);
                    counter++;
                }

            }
            if (counter == 0)
            {
                MessageBox.Show($"No matches for \"{this.textBox1.Text}\" found!", "Search Results",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Clear();
                textBox1.Focus();
            }
            else
            {
                MessageBox.Show($"{counter} items found for \"{this.textBox1.Text}\"!", "Search Results",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Focus();
            }


        }
    }
}

