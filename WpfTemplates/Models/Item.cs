namespace WpfTemplates.Models;

public class Item
{
    public string Title { get; set; }
    public string Text { get; set; }

    public Item(string title, string text)
    {
        Title = title;
        Text = text;
    }

}
