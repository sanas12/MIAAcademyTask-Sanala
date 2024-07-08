using MiaAcademyAutomation;
using Newtonsoft.Json;

public class Datadriventesting
{
    public static List<User> LoadUsers1(string filePath)
    {
        var json = File.ReadAllText(filePath);
        var userData = JsonConvert.DeserializeObject<Dictionary<string, List<User>>>(json);
        return userData["users1"];
    }

    public static List<User> LoadUsers2(string filePath)
    {
        var json = File.ReadAllText(filePath);
        var userData = JsonConvert.DeserializeObject<Dictionary<string, List<User>>>(json);
        return userData["users2"];
    }
}
