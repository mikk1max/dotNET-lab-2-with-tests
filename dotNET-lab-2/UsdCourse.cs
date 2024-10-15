namespace dotNET_Lab_2;

class UsdCourse
{
    public static float Current = 0;
    public async static Task<float> GetUsdCourseAsync()
    {
        var wc = new HttpClient();
        var response = await wc.GetAsync("https://static.nbp.pl/dane/kursy/xml/a197z241009.xml");
        if (!response.IsSuccessStatusCode)
            throw new InvalidOperationException();

        System.Xml.XmlDocument xd = new System.Xml.XmlDocument();

        xd.LoadXml(await response.Content.ReadAsStringAsync());

        foreach (System.Xml.XmlNode p in xd.GetElementsByTagName("pozycja"))
        {
            if (p.NodeType == System.Xml.XmlNodeType.Element)
            {
                System.Xml.XmlElement pp = (System.Xml.XmlElement)p;
                System.Xml.XmlElement w = (System.Xml.XmlElement)pp.GetElementsByTagName("kod_waluty")[0];
                if (w.InnerText == "USD")
                {
                    return
                    Convert.ToSingle(pp.GetElementsByTagName("kurs_sredni")[0].InnerText);
                }
            }
        }
        throw new InvalidOperationException();
    }
}