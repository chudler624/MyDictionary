namespace MyDictionary
{
    public class WordInfoResults
    {

        public List<> data { get; set; }
        public string definition { get; set; }

        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class Pronunciation
        {
            public string all { get; set; }
        }

        public class Result
        {
            public string definition { get; set; }
            public string partOfSpeech { get; set; }
            public List<string> synonyms { get; set; }
            public List<string> typeOf { get; set; }
            public List<string> hasTypes { get; set; }
            public List<string> also { get; set; }
            public List<string> derivation { get; set; }
            public List<string> hasMembers { get; set; }
            public List<string> examples { get; set; }
            public List<string> partOf { get; set; }
            public List<string> hasSubstances { get; set; }
        }

        public class Root
        {
            public string word { get; set; }
            public List<Result> results { get; set; }
            public Syllables syllables { get; set; }
            public Pronunciation pronunciation { get; set; }
            public double frequency { get; set; }
        }

        public class Syllables
        {
            public int count { get; set; }
            public List<string> list { get; set; }
        }


    }
}
