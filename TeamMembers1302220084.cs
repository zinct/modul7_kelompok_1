using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static modul7_kelompok_1.DataMahasiswa1302220084;

namespace modul7_kelompok_1
{ 
    public class TeamMembers1302220084
    {
        public class Members
        {
            public Anggota[] members;
        }

        public class Anggota
        {
            public String firstName;
            public String lastName;
            public String gender;
            public int age;
            public String nim;
        }
        public void readJSON()
        {
            var dataJson = File.ReadAllText("../../../jurnal7_2_1302220084.json");

            var data = JsonSerializer.Deserialize<Members>(dataJson, new JsonSerializerOptions { IncludeFields = true });

            Console.WriteLine("Team Member List: ");
            for (int i = 0; i < data.members.Length; i++)
            {
                Console.WriteLine($"{data.members[i].nim} {data.members[i].firstName} {data.members[i].lastName} ({data.members[i].age} {data.members[i].gender})");
            }
        }
    }
}
