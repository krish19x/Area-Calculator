using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Area_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ValueBox.Items.AddRange(new string[]{"Square", "Rectangle","Parallelogram", "Circle", "Semi-Circle","Ellipse","Trapezium"});
        }

        
        private void ValueBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            lengthLbl.Visible = true;
            lengthbox.Visible = true;
            widthLbl.Visible = true;
            widhtbox.Visible = true;
            Heightlbl.Visible = true;
            HeightBox.Visible = true;
            lengthbox.Text = "";
            widhtbox.Text = "";
            HeightBox.Text = "";

            string Length = "Length";
            string Width = "Width";
            string radius = "Radius";
            switch (ValueBox.Text)
            {
                default:
                    break;
                case "Square":
                    {
                        widthLbl.Visible = false;
                        widhtbox.Visible = false;
                        Heightlbl.Visible = false;
                        lengthLbl.Text = "Side";
                        HeightBox.Visible = false;
                        break;
                    }
                case "Rectangle":
                    {
                        widthLbl.Visible = true;
                        widhtbox.Visible = true;
                        widthLbl.Text = Width;
                        lengthLbl.Text = Length;
                        Heightlbl.Visible = false;
                        HeightBox.Visible = false;
                        break;
                    }
                case "Parallelogram":
                    {
                        widthLbl.Visible = true;
                        widhtbox.Visible = true;
                        widthLbl.Text = "Height";
                        lengthLbl.Text = "Length";
                        Heightlbl.Visible = false;
                        HeightBox.Visible = false;
                        break;
                    }
                case "Circle":
                case "Semi-Circle":
                    {
                        widthLbl.Visible = false;
                        widhtbox.Visible = false;
                        HeightBox.Visible = false;
                        Heightlbl.Visible = false;
                        lengthLbl.Text = radius;
                        break;
                    }
                case "Ellipse":
                    {
                        lengthLbl.Text = "Major Radius";
                        widthLbl.Text = "Minor Radius";
                        HeightBox.Visible = false;
                        Heightlbl.Visible = false;
                        break;
                    }
                case "Trapezium":
                    {
                        lengthLbl.Text = "Side1";
                        widthLbl.Text = "Side2";
                        Heightlbl.Text = "Heights";
                        break;
                    }

            }
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            double Length = 1, Width = 1, Height = 1;
            if (lengthbox.Text != "")
                Length = Convert.ToDouble(lengthbox.Text);
            if (widhtbox.Text != "")
                Width = Convert.ToDouble(widhtbox.Text);
            if(HeightBox.Text != "")
                Height = Convert.ToDouble(HeightBox.Text);
            switch (ValueBox.Text)
            {
                default:
                    break;
                case "Square":
                    label1.Text = (Length * Length).ToString();
                    label4.Text = (4 * Length).ToString();
                    break;
                case "Rectangle":
                case "Parallelogram":
                    label1.Text = (Length * Width).ToString();
                    label4.Text = (2 * (Length + Width)).ToString();
                    break;
                case "Circle":
                    label1.Text = (Length * Length * Math.PI).ToString();
                    label4.Text = (2 * Math.PI * Length).ToString();
                    break;
                case "Semi-Circle":
                    label1.Text = ((Length * Length * Math.PI) / 2).ToString();
                    label4.Text = ((Length * Math.PI) + (Length * 2)).ToString();
                    break;
                case "Ellipse":
                        label1.Text = (Length * Width * Math.PI).ToString();
                        label4.Text = "No Formula";
                        break;
                case "Trapezium":
                    label4.Text = "No Formula";
                    label1.Text = (((Length + Width)/2)*Height).ToString();
                    break;

            }
            //ValueBox.Items.AddRange(new string[] { "Square", "Rectangle", "Parallelogram", "Circle", "Semi-Circle", "Ellipse", "Trapezium" });
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
