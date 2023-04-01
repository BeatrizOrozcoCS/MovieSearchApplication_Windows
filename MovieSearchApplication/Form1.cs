
using System.Net.Http.Headers;

using System.Text.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

//using Newtonsoft.Json.Ling;

namespace MovieSearchApplication
{ 
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //clear the list boxes
            btnClear_Click(sender, e);
            //get the api responses
            string searchTerm = txtSearchTerm.Text;
            int page = 1;
            const int RESULT_PER_PAGE = 10;
            const int PAGE_LIMIT = 15;
            HttpClient client = new HttpClient();
            string url = "https://www.omdbapi.com/?s=" + searchTerm + "&apikey=71ac85d0&page=" + page.ToString();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.BaseAddress = new Uri(url);
            HttpResponseMessage response = client.GetAsync(url).Result;
               

            string jsonString =  response.Content.ReadAsStringAsync().Result;
            Result? result = JsonSerializer.Deserialize<Result>(jsonString);

            Movies.movieList.Clear();

            if (result.Response == "True")
            {
                txtPageNum.Text = page.ToString();
                int totalResults = int.Parse(result?.totalResults);//get the total results based on the keyword search

                if (totalResults % RESULT_PER_PAGE == 0) //figure ou the amount of pages. its 10 results per api page
                {
                    page = totalResults / RESULT_PER_PAGE; //10 being the r
                }
                else
                {
                    page = totalResults / RESULT_PER_PAGE + 1;
                }
               
                txtTotalResults.Text = totalResults.ToString();


                //get the first page
                foreach (Movie movie in result?.Search)
                {
                    lstName.Items.Add(movie?.Title);
                    lstType.Items.Add(movie?.Type);
                    lstImdbID.Items.Add(movie?.imdbID);
                    lstYear.Items.Add(movie?.Year);
                    Movies.movieList.Add(movie?.Title + "\t" + movie?.Year + "\t" + movie?.Type + "\t" + movie?.imdbID);
                }

                //get the remaining results

                for (int i = 2; i <= page; i++)
                {
                    txtPageNum.Text = i.ToString() +"/"+page.ToString();
                    client = new HttpClient();
                    url = "https://www.omdbapi.com/?s=" + searchTerm + "&apikey=71ac85d0&page=" + i.ToString();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    client.BaseAddress = new Uri(url);
                    response = client.GetAsync(url).Result;
                    jsonString = response.Content.ReadAsStringAsync().Result;
                    result = JsonSerializer.Deserialize<Result>(jsonString);
                    foreach (Movie movie in result?.Search)
                    {
                        if (i< PAGE_LIMIT)
                        {
                            lstName.Items.Add(movie?.Title);
                            lstType.Items.Add(movie?.Type);
                            lstImdbID.Items.Add(movie?.imdbID);
                            lstYear.Items.Add(movie?.Year);
                        }
                        Movies.movieList.Add(movie?.Title + "\t" + movie?.Year + "\t" + movie?.Type + "\t" + movie?.imdbID);

                    }

                }
            }
            else
            {
                MessageBox.Show("Movie Search Term did not release any results");
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstImdbID.Items.Clear();
            lstYear.Items.Clear();
            lstName.Items.Clear();
            lstType.Items.Clear();
            txtPageNum.Text = "";
            txtTotalResults.Text = "";
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            //save file dialog here and check for valdiation
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //streamwriter
                StreamWriter outputFile;
                outputFile = File.CreateText(saveFileDialog1.FileName);
                string line = "";

                //write contents of list items to file
                for (int i = 0; i < Movies.movieList.Count; i++)
                {
                    line = Movies.movieList[i];
                    outputFile.WriteLine(line);
                }
                //closefile
                outputFile.Close();

            }
        }


    }
    public class Result
    {
        //public Dictionary<string, Movie>? Search{ get; set; }
        //public string? Search { get; set; }
        public IList<Movie>? Search { get; set; }
        public string? totalResults { get; set; }
        public string? Response { get; set; }
    }
    public class Movie
    {
        public string? Title { get; set; }
        public string? Year { get; set; }
        public string? imdbID { get; set; }
        public string? Type { get; set; }
        public string? Poster { get; set; }
    }
    static class Movies
    {
        public static List<string> movieList = new List<string>();
    }
}
