using modul7_kelompok_1;

internal class Program
{
    private static void Main(string[] args)
    {
        DataMahasiswa1302220084 t1 = new DataMahasiswa1302220084();
        t1.readJSON();

        TeamMembers1302220084 t2 = new TeamMembers1302220084();
        t2.readJSON();

        GlossaryItem1302220084 t3 = new GlossaryItem1302220084();
        t3.readJSON();
    }
}