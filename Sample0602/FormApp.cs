using System;
using System.Drawing;
using System.Windows.Forms;

class FormmApp
{
    static Form form;
    static Label labelRedSignal;
    static Label labelYellowSignal;
    static Label labelBlueSignal;

    public static void Main()
    {
        form = new Form();

        form.Text = "フォームアプリケーション";
        form.Width = 400;
        form.Height = 200;

        labelRedSignal = new Label();
        labelRedSignal.Width = 100;
        labelRedSignal.Height = 100;
        labelRedSignal.BackColor = Color.Red;
        labelRedSignal.Parent = form;

        labelYellowSignal = new Label();
        labelYellowSignal.Width = 100;
        labelYellowSignal.Height = 100;
        labelYellowSignal.BackColor = Color.Red;
        labelYellowSignal.Parent = form;

        labelBlueSignal = new Label();
        labelBlueSignal.Width = 100;
        labelBlueSignal.Height = 100;
        labelBlueSignal.BackColor = Color.Red;
        labelBlueSignal.Parent = form;

        Button buttonpush = new Button();
        buttonpush.Text = "押す";
        buttonpush.Top = 150;
        buttonpush.Left = 250;

        buttonpush.Width = 100;
        buttonpush.Height = 50;

        buttonpush.Parent = form;
        buttonpush.Click += ButtonPush_Click;

    }

    private static void ButtonPush_Click(object sender, EventArgs e)
    {
        labelRedSignal
        if(StatusBar = 0)
        {

        }else if(StatusBar = 1)
        {

        }
        else
        {

        }

        if(labelRedSignal.BackColor = Color.Red)
    }
}
