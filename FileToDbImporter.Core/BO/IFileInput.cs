namespace FileToDbImporter.Core.BO
{
    public interface IFileInput
    {
        public string FileName { get; set; }
        public string Extension { get; set; }

        public string MimeType { get; set; }

        public float Size { get; set; }

    }
}