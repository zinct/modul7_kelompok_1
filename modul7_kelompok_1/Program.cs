using System.Text.Json;

internal class Program
{
    private static void Main(string[] args)
    {
        var data = new DataMahasiswa1302220067();
        data.ReadJSON();
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
    }
}