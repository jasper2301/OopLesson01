using System;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;

class Ball
{
    public double XPos { get; set; }
    public double Xpos { get; }
    public double Ypos { get; set; }

    public Image Img { get; set; }
    public int YPos { get; internal set; }

    private readonly double moveX;
    private readonly double moveY;
    private object rnd;

    //public Ball()
    //{
    //    XPos = 0;
    //    Ypos = 0;
    //    Img = Image.FromFile(@"images\freddie.jpg");

    //    moveX = 5;
    //    moveY = 5;
    //}
    public Ball(int v, double xp, double yp) {
        Xpos = xp;
        Ypos = yp;
        Img = Image.FromFile(@"images\freddie.jpg");

        moveX += 5;
        moveY += 5;

        Console.WriteLine("X = {0}, Y = {1}", (int)moveX, (int)moveY);
    }
    public void Move()
    {
        XPos += moveX;
        Ypos += moveY;

        if ((Ypos > 800 - 100) || Ypos < 0)
            NewMethod();
        if ((Xpos > 1200 - 70) || Xpos < 0)
        {
            moveX = -moveX;
        }
        Console.WriteLine("Xpos = {0}, Ypos = {1}", (int)Xpos, (int)Ypos);
    }














































        ;private void NewMethod()
    {
        moveY = -moveY;
    }
}
