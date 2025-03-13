public class Document
{
    public string Title { get; set; } = string.Empty; // Initialize to avoid null warnings
    public string Category { get; set; } = string.Empty;
    public DateTime UploadDate { get; set; }
    public string FileName { get; set; } = string.Empty;
}
