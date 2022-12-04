namespace Zad_6_Strategy_Template;


public partial class Form1 : Form
{
    private Mucha[] ar = new Mucha[30];

    public Form1()
    {
        InitializeComponent();
        this.Size = new Size(640, 480);
        this.Muchy();
    }

    public void Muchy()
    {
        ar = new Mucha[30];
        for (int i = 0; i < ar.Length; ++i)
        {
            ar[i] = new Mucha();
        }
    }

    public void paintComponent(Graphics g)
    {
        for (int i = 0; i < ar.Length; ++i)
            ar[i].draw(g);
    }

    private void Form1_Paint(object sender, PaintEventArgs e)
    {
        while (true)
        {
            for (int i = 0; i < ar.Length; ++i)
            {
                ar[i].move();
            }
            for (int i = 0; i < ar.Length; ++i)
                ar[i].draw(e.Graphics);
            try
            {
                Thread.Sleep(20);
            }
            catch (Exception ex) { Console.WriteLine(ex.StackTrace); }
        }
    }
}
