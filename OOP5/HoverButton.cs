using OOP5.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP5
{
    class HoverButton : Button
    {
        private Color color = Color.SkyBlue;

        public struct Pik4a
        {
            public Bitmap bitmap;
            public string name;
            public Pik4a(Bitmap img, string nam)
            {
                bitmap = img;
                name = nam;
            }
            
        }

        public List<Pik4a> gallery = new List<Pik4a>();
        private int pictureIndex = 0;

        public HoverButton() : base()
        {
            BackColor = Color.Black;
            ForeColor = Color.White;
            Font = new Font("Microsoft YaHei UI",
             20.25F,
             FontStyle.Bold,
             GraphicsUnit.Point,
             0);
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            
            Image = gallery[pictureIndex].bitmap;
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            
            Text = "❣ Здесь изображен " + gallery[pictureIndex].name + " ♥";
            
            color = Color.Blue;
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            Text = "";
            color = Color.SkyBlue;
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            
            if (pictureIndex == gallery.Count - 1)
            {
                pictureIndex = 0;
                
            }
            else
            {
                pictureIndex++;
            }
            Text = "❣ Здесь изображен " + gallery[pictureIndex].name + " ♥";
            Invalidate();
        }
    }
}
