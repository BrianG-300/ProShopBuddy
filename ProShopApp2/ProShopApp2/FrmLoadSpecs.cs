using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ProShopApp2
{
    public partial class FrmLoadSpecs : Form
    {
        int colIndex = 0;
        int rowIndex = 0;
        double[,] myArray;
        int nRows=4;
        int nColumns=20;
        Players newPlayer = new Players();

        public FrmLoadSpecs()
        {
            InitializeComponent();
        }

        private void FrmLoadSpecs_Load(object sender, EventArgs e)
        {
            //Load names from Excel file into Combobox to be picked
            comboBox1.Text = "Select a name from the list";
            OpenCSV();
        }

        public void OpenCSV()
        {

            myArray = new double[nRows, nColumns];
            //int colIndex = 0;
            //int rowIndex = 0;
            var reader = new StreamReader(File.OpenRead(@"C:\Users\BrianG\Documents\test2.csv"));
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');
                foreach (string part in values)
                {
                    myArray[rowIndex, colIndex] = Double.Parse(part);
                    ++colIndex;
                }
                ++rowIndex;
            }
            reader.Close();

        }

        //public void OpenCSV2()
        //{
        //    var reader = new StreamReader(File.OpenRead(@"C:\Users\BrianG\Documents\test2.csv"));

        //    while (!reader.EndOfStream)
        //    {
        //        var line = reader.ReadLine();
        //        if (!line.Contains("Bowlers Name"))
        //        {
        //            var values = line.Split(',');

        //            newPlayer.Bowler_Name = values[0];
        //            newPlayer.Bowler_Hand = values[1];
        //            newPlayer.Bowler_PAP = values[2];
        //            newPlayer.Bowler_FingerSize = values[3];
        //            newPlayer.Bowler_ThumbSize = values[4];
        //            newPlayer.Bowler_SpanLeft = values[5];
        //            newPlayer.Bowler_SpanRight = values[6];
        //            newPlayer.Bowler_MiddleInsert = values[7];
        //            newPlayer.Bowler_RingInsert = values[8];
        //            newPlayer.Bowler_Bridge = values[9];
        //            newPlayer.ReverseLeft = values[10];
        //            newPlayer.LatLeft = values[11];
        //            newPlayer.ForwardLeft = values[12];
        //            newPlayer.ReverseRight = values[13];
        //            newPlayer.LatRight = values[14];
        //            newPlayer.ForwardRight = values[15];
        //            newPlayer.ReverseThumb = values[16];
        //            newPlayer.AwayThumb = values[17];
        //            newPlayer.ForwardThumb = values[18];
        //            newPlayer.IntoThumb = values[19];

        //            comboBox1.Items.Add(newPlayer.Bowler_Name);              
        //        }
        //    }          
        //}

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLoadSpec_Click(object sender, EventArgs e)
        {
            MessageBox.Show(myArray.ToString());
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a name in the list");
            }
            else
            {
                MessageBox.Show(comboBox1.SelectedIndex.ToString());
                lblName.Text = comboBox1.SelectedItem.ToString();
            }
        }
    }
}
