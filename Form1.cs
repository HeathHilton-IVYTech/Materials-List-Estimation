using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;



namespace Materials_List_Estimation
{
    public partial class mainForm : Form
    {

        Bitmap memoryImage;
        public mainForm()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //Setting the size of the Group Boxes for all of the estimating sections
            //all are basically closed until they are selected at which point the open
            //tabs are closed and the one you select is expanded to a useable size. 
            groupBoxGeneral.Size = new Size(600, 320);
            groupBoxFlooring.Size = new Size(0, 0);
            groupBoxWalls.Size = new Size(0, 0);
            groupBoxOpenings.Size = new Size(0, 0);
            groupBoxRoof.Size = new Size(0, 0);
            groupBoxOtherItems.Size = new Size(0, 0);

            groupBoxGeneral.Location = new Point(170, 68);
            groupBoxFlooring.Location = new Point(170, 68);
            groupBoxWalls.Location = new Point(170, 68);
            groupBoxOpenings.Location = new Point(170, 68);
            groupBoxRoof.Location = new Point(170, 68);
            groupBoxOtherItems.Location = new Point(170, 68);

            //Defaulting the "General" item in then listCategory that 
            listCategory.SelectedItem = "General";

        }

        //Close the program when requested
        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Once the item is selected, it expand the group boxes and closes the others. 
        private void listCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            String text = listCategory.SelectedItems[0].ToString();
            Console.WriteLine(text);

