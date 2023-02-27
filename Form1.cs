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



namespace Materials_List_Estimation
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();

        }


        private void Form1_Load(object sender, EventArgs e)
        {

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

            listCategory.SelectedItem = "General";

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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
                    otherItemsTotal = decimal.Parse(lblOtherCost1.Text) + decimal.Parse(lblOpeningsCost2.Text) + decimal.Parse(lblOtherCost3.Text) + decimal.Parse(lblOtherCost4.Text) + decimal.Parse(lblOtherCost5.Text) + decimal.Parse(lblOtherCost6.Text) + decimal.Parse(lblOtherCost7.Text) + decimal.Parse(lblOtherCost8.Text) + decimal.Parse(lblOtherCost9.Text) + decimal.Parse(lblOtherCost10.Text);
                    grandTotal = grandTotal + otherItemsTotal;
                    lblOtherTotal.Text = otherItemsTotal.ToString();
                }
            }

             lblEstimateTotal.Text = grandTotal.ToString();
        }

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

        private void exportBtn_Click(object sender, EventArgs e)
        {
            //before your loop
            var csv = new StringBuilder();

            //in your loop
            var first = lblFlooringItem1.Text.ToString();
            var second = lblFlooringMaterial1.Text.ToString();
            var third = lblFlooringDesc1.Text.ToString();
            var forth = lblFlooringQty1.Text.ToString();
            var fifth = lblFlooringPrice1.Text.ToString();
            var sixth = lblFlooringCost1.Text.ToString();
            //Suggestion made by KyleMit

            //redirect_output("test_csv_file.txt");
            Console.WriteLine("1,2,3,4,5,6,6,7,test,file");
            //redirect_output(false);

            var newLine = string.Format("{0},{1},{2},{3},{4},{5}", first, second, third, forth, fifth, sixth);
            csv.AppendLine(newLine);

            //after your loop
            //string path = "C:\Users\lakef\OneDrive\Desktop";
            //File.WriteAllText(path, csv.ToString());
        }
    }
}
