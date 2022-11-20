using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace WordGenerator
{
    public class WordGenerator
    {
        private List<string> words = new List<string>();
        static readonly HttpClient client = new HttpClient();
        public string[] GetWords()
        {
            LoadWordList();
            //LoadWordsFromStream();
            //LoadWordsFromFileUsingFile();
            //LoadwordsFromWeb();

            return words.ToArray();
        }
        private void LoadWordList()
        {
            words.Add("airplane");
            words.Add("gypsy");
            words.Add("abruptly");
            words.Add("helicopter");
            words.Add("layrnx");

        }

        private void LoadWordsFromStream()
        {
            string path = "words.txt";
            using (var fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                using (var sr = new StreamReader(fs))
                {
                    var line = string.Empty;
                    while ((line = sr.ReadLine()) != null)
                    {
                        words.Add(line);
                    }
                }
            }
        }
        private void GetWordsFromFileUsingFile(string url)
        {
            string path = "words.txt";
            var lines = File.ReadLines(path);
            foreach (var line in lines)
            {
                words.Add(line);
            }
        }

        private void LoadWordsFromWeb()
        {
            var path = "C:\\exports\\WebWords.txt";
            if (!File.Exists(path))
            {
                GenerateWordFile();
            }
        }
        public void GenerateWordFile()
        {
            var allwords = new List<string>();
            var path = "WebWords.txt";
            if (!File.Exists(path))
            {
                for (int i = 6; i <= 6; i++)
                {
                    var query = $@"https://random-word-api.herokuapp.com/word?length={i}&number=10";
                    var nextList = GetWordsFromWeb(query);
                    //put those words in a text file
                    //...

                    allwords.AddRange(nextList);
                }
            }
            File.WriteAllLines(path, allwords);

        }
        static async Task<List<string>> GetAsync(string url)
        {
            using HttpResponseMessage response = await client.GetAsync(url);
            var jsonResponse = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<List<string>>(jsonResponse);
        }

        private List<string> GetWordsFromWeb(string url)
        {
            var theWords = Task.Run(async () => await GetAsync(url)).Result;
            return theWords;
        }

    }
}