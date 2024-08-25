using System.Diagnostics;
using System.Text.Json;

public class Faction
{
    public string Name { get; set; }
    public string Influence { get; set; }
    public List<string> Equipment { get; set; }
    public string Talent { get; set; }
    public int Solars { get; set; }
    public List<string> DefaultAdvances { get; set; }
    public string DefaultStatBonus { get; set; }
    public List<string> DefaultStatBonusChoice { get; set; }
    public List<string> DefaultEquipmentChoice { get; set; }
    public List<string> DefaultAugmeticChoice { get; set; }
    public List<string> DefaultTalents { get; set; }
    public string PersonalContact { get; set; }
    public int OptionalSolars { get; set; }
    public List<Duty> Duties { get; set; }

    public Faction()
    {
    }

    public static Faction Deserialize()
    {
        string json = File.ReadAllText("data/factions.json");
        return JsonSerializer.Deserialize<Faction>(json);
    }
}

public class FactionList //this really feels wonky
{
    public List<Faction> Factions { get; set; }
    public FactionList()
    {
    }

    public FactionList Deserialize()
    {
        //string filename = "C:\\dev\\charcreator\\AdMunitorum\\AdMunitorum\\data\\Factions.json";
        string cwd = Directory.GetCurrentDirectory();
        string dataDir = Path.Combine(cwd, "..\\..\\..\\data");
        string filename = Path.Combine(dataDir, "Factions.json");
        string json = File.ReadAllText(filename);//actually tho, make this a relative path
        FactionList? factionList = JsonSerializer.Deserialize<FactionList>(json);
        return factionList;
    }
}

public class Duty
{
    public string Name { get; set; }
    public string Description { get; set; }
    public List<string> Advances { get; set; }
    public List<string> StatBonuses { get; set; }
    public List<string> Equipment { get; set; }
    public List<string> Augmetics { get; set; }
    public List<string> Talents { get; set; }
    public int Solars { get; set; }
}

