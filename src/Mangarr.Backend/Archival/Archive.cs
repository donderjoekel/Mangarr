namespace Mangarr.Backend.Archival;

public class Archive
{
    public byte[] Data { get; }
    public string Extension { get; }

    public Archive(byte[] data, string extension)
    {
        Data = data;
        Extension = extension;
    }
}
