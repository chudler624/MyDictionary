using MyDictionary.Models;
using Newtonsoft.Json;

namespace MyDictionary.Services.DictionaryApiService
{
    public class DictionaryApi
    {
        public DictionaryApi() { }

        public List<WordInfoModel> GetWordInfo(string word)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://wordsapiv1.p.rapidapi.com/words/{word}"),
                Headers =
                {
                    { "X-RapidAPI-Key", "fe96c29976msh7164fa7f072bef1p19efc6jsn0ad83cbe2bb2" },
                    { "X-RapidAPI-Host", "wordsapiv1.p.rapidapi.com" },
                },
            };

            using (var response = client.SendAsync(request).Result)
            {
                response.EnsureSuccessStatusCode();
                var body = response.Content.ReadAsStringAsync().Result;

                var wordInfo = JsonConvert.DeserializeObject<WordInfoResults>(body);

                

                var wordModels = new List<WordInfoModel>();
                
                foreach (var item in wordInfo.results)
                {
                   

                    wordModels.Add(new WordInfoModel
                    {
                        Definition = item.definition,
                        PartOfSpeech = item.partOfSpeech,
                        Examples = item.examples,
                        Word = wordInfo.word

                    });


                }

                return wordModels;

            }

            

        }

    }
}
