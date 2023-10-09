namespace JSONi18n.MASA.Shared.Models;

public class NavItem
{
    public NavItem( ) { }

    public NavItem(string name , string icon , string href)
    {
        Name = name;
        Icon = icon;
        Href = href;
    }
    public string Name;
    public string Icon;
    public string Href;

}
