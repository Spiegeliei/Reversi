using System;
using System.Drawing;
using System.Windows.Forms;

class Scherm : Form
{
    private ComboBox BordGrootte;
    private Panel Panel;
    private Label Label;

    public Scherm()
    {
        Text = "reversie piemeltje";
        Size = new Size(500, 600);

        Label = new Label();
        Label.Text = "Kies bordgrootte:";
        Label.Location = new Point(20, 20);
        Controls.Add(Label);

        BordGrootte = new ComboBox();
        BordGrootte.Items.AddRange(new object[] { "4x4", "6x6", "8x8", "10x10" });
        BordGrootte.SelectedIndex = 1; // Standaard: 6x6
        BordGrootte.Location = new Point(150, 20);
        Controls.Add(BordGrootte);

        Panel = new Panel();
        Panel.Location = new Point(20, 60);
        Panel.Size = new Size(400, 400);
        Panel.BorderStyle = BorderStyle.FixedSingle;
        Controls.Add(Panel);
    }
}

class Program
{
    public static void Main()
    {
        Application.Run(new Scherm());
    }
}
