using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace modul7_kelompok_1
{
    public class DataMahasiswa1302220084
    {
        public class alamat
        {
            public String streetAddress;
            public String city;
            public String state;
        }

        public class MataKuliah
        {
            public String code;
            public String name;
        }
        

        public class Mahasiswa
        {
            public String firstName;
            public String lastName;
            public String gender;
            public int age;
            public alamat address;
            public MataKuliah[] courses;
        }
        public void readJSON()
        {
            var dataJson = File.ReadAllText("../../../jurnal7_1_1302220084.json");

            var data = JsonSerializer.Deserialize<Mahasiswa>(dataJson, new JsonSerializerOptions { IncludeFields = true });

            Console.WriteLine(data.firstName);
            Console.WriteLine(data.lastName);
            Console.WriteLine(data.gender);
            Console.WriteLine(data.age);
            Console.WriteLine(data.address.streetAddress);
            Console.WriteLine(data.address.city);
            Console.WriteLine(data.address.state);
            for (int i = 0; i < data.courses.Length; i++)
            {
                Console.WriteLine($"{data.courses[i].code}  {data.courses[i].name}");
            }
        }
    }
}
