using System;
using System.Timers;

class DvdScreenSaver
{
    int x;
    int y;

    int oldX;
    int oldY;

    bool Right;
    bool Down;

    Timer fpsTimer;

    string icon;
    string clear;


    public DvdScreenSaver(int startX, int startY, string icon, float interval)
    {
        x = startX;
        y = startY;
        this.icon = icon;

        Right = true;
        Down = true;

        SetupGrid();

        fpsTimer = new Timer(interval);
        fpsTimer.Elapsed += MoveDvd;
        fpsTimer.AutoReset = true;
        fpsTimer.Enabled = true;

        for (int i = 0; i < icon.Length; i++)
        {
            clear += "-";
        }
    }

    public void MoveDvd(object source, ElapsedEventArgs e)
    {
        GetNewPosition();
        Console.SetCursorPosition(oldX, oldY);
        Console.Write(clear);
        Console.SetCursorPosition(x, y);
        oldX = x;
        oldY = y;
        Console.Write(icon);
    }

    private void GetNewPosition()
    {
        // Check X out of bounds
        if(x <= 0 || x >= Console.WindowWidth - (icon.Length - 1))
            Right = !Right;

        // Check y out of bounds
        if (y <= 0 || y >= Console.WindowHeight-1)
            Down = !Down;


        // Move x
        if (Right)
            x++;
        else
            x--;

        // Move y
        if (Down)
            y++;
        else
            y--;
    }

    public void SetupGrid()
    {
        int width = Console.WindowWidth;
        int height = Console.WindowHeight;

        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                Console.Write("-");
            }
        }
    }
}
