using System;
//CourseCode: kurssin yksilöllinen tunniste
//•Name: Kurssin nimi
//•StartDate: alkupäivä
//•EndDate: loppupäivä, sama kuin alkupvmjos vain yhden päivän kestävä kurssi
//•Location: sijainti, Online tarkoittaa mahdollisuutta etäosallistua vaikka Skypen kautta
//•MaterialType: paperi/sähköinen
//•Description: Kuvausteksti
//•MatCode: materiaalikoodi
//•MainCategory: Kurssin pääluokittelu
//•SubCategory1 ja SubCategory2: kurssin muut luokittelut

public class Kurssi
{
    public int CourseCode { get; set; }
    public string Name { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string Location { get; set; }
    public string MaterialType { get; set; }
    public string Description { get; set; }
    public int MyProperty { get; set; }
    public string MatCode { get; set; }
    public string MainCategory { get; set; }
    public string SubCategory1 { get; set; }
    public string SubCategory2 { get; set; }
}
