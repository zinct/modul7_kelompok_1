using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static modul7_kelompok_1.DataMahasiswa1302220084;

namespace modul7_kelompok_1
{
    public class GlossaryItem1302220084
    {
        public class GlossSeeAlsoItem 
        {
            public String name;
        }

        public class GlossDefClass
        {
            public String para;
            public GlossSeeAlsoItem[] GlossSeeAlso;
        }
        public class GlossEntryClass
        {
            public String ID;
            public String SortAs;
            public String GlossTerm;
            public String Acronym;
            public String Abbrev;
            public GlossDefClass GlossDef;
            public String GlossSee;
        }

        public class GlossListClass 
        {
            public GlossEntryClass GlossEntry;
        }

        public class GlossDivClass
        {
            public String title;
            public GlossListClass GlossList;
        }

        public class Glossary
        {
            public String title;
            public GlossDivClass GlossDiv;
        }

        public class Last
        {
            public Glossary glossary;
        }
        
        public void readJSON()
        {
            var dataJson = File.ReadAllText("../../../jurnal7_3_1302220084.json");

            var data = JsonSerializer.Deserialize<Last>(dataJson, new JsonSerializerOptions { IncludeFields = true });

            Console.WriteLine(data.glossary.GlossDiv.GlossList.GlossEntry.ID);
        
        }
    }
}
