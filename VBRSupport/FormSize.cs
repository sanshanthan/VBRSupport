using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VBRSupport;


public static class FormSize
{
    static FormSize()
    { }
    public static int Width(string tag)
    {
        int treeWidth = Convert.ToInt32(Singleton<Tree>.Instance.Width.ToString());
        int screenWidth = Screen.PrimaryScreen.WorkingArea.Width;

        switch (tag)
        {
            case "Main":
                return screenWidth;
            case "Tree":
                return 230;
            case "FullSize":
                return screenWidth - treeWidth-5;
            default:
                return 0;
        }
    }

    public static int Heigth(string tag)
    {
        int screenHeight = Screen.PrimaryScreen.WorkingArea.Height;
        switch (tag)
        {
            case "Main":
                return screenHeight;
            case "Tree":
                return screenHeight - 30;
            case "FullSize":
                return screenHeight - 10;
            default:
                return 0;
        }
    }
}

