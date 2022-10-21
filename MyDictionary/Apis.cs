using MyDictionary.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MyDictionary
{
    public class Apis
    {
        public Apis() { }

        public async List<WordInfoModel> GetWordInfo(string word)
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
				var wordInfo = JArray.Parse(body)["results"];
				var wordInfoResults = JsonConvert.DeserializeObject<WordInfoResults>(body);

				List<WordInfoModel> wordInformation = new List<WordInfoModel>();
				var resultData = wordInfoResults;

				foreach(var item in wordInfo)
                {
					var wordInfoModel = new WordInfoModel();
					wordInfoModel.Definition = (string)item["definition"];
					wordInfoModel.PartOfSpeech = (string)item["partOfSpeech"];
					wordInfoModel.Synonyms= item["sysonyms"]
				
					


				return List<WordInfoModel>;
			}

		}


    }
}
