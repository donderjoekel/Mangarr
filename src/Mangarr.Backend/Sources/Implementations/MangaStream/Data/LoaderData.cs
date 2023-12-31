namespace Mangarr.Backend.Sources.Implementations.MangaStream.Data;

public class LoaderData
{
    public class Source
    {
        public string source { get; set; }
        public string[] images { get; set; }
    }

    public Source[] sources { get; set; }
}
