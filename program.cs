using System.Text.Json;

Dictionary<int, string> dic = new Dictionary<int, string>();
dic.Add(1, "dsadas");
dic.Add(2, "curk");
dic.Add(3, "dsadas");
dic.Add(4, "dsadas");
dic.Add(5, "falm");
dic.Add(6, "curk");
dic.Add(7, "fifa");
dic.Add(8, "dsadas");

Dictionary<int, string> dic2 = new Dictionary<int, string>();

foreach (KeyValuePair<int, string> pair in dic)
{
    if(!dic2.ContainsValue(pair.Value))
    {
        dic2.Add(pair.Key, pair.Value);
    }
}

string json = JsonSerializer.Serialize(dic2);
Console.WriteLine(json);
Console.ReadKey();