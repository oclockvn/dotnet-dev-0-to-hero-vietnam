namespace SearchRepo;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    struct Repo
    {
        string Name { get; set; }
        string Url { get; set; }
        string Description { get; set; }
        string CreatedAt { get; set; }
        int Star { get; set; }
        int Watch { get; set; }
        int Fork { get; set; }
    }

    public class GithubResponse
    {
        public List<RepoResponse> items { get; set; }
    }

    public class RepoResponse
    {
        int id { get; set; }
        string full_name { get; set; } = null!;
        string url { get; set; } = null!;
        string description { get; set; } = null!;
        string createdat { get; set; } = null!;
        RepoOwner owner { get; set; }
        int open_issues { get; set; }
        int stargazers_count { get; set; }
    }

    public class RepoOwner
    {
        string login { get; set; } = null!;
    }

    public class GithubService
    {
        public List<Repo> SearchRepositories(string query)
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.124 Safari/537.36 Edg/91.0.864.59");

            string url = $"https://api.github.com/search/repositories?q={query}";

            var response = client.GetAsync(url).Result;
            var repos = new List<Repo>();

            if (response.StatusCode == System.Net.HttpStatusCode.OK) 
            {
                string content = response.Content.ReadAsStringAsync().Result;

                var r = System.Text.Json.JsonSerializer.Deserialize<GithubResponse>(content);

                foreach (var x in r.items)
                {
                    repos.Add(new Repo()
                    {

                    });
                }
            }
            return repos;
        }
    }
}
