namespace MSLearnBlazorApp
{
    /// <summary>
    /// Item for task tracked in Todo component
    /// </summary>
    public class TodoItem
    {
        public string? Title { get; set; }
        public bool IsDone { get; set; } = false;
    }
}
