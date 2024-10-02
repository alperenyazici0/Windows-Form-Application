//**********************************************************************
//**                                                                  **
//**             STUDENT NAME: ALPEREN YAZICI                         **
//**             STUDENT NUMBER: B221202019                           **
//**********************************************************************


using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace proje1
{
    public partial class Form1 : Form
    {
        private Polygon polygon;
        private List<PointF> edgepoints; // List to store edge points

        public Form1()
        {
            InitializeComponent(); // Initializing default values
            txt_centerX.Text = "0";
            txt_centerY.Text = "0";
            txt_length.Text = "4";
            txt_edgeNumber.Text = "5";
            txt_rotation.Text = "30";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) // For button click to generate random values
        {
            Random rand = new Random();
            txt_centerX.Text = rand.Next(0, 4).ToString();  //Assign random values between selected numbers
            txt_centerY.Text = rand.Next(0, 4).ToString();
            txt_length.Text = rand.Next(3, 10).ToString();
            txt_edgeNumber.Text = rand.Next(3, 11).ToString();
            txt_rotation.Text = rand.Next(0, 360).ToString();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_edgeNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_length_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_rotation_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_draw_Click(object sender, EventArgs e) // For draw button click
        {
            try
            {
                Point2D center = new Point2D(Convert.ToDouble(txt_centerX.Text), Convert.ToDouble(txt_centerY.Text));
                double length = Convert.ToDouble(txt_length.Text); // Get side length
                int numberOfEdges = Convert.ToInt32(txt_edgeNumber.Text); // Get number of edges
                length *= 15; // This is an operation for bigger polygon

                polygon = new Polygon(center, length, numberOfEdges); // Create new polygon
               

                edgepoints = new List<PointF>();
                var corner = polygon.calculateEdgeCoordinates(); // Calculate edge coordinates
                foreach (var vertex in corner)
                {
                    edgepoints.Add(new PointF((float)vertex.x, (float)vertex.y));
                }

                listBox1.Items.Clear();
                foreach (var point in edgepoints)
                {
                    listBox1.Items.Add("(" + point.X + "," + point.Y + ")"); // Add points to list box
                }
                if (polygon!=null)
                {
                    double currentRotation = Convert.ToDouble(txt_rotation.Text); // Get the currrent rotate angle
                    txt_rotation.Text = currentRotation.ToString(); 
                }
                pictureBox1.Refresh();    // Refresh the picture box to redraw polygon        
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); // Show error message if something goes wrong
            }
        }

        private void btn_rotate_Click(object sender, EventArgs e)
        {
            try
            {
                if (polygon == null)
                {
                    MessageBox.Show("Please draw the polygon."); // Show message if no polygon is drawn
                    return;
                    
                }

                double angle = Convert.ToDouble(txt_rotation.Text); // Get the rotation angle
                polygon.rotatePolygon(angle); // Rotate the polygon

                edgepoints = new List<PointF>();
                var corners = polygon.calculateEdgeCoordinates(); // Calculate new edge points
                foreach (var vertex in corners)
                {
                    edgepoints.Add(new PointF((float)vertex.x, (float)vertex.y));
                }

                listBox1.Items.Clear();
                foreach (var point in edgepoints)
                {
                    listBox1.Items.Add("(" + point.X + "," + point.Y + ")"); // Add new edge points to list
                }
                txt_rotation.Text = Convert.ToString(angle);

                pictureBox1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txt_centerX_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (polygon != null)
            {
                Graphics g = e.Graphics;
                List<PointF> points = new List<PointF>();

                // Get the edge coordinates of polygon
                var corners = polygon.calculateEdgeCoordinates();
                foreach (var vertex in corners)
                {
                    // Draw based on the middle of PictureBox
                    points.Add(new PointF((float)(vertex.x + pictureBox1.Width / 2), (float)(vertex.y + pictureBox1.Height / 2)));
                }

                // Draw the polygon
                if (points.Count > 1)
                {
                    g.DrawPolygon(Pens.Black, points.ToArray());
                }
            }
        }
    }
}
