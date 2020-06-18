using System.Collections.Generic;
using System.Windows.Forms;

class Stage : Form
{
    private List<PictureBox> pictureBoxBalls = new List<PictureBox>();
    private List<Ball> balls = new List<Ball>();
    private Ball ball;
    private object e;
    string path;
    private readonly Timer timer = new Timer();

    public Ball Ball { get; }

    public static void Main()
    {
        Application.Run(new Stage());
    }
    public Stage()
    {

        Width = 1200;
        Height = 800;
        Text = "Freddie Mercury";



        timer.Interval = 1;
        timer.Tick += Timer_Tick;
        timer.Start();

        this.MouseClick += Stage_MouseClick;
    }
    private void Stage_MouseClick(object sender, MouseEventArgs e)
    {
        path = "images\\freddie.jpg";
        Ball ball = new Ball(e.X - 25, e.Y - 25, path);
        balls.Add(ball);

        PictureBox pictureBoxBall = new PictureBox();

        pictureBoxBall.Width = 500;
        pictureBoxBall.Height = 500;
        pictureBoxBall.Left = (int)ball.XPos;
        pictureBoxBall.Top = ball.YPos;
        pictureBoxBall.Image = ball.Img;0
        pictureBoxBall.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBoxBall.Parent = this;

        timer.Interval = 1;
        timer.Tick += Timer_Tick;
        timer.Start();
    }
    private void Timer_Tick(object sender, System.EventArgs e)
    {
        ball.Move();

        pictureBoxBall.Left = (int)ball.XPos;
        pictureBoxBall.Top = ball.YPos;


    }
}