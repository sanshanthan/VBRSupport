using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public static class Config
{
    static Config()
    {
        VBR4000Connection = "Data Source=.;Initial Catalog=VBR;Integrated Security=True";
    }

    public static string VBR4000Connection { get; set; }
}

