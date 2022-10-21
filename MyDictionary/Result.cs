namespace MyDictionary
{
    public partial class WordInfoResults
    {
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


    }
}
