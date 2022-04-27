using Proton.Data;
using Proton.Models;
using Proton.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
#pragma warning disable

namespace Proton
{
    public partial class WatchMovie : Form
    {
        private Movie movie;
        private string id;
        public WatchMovie()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void close_MouseLeave(object sender, EventArgs e)
        {
            close.ForeColor = Color.FromArgb(41, 43, 44);
        }

        private void close_MouseHover(object sender, EventArgs e)
        {
            close.ForeColor = Color.FromArgb(217, 83, 79);
        }

        private void min_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void min_MouseHover(object sender, EventArgs e)
        {
            min.ForeColor = Color.FromArgb(91, 192, 222);
        }

        private void min_MouseLeave(object sender, EventArgs e)
        {
            min.ForeColor = Color.FromArgb(247, 247, 247);
        }

        private void ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void SetMovie(string id)
        { this.id = id; }

        private async void WatchMovie_LoadAsync(object sender, EventArgs e)
        {
            movie = await MovieService.GetMovieAsync(id);

            title.Text = movie.Title;
            year.Text = movie.Year.ToString();

            var bmp = await MovieService.GetCaptureAsync(movie.Info.image_url, false);
            Color color = Color.FromArgb(176, 206, 249);
            box.BackgroundImage = MovieView.Scale(bmp, color, 120, 120);

            if (!string.IsNullOrEmpty(movie.Info.plot))
            {
                about.Clear();
                about.AppendText(movie.Info.plot);
            }

            var stars = movie.Info.rating;

            if (stars > 0)
                rating.Text = stars.ToString("0.#");
            else
            {
                header.Text = "duration:";
                rating.Text = "Unknown";

                if (movie.Info.running_time_secs != null)
                    rating.Text = movie.Info.running_time_secs.Value.ToString();
            }

            genres.Text = string.Join(", ", movie.Info.genres);
            bool dir = movie.Info.directors?.Length > 0;
            bool act = movie.Info.actors?.Length > 0;

            if(movie.Info.directors != null && movie.Info.directors.Length > 0)
            {
                foreach (var item in movie.Info.directors)
                    directors.Items.Add($"* {item}");
            }

            if (movie.Info.actors != null && movie.Info.actors.Length > 0)
            {
                foreach (var item in movie.Info.actors)
                    actors.Items.Add($"* {item}");
            }

            if(!dir)
            {
                bunifuCustomLabel5.Visible = false;
                directors.Visible = false;
            }

            if (!act)
            {
                bunifuCustomLabel11.Visible = false;
                actors.Visible = false;
            }

            if (!dir && !act)
                panel10.Visible = false;
        }
    }
}
