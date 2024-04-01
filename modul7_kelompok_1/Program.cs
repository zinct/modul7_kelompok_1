using System.Text.Json;
using static DataMahasiswa1302220067;
using static TeamMembers1302220067;

internal class Program
{
    private static void Main(string[] args)
    {
        var data = new DataMahasiswa1302220067();
        data.ReadJSON();

        Console.WriteLine();

        var tes = new TeamMembers1302220067();
        tes.ReadJSON();

        Console.WriteLine();

        var tes2 = new GlossaryItem1302220067();
        tes2.ReadJSON();
    }
}

public class DataMahasiswa1302220067
{
    public class Mahasiswa
    {
        public String? firstName;
        public String? lastName;
        public String? gender;
        public int age;
        public Address? address;
        public Course[]? courses;


    }
    public class Address
    {
        public String? streetAddress;
        public String? city;
        public String? state;
    }

    public class Course
    {
        public String? code;
        public String? name;
    }

    public void ReadJSON()
    {
        string json = File.ReadAllText("../../../jurnal7_1_1302220067.json");
        Mahasiswa mahasiswa = JsonSerializer.Deserialize<Mahasiswa>(json, new JsonSerializerOptions { IncludeFields = true });

        Console.WriteLine("Nama saya {0} {1} berumur {2}, saya berkelamin {3} dan saya tinggal di {4}, {5}, {6}", mahasiswa?.firstName, mahasiswa?.lastName, mahasiswa?.age, mahasiswa?.gender, mahasiswa?.address.streetAddress, mahasiswa.address.city, mahasiswa.address.state);
        Console.WriteLine("MataKuliah list:");
        for (int i = 0; i < mahasiswa.courses.Length; i++)
        {
            Console.WriteLine("{0} {1}", mahasiswa.courses[i].code, mahasiswa.courses[i].name);
        }
    }
}
public class TeamMembers1302220067
{
    public class Members
    {
        public Member[] members;
    }

    public class Member
    {
        public String? firstName;
        public String? lastName;
        public String? gender;
        public int? age;
        public String? nim;
    }

    public void ReadJSON()
    {
        string json = File.ReadAllText("../../../jurnal7_2_1302220067.json");
        var members = JsonSerializer.Deserialize<Members>(json, new JsonSerializerOptions { IncludeFields = true });

        Console.WriteLine("Team member list:");
        for(int i = 0; i < members.members.Length; i++)
        {
            Console.WriteLine("{0} {1}-{2}", members.members[i].nim, members.members[i].firstName, members.members[i].lastName);
        }
    }
}

public class GlossaryItem1302220067
{
    public class Data
    {
        public Glossary glossary;

        public class Glossary
        {
            public String title;
            public GlossDiv GlossDiv;
        }

        public class GlossDiv
        {
            public String title;
            public GlossList GlossList;
        }

        public class GlossList
        {
            public GlossEntry GlossEntry;
        }

        public class GlossEntry
        {
            public String ID;
            public String SortAS;
            public String GlossTerm;
            public String Acronym;
            public String Abbrev;
            public GlossDef GlossDef;
            public String GlossSee;
        }

        public class GlossDef
        {
            public String para;
            public String[] GlossSeeAlso;
        }

    }
    public void ReadJSON()
    {
        string json = File.ReadAllText("../../../jurnal7_3_1302220067.json");
        var data = JsonSerializer.Deserialize<Data>(json, new JsonSerializerOptions { IncludeFields = true });

        Console.WriteLine("Title: " + data.glossary.title);
        Console.WriteLine("GlossDiv Title: " + data.glossary.GlossDiv.title);
        Console.WriteLine("GlossDiv Entry ID: " + data.glossary.GlossDiv.GlossList.GlossEntry.ID);
        Console.WriteLine("GlossDiv Entry Sort As: " + data.glossary.GlossDiv.GlossList.GlossEntry.SortAS);
        Console.WriteLine("GlossDiv Entry Gloss Term: " + data.glossary.GlossDiv.GlossList.GlossEntry.GlossTerm);
        Console.WriteLine("GlossDiv Entry Acronym: " + data.glossary.GlossDiv.GlossList.GlossEntry.Acronym);
        Console.WriteLine("GlossDiv Entry Abbrev: " + data.glossary.GlossDiv.GlossList.GlossEntry.Abbrev);
        Console.WriteLine("GlossDiv Entry GlossDef: " + data.glossary.GlossDiv.GlossList.GlossEntry.GlossDef);
        Console.WriteLine("GlossDiv Entry GlossSee: " + data.glossary.GlossDiv.GlossList.GlossEntry.GlossSee);


        Console.WriteLine("Para: " + data.glossary.GlossDiv.GlossList.GlossEntry.GlossDef.para);
        foreach(String see in data.glossary.GlossDiv.GlossList.GlossEntry.GlossDef.GlossSeeAlso)
        {
            Console.WriteLine("See Also: " + see);
        }
        
    }
}