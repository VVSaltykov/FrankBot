using System.Text;
using System.Xml;

namespace FrankBot.Repositories
{
    public class CurrentRepositore
    {
        public static decimal USDReader()
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            XmlTextReader reader = new XmlTextReader("http://www.cbr.ru/scripts/XML_daily.asp");
            string USDXml = "";

            while (reader.Read())
            {
                if (reader.Name == "Valute")
                {
                    if (reader.HasAttributes)
                    {
                        while (reader.MoveToNextAttribute())
                        {
                            if (reader.Name == "ID")
                            {
                                if (reader.Value == "R01235")
                                {
                                    reader.MoveToElement();
                                    USDXml = reader.ReadOuterXml();
                                }
                            }
                        }
                    }
                }
            }
            XmlDocument usdXmlDocument = new XmlDocument();
            usdXmlDocument.LoadXml(USDXml);
            XmlNode xmlNode = usdXmlDocument.SelectSingleNode("Valute/Value");

            decimal usdValue = Convert.ToDecimal(xmlNode.InnerText);
            return usdValue;
        }
        public static decimal EURReader()
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            XmlTextReader reader = new XmlTextReader("http://www.cbr.ru/scripts/XML_daily.asp");
            string EURXml = "";

            while (reader.Read())
            {
                if (reader.Name == "Valute")
                {
                    if (reader.HasAttributes)
                    {
                        while (reader.MoveToNextAttribute())
                        {
                            if (reader.Name == "ID")
                            {
                                if (reader.Value == "R01239")
                                {
                                    reader.MoveToElement();
                                    EURXml = reader.ReadOuterXml();
                                }
                            }
                        }
                    }
                }
            }
            XmlDocument eurXmlDocument = new XmlDocument();
            eurXmlDocument.LoadXml(EURXml);
            XmlNode xmlNode = eurXmlDocument.SelectSingleNode("Valute/Value");

            decimal eurValue = Convert.ToDecimal(xmlNode.InnerText);
            return eurValue;
        }
    }
}
