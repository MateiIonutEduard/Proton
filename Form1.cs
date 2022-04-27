using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;
using Proton.Services;
using Proton.Models;
using Proton.Data;
using System.Net.Http;
#pragma warning disable

namespace Proton
{
    public partial class Form1 : Form
    {
        Point lastPos = Point.Empty;
        SearchModel searchModel;
        Movie[] list;
        int page;
        int count;
        bool find;

        public Form1()
        {
            find = false;
            InitializeComponent(); 
            page = 1;
            count = 1;
        }

        private void bunifuCustomLabel3_MouseHover(object sender, EventArgs e)
        {
            close.ForeColor = Color.FromArgb(217, 83, 79);
        }

        private void close_MouseLeave(object sender, EventArgs e)
        {
            close.ForeColor = Color.FromArgb(41, 43, 44);
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void bunifuCustomLabel3_MouseHover_1(object sender, EventArgs e)
        {
            min.ForeColor = Color.FromArgb(91, 192, 222);
        }

        private void min_MouseLeave(object sender, EventArgs e)
        {
            min.ForeColor = Color.FromArgb(247, 247, 247);
        }

        private void genres_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = genres.SelectedIndex;
            if (index >= 0)
            {
                bunifuCustomLabel5.Focus();
                genres.SelectedIndex = -1;
            }
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            if (!find)
            {
                bunifuCustomLabel3.Text = "Home / Movies";
                try
                {
                    var genres = await GenreService.AllGenresAsync();
                    if (genres == null) Close();

                    foreach (var genre in genres)
                        this.genres.Items.Add(genre.name);

                    list = await MovieService.PopularMoviesAsync();
                    movies.DataSource = Array.ConvertAll<Movie, MovieView>(list, m => (MovieView)m);

                    current.Text = page.ToString();
                    lastPos = current.Location;

                    last.Visible = false;
                    next.Visible = false;

                    current.Location = next.Location;
                    pageUp.Visible = false;
                }
                catch(HttpRequestException)
                { 
                    if (MessageBox.Show("Something is wrong with the host.", "Proton") == DialogResult.OK)
                        this.Close();
                }
            }
            else
            {
                page = 1;
                count = 1;
            }
        }

        private void ResetPages()
        {
            if(lastPos != Point.Empty)
            {
                current.Location = lastPos;

                last.Visible = true;
                next.Visible = true;

                pageUp.Visible = true;
                pageDown.Visible = true;
            }

            if(count == 1)
            {
                lastPos = current.Location;

                last.Visible = false;
                next.Visible = false;

                current.Location = next.Location;
                pageUp.Visible = false;
            }
            else
            {
                if(page > 1 && page <= count - 1)
                {
                    last.Text = (page - 1).ToString();
                    current.Text = page.ToString();
                    next.Text = (page + 1).ToString();
                }
                else
                if(page > 1 && page == count)
                {
                    pageDown.Visible = false;
                    next.Visible = false;

                    lastPos = current.Location;
                    last.Text = (page - 1).ToString();
                    current.Text = page.ToString();
                }
                else if(page == 1)
                {
                    current.Text = page.ToString();
                    lastPos = current.Location;

                    last.Visible = false;
                    next.Visible = false;

                    current.Location = next.Location;
                    pageUp.Visible = false;
                }
            }
        }

        private async void SearchClick(object sender, EventArgs e)
        {
            string title = name.Text;
            var list = GetSelectedGenres();
            bunifuCustomLabel3.Text = "Movies / Results";

            if (!string.IsNullOrEmpty(title) || list.Count > 0)
            {
                // search by title or by genres...
                this.searchModel = new SearchModel
                {
                    title = title,
                    genres = list.ToArray()
                };

                try
                {
                    var listModel = await MovieService.FindMoviesAsync(searchModel);
                    this.list = listModel.movies;
                    page = 1;

                    count = listModel.pages.Value;
                    current.Text = page.ToString();
                    ResetPages();

                    var views = Array.ConvertAll<Movie, MovieView>(this.list,
                            m => (MovieView)m);

                    for (int j = 0; j < views.Length; j++)
                    {
                        var bmp = await MovieService.GetCaptureAsync(this.list[j].Info.image_url);
                        Color color = Color.FromArgb(119, 99, 173);
                        views[j].Capture = MovieView.Scale(bmp, color);
                    }

                    movies.DataSource = views;
                }
                catch(HttpRequestException)
                {
                    if (MessageBox.Show("The application is not configured correctly or the server is not running!", "Proton") == DialogResult.OK)
                        this.Close();
                }
            }
        }

        private List<string> GetSelectedGenres()
        {
            var array = genres.Items;
            var list = new List<string>();

            for(int j = 0; j < array.Count; j++)
            {
                if(genres.GetItemChecked(j))
                {
                    var genre = array[j].ToString();
                    list.Add(genre);
                }
            }

            return list;
        }

        private async void pageDown_ClickAsync(object sender, EventArgs e)
        {
            if (page < count)
            {
                if(searchModel != null)
                {
                    var listModel = await MovieService.FindMoviesByPageAsync(page, searchModel);
                    this.list = listModel.movies;
                    page++;

                    current.Text = page.ToString();
                    ResetPages();

                    var views = Array.ConvertAll<Movie, MovieView>(this.list,
                            m => (MovieView)m);

                    for (int j = 0; j < views.Length; j++)
                    {
                        var bmp = await MovieService.GetCaptureAsync(this.list[j].Info.image_url);
                        Color color = Color.FromArgb(119, 99, 173);
                        views[j].Capture = MovieView.Scale(bmp, color);
                    }

                    movies.DataSource = views;
                }
            }

            current.Text = page.ToString();

        }

        private async void pageUp_Click(object sender, EventArgs e)
        {
            if(page > 1)
            {
                if (searchModel != null)
                {
                    var listModel = await MovieService.FindMoviesByPageAsync(page, searchModel);
                    this.list = listModel.movies;
                    page--;

                    current.Text = page.ToString();
                    ResetPages();

                    var views = Array.ConvertAll<Movie, MovieView>(this.list,
                            m => (MovieView)m);

                    for (int j = 0; j < views.Length; j++)
                    {
                        var bmp = await MovieService.GetCaptureAsync(this.list[j].Info.image_url);
                        Color color = Color.FromArgb(119, 99, 173);
                        views[j].Capture = MovieView.Scale(bmp, color);
                    }

                    movies.DataSource = views;
                }
            }

            current.Text = page.ToString();
        }

        private void movies_DoubleClick(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in movies.Rows)
            {
                if (row.Selected)
                {
                    var watch = new WatchMovie();
                    var movie = list[row.Index];
                    row.Selected = false;
                    watch.SetMovie(movie.Id);
                    watch.ShowDialog();
                }
            }
        }
    }
}
