using System;
using System.Collections.Generic;
using System.Ling;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;


public class TeamMembers1302220087
{
	public class Nama ()
	{
		public string firstN;
		public string lastN;
	}

	public class Team
	{
		public Nama nama;
		public string gender;
		public int age;
		public string nim;
	}

	public void readJSON()
	{
		var djson = File.ReadAllText("../../../../../jurnal7_2_1302220087.json");
		var team = JsonSerializer.Deserialize<TeamMembers1302220087>(djson, new JsonSerializerOptions {IncludeFields = true};
		for (int i = 0; i <	team.TeamMembers1302220087.	Length;i++) {
		Console WriteLine("Nim {0}, Nama{1}, Jenis Kelamin{2}, Umur{3}, nim{4}",team.nama.firstN, team.nama.lastN, team.gender, team.age, team.nim);
	}
}
