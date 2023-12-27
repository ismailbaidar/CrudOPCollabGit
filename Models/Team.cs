namespace CrudOPCollabGit.Models
{
    public class Team
    {
        int Id {  get; set; }
        string Name { get; set; }
        string LeagueName {  get; set; } 
        List<Player> Players { get; set; }
        List<Coach> Coach {  get; set; } 
    }
}
