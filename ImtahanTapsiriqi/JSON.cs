using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

public class JSON
{
    public static void JsonSerializeEmployer(object? collection)
    {
        var str =JsonConvert.SerializeObject(collection, Newtonsoft.Json.Formatting.Indented);
        File.WriteAllText("employer.json", str);
    }
    public static object? JsonDeSerializeEmployer()
    {
        var jsonStr = File.ReadAllText("employer.json");
        return JsonConvert.DeserializeObject<List<Employer>>(jsonStr);
    }

    public static void JsonSerializeWorker(object? collection)
    {
        var str = JsonConvert.SerializeObject(collection, Newtonsoft.Json.Formatting.Indented);
        File.WriteAllText("workers.json", str);
    }
    public static object? JsonDeSerializeWorker()
    {
        var jsonStr = File.ReadAllText("workers.json");
        return JsonConvert.DeserializeObject<List<Worker>>(jsonStr);
    }

    public static void JsonSerializeWorkCV(object? collection)
    {
        var str = JsonConvert.SerializeObject(collection, Newtonsoft.Json.Formatting.Indented);
        File.WriteAllText("workcv.json", str);
    }
    public static object? JsonDeSerializeWorkCV()
    {
        var jsonStr = File.ReadAllText("workcv.json");
        return JsonConvert.DeserializeObject<List<WorkCv>>(jsonStr);
    }
}