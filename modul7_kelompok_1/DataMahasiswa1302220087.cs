using System;
using System.Text.Json;
using System.Text.Json.Serialization;

public class DataMahasiswa1302220087
{
	public class Nama {
		public string first;
		public string last;
	}

	public class Praktikan1302220087
	{
		public Nama nama;
	}

	public static void readJSON()
	{
		var djson = File.ReadAllText("../jurnal_7_1302220087.json");
		var praktikan = JsonSerializer.Deserialize<Praktikan1302220087>(djson,new JsonSerializer.Options {IncludeFields = true});
		Console.WriteLine("Nama {0} {1}",  praktikan.nama.first, praktikan.nama.last);

	}
}
