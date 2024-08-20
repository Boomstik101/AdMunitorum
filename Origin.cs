using System.Diagnostics;
using System.Text.Json;
public class Origin
{
    public string Name { get; set; }
    public string StatBonuses { get; set; }
    public List<string> Choice { get; set; }
    public string Description { get; set; }
    public string Item { get; set; }
    public List<string> Example { get; set; }
    public string SelectedChoice { get; set; }

    public Origin()
    {
        Debug.WriteLine("Did this happen?");
    }

    public static Origin Deserialize()
    {
        string json = File.ReadAllText("data/origins.json");
        return JsonSerializer.Deserialize<Origin>(json);
    }
}

public class OriginList
{
    public List<Origin> Origins { get; set; }
    public OriginList()
    {
    }

    public OriginList Deserialize()
    {
        //string workingDirectory = Environment.CurrentDirectory;
        //string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
        string filename = "C:\\dev\\charcreator\\AdMunitorum\\AdMunitorum\\data\\Origins.json";
        string json = File.ReadAllText(filename);//actually tho, make this a relative path
        OriginList? originList = JsonSerializer.Deserialize<OriginList>(json);
        return originList;
    }
}
/*
}
 "Origins": [
    {
      "Name": "Agri World",
      "StatBonuses": "Strength",
      "Choice": [ "Toughness", "Agility", "Willpower" ],
      "Description": "This is the first origin. It is the best origin. It is the origin that will save us all. It is the origin that will bring peace to the galaxy",
      "item": "Shoddy Entrenching Tool"
    },
    {"Name": "Hive World",
      "StatBonuses": "Agility",
      "Choice": [ "BallisticsSkill", "Perception", "Fellowship" ],
      "Description": "This is the second origin. It is the best origin. It is the origin that will save us all. It is the origin that will bring peace to the galaxy",
      "item": "Ugly Filtration Plugs"
    }
]
}
 */