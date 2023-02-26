using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            } else
            {
                String text = listCategory.SelectedItems[0].ToString();
                if (text == "Flooring") {
                    listCategory.SelectedIndex = 0;
                }
                listCategory.Items.Remove("Flooring");
            }
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
        }
    }
}