            switch (text)
            {
                case "General":
                    Console.WriteLine("General");
                    groupBoxGeneral.Size = new Size(600, 320);
                    groupBoxFlooring.Size = new Size(0, 0);
                    groupBoxWalls.Size = new Size(0, 0);
                    groupBoxOpenings.Size = new Size(0, 0);
                    groupBoxRoof.Size = new Size(0, 0);
                    groupBoxOtherItems.Size = new Size(0, 0);
                    break;
                case "Flooring":
                    Console.WriteLine("Flooring");
                    groupBoxGeneral.Size = new Size(0, 0);
                    groupBoxFlooring.Size = new Size(600, 320);
                    groupBoxWalls.Size = new Size(0, 0);
                    groupBoxOpenings.Size = new Size(0, 0);
                    groupBoxRoof.Size = new Size(0, 0);
                    groupBoxOtherItems.Size = new Size(0, 0);
                    break;
                case "Walls":
                    Console.WriteLine("Walls");
                    groupBoxGeneral.Size = new Size(0, 0);
                    groupBoxFlooring.Size = new Size(0, 0);
                    groupBoxWalls.Size = new Size(600, 320);
                    groupBoxOpenings.Size = new Size(0, 0);
                    groupBoxRoof.Size = new Size(0, 0);
                    groupBoxOtherItems.Size = new Size(0, 0);
                    break;
                case "Openings":
                    Console.WriteLine("Openings");
                    groupBoxGeneral.Size = new Size(0, 0);
                    groupBoxFlooring.Size = new Size(0, 0);
                    groupBoxWalls.Size = new Size(0, 0);
                    groupBoxOpenings.Size = new Size(600, 320);
                    groupBoxRoof.Size = new Size(0, 0);
                    groupBoxOtherItems.Size = new Size(0, 0);
                    break;
                case "Roof":
                    Console.WriteLine("Roof");
                    groupBoxGeneral.Size = new Size(0, 0);
                    groupBoxFlooring.Size = new Size(0, 0);
                    groupBoxWalls.Size = new Size(0, 0);
                    groupBoxOpenings.Size = new Size(0, 0);
                    groupBoxRoof.Size = new Size(600, 320);
                    groupBoxOtherItems.Size = new Size(0, 0);
                    break;
                case "Other Items":
                    Console.WriteLine("Other Items");
                    groupBoxGeneral.Size = new Size(0, 0);
                    groupBoxFlooring.Size = new Size(0, 0);
                    groupBoxWalls.Size = new Size(0, 0);
                    groupBoxOpenings.Size = new Size(0, 0);
                    groupBoxRoof.Size = new Size(0, 0);
                    groupBoxOtherItems.Size = new Size(600, 320);
                    break;

            }
        }

        //These following checkboxes add or remove the options for estimating groups
        private void flooringBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (flooringBtn.Checked == true)
            {
                listCategory.Items.Add("Flooring");
            }
            else
            {
                String text = listCategory.SelectedItems[0].ToString();
                if (text == "Flooring")
                {
                    listCategory.SelectedIndex = 0;
                }
                listCategory.Items.Remove("Flooring");
            }
            updateBtn_Click(null, null);
        }

        private void wallsBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (wallsBtn.Checked == true)
            {
                listCategory.Items.Add("Walls");
            }
            else
            {
                String text = listCategory.SelectedItems[0].ToString();
                if (text == "Walls")
                {
                    listCategory.SelectedIndex = 0;
                }
                listCategory.Items.Remove("Walls");
            }
            updateBtn_Click(null, null);
        }

        private void openingsBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (openingsBtn.Checked == true)
            {
                listCategory.Items.Add("Openings");
            }
            else
            {
                String text = listCategory.SelectedItems[0].ToString();
                if (text == "Openings")
                {
                    listCategory.SelectedIndex = 0;
                }
                listCategory.Items.Remove("Openings");
            }
            updateBtn_Click(null, null);
        }

        private void roofBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (roofBtn.Checked == true)
            {
                listCategory.Items.Add("Roof");
            }
            else
            {
                String text = listCategory.SelectedItems[0].ToString();
                if (text == "Roof")
                {
                    listCategory.SelectedIndex = 0;
                }
                listCategory.Items.Remove("Roof");
            }
            updateBtn_Click(null, null);
        }

        private void otherItemsBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (otherItemsBtn.Checked == true)
            {
                listCategory.Items.Add("Other Items");
            }
            else
            {
                String text = listCategory.SelectedItems[0].ToString();
                if (text == "Other Items")
                {
                    listCategory.SelectedIndex = 0;
                }
                listCategory.Items.Remove("Other Items");
            }
            updateBtn_Click(null, null);
        }

        //Update button to calculate all of the estimates and figures.
        public void updateBtn_Click(object sender, EventArgs e)
        {
            decimal decimal1, decimal2, costDecimal;
            decimal flooringTotal, wallsTotal, openingsTotal, roofTotal, otherItemsTotal;
            decimal grandTotal = 0;

            bool t1;
            bool t2;

            bool s1 = true;
            bool s2 = true;
            bool s3 = true;
            bool s4 = true;
            bool s5 = true;

            string c;
            
            lblEstimateTotal.Text = "0.00";

            resetColors();

            //xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx

            if (lblFlooringQty1.Text == "")
            {
                lblFlooringCost1.Text = "0.00";
            } else
            {
                t1 = decimal.TryParse(lblFlooringQty1.Text, out decimal1);
                t2 = decimal.TryParse(lblFlooringPrice1.Text, out decimal2);
                if (t1 == true)
                {
                    costDecimal = decimal1 * decimal2;
                    c = costDecimal.ToString("0.00");
                    lblFlooringCost1.Text = c.ToString();
                } else
                {
                    lblFlooringQty1.ForeColor = Color.Red;
                    lblFlooringCost1.Text = "0.00";
                    s1 = false;
                }
            }

            if (lblFlooringQty2.Text == "")
            {
                lblFlooringCost2.Text = "0.00";
            }
            else
            {
                t1 = decimal.TryParse(lblFlooringQty2.Text, out decimal1);
                t2 = decimal.TryParse(lblFlooringPrice2.Text, out decimal2);
                if (t1 == true)
                {
                    costDecimal = decimal1 * decimal2;
                    c = costDecimal.ToString("0.00");
                    lblFlooringCost2.Text = c.ToString();
                }
                else
                {
                    lblFlooringQty2.ForeColor = Color.Red;
                    lblFlooringCost2.Text = "0.00";
                    s1 = false;
                }
            }

            if (lblFlooringQty3.Text == "")
            {
                lblFlooringCost3.Text = "0.00";
            }
            else
            {
                t1 = decimal.TryParse(lblFlooringQty3.Text, out decimal1);
                t2 = decimal.TryParse(lblFlooringPrice3.Text, out decimal2);
                if (t1 == true)
                {
                    costDecimal = decimal1 * decimal2;
                    c = costDecimal.ToString("0.00");
                    lblFlooringCost3.Text = c.ToString();
                }
                else
                {
                    lblFlooringQty3.ForeColor = Color.Red;
                    lblFlooringCost3.Text = "0.00";
                    s1 = false;
                }
            }

            if (lblFlooringQty4.Text == "")
            {
                lblFlooringCost4.Text = "0.00";
            }
            else
            {
                t1 = decimal.TryParse(lblFlooringQty4.Text, out decimal1);
                t2 = decimal.TryParse(lblFlooringPrice4.Text, out decimal2);
                if (t1 == true)
                {
                    costDecimal = decimal1 * decimal2;
                    c = costDecimal.ToString("0.00");
                    lblFlooringCost4.Text = c.ToString();
                }
                else
                {
                    lblFlooringQty4.ForeColor = Color.Red;
                    lblFlooringCost4.Text = "0.00";
                    s1 = false;
                }
            }



            //xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx

            if (lblWallsQty1.Text == "")
            {
                lblWallsCost1.Text = "0.00";
            }
            else
            {
                t1 = decimal.TryParse(lblWallsQty1.Text, out decimal1);
                t2 = decimal.TryParse(lblWallsPrice1.Text, out decimal2);
                if (t1 == true)
                {
                    costDecimal = decimal1 * decimal2;
                    c = costDecimal.ToString("0.00");
                    lblWallsCost1.Text = c.ToString();
                }
                else
                {
                    lblWallsQty1.ForeColor = Color.Red;
                    lblWallsCost1.Text = "0.00";
                    s2 = false;
                }
            }

            if (lblWallsQty2.Text == "")
            {
                lblWallsCost2.Text = "0.00";
            }
            else
            {
                t1 = decimal.TryParse(lblWallsQty2.Text, out decimal1);
                t2 = decimal.TryParse(lblWallsPrice2.Text, out decimal2);
                if (t1 == true)
                {
                    costDecimal = decimal1 * decimal2;
                    c = costDecimal.ToString("0.00");
                    lblWallsCost2.Text = c.ToString();
                }
                else
                {
                    lblWallsQty2.ForeColor = Color.Red;
                    lblWallsCost2.Text = "0.00";
                    s2 = false;
                }
            }

            if (lblWallsQty3.Text == "")
            {
                lblWallsCost3.Text = "0.00";
            }
            else
            {
                t1 = decimal.TryParse(lblWallsQty3.Text, out decimal1);
                t2 = decimal.TryParse(lblWallsPrice3.Text, out decimal2);
                if (t1 == true)
                {
                    costDecimal = decimal1 * decimal2;
                    c = costDecimal.ToString("0.00");
                    lblWallsCost3.Text = c.ToString();
                }
                else
                {
                    lblWallsQty3.ForeColor = Color.Red;
                    lblWallsCost3.Text = "0.00";
                    s2 = false;
                }
            }

            if (lblWallsQty4.Text == "")
            {
                lblWallsCost4.Text = "0.00";
            }
            else
            {
                t1 = decimal.TryParse(lblWallsQty4.Text, out decimal1);
                t2 = decimal.TryParse(lblWallsPrice4.Text, out decimal2);
                if (t1 == true)
                {
                    costDecimal = decimal1 * decimal2;
                    c = costDecimal.ToString("0.00");
                    lblWallsCost4.Text = c.ToString();
                }
                else
                {
                    lblWallsQty4.ForeColor = Color.Red;
                    lblWallsCost4.Text = "0.00";
                    s2 = false;
                }
            }

            if (lblWallsQty5.Text == "")
            {
                lblWallsCost5.Text = "0.00";
            }
            else
            {
                t1 = decimal.TryParse(lblWallsQty5.Text, out decimal1);
                t2 = decimal.TryParse(lblWallsPrice5.Text, out decimal2);
                if (t1 == true)
                {
                    costDecimal = decimal1 * decimal2;
                    c = costDecimal.ToString("0.00");
                    lblWallsCost5.Text = c.ToString();
                }
                else
                {
                    lblWallsQty5.ForeColor = Color.Red;
                    lblWallsCost5.Text = "0.00";
                    s2 = false;
                }
            }

            if (lblWallsQty6.Text == "")
            {
                lblWallsCost6.Text = "0.00";
            }
            else
            {
                t1 = decimal.TryParse(lblWallsQty6.Text, out decimal1);
                t2 = decimal.TryParse(lblWallsPrice6.Text, out decimal2);
                if (t1 == true)
                {
                    costDecimal = decimal1 * decimal2;
                    c = costDecimal.ToString("0.00");
                    lblWallsCost6.Text = c.ToString();
                }
                else
                {
                    lblWallsQty6.ForeColor = Color.Red;
                    lblWallsCost6.Text = "0.00";
                    s2 = false;
                }
            }

            if (lblWallsQty7.Text == "")
            {
                lblWallsCost7.Text = "0.00";
            }
            else
            {
                t1 = decimal.TryParse(lblWallsQty7.Text, out decimal1);
                t2 = decimal.TryParse(lblWallsPrice7.Text, out decimal2);
                if (t1 == true)
                {
                    costDecimal = decimal1 * decimal2;
                    c = costDecimal.ToString("0.00");
                    lblWallsCost7.Text = c.ToString();
                }
                else
                {
                    lblWallsQty7.ForeColor = Color.Red;
                    lblWallsCost7.Text = "0.00";
                    s2 = false;
                }
            }

            if (lblWallsQty8.Text == "")
            {
                lblWallsCost8.Text = "0.00";
            }
            else
            {
                t1 = decimal.TryParse(lblWallsQty8.Text, out decimal1);
                t2 = decimal.TryParse(lblWallsPrice8.Text, out decimal2);
                if (t1 == true)
                {
                    costDecimal = decimal1 * decimal2;
                    c = costDecimal.ToString("0.00");
                    lblWallsCost8.Text = c.ToString();
                }
                else
                {
                    lblWallsQty8.ForeColor = Color.Red;
                    lblWallsCost8.Text = "0.00";
                    s2 = false;
                }
            }

            if (lblWallsQty9.Text == "")
            {
                lblWallsCost9.Text = "0.00";
            }
            else
            {
                t1 = decimal.TryParse(lblWallsQty9.Text, out decimal1);
                t2 = decimal.TryParse(lblWallsPrice9.Text, out decimal2);
                if (t1 == true)
                {
                    costDecimal = decimal1 * decimal2;
                    c = costDecimal.ToString("0.00");
                    lblWallsCost9.Text = c.ToString();
                }
                else
                {
                    lblWallsQty9.ForeColor = Color.Red;
                    lblWallsCost9.Text = "0.00";
                    s2 = false;
                }
            }

            if (lblWallsQty10.Text == "")
            {
                lblWallsCost10.Text = "0.00";
            }
            else
            {
                t1 = decimal.TryParse(lblWallsQty10.Text, out decimal1);
                t2 = decimal.TryParse(lblWallsPrice10.Text, out decimal2);
                if (t1 == true)
                {
                    costDecimal = decimal1 * decimal2;
                    c = costDecimal.ToString("0.00");
                    lblWallsCost10.Text = c.ToString();
                }
                else
                {
                    lblWallsQty10.ForeColor = Color.Red;
                    lblWallsCost10.Text = "0.00";
                    s2 = false;
                }
            }

            if (lblWallsQty11.Text == "")
            {
                lblWallsCost11.Text = "0.00";
            }
            else
            {
                t1 = decimal.TryParse(lblWallsQty11.Text, out decimal1);
                t2 = decimal.TryParse(lblWallsPrice11.Text, out decimal2);
                if (t1 == true)
                {
                    costDecimal = decimal1 * decimal2;
                    c = costDecimal.ToString("0.00");
                    lblWallsCost11.Text = c.ToString();
                }
                else
                {
                    lblWallsQty11.ForeColor = Color.Red;
                    lblWallsCost11.Text = "0.00";
                    s2 = false;
                }
            }

            //xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx

            if (lblOpeningsQty1.Text == "")
            {
                lblOpeningsCost1.Text = "0.00";
            }
            else
            {
                t1 = decimal.TryParse(lblOpeningsQty1.Text, out decimal1);
                t2 = decimal.TryParse(lblOpeningsPrice1.Text, out decimal2);
                if (t1 == true)
                {
                    costDecimal = decimal1 * decimal2;
                    c = costDecimal.ToString("0.00");
                    lblOpeningsCost1.Text = c.ToString();
                }
                else
                {
                    lblOpeningsQty1.ForeColor = Color.Red;
                    lblOpeningsCost1.Text = "0.00";
                    s3 = false;
                }
            }

            if (lblOpeningsQty2.Text == "")
            {
                lblOpeningsCost2.Text = "0.00";
            }
            else
            {
                t1 = decimal.TryParse(lblOpeningsQty2.Text, out decimal1);
                t2 = decimal.TryParse(lblOpeningsPrice2.Text, out decimal2);
                if (t1 == true)
                {
                    costDecimal = decimal1 * decimal2;
                    c = costDecimal.ToString("0.00");
                    lblOpeningsCost2.Text = c.ToString();
                }
                else
                {
                    lblOpeningsQty2.ForeColor = Color.Red;
                    lblOpeningsCost2.Text = "0.00";
                    s3 = false;
                }
            }


            //xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx

            if (lblRoofQty1.Text == "")
            {
                lblRoofCost1.Text = "0.00";
            }
            else
            {
                t1 = decimal.TryParse(lblRoofQty1.Text, out decimal1);
                t2 = decimal.TryParse(lblRoofPrice1.Text, out decimal2);
                if (t1 == true)
                {
                    costDecimal = decimal1 * decimal2;
                    c = costDecimal.ToString("0.00");
                    lblRoofCost1.Text = c.ToString();
                }
                else
                {
                    lblRoofQty1.ForeColor = Color.Red;
                    lblRoofCost1.Text = "0.00";
                    s4 = false;
                }
            }

            if (lblRoofQty2.Text == "")
            {
                lblRoofCost2.Text = "0.00";
            }
            else
            {
                t1 = decimal.TryParse(lblRoofQty2.Text, out decimal1);
                t2 = decimal.TryParse(lblRoofPrice2.Text, out decimal2);
                if (t1 == true)
                {
                    costDecimal = decimal1 * decimal2;
                    c = costDecimal.ToString("0.00");
                    lblRoofCost2.Text = c.ToString();
                }
                else
                {
                    lblRoofQty2.ForeColor = Color.Red;
                    lblRoofCost2.Text = "0.00";
                    s4 = false;
                }
            }

            if (lblRoofQty3.Text == "")
            {
                lblRoofCost3.Text = "0.00";
            }
            else
            {
                t1 = decimal.TryParse(lblRoofQty3.Text, out decimal1);
                t2 = decimal.TryParse(lblRoofPrice3.Text, out decimal2);
                if (t1 == true)
                {
                    costDecimal = decimal1 * decimal2;
                    c = costDecimal.ToString("0.00");
                    lblRoofCost3.Text = c.ToString();
                }
                else
                {
                    lblRoofQty3.ForeColor = Color.Red;
                    lblRoofCost3.Text = "0.00";
                    s4 = false;
                }
            }

            if (lblRoofQty4.Text == "")
            {
                lblRoofCost4.Text = "0.00";
            }
            else
            {
                t1 = decimal.TryParse(lblRoofQty4.Text, out decimal1);
                t2 = decimal.TryParse(lblRoofPrice4.Text, out decimal2);
                if (t1 == true)
                {
                    costDecimal = decimal1 * decimal2;
                    c = costDecimal.ToString("0.00");
                    lblRoofCost4.Text = c.ToString();
                }
                else
                {
                    lblRoofQty4.ForeColor = Color.Red;
                    lblRoofCost4.Text = "0.00";
                    s4 = false;
                }
            }

            if (lblRoofQty5.Text == "")
            {
                lblRoofCost5.Text = "0.00";
            }
            else
            {
                t1 = decimal.TryParse(lblRoofQty5.Text, out decimal1);
                t2 = decimal.TryParse(lblRoofPrice5.Text, out decimal2);
                if (t1 == true)
                {
                    costDecimal = decimal1 * decimal2;
                    c = costDecimal.ToString("0.00");
                    lblRoofCost5.Text = c.ToString();
                }
                else
                {
                    lblRoofQty5.ForeColor = Color.Red;
                    lblRoofCost5.Text = "0.00";
                    s4 = false;
                }
            }

            if (lblRoofQty6.Text == "")
            {
                lblRoofCost6.Text = "0.00";
            }
            else
            {
                t1 = decimal.TryParse(lblRoofQty6.Text, out decimal1);
                t2 = decimal.TryParse(lblRoofPrice6.Text, out decimal2);
                if (t1 == true)
                {
                    costDecimal = decimal1 * decimal2;
                    c = costDecimal.ToString("0.00");
                    lblRoofCost6.Text = c.ToString();
                }
                else
                {
                    lblRoofQty6.ForeColor = Color.Red;
                    lblRoofCost6.Text = "0.00";
                    s4 = false;
                }
            }

            if (lblRoofQty7.Text == "")
            {
                lblRoofCost7.Text = "0.00";
            }
            else
            {
                t1 = decimal.TryParse(lblRoofQty7.Text, out decimal1);
                t2 = decimal.TryParse(lblRoofPrice7.Text, out decimal2);
                if (t1 == true)
                {
                    costDecimal = decimal1 * decimal2;
                    c = costDecimal.ToString("0.00");
                    lblRoofCost7.Text = c.ToString();
                }
                else
                {
                    lblRoofQty7.ForeColor = Color.Red;
                    lblRoofCost7.Text = "0.00";
                    s4 = false;
                }
            }

            if (lblRoofQty8.Text == "")
            {
                lblRoofCost8.Text = "0.00";
            }
            else
            {
                t1 = decimal.TryParse(lblRoofQty8.Text, out decimal1);
                t2 = decimal.TryParse(lblRoofPrice8.Text, out decimal2);
                if (t1 == true)
                {
                    costDecimal = decimal1 * decimal2;
                    c = costDecimal.ToString("0.00");
                    lblRoofCost8.Text = c.ToString();
                }
                else
                {
                    lblRoofQty8.ForeColor = Color.Red;
                    lblRoofCost8.Text = "0.00";
                    s4 = false;
                }
            }

            //xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx


            if (lblOtherQty1.Text != "" || lblOtherPrice1.Text != "")
            {
                t1 = decimal.TryParse(lblOtherQty1.Text, out decimal1);
                t2 = decimal.TryParse(lblOtherPrice1.Text, out decimal2);
                if (t1 == true && t2 == true)
                {
                    costDecimal = decimal1 * decimal2;
                    c = costDecimal.ToString("0.00");
                    lblOtherCost1.Text = c.ToString();
                }
                else
                {
                    lblOtherQty1.ForeColor = Color.Red;
                    lblOtherPrice1.ForeColor = Color.Red;
                    lblOtherCost1.Text = "0.00";
                    s5 = false;
                }
            }

            if (lblOtherQty2.Text != "" || lblOtherPrice2.Text != "")
            {
                t1 = decimal.TryParse(lblOtherQty2.Text, out decimal1);
                t2 = decimal.TryParse(lblOtherPrice2.Text, out decimal2);
                if (t1 == true && t2 == true)
                {
                    costDecimal = decimal1 * decimal2;
                    c = costDecimal.ToString("0.00");
                    lblOtherCost2.Text = c.ToString();
                }
                else
                {
                    lblOtherQty2.ForeColor = Color.Red;
                    lblOtherPrice2.ForeColor = Color.Red;
                    lblOtherCost1.Text = "0.00";
                    s5 = false;
                }
            }

            if (lblOtherQty3.Text != "" || lblOtherPrice3.Text != "")
            {
                t1 = decimal.TryParse(lblOtherQty3.Text, out decimal1);
                t2 = decimal.TryParse(lblOtherPrice3.Text, out decimal2);
                if (t1 == true && t2 == true)
                {
                    costDecimal = decimal1 * decimal2;
                    c = costDecimal.ToString("0.00");
                    lblOtherCost3.Text = c.ToString();
                }
                else
                {
                    lblOtherQty3.ForeColor = Color.Red;
                    lblOtherPrice3.ForeColor = Color.Red;
                    lblOtherCost1.Text = "0.00";
                    s5 = false;
                }
            }

            if (lblOtherQty4.Text != "" || lblOtherPrice4.Text != "")
            {
                t1 = decimal.TryParse(lblOtherQty4.Text, out decimal1);
                t2 = decimal.TryParse(lblOtherPrice4.Text, out decimal2);
                if (t1 == true && t2 == true)
                {
                    costDecimal = decimal1 * decimal2;
                    c = costDecimal.ToString("0.00");
                    lblOtherCost4.Text = c.ToString();
                }
                else
                {
                    lblOtherQty4.ForeColor = Color.Red;
                    lblOtherPrice4.ForeColor = Color.Red;
                    lblOtherCost1.Text = "0.00";
                    s5 = false;
                }
            }

            if (lblOtherQty5.Text != "" || lblOtherPrice5.Text != "")
            {
                t1 = decimal.TryParse(lblOtherQty5.Text, out decimal1);
                t2 = decimal.TryParse(lblOtherPrice5.Text, out decimal2);
                if (t1 == true && t2 == true)
                {
                    costDecimal = decimal1 * decimal2;
                    c = costDecimal.ToString("0.00");
                    lblOtherCost5.Text = c.ToString();
                }
                else
                {
                    lblOtherQty5.ForeColor = Color.Red;
                    lblOtherPrice5.ForeColor = Color.Red;
                    lblOtherCost1.Text = "0.00";
                    s5 = false;
                }
            }

            if (lblOtherQty6.Text != "" || lblOtherPrice6.Text != "")
            {
                t1 = decimal.TryParse(lblOtherQty6.Text, out decimal1);
                t2 = decimal.TryParse(lblOtherPrice6.Text, out decimal2);
                if (t1 == true && t2 == true)
                {
                    costDecimal = decimal1 * decimal2;
                    c = costDecimal.ToString("0.00");
                    lblOtherCost6.Text = c.ToString();
                }
                else
                {
                    lblOtherQty6.ForeColor = Color.Red;
                    lblOtherPrice6.ForeColor = Color.Red;
                    lblOtherCost1.Text = "0.00";
                    s5 = false;
                }
            }

            if (lblOtherQty7.Text != "" || lblOtherPrice7.Text != "")
            {
                t1 = decimal.TryParse(lblOtherQty7.Text, out decimal1);
                t2 = decimal.TryParse(lblOtherPrice7.Text, out decimal2);
                if (t1 == true && t2 == true)
                {
                    costDecimal = decimal1 * decimal2;
                    c = costDecimal.ToString("0.00");
                    lblOtherCost7.Text = c.ToString();
                }
                else
                {
                    lblOtherQty7.ForeColor = Color.Red;
                    lblOtherPrice7.ForeColor = Color.Red;
                    lblOtherCost1.Text = "0.00";
                    s5 = false;
                }
            }

            if (lblOtherQty8.Text != "" || lblOtherPrice8.Text != "")
            {
                t1 = decimal.TryParse(lblOtherQty8.Text, out decimal1);
                t2 = decimal.TryParse(lblOtherPrice8.Text, out decimal2);
                if (t1 == true && t2 == true)
                {
                    costDecimal = decimal1 * decimal2;
                    c = costDecimal.ToString("0.00");
                    lblOtherCost8.Text = c.ToString();
                }
                else
                {
                    lblOtherQty8.ForeColor = Color.Red;
                    lblOtherPrice8.ForeColor = Color.Red;
                    lblOtherCost1.Text = "0.00";
                    s5 = false;
                }
            }

            if (lblOtherQty9.Text != "" || lblOtherPrice9.Text != "")
            {
                t1 = decimal.TryParse(lblOtherQty9.Text, out decimal1);
                t2 = decimal.TryParse(lblOtherPrice9.Text, out decimal2);
                if (t1 == true && t2 == true)
                {
                    costDecimal = decimal1 * decimal2;
                    c = costDecimal.ToString("0.00");
                    lblOtherCost9.Text = c.ToString();
                }
                else
                {
                    lblOtherQty9.ForeColor = Color.Red;
                    lblOtherPrice9.ForeColor = Color.Red;
                    lblOtherCost1.Text = "0.00";
                    s5 = false;
                }
            }

            if (lblOtherQty10.Text != "" || lblOtherPrice10.Text != "")
            {
                t1 = decimal.TryParse(lblOtherQty10.Text, out decimal1);
                t2 = decimal.TryParse(lblOtherPrice10.Text, out decimal2);
                if (t1 == true && t2 == true)
                {
                    costDecimal = decimal1 * decimal2;
                    c = costDecimal.ToString("0.00");
                    lblOtherCost10.Text = c.ToString();
                }
                else
                {
                    lblOtherQty10.ForeColor = Color.Red;
                    lblOtherPrice10.ForeColor = Color.Red;
                    lblOtherCost1.Text = "0.00";
                    s5 = false;
                }
            }


            if (flooringBtn.Checked == true)
            {
                if (s1 == false)
                {
                    lblEstimateTotal.Text = "error";
                    lblFlooringTotal.Text = "error";
                }
                else
                {
                    flooringTotal = decimal.Parse(lblFlooringCost1.Text) + decimal.Parse(lblFlooringCost2.Text) + decimal.Parse(lblFlooringCost3.Text) + decimal.Parse(lblFlooringCost4.Text);
                    grandTotal = grandTotal + flooringTotal;
                    lblFlooringTotal.Text = flooringTotal.ToString();
                }
            }

            if (wallsBtn.Checked == true)
            {
                if (s2 == false)
                {
                    lblEstimateTotal.Text = "error";
                    lblWallsTotal.Text = "error";
                }
                else
                {
                    wallsTotal = decimal.Parse(lblWallsCost1.Text) + decimal.Parse(lblWallsCost2.Text) + decimal.Parse(lblWallsCost3.Text) + decimal.Parse(lblWallsCost4.Text) + decimal.Parse(lblWallsCost5.Text) + decimal.Parse(lblWallsCost6.Text) + decimal.Parse(lblWallsCost7.Text) + decimal.Parse(lblWallsCost8.Text) + decimal.Parse(lblWallsCost9.Text) + decimal.Parse(lblWallsCost10.Text) + decimal.Parse(lblWallsCost11.Text);
                    grandTotal = grandTotal + wallsTotal;
                    lblWallsTotal.Text = wallsTotal.ToString();
                }
            }

            if (openingsBtn.Checked == true)
            {
                if (s3 == false)
                {
                    lblEstimateTotal.Text = "error";
                    lblOpeningsTotal.Text = "error";
                }
                else
                {
                    openingsTotal = decimal.Parse(lblOpeningsCost1.Text) + decimal.Parse(lblOpeningsCost2.Text);
                    grandTotal = grandTotal + openingsTotal;
                    lblOpeningsTotal.Text = openingsTotal.ToString();
                }
            }

            if (roofBtn.Checked == true)
            {
                if (s4 == false)
                {
                    lblEstimateTotal.Text = "error";
                    lblRoofTotal.Text = "error";
                }
                else
                {
                    roofTotal = decimal.Parse(lblRoofCost1.Text) + decimal.Parse(lblRoofCost2.Text) + decimal.Parse(lblRoofCost3.Text) + decimal.Parse(lblRoofCost4.Text) + decimal.Parse(lblRoofCost5.Text) + decimal.Parse(lblRoofCost6.Text) + decimal.Parse(lblRoofCost7.Text) + decimal.Parse(lblRoofCost8.Text);
                    grandTotal = grandTotal + roofTotal;
                    lblRoofTotal.Text = roofTotal.ToString();
                }
            }

            if (otherItemsBtn.Checked == true)
            {
                if (s5 == false)
                {
                    lblEstimateTotal.Text = "error";
                    lblOtherTotal.Text = "error";
                }
                else
                {
                    otherItemsTotal = decimal.Parse(lblOtherCost1.Text) + decimal.Parse(lblOtherCost2.Text) + decimal.Parse(lblOtherCost3.Text) + decimal.Parse(lblOtherCost4.Text) + decimal.Parse(lblOtherCost5.Text) + decimal.Parse(lblOtherCost6.Text) + decimal.Parse(lblOtherCost7.Text) + decimal.Parse(lblOtherCost8.Text) + decimal.Parse(lblOtherCost9.Text) + decimal.Parse(lblOtherCost10.Text);
                    grandTotal = grandTotal + otherItemsTotal;
                    lblOtherTotal.Text = otherItemsTotal.ToString();
                }
            }
            if (lblEstimateTotal.Text != "error")
            {
                    lblEstimateTotal.Text = grandTotal.ToString();
            }
        }

        //Resets the colors of all of the fields that changed color due to being an error.
        private void resetColors()
        {

            lblFlooringQty1.ForeColor = SystemColors.WindowText;
            lblFlooringQty2.ForeColor = SystemColors.WindowText;
            lblFlooringQty3.ForeColor = SystemColors.WindowText;
            lblFlooringQty4.ForeColor = SystemColors.WindowText;
            lblFlooringPrice1.ForeColor = SystemColors.WindowText;
            lblFlooringPrice2.ForeColor = SystemColors.WindowText;
            lblFlooringPrice3.ForeColor = SystemColors.WindowText;
            lblFlooringPrice4.ForeColor = SystemColors.WindowText;

            lblWallsQty1.ForeColor = SystemColors.WindowText;
            lblWallsQty2.ForeColor = SystemColors.WindowText;
            lblWallsQty3.ForeColor = SystemColors.WindowText;
            lblWallsQty4.ForeColor = SystemColors.WindowText;
            lblWallsQty5.ForeColor = SystemColors.WindowText;
            lblWallsQty6.ForeColor = SystemColors.WindowText;
            lblWallsQty7.ForeColor = SystemColors.WindowText;
            lblWallsQty8.ForeColor = SystemColors.WindowText;
            lblWallsQty9.ForeColor = SystemColors.WindowText;
            lblWallsQty10.ForeColor = SystemColors.WindowText;
            lblWallsQty11.ForeColor = SystemColors.WindowText;
            lblWallsPrice1.ForeColor = SystemColors.WindowText;
            lblWallsPrice2.ForeColor = SystemColors.WindowText;
            lblWallsPrice3.ForeColor = SystemColors.WindowText;
            lblWallsPrice4.ForeColor = SystemColors.WindowText;
            lblWallsPrice5.ForeColor = SystemColors.WindowText;
            lblWallsPrice6.ForeColor = SystemColors.WindowText;
            lblWallsPrice7.ForeColor = SystemColors.WindowText;
            lblWallsPrice8.ForeColor = SystemColors.WindowText;
            lblWallsPrice9.ForeColor = SystemColors.WindowText;
            lblWallsPrice10.ForeColor = SystemColors.WindowText;
            lblWallsPrice11.ForeColor = SystemColors.WindowText;

            lblOpeningsQty1.ForeColor = SystemColors.WindowText;
            lblOpeningsQty2.ForeColor = SystemColors.WindowText;
            lblOpeningsPrice1.ForeColor = SystemColors.WindowText;
            lblOpeningsPrice2.ForeColor = SystemColors.WindowText;

            lblRoofQty1.ForeColor = SystemColors.WindowText;
            lblRoofQty2.ForeColor = SystemColors.WindowText;
            lblRoofQty3.ForeColor = SystemColors.WindowText;
            lblRoofQty4.ForeColor = SystemColors.WindowText;
            lblRoofQty5.ForeColor = SystemColors.WindowText;
            lblRoofQty6.ForeColor = SystemColors.WindowText;
            lblRoofQty7.ForeColor = SystemColors.WindowText;
            lblRoofQty8.ForeColor = SystemColors.WindowText;
            lblRoofPrice1.ForeColor = SystemColors.WindowText;
            lblRoofPrice2.ForeColor = SystemColors.WindowText;
            lblRoofPrice3.ForeColor = SystemColors.WindowText;
            lblRoofPrice4.ForeColor = SystemColors.WindowText;
            lblRoofPrice5.ForeColor = SystemColors.WindowText;
            lblRoofPrice6.ForeColor = SystemColors.WindowText;
            lblRoofPrice7.ForeColor = SystemColors.WindowText;
            lblRoofPrice8.ForeColor = SystemColors.WindowText;

            lblOtherQty1.ForeColor = SystemColors.WindowText;
            lblOtherQty2.ForeColor = SystemColors.WindowText;
            lblOtherQty3.ForeColor = SystemColors.WindowText;
            lblOtherQty4.ForeColor = SystemColors.WindowText;
            lblOtherQty5.ForeColor = SystemColors.WindowText;
            lblOtherQty6.ForeColor = SystemColors.WindowText;
            lblOtherQty7.ForeColor = SystemColors.WindowText;
            lblOtherQty8.ForeColor = SystemColors.WindowText;
            lblOtherQty9.ForeColor = SystemColors.WindowText;
            lblOtherQty10.ForeColor = SystemColors.WindowText;
            lblOtherPrice1.ForeColor = SystemColors.WindowText;
            lblOtherPrice2.ForeColor = SystemColors.WindowText;
            lblOtherPrice3.ForeColor = SystemColors.WindowText;
            lblOtherPrice4.ForeColor = SystemColors.WindowText;
            lblOtherPrice5.ForeColor = SystemColors.WindowText;
            lblOtherPrice6.ForeColor = SystemColors.WindowText;
            lblOtherPrice7.ForeColor = SystemColors.WindowText;
            lblOtherPrice8.ForeColor = SystemColors.WindowText;
            lblOtherPrice9.ForeColor = SystemColors.WindowText;
            lblOtherPrice10.ForeColor = SystemColors.WindowText;

        }

        //Button to trigger the export button
        public void exportBtn_Click(object sender, EventArgs e)
        {
            //printThisScreen();
            saveThisInfo();
        }

        //Export section
        public void saveThisInfo()
        {

            if (lblEstimateTotal.Text != "error" && lblEstimateTotal.Text != "0.00")
            {
                // Folder, where a file is created.
                string folderRoot = @"C:\";
                string fileName = txtProjectName.Text;
                //DateTime today = DateTime.Today;
                string fileDate = DateTime.Now.ToString("yyyy-MM-dd");
                string fileType = ".csv";
                string fullPath = folderRoot + fileDate + "_" + fileName + fileType;
                string csvOutput = buildTheOutput();
                string[] stringArray = new string[] { csvOutput };
                try
                {
                    File.WriteAllLines(fullPath, stringArray);
                    // Do not initialize this variable here.
                    string readText = File.ReadAllText(fullPath);
                    string message = "Export successful\n\n" + fullPath;
                    string title = "Estimate Exported";
                    MessageBox.Show(message, title);
                }
                catch
                {

                    string message = "Exporting appears to be unavailable.";
                    string title = "Export Failure";
                    MessageBox.Show(message, title);
                }
                // Error: Use of unassigned local variable 'n'.
                //Console.WriteLine(readText);
                //Console.WriteLine(today);
            }
        }

        //Creating the data that will be a part of the export file
        public string buildTheOutput()
        {
            string mainString;
            mainString = generalInfoOutput();
            if (flooringBtn.Checked == true)
            {
                mainString = generalFlooringOutput(mainString);
            }
            if (wallsBtn.Checked == true)
            {
                mainString = generalWallsOutput(mainString);
            }
            if (openingsBtn.Checked == true)
            {
                mainString = generalOpeningsOutput(mainString);
            }
            if (roofBtn.Checked == true)
            {
                mainString = generalRoofOutput(mainString);
            }
            if (otherItemsBtn.Checked == true)
            {
                mainString = generalOtherItemsOutput(mainString);
            }

            mainString += "\n\n,,,,,,,Grand Total," + lblEstimateTotal.Text;
            return mainString;
        }

        //Adding the General info to the export file
        public string generalInfoOutput()
        {
            string temp;
            temp = "Project Name:," + txtProjectName.Text + "\nProject Manager:," + txtProjectManager.Text + "\nProject Address:," + txtProjectAddress.Text + "\nCity:," + textBox3.Text + ",State:," + listBox1.GetItemText(listBox1.SelectedItem);
            return temp;
        }

        //Adding the Flooring info to the export file
        public string generalFlooringOutput(string temp)
        {
            temp += "\n\n";
            temp += "Flooring,Item,Material,Size/Description,Quantity,Price,Cost\n";
            temp += "," + lblFlooringItem1.Text + "," + lblFlooringMaterial1.Text + "," + lblFlooringDesc1.Text + "," + lblFlooringQty1.Text + "," + lblFlooringPrice1.Text + "," + lblFlooringCost1.Text + "\n";
            temp += "," + lblFlooringItem2.Text + "," + lblFlooringMaterial2.Text + "," + lblFlooringDesc2.Text + "," + lblFlooringQty2.Text + "," + lblFlooringPrice2.Text + "," + lblFlooringCost2.Text + "\n";
            temp += "," + lblFlooringItem3.Text + "," + lblFlooringMaterial3.Text + "," + lblFlooringDesc3.Text + "," + lblFlooringQty3.Text + "," + lblFlooringPrice3.Text + "," + lblFlooringCost3.Text + "\n";
            temp += "," + lblFlooringItem4.Text + "," + lblFlooringMaterial4.Text + "," + lblFlooringDesc4.Text + "," + lblFlooringQty4.Text + "," + lblFlooringPrice4.Text + "," + lblFlooringCost4.Text + "\n";
            temp += ",,,,,,,Sub Total," + lblFlooringTotal.Text;
            return temp;
        }

        //Adding the Walls info to the export file
        public string generalWallsOutput(string temp)
        {
            temp += "\n\n";
            temp += "Walls,Item,Material,Size/Description,Quantity,Price,Cost\n";
            temp += "," + lblWallsItem1.Text + "," + lblWallsMaterial1.Text + "," + lblWallsDesc1.Text + "," + lblWallsQty1.Text + "," + lblWallsPrice1.Text + "," + lblWallsCost1.Text + "\n";
            temp += "," + lblWallsItem2.Text + "," + lblWallsMaterial2.Text + "," + lblWallsDesc2.Text + "," + lblWallsQty2.Text + "," + lblWallsPrice2.Text + "," + lblWallsCost2.Text + "\n";
            temp += "," + lblWallsItem3.Text + "," + lblWallsMaterial3.Text + "," + lblWallsDesc3.Text + "," + lblWallsQty3.Text + "," + lblWallsPrice3.Text + "," + lblWallsCost3.Text + "\n";
            temp += "," + lblWallsItem4.Text + "," + lblWallsMaterial4.Text + "," + lblWallsDesc4.Text + "," + lblWallsQty4.Text + "," + lblWallsPrice4.Text + "," + lblWallsCost4.Text + "\n";
            temp += "," + lblWallsItem5.Text + "," + lblWallsMaterial5.Text + "," + lblWallsDesc5.Text + "," + lblWallsQty5.Text + "," + lblWallsPrice5.Text + "," + lblWallsCost5.Text + "\n";
            temp += "," + lblWallsItem6.Text + "," + lblWallsMaterial6.Text + "," + lblWallsDesc6.Text + "," + lblWallsQty6.Text + "," + lblWallsPrice6.Text + "," + lblWallsCost6.Text + "\n";
            temp += "," + lblWallsItem7.Text + "," + lblWallsMaterial7.Text + "," + lblWallsDesc7.Text + "," + lblWallsQty7.Text + "," + lblWallsPrice7.Text + "," + lblWallsCost7.Text + "\n";
            temp += "," + lblWallsItem8.Text + "," + lblWallsMaterial8.Text + "," + lblWallsDesc8.Text + "," + lblWallsQty8.Text + "," + lblWallsPrice8.Text + "," + lblWallsCost8.Text + "\n";
            temp += "," + lblWallsItem9.Text + "," + lblWallsMaterial9.Text + "," + lblWallsDesc9.Text + "," + lblWallsQty9.Text + "," + lblWallsPrice9.Text + "," + lblWallsCost9.Text + "\n";
            temp += "," + lblWallsItem10.Text + "," + lblWallsMaterial10.Text + "," + lblWallsDesc10.Text + "," + lblWallsQty10.Text + "," + lblWallsPrice10.Text + "," + lblWallsCost10.Text + "\n";
            temp += "," + lblWallsItem11.Text + "," + lblWallsMaterial11.Text + "," + lblWallsDesc11.Text + "," + lblWallsQty11.Text + "," + lblWallsPrice11.Text + "," + lblWallsCost11.Text + "\n";
            temp += ",,,,,,,Sub Total," + lblWallsTotal.Text;
            return temp;
        }

        //Adding the Openings info to the export file
        public string generalOpeningsOutput(string temp)
        {
            temp += "\n\n";
            temp += "Openings,Item,Material,Size/Description,Quantity,Price,Cost\n";
            temp += "," + lblOpeningsItem1.Text + "," + lblOpeningsMaterial1.Text + "," + lblOpeningsDesc1.Text + "," + lblOpeningsQty1.Text + "," + lblOpeningsPrice1.Text + "," + lblOpeningsCost1.Text + "\n";
            temp += "," + lblOpeningsItem2.Text + "," + lblOpeningsMaterial2.Text + "," + lblOpeningsDesc2.Text + "," + lblOpeningsQty2.Text + "," + lblOpeningsPrice2.Text + "," + lblOpeningsCost2.Text + "\n";
            temp += ",,,,,,,Sub Total," + lblOpeningsTotal.Text;
            return temp;
        }

        //Adding the Roof info to the export file
        public string generalRoofOutput(string temp)
        {
            temp += "\n\n";
            temp += "Roof,Item,Material,Size/Description,Quantity,Price,Cost\n";
            temp += "," + lblRoofItem1.Text + "," + lblRoofMaterial1.Text + "," + lblRoofDesc1.Text + "," + lblRoofQty1.Text + "," + lblRoofPrice1.Text + "," + lblRoofCost1.Text + "\n";
            temp += "," + lblRoofItem2.Text + "," + lblRoofMaterial2.Text + "," + lblRoofDesc2.Text + "," + lblRoofQty2.Text + "," + lblRoofPrice2.Text + "," + lblRoofCost2.Text + "\n";
            temp += "," + lblRoofItem3.Text + "," + lblRoofMaterial3.Text + "," + lblRoofDesc3.Text + "," + lblRoofQty3.Text + "," + lblRoofPrice3.Text + "," + lblRoofCost3.Text + "\n";
            temp += "," + lblRoofItem4.Text + "," + lblRoofMaterial4.Text + "," + lblRoofDesc4.Text + "," + lblRoofQty4.Text + "," + lblRoofPrice4.Text + "," + lblRoofCost4.Text + "\n";
            temp += "," + lblRoofItem5.Text + "," + lblRoofMaterial5.Text + "," + lblRoofDesc5.Text + "," + lblRoofQty5.Text + "," + lblRoofPrice5.Text + "," + lblRoofCost5.Text + "\n";
            temp += "," + lblRoofItem6.Text + "," + lblRoofMaterial6.Text + "," + lblRoofDesc6.Text + "," + lblRoofQty6.Text + "," + lblRoofPrice6.Text + "," + lblRoofCost6.Text + "\n";
            temp += "," + lblRoofItem7.Text + "," + lblRoofMaterial7.Text + "," + lblRoofDesc7.Text + "," + lblRoofQty7.Text + "," + lblRoofPrice7.Text + "," + lblRoofCost7.Text + "\n";
            temp += "," + lblRoofItem8.Text + "," + lblRoofMaterial8.Text + "," + lblRoofDesc8.Text + "," + lblRoofQty8.Text + "," + lblRoofPrice8.Text + "," + lblRoofCost8.Text + "\n";
            temp += ",,,,,,,Sub Total," + lblRoofTotal.Text;
            return temp;
        }

        //Adding the Other Items info to the export file
        public string generalOtherItemsOutput(string temp)
        {
            temp += "\n\n";
            temp += "Other Items,Item,Material,Size/Description,Quantity,Price,Cost\n";
            temp += "," + lblOtherItem1.Text + "," + lblOtherMaterial1.Text + "," + lblOtherDesc1.Text + "," + lblOtherQty1.Text + "," + lblOtherPrice1.Text + "," + lblOtherCost1.Text + "\n";
            temp += "," + lblOtherItem2.Text + "," + lblOtherMaterial2.Text + "," + lblOtherDesc2.Text + "," + lblOtherQty2.Text + "," + lblOtherPrice2.Text + "," + lblOtherCost2.Text + "\n";
            temp += "," + lblOtherItem3.Text + "," + lblOtherMaterial3.Text + "," + lblOtherDesc3.Text + "," + lblOtherQty3.Text + "," + lblOtherPrice3.Text + "," + lblOtherCost3.Text + "\n";
            temp += "," + lblOtherItem4.Text + "," + lblOtherMaterial4.Text + "," + lblOtherDesc4.Text + "," + lblOtherQty4.Text + "," + lblOtherPrice4.Text + "," + lblOtherCost4.Text + "\n";
            temp += "," + lblOtherItem5.Text + "," + lblOtherMaterial5.Text + "," + lblOtherDesc5.Text + "," + lblOtherQty5.Text + "," + lblOtherPrice5.Text + "," + lblOtherCost5.Text + "\n";
            temp += "," + lblOtherItem6.Text + "," + lblOtherMaterial6.Text + "," + lblOtherDesc6.Text + "," + lblOtherQty6.Text + "," + lblOtherPrice6.Text + "," + lblOtherCost6.Text + "\n";
            temp += "," + lblOtherItem7.Text + "," + lblOtherMaterial7.Text + "," + lblOtherDesc7.Text + "," + lblOtherQty7.Text + "," + lblOtherPrice7.Text + "," + lblOtherCost7.Text + "\n";
            temp += "," + lblOtherItem8.Text + "," + lblOtherMaterial8.Text + "," + lblOtherDesc8.Text + "," + lblOtherQty8.Text + "," + lblOtherPrice8.Text + "," + lblOtherCost8.Text + "\n";
            temp += "," + lblOtherItem9.Text + "," + lblOtherMaterial9.Text + "," + lblOtherDesc9.Text + "," + lblOtherQty9.Text + "," + lblOtherPrice9.Text + "," + lblOtherCost9.Text + "\n";
            temp += "," + lblOtherItem10.Text + "," + lblOtherMaterial10.Text + "," + lblOtherDesc10.Text + "," + lblOtherQty10.Text + "," + lblOtherPrice10.Text + "," + lblOtherCost10.Text + "\n";
            temp += ",,,,,,,Sub Total," + lblOtherTotal.Text;
            return temp;
        }

        //Clear all button to start a new estimate
        public void clearAll()
        {
            listCategory.SelectedItem = "General";
            flooringBtn.Checked = false;
            wallsBtn.Checked = false;
            openingsBtn.Checked = false;
            roofBtn.Checked = false;
            otherItemsBtn.Checked = false;
            updateBtn_Click(null, null);
            lblEstimateTotal.Text = "0.00";

            txtProjectName.Text = "";
            txtProjectManager.Text = "";
            txtProjectAddress.Text = "";
            textBox3.Text = "";
            listBox1.SelectedItem = "AL";

            lblFlooringQty1.Text = "";
            lblFlooringQty2.Text = "";
            lblFlooringQty3.Text = "";
            lblFlooringQty4.Text = "";

            lblWallsQty1.Text = "";
            lblWallsQty2.Text = "";
            lblWallsQty3.Text = "";
            lblWallsQty4.Text = "";
            lblWallsQty5.Text = "";
            lblWallsQty6.Text = "";
            lblWallsQty7.Text = "";
            lblWallsQty8.Text = "";
            lblWallsQty9.Text = "";
            lblWallsQty10.Text = "";
            lblWallsQty11.Text = "";

            lblOpeningsQty1.Text = "";
            lblOpeningsQty2.Text = "";

            lblRoofQty1.Text = "";
            lblRoofQty2.Text = "";
            lblRoofQty3.Text = "";
            lblRoofQty4.Text = "";
            lblRoofQty5.Text = "";
            lblRoofQty6.Text = "";
            lblRoofQty7.Text = "";
            lblRoofQty8.Text = "";

            lblOtherItem1.Text = "";
            lblOtherMaterial1.Text = "";
            lblOtherDesc1.Text = "";
            lblOtherQty1.Text = "";
            lblOtherPrice1.Text = "";
            lblOtherCost1.Text = "";
            lblOtherItem2.Text = "";
            lblOtherMaterial2.Text = "";
            lblOtherDesc2.Text = "";
            lblOtherQty2.Text = "";
            lblOtherPrice2.Text = "";
            lblOtherCost2.Text = "";
            lblOtherItem3.Text = "";
            lblOtherMaterial3.Text = "";
            lblOtherDesc3.Text = "";
            lblOtherQty3.Text = "";
            lblOtherPrice3.Text = "";
            lblOtherCost3.Text = "";
            lblOtherItem4.Text = "";
            lblOtherMaterial4.Text = "";
            lblOtherDesc4.Text = "";
            lblOtherQty4.Text = "";
            lblOtherPrice4.Text = "";
            lblOtherCost4.Text = "";
            lblOtherItem5.Text = "";
            lblOtherMaterial5.Text = "";
            lblOtherDesc5.Text = "";
            lblOtherQty5.Text = "";
            lblOtherPrice5.Text = "";
            lblOtherCost5.Text = "";
            lblOtherItem6.Text = "";
            lblOtherMaterial6.Text = "";
            lblOtherDesc6.Text = "";
            lblOtherQty6.Text = "";
            lblOtherPrice6.Text = "";
            lblOtherCost6.Text = "";
            lblOtherItem7.Text = "";
            lblOtherMaterial7.Text = "";
            lblOtherDesc7.Text = "";
            lblOtherQty7.Text = "";
            lblOtherPrice7.Text = "";
            lblOtherCost7.Text = "";
            lblOtherItem8.Text = "";
            lblOtherMaterial8.Text = "";
            lblOtherDesc8.Text = "";
            lblOtherQty8.Text = "";
            lblOtherPrice8.Text = "";
            lblOtherCost8.Text = "";
            lblOtherItem9.Text = "";
            lblOtherMaterial9.Text = "";
            lblOtherDesc9.Text = "";
            lblOtherQty9.Text = "";
            lblOtherPrice9.Text = "";
            lblOtherCost9.Text = "";
            lblOtherItem10.Text = "";
            lblOtherMaterial10.Text = "";
            lblOtherDesc10.Text = "";
            lblOtherQty10.Text = "";
            lblOtherPrice10.Text = "";
            lblOtherCost10.Text = "";
        }



        //Future use
        public void printThisScreen()
        {
            PrintDocument printDocument1 = new PrintDocument();
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            CaptureScreen();
            printDocument1.Print();
        }

        //Future Use
        private void CaptureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
        }

        //Future Use
        private void printDocument1_PrintPage(Object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }

        //Triggers the New Estimate Commands
        private void newBtn_Click(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}

