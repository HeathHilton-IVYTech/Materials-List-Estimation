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
            groupBoxFlooring.Size = new Size(0, 0);
            groupBoxWalls.Size = new Size(0, 0);
            groupBoxOpenings.Size = new Size(0, 0);
            groupBoxRoof.Size = new Size(0, 0);
            groupBoxOtherItems.Size = new Size(0, 0);

            groupBoxFlooring.Location = new Point(159, 112);
            groupBoxWalls.Location = new Point(159, 112);
            groupBoxOpenings.Location = new Point(159, 112);
            groupBoxRoof.Location = new Point(159, 112);
            groupBoxOtherItems.Location = new Point(159, 112);

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            String text = listCategory.SelectedItems[0].ToString();
            //Console.WriteLine(text);

            switch (text)
            {
                case "Flooring":
                    Console.WriteLine("Flooring");
                    groupBoxFlooring.Size = new Size(399, 318);
                    groupBoxWalls.Size = new Size(0, 0);
                    groupBoxOpenings.Size = new Size(0, 0);
                    groupBoxRoof.Size = new Size(0, 0);
                    groupBoxOtherItems.Size = new Size(0, 0);
                    break;
                case "Walls":
                    Console.WriteLine("Walls");
                    groupBoxFlooring.Size = new Size(0, 0);
                    groupBoxWalls.Size = new Size(399, 318);
                    groupBoxOpenings.Size = new Size(0, 0);
                    groupBoxRoof.Size = new Size(0, 0);
                    groupBoxOtherItems.Size = new Size(0, 0);
                    break;
                case "Openings":
                    Console.WriteLine("Openings");
                    groupBoxFlooring.Size = new Size(0, 0);
                    groupBoxWalls.Size = new Size(0, 0);
                    groupBoxOpenings.Size = new Size(399, 318);
                    groupBoxRoof.Size = new Size(0, 0);
                    groupBoxOtherItems.Size = new Size(0, 0);
                    break;
                case "Roof":
                    Console.WriteLine("Roof");
                    groupBoxFlooring.Size = new Size(0, 0);
                    groupBoxWalls.Size = new Size(0, 0);
                    groupBoxOpenings.Size = new Size(0, 0);
                    groupBoxRoof.Size = new Size(399, 318);
                    groupBoxOtherItems.Size = new Size(0, 0);
                    break;
                case "Other Items":
                    Console.WriteLine("Other Items");
                    groupBoxFlooring.Size = new Size(0, 0);
                    groupBoxWalls.Size = new Size(0, 0);
                    groupBoxOpenings.Size = new Size(0, 0);
                    groupBoxRoof.Size = new Size(0, 0);
                    groupBoxOtherItems.Size = new Size(399, 318);
                    break;

            }
        }
    }
}
