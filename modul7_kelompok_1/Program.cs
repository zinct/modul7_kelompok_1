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