namespace TerminalRPGEncounter.Models
{
    public interface IHaveStats
    {
    
        string Name { get; set; }
        int Strength { get; set; }
        int Dexterity { get; set; }
        string GetInfo();
    
    }
}