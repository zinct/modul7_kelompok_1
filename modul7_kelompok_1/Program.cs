// See https://aka.ms/new-console-template for more information
using System.Text.Json;
using static DataMahasiswa1302220002;

Console.WriteLine("Hello, World!");
//var A = new DataMahasiswa1302220002();
var A = new TeamMembers1302220002();
A.ReadJSON();

class DataMahasiswa1302220002
{
    public class Mahasiswa
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public Address address { get; set; }
        public Cours[] courses { get; set; }
    }

    public class Address
    {
        public string streetAddress { get; set; }
        public string city { get; set; }
        public string state { get; set; }
    }

    public class Cours
    {
        public string code { get; set; }
        public string name { get; set; }
    }

    public void ReadJSON()
    {
        String json = File.ReadAllText("../../../jurnal7_1_1302220002.json");
        var mahasiswa = JsonSerializer.Deserialize<Mahasiswa>(json);
        Console.WriteLine($"{mahasiswa.firstName} {mahasiswa.lastName} gender {mahasiswa.gender} dan umur {mahasiswa.age} tinggal di {mahasiswa.address.streetAddress}, {mahasiswa.address.city}, {mahasiswa.address.state}");
        Console.WriteLine("mengambil mata kuliah: ");
        for (int i = 0; i < mahasiswa.courses.Length; i++)
        {
            Console.WriteLine($"matakualiah {i + 1} {mahasiswa.courses[i].code} - {mahasiswa.courses[i].name}");
        }
    }

}

class TeamMembers1302220002
{

    public class TeamMmember
    { 
        public Member[] members { get; set; }
    }

    public class Member
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public string nim { get; set; }
    }

    public void ReadJSON()
    {
        String json = File.ReadAllText("../../../jurnal7_2_1302220002.json");
        var teamMember = JsonSerializer.Deserialize<TeamMmember>(json);
        Console.WriteLine("Team Member List: ");
        for(int i = 0;i < teamMember.members.Length; i++)
        {
            Console.WriteLine($"{teamMember.members[i].nim} {teamMember.members[i].firstName} {teamMember.members[i].lastName} ({teamMember.members[i].age} {teamMember.members[i].gender})");
        }
    }

}
