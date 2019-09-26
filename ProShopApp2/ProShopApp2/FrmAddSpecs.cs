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
    public partial class FrmAddSpecs : Form
    {
        Players newPlayers = new Players();
        public string BowlersDetails;
        public FrmAddSpecs()
        {
            InitializeComponent();
        }

        private void btnSaveSpec_Click(object sender, EventArgs e)
        {
            
            newPlayers.Bowler_Name = txtName.Text;
            newPlayers.Bowler_Hand = txtLeftOrRight.Text;
            newPlayers.Bowler_PAP = txtPAP.Text;
            newPlayers.Bowler_FingerSize = txtFingerDrill.Text;
            newPlayers.Bowler_ThumbSize = txtThumbDrill.Text;
            newPlayers.Bowler_SpanLeft = txtLeftSpan.Text;
            newPlayers.Bowler_SpanRight = txtRightSpan.Text;
            newPlayers.Bowler_MiddleInsert = txtMiddleInsert.Text;
            newPlayers.Bowler_RingInsert = txtRingInsert.Text;
            newPlayers.Bowler_Bridge = txtBridge.Text;
            newPlayers.ReverseLeft = txtLeftRev.Text;
            newPlayers.LatLeft = txtLateralLeft.Text;
            newPlayers.ForwardLeft = txtLeftFor.Text;
            newPlayers.ReverseRight = txtRightRev.Text;
            newPlayers.LatRight = txtLateralRight.Text;
            newPlayers.ForwardRight = txtRightFor.Text;
            newPlayers.ReverseThumb = txtThumbRev.Text;
            newPlayers.AwayThumb = txtAwayFromPalm.Text;
            newPlayers.ForwardThumb = txtThumbFor.Text;
            newPlayers.IntoThumb = txtIntoPalm.Text;

            BowlersDetails = newPlayers.Bowler_Name + "," + newPlayers.Bowler_Hand + "," + newPlayers.Bowler_PAP + "," + newPlayers.Bowler_FingerSize + "," + newPlayers.Bowler_ThumbSize + "," + newPlayers.Bowler_SpanLeft + "," + newPlayers.Bowler_SpanRight + "," + newPlayers.Bowler_MiddleInsert + "," + newPlayers.Bowler_RingInsert + "," + newPlayers.Bowler_Bridge + "," + newPlayers.ReverseLeft + "," + newPlayers.LatLeft + "," + newPlayers.ForwardLeft + "," + newPlayers.ReverseRight + "," + newPlayers.LatRight + "," + newPlayers.ForwardRight + "," + newPlayers.ReverseThumb + "," + newPlayers.AwayThumb + "," + newPlayers.ForwardThumb + "," + newPlayers.IntoThumb + Environment.NewLine;

            saveCSV();
            MessageBox.Show("Data Saved");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void saveCSV()
        {
            string newFileName = @"C:\Users\BrianG\Documents\test3.csv";

            if (!File.Exists(newFileName))
            {
                string BowlersHeader = "Bowlers Name" + "," + "Bowlers Hand" + "," + "Bowlers PAP" + "," + "Bowlers Finger Drill" + "," + "Bowlers Thumb Drill" + "," + "Bowlers Span (To Left Finger)" + "," + "Bowlers Span (To Right Finger)" + "," + "Bowlers Middle Insert" + "," + "Bowlers Ring Insert" + "," + "Bowlers Bridge" + "," + "Reverse Left Finger" + "," + "Lateral Left Finger" + "," + "Forward Left Finger" + "," + "Reverse Right Finger" + "," + "Lateral Right Finger" + "," + "Forward Right Finger" + "," + "ReverseThumb" + "," + "AwayThumb" + "," + "ForwardThumb" + "," + "IntoThumb" + Environment.NewLine;
                File.WriteAllText(newFileName, BowlersHeader);
            }
            File.AppendAllText(newFileName, BowlersDetails);
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
