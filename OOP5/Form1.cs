using OOP5.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            hoverButton1.gallery.Add(new HoverButton.Pik4a(Resources.svin, "svin"));
            hoverButton1.gallery.Add(new HoverButton.Pik4a(Resources.chel, "chel"));
            hoverButton1.gallery.Add(new HoverButton.Pik4a(Resources.tigr, "tigr"));
            hoverButton1.gallery.Add(new HoverButton.Pik4a(Resources.shrek, "shrek"));
            hoverButton1.gallery.Add(new HoverButton.Pik4a(Resources.lev, "lev"));
            hoverButton1.gallery.Add(new HoverButton.Pik4a(Resources.shrek2, "shrek2"));
            hoverButton1.gallery.Add(new HoverButton.Pik4a(Resources.kot, "kot"));

            hoverButtonRound1.gallery.Add(new HoverButton.Pik4a(Resources.svin, "svin"));
            hoverButtonRound1.gallery.Add(new HoverButton.Pik4a(Resources.chel, "chel"));
            hoverButtonRound1.gallery.Add(new HoverButton.Pik4a(Resources.tigr, "tigr"));
            hoverButtonRound1.gallery.Add(new HoverButton.Pik4a(Resources.shrek, "shrek"));
            hoverButtonRound1.gallery.Add(new HoverButton.Pik4a(Resources.lev, "lev"));
            hoverButtonRound1.gallery.Add(new HoverButton.Pik4a(Resources.shrek2, "shrek2"));
            hoverButtonRound1.gallery.Add(new HoverButton.Pik4a(Resources.kot, "kot"));


        }
    }
}
