using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace MIAPR1
{
    public partial class Form1 : Form
    {
        int classAmount;
        int objectsAmount;
        List<Point> points = new List<Point>();
        readonly Color[] colors = { Color.Black, Color.Red, Color.Yellow, Color.Pink, Color.Blue, Color.Coral, Color.Bisque, Color.Olive, Color.Navy, Color.Peru, Color.Purple,
            Color.Silver, Color.Teal, Color.Aquamarine, Color.Brown, Color.BurlyWood, Color.Cyan, Color.Crimson, Color.DarkGoldenrod, Color.Lavender, Color.Lime
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            points.Clear();
            objectsAmount = Int32.Parse(ObjectsTextBox.Text);
            classAmount = Int32.Parse(ClassesTextBox.Text);

            if (objectsAmount >= 1000 && objectsAmount <= 100000)
            {
                if (classAmount >= 2 && classAmount <= 20)
                {
                    Initialize();
                    MainTask();
                    DrawObjects();
                    while(!Step());
                    DrawObjects();
                }
            }
        }

        public void Initialize()
        {
            for (int i = 0; i < objectsAmount; i++)
            {
                Random r = new Random();
                int x = r.Next(pictureBox1.Width);
                int y = r.Next(pictureBox1.Height);
                    
                if (i < classAmount)
                {
                    points.Add(new Point(x, y, Color.Black));
                    points[i].isCenter = true;
                    points[i].claster = i;
                }
                else
                {
                    points.Add(new Point(x, y, colors[r.Next(colors.Length)]));
                    points[i].isCenter = false;
                }
            }
        }

        public void MainTask()
        {
            for (int i = classAmount; i < objectsAmount; i++)
            {
                points[i].distance = 0;
                for (int j = 0; j < classAmount; j++)
                {
                    double distance = Math.Sqrt(Math.Pow(points[j].x - points[i].x, 2) + Math.Pow(points[j].y - points[i].y, 2));
                    if (distance < points[i].distance || points[i].distance == 0)
                    {
                        points[i].distance = distance;
                        points[i].claster = j;
                    }
                }
            }
        }

        public bool Step()
        {
            bool isEnd = true;
            for (int j = 0; j < classAmount; j++)
            {
                List<int> clasterX = new List<int>();
                List<int> clasterY = new List<int>();
                for (int i = 0; i < objectsAmount; i++)
                {
                    if (points[i].claster == j)
                    {
                        clasterX.Add(points[i].x);
                        clasterY.Add(points[i].y);
                    }
                }
                if ((points[j].x != GetAverage(clasterX)) && (points[j].y != GetAverage(clasterY)))
                {
                    isEnd = false;
                    points[j].x = GetAverage(clasterX);
                    points[j].y = GetAverage(clasterY);
                }
            }
            MainTask();
            return isEnd;
        }

        public int GetAverage(List<int> arr)
        {
            int sum = 0;
            foreach (var curr in arr)
            {
                sum += curr;
            }
            int average = sum / arr.Count;
            return average;
        }

        public void DrawObjects()
        {
            PictureBox buff = pictureBox1;
            Graphics g = buff.CreateGraphics();
            g.Clear(Color.White);
            foreach(var curr in points)
            {
                int isCenter = curr.isCenter ? 0 : 1;
                SolidBrush myBrush = new SolidBrush(colors[(curr.claster + 1) * isCenter]);
                g.FillRectangle(myBrush, curr.x, curr.y, 7 - isCenter * 5, 7 - isCenter * 5);
            }
        }
    }
}