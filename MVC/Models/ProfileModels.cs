namespace MVC.Models
{
    public class ProfileModel
    {
        required public string Name { get; set;}
        required public string School { get; set; }
        required public string Program { get; set; }
        required public string Address { get; set; }
        required public string[] Skills { get; set; }

    }
}
