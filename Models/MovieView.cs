using System;
using System.IO;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using Proton.Data;
using Bunifu.Framework.UI;
using System.ComponentModel;
using Proton.Services;
using System.Windows.Forms;
#pragma warning disable

namespace Proton.Models
{
    public class MovieView
    {
        [Browsable(false)]
        public string Id { get; set; }
        public Bitmap Capture { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public int Rank { get; set; }

        public Bitmap Watch { get; set; }

        public static explicit operator MovieView(Movie movie)
        {
            var view = new MovieView
            {
                Id = movie.Id,
                Title = movie.Title,
                Year = movie.Year,
                Rank = movie.Info.Rank
            };

            var resx = new ResourceManager("Proton.Resources", typeof(Proton.Resources).Assembly);

            if (string.IsNullOrEmpty(movie.Info.image_url))
            {
                var capture = resx.GetObject("cinema");
                view.Capture = (Bitmap)capture;
            }

            var eye = resx.GetObject("eye_small");
            Color color = Color.Transparent;
            view.Watch = Scale((Bitmap)eye, color, 32, 32);

            return view;
        }

        public static Bitmap Scale(Bitmap bmp, Color color, int w = 64, int h = 64)
        {
            Bitmap result = new Bitmap(w, h);

            using (Graphics g = Graphics.FromImage(result))
            {
                g.Clear(color);
                g.DrawImage(bmp, 0, 0, w, h);
            }

            return result;
        }
    }
}
