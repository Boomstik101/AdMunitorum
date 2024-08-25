using System.Diagnostics;
using System.Text.Json;


public class Role
{
    public string Name { get; set; }
    public int NumTalent { get; set; }
    public List<string> Talent { get; set; }
    public int NumAdvances { get; set; }
    public List<string> Advances { get; set; }
    public int NumSpecialisations { get; set; }
    public List<string> Specialisations { get; set; }
    public List<string> RoleDefualtEquip { get; set; }
    public List<string> RoleEquipChoice { get; set; }
    public bool AddRolePsyker { get; set; }


    public Role()
    {
        Debug.WriteLine("Did this happen?");
    }

    public static Role Deserialize()
    {
        string json = File.ReadAllText("data/roles.json");
        return JsonSerializer.Deserialize<Role>(json);
    }
}

public class RoleList
{
    public List<Role> Roles { get; set; }
    public RoleList()
    {
    }

    public RoleList Deserialize()
    {
        //string workingDirectory = Environment.CurrentDirectory;
        //string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
        string cwd = Directory.GetCurrentDirectory();
        //go up 3 directories and then into data
        string dataDir = Path.Combine(cwd, "..\\..\\..\\data");

        string filename = Path.Combine(dataDir, "Roles.json");
        string json = File.ReadAllText(filename);//actually tho, make this a relative path
        RoleList? roleList = JsonSerializer.Deserialize<RoleList>(json);
        return roleList;
    }
}