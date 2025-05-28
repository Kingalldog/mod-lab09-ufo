namespace mod_lab09_ufo;
using System.Drawing;

public partial class Form1 : Form
{
    private Bitmap drawingBitmap;
    private Graphics graphics;
    public Form1()
    {
        InitializeComponent();

        this.Text = "Line Drawing Example";
        this.ClientSize = new Size(800, 600);
        this.BackColor = Color.White;

        // Создаем Bitmap для рисования
        drawingBitmap = new Bitmap(this.ClientSize.Width, this.ClientSize.Height);
        graphics = Graphics.FromImage(drawingBitmap);
        graphics.Clear(Color.White);

        graphics.ScaleTransform(0.5f, 0.5f);

    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        // Отображаем Bitmap на форме
        e.Graphics.DrawImage(drawingBitmap, 0, 0);
    }

    private double mySin(double x, int n)
    {
        double res = 0;
        double xx = x;
        int fact = 1;
        int now = 1;

        for (int i = 0; i < n; i++)
        {
            res += (i % 2 == 0 ? 1 : -1) * xx / fact;
            xx *= x * x;
            fact *= (now + 1) * (now + 2);
            now += 2;
        }

        return res;
    }

    private double myCos(double x, int n)
    {
        double res = 0;
        double xx = 1;
        double fact = 1;
        int now = 0;

        for (int i = 0; i < n; i++)
        {
            res += (i % 2 == 0 ? 1 : -1) * xx / fact;
            xx *= x * x;
            fact *= (now + 1) * (now + 2);
            now += 2;
        }

        return res;
    }
    private void Line(int x1, int y1, int x2, int y2)
    {
        double k = (double)(y2 - y1) / (x2 - x1);
        double b = y1 - k * x1;
        for (int x = x1; x <= x2; x++)
            DrawPoint(x, (int)Math.Round(k * x + b), Color.Black);

    }

    private double Line2(int x1, int y1, int x2, int y2, int n, int step)
    {
        double angle = Math.Atan((double)(y2 - y1) / (double)(x2 - x1));

        double x = x1;
        double y = y1;
        double distance = (Math.Abs(x - x2)) * (Math.Abs(x - x2)) + Math.Abs(y - y2) * Math.Abs(y - y2);
        double value = 1;
        while (x < x2)
        {
            distance = (Math.Abs(x - x2)) * (Math.Abs(x - x2)) + Math.Abs(y - y2) * Math.Abs(y - y2);
            x += ((double)step * myCos(angle, n));
            y += ((double)step * mySin(angle, n));
            DrawPoint((int)x, (int)y, Color.Red);
            
        }

        return Math.Sqrt(distance);
    }

    private void DrawPoint(int x, int y, Color color)
    {
        // Проверяем, чтобы точка была в пределах Bitmap
        if (x >= 0 && x < drawingBitmap.Width && y >= 0 && y < drawingBitmap.Height)
        {
            drawingBitmap.SetPixel(x, y, color);
        }

        // Перерисовываем форму
        this.Invalidate();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
        int x1 = int.Parse(boxX1.Text);
        int y1 = int.Parse(boxY1.Text);
        int x2 = int.Parse(boxX2.Text);
        int y2 = int.Parse(boxY2.Text);

        if (x1 > x2)
        {
            var t1 = x1; x1 = x2; x2 = t1;
            var t2 = y1; y1 = y2; y2 = t2;
        }

        Line(x1, y1, x2, y2);
    }

    private void button2_Click(object sender, EventArgs e)
    {
        int x1 = int.Parse(boxX1.Text);
        int y1 = int.Parse(boxY1.Text);
        int x2 = int.Parse(boxX2.Text);
        int y2 = int.Parse(boxY2.Text);

        if (x1 > x2)
        {
            var t1 = x1; x1 = x2; x2 = t1;
            var t2 = y1; y1 = y2; y2 = t2;
        }

        Line2(x1, y1, x2, y2, 1, 10);
    }

    private void button3_Click(object sender, EventArgs e)
    {
        try
        {
            int x1 = 100; int y1 = 100;
            int x2 = 5000; int y2 = 6000;
            int step = 1;
            StreamWriter sw = new StreamWriter("../../../result/data.txt");
            textBox1.Text = "OPEN";

            for (int i = 1; i < 18; i++)
            {
                textBox1.Text = i.ToString();
                double err = Line2(x1, y1, x2, y2, i, step);
                sw.WriteLine(i + " " + err);
            }
            sw.Close();
        }
        catch (Exception o)
        {
            Console.WriteLine("Exception: " + o.Message);
        }
        finally
        {
            Console.WriteLine("Executing finally block.");
        }

    }
}
