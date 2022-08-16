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
        public static decimal AUDReader()
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            XmlTextReader reader = new XmlTextReader("http://www.cbr.ru/scripts/XML_daily.asp");
            string AUDXml = "";

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
                                if (reader.Value == "R01010")
                                {
                                    reader.MoveToElement();
                                    AUDXml = reader.ReadOuterXml();
                                }
                            }
                        }
                    }
                }
            }
            XmlDocument audXmlDocument = new XmlDocument();
            audXmlDocument.LoadXml(AUDXml);
            XmlNode xmlNode = audXmlDocument.SelectSingleNode("Valute/Value");

            decimal audValue = Convert.ToDecimal(xmlNode.InnerText);
            return audValue;
        }
        public static decimal AZNReader()
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            XmlTextReader reader = new XmlTextReader("http://www.cbr.ru/scripts/XML_daily.asp");
            string AZNXml = "";

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
                                if (reader.Value == "R01020A")
                                {
                                    reader.MoveToElement();
                                    AZNXml = reader.ReadOuterXml();
                                }
                            }
                        }
                    }
                }
            }
            XmlDocument aznXmlDocument = new XmlDocument();
            aznXmlDocument.LoadXml(AZNXml);
            XmlNode xmlNode = aznXmlDocument.SelectSingleNode("Valute/Value");

            decimal aznValue = Convert.ToDecimal(xmlNode.InnerText);
            return aznValue;
        }
        public static decimal GBPReader()
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            XmlTextReader reader = new XmlTextReader("http://www.cbr.ru/scripts/XML_daily.asp");
            string GBPXml = "";

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
                                if (reader.Value == "R01035")
                                {
                                    reader.MoveToElement();
                                    GBPXml = reader.ReadOuterXml();
                                }
                            }
                        }
                    }
                }
            }
            XmlDocument gbpXmlDocument = new XmlDocument();
            gbpXmlDocument.LoadXml(GBPXml);
            XmlNode xmlNode = gbpXmlDocument.SelectSingleNode("Valute/Value");

            decimal gbpValue = Convert.ToDecimal(xmlNode.InnerText);
            return gbpValue;
        }
        public static decimal AMDReader()
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            XmlTextReader reader = new XmlTextReader("http://www.cbr.ru/scripts/XML_daily.asp");
            string AMDXml = "";

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
                                if (reader.Value == "R01060")
                                {
                                    reader.MoveToElement();
                                    AMDXml = reader.ReadOuterXml();
                                }
                            }
                        }
                    }
                }
            }
            XmlDocument amdXmlDocument = new XmlDocument();
            amdXmlDocument.LoadXml(AMDXml);
            XmlNode xmlNode = amdXmlDocument.SelectSingleNode("Valute/Value");

            decimal amdValue = Convert.ToDecimal(xmlNode.InnerText);
            return amdValue;
        }
        public static decimal BYNReader()
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            XmlTextReader reader = new XmlTextReader("http://www.cbr.ru/scripts/XML_daily.asp");
            string BYNXml = "";

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
                                if (reader.Value == "R01090B")
                                {
                                    reader.MoveToElement();
                                    BYNXml = reader.ReadOuterXml();
                                }
                            }
                        }
                    }
                }
            }
            XmlDocument bynXmlDocument = new XmlDocument();
            bynXmlDocument.LoadXml(BYNXml);
            XmlNode xmlNode = bynXmlDocument.SelectSingleNode("Valute/Value");

            decimal bynValue = Convert.ToDecimal(xmlNode.InnerText);
            return bynValue;
        }
        public static decimal BGNReader()
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            XmlTextReader reader = new XmlTextReader("http://www.cbr.ru/scripts/XML_daily.asp");
            string BGNXml = "";

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
                                if (reader.Value == "R01010")
                                {
                                    reader.MoveToElement();
                                    BGNXml = reader.ReadOuterXml();
                                }
                            }
                        }
                    }
                }
            }
            XmlDocument bgnXmlDocument = new XmlDocument();
            bgnXmlDocument.LoadXml(BGNXml);
            XmlNode xmlNode = bgnXmlDocument.SelectSingleNode("Valute/Value");

            decimal bgnValue = Convert.ToDecimal(xmlNode.InnerText);
            return bgnValue;
        }
        public static decimal BRLReader()
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            XmlTextReader reader = new XmlTextReader("http://www.cbr.ru/scripts/XML_daily.asp");
            string BRLXml = "";

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
                                if (reader.Value == "R01115")
                                {
                                    reader.MoveToElement();
                                    BRLXml = reader.ReadOuterXml();
                                }
                            }
                        }
                    }
                }
            }
            XmlDocument brlXmlDocument = new XmlDocument();
            brlXmlDocument.LoadXml(BRLXml);
            XmlNode xmlNode = brlXmlDocument.SelectSingleNode("Valute/Value");

            decimal brlValue = Convert.ToDecimal(xmlNode.InnerText);
            return brlValue;
        }
        public static decimal HUFReader()
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            XmlTextReader reader = new XmlTextReader("http://www.cbr.ru/scripts/XML_daily.asp");
            string HUFXml = "";

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
                                if (reader.Value == "R01135")
                                {
                                    reader.MoveToElement();
                                    HUFXml = reader.ReadOuterXml();
                                }
                            }
                        }
                    }
                }
            }
            XmlDocument hufXmlDocument = new XmlDocument();
            hufXmlDocument.LoadXml(HUFXml);
            XmlNode xmlNode = hufXmlDocument.SelectSingleNode("Valute/Value");

            decimal hufValue = Convert.ToDecimal(xmlNode.InnerText);
            return hufValue;
        }
        public static decimal HKDReader()
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            XmlTextReader reader = new XmlTextReader("http://www.cbr.ru/scripts/XML_daily.asp");
            string HKDXml = "";

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
                                if (reader.Value == "R01200")
                                {
                                    reader.MoveToElement();
                                    HKDXml = reader.ReadOuterXml();
                                }
                            }
                        }
                    }
                }
            }
            XmlDocument hkdXmlDocument = new XmlDocument();
            hkdXmlDocument.LoadXml(HKDXml);
            XmlNode xmlNode = hkdXmlDocument.SelectSingleNode("Valute/Value");

            decimal hkdValue = Convert.ToDecimal(xmlNode.InnerText);
            return hkdValue;
        }
        public static decimal DKKReader()
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            XmlTextReader reader = new XmlTextReader("http://www.cbr.ru/scripts/XML_daily.asp");
            string DKKXml = "";

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
                                if (reader.Value == "R01215")
                                {
                                    reader.MoveToElement();
                                    DKKXml = reader.ReadOuterXml();
                                }
                            }
                        }
                    }
                }
            }
            XmlDocument dkkXmlDocument = new XmlDocument();
            dkkXmlDocument.LoadXml(DKKXml);
            XmlNode xmlNode = dkkXmlDocument.SelectSingleNode("Valute/Value");

            decimal dkkValue = Convert.ToDecimal(xmlNode.InnerText);
            return dkkValue;
        }
        public static decimal INRReader()
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            XmlTextReader reader = new XmlTextReader("http://www.cbr.ru/scripts/XML_daily.asp");
            string INRXml = "";

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
                                if (reader.Value == "R01270")
                                {
                                    reader.MoveToElement();
                                    INRXml = reader.ReadOuterXml();
                                }
                            }
                        }
                    }
                }
            }
            XmlDocument inrXmlDocument = new XmlDocument();
            inrXmlDocument.LoadXml(INRXml);
            XmlNode xmlNode = inrXmlDocument.SelectSingleNode("Valute/Value");

            decimal inrValue = Convert.ToDecimal(xmlNode.InnerText);
            return inrValue;
        }
        public static decimal KZTReader()
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            XmlTextReader reader = new XmlTextReader("http://www.cbr.ru/scripts/XML_daily.asp");
            string KZTXml = "";

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
                                if (reader.Value == "R01335")
                                {
                                    reader.MoveToElement();
                                    KZTXml = reader.ReadOuterXml();
                                }
                            }
                        }
                    }
                }
            }
            XmlDocument kztXmlDocument = new XmlDocument();
            kztXmlDocument.LoadXml(KZTXml);
            XmlNode xmlNode = kztXmlDocument.SelectSingleNode("Valute/Value");

            decimal kztValue = Convert.ToDecimal(xmlNode.InnerText);
            return kztValue;
        }
        public static decimal CADReader()
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            XmlTextReader reader = new XmlTextReader("http://www.cbr.ru/scripts/XML_daily.asp");
            string CADXml = "";

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
                                if (reader.Value == "R01350")
                                {
                                    reader.MoveToElement();
                                    CADXml = reader.ReadOuterXml();
                                }
                            }
                        }
                    }
                }
            }
            XmlDocument cadXmlDocument = new XmlDocument();
            cadXmlDocument.LoadXml(CADXml);
            XmlNode xmlNode = cadXmlDocument.SelectSingleNode("Valute/Value");

            decimal cadValue = Convert.ToDecimal(xmlNode.InnerText);
            return cadValue;
        }
        public static decimal KGSReader()
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            XmlTextReader reader = new XmlTextReader("http://www.cbr.ru/scripts/XML_daily.asp");
            string KGSXml = "";

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
                                if (reader.Value == "R01370")
                                {
                                    reader.MoveToElement();
                                    KGSXml = reader.ReadOuterXml();
                                }
                            }
                        }
                    }
                }
            }
            XmlDocument kgsXmlDocument = new XmlDocument();
            kgsXmlDocument.LoadXml(KGSXml);
            XmlNode xmlNode = kgsXmlDocument.SelectSingleNode("Valute/Value");

            decimal kgsValue = Convert.ToDecimal(xmlNode.InnerText);
            return kgsValue;
        }
        public static decimal CNYReader()
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            XmlTextReader reader = new XmlTextReader("http://www.cbr.ru/scripts/XML_daily.asp");
            string CNYXml = "";

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
                                if (reader.Value == "R01375")
                                {
                                    reader.MoveToElement();
                                    CNYXml = reader.ReadOuterXml();
                                }
                            }
                        }
                    }
                }
            }
            XmlDocument cnyXmlDocument = new XmlDocument();
            cnyXmlDocument.LoadXml(CNYXml);
            XmlNode xmlNode = cnyXmlDocument.SelectSingleNode("Valute/Value");

            decimal cnyValue = Convert.ToDecimal(xmlNode.InnerText);
            return cnyValue;
        }
        public static decimal MDLReader()
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            XmlTextReader reader = new XmlTextReader("http://www.cbr.ru/scripts/XML_daily.asp");
            string MDLXml = "";

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
                                if (reader.Value == "R01500")
                                {
                                    reader.MoveToElement();
                                    MDLXml = reader.ReadOuterXml();
                                }
                            }
                        }
                    }
                }
            }
            XmlDocument mdlXmlDocument = new XmlDocument();
            mdlXmlDocument.LoadXml(MDLXml);
            XmlNode xmlNode = mdlXmlDocument.SelectSingleNode("Valute/Value");

            decimal mdlValue = Convert.ToDecimal(xmlNode.InnerText);
            return mdlValue;
        }
        public static decimal NOKReader()
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            XmlTextReader reader = new XmlTextReader("http://www.cbr.ru/scripts/XML_daily.asp");
            string NOKXml = "";

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
                                if (reader.Value == "R01535")
                                {
                                    reader.MoveToElement();
                                    NOKXml = reader.ReadOuterXml();
                                }
                            }
                        }
                    }
                }
            }
            XmlDocument nokXmlDocument = new XmlDocument();
            nokXmlDocument.LoadXml(NOKXml);
            XmlNode xmlNode = nokXmlDocument.SelectSingleNode("Valute/Value");

            decimal nokValue = Convert.ToDecimal(xmlNode.InnerText);
            return nokValue;
        }
        public static decimal PLNReader()
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            XmlTextReader reader = new XmlTextReader("http://www.cbr.ru/scripts/XML_daily.asp");
            string PLNXml = "";

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
                                if (reader.Value == "R01565")
                                {
                                    reader.MoveToElement();
                                    PLNXml = reader.ReadOuterXml();
                                }
                            }
                        }
                    }
                }
            }
            XmlDocument plnXmlDocument = new XmlDocument();
            plnXmlDocument.LoadXml(PLNXml);
            XmlNode xmlNode = plnXmlDocument.SelectSingleNode("Valute/Value");

            decimal plnValue = Convert.ToDecimal(xmlNode.InnerText);
            return plnValue;
        }
        public static decimal RONReader()
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            XmlTextReader reader = new XmlTextReader("http://www.cbr.ru/scripts/XML_daily.asp");
            string RONXml = "";

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
                                if (reader.Value == "R01585F")
                                {
                                    reader.MoveToElement();
                                    RONXml = reader.ReadOuterXml();
                                }
                            }
                        }
                    }
                }
            }
            XmlDocument ronXmlDocument = new XmlDocument();
            ronXmlDocument.LoadXml(RONXml);
            XmlNode xmlNode = ronXmlDocument.SelectSingleNode("Valute/Value");

            decimal ronValue = Convert.ToDecimal(xmlNode.InnerText);
            return ronValue;
        }
        public static decimal XDRReader()
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            XmlTextReader reader = new XmlTextReader("http://www.cbr.ru/scripts/XML_daily.asp");
            string XDRXml = "";

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
                                if (reader.Value == "R01589")
                                {
                                    reader.MoveToElement();
                                    XDRXml = reader.ReadOuterXml();
                                }
                            }
                        }
                    }
                }
            }
            XmlDocument xdrXmlDocument = new XmlDocument();
            xdrXmlDocument.LoadXml(XDRXml);
            XmlNode xmlNode = xdrXmlDocument.SelectSingleNode("Valute/Value");

            decimal xdrValue = Convert.ToDecimal(xmlNode.InnerText);
            return xdrValue;
        }
        public static decimal SGDReader()
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            XmlTextReader reader = new XmlTextReader("http://www.cbr.ru/scripts/XML_daily.asp");
            string SGDXml = "";

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
                                if (reader.Value == "R01625")
                                {
                                    reader.MoveToElement();
                                    SGDXml = reader.ReadOuterXml();
                                }
                            }
                        }
                    }
                }
            }
            XmlDocument sgdXmlDocument = new XmlDocument();
            sgdXmlDocument.LoadXml(SGDXml);
            XmlNode xmlNode = sgdXmlDocument.SelectSingleNode("Valute/Value");

            decimal sgdValue = Convert.ToDecimal(xmlNode.InnerText);
            return sgdValue;
        }
        public static decimal TJSReader()
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            XmlTextReader reader = new XmlTextReader("http://www.cbr.ru/scripts/XML_daily.asp");
            string TJSXml = "";

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
                                if (reader.Value == "R01670")
                                {
                                    reader.MoveToElement();
                                    TJSXml = reader.ReadOuterXml();
                                }
                            }
                        }
                    }
                }
            }
            XmlDocument tjsXmlDocument = new XmlDocument();
            tjsXmlDocument.LoadXml(TJSXml);
            XmlNode xmlNode = tjsXmlDocument.SelectSingleNode("Valute/Value");

            decimal tjsValue = Convert.ToDecimal(xmlNode.InnerText);
            return tjsValue;
        }
        public static decimal TRYReader()
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            XmlTextReader reader = new XmlTextReader("http://www.cbr.ru/scripts/XML_daily.asp");
            string TRYXml = "";

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
                                if (reader.Value == "R01700J")
                                {
                                    reader.MoveToElement();
                                    TRYXml = reader.ReadOuterXml();
                                }
                            }
                        }
                    }
                }
            }
            XmlDocument tryXmlDocument = new XmlDocument();
            tryXmlDocument.LoadXml(TRYXml);
            XmlNode xmlNode = tryXmlDocument.SelectSingleNode("Valute/Value");

            decimal tryValue = Convert.ToDecimal(xmlNode.InnerText);
            return tryValue;
        }
        public static decimal TMTReader()
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            XmlTextReader reader = new XmlTextReader("http://www.cbr.ru/scripts/XML_daily.asp");
            string TMTXml = "";

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
                                if (reader.Value == "R01710A")
                                {
                                    reader.MoveToElement();
                                    TMTXml = reader.ReadOuterXml();
                                }
                            }
                        }
                    }
                }
            }
            XmlDocument tmtXmlDocument = new XmlDocument();
            tmtXmlDocument.LoadXml(TMTXml);
            XmlNode xmlNode = tmtXmlDocument.SelectSingleNode("Valute/Value");

            decimal tmtValue = Convert.ToDecimal(xmlNode.InnerText);
            return tmtValue;
        }
        public static decimal UZSReader()
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            XmlTextReader reader = new XmlTextReader("http://www.cbr.ru/scripts/XML_daily.asp");
            string UZSXml = "";

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
                                if (reader.Value == "R01717")
                                {
                                    reader.MoveToElement();
                                    UZSXml = reader.ReadOuterXml();
                                }
                            }
                        }
                    }
                }
            }
            XmlDocument uzsXmlDocument = new XmlDocument();
            uzsXmlDocument.LoadXml(UZSXml);
            XmlNode xmlNode = uzsXmlDocument.SelectSingleNode("Valute/Value");

            decimal uzsValue = Convert.ToDecimal(xmlNode.InnerText);
            return uzsValue;
        }
        public static decimal UAHReader()
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            XmlTextReader reader = new XmlTextReader("http://www.cbr.ru/scripts/XML_daily.asp");
            string UAHXml = "";

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
                                if (reader.Value == "R01720")
                                {
                                    reader.MoveToElement();
                                    UAHXml = reader.ReadOuterXml();
                                }
                            }
                        }
                    }
                }
            }
            XmlDocument uahXmlDocument = new XmlDocument();
            uahXmlDocument.LoadXml(UAHXml);
            XmlNode xmlNode = uahXmlDocument.SelectSingleNode("Valute/Value");

            decimal uahValue = Convert.ToDecimal(xmlNode.InnerText);
            return uahValue;
        }
        public static decimal CZKReader()
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            XmlTextReader reader = new XmlTextReader("http://www.cbr.ru/scripts/XML_daily.asp");
            string CZKXml = "";

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
                                if (reader.Value == "R01760")
                                {
                                    reader.MoveToElement();
                                    CZKXml = reader.ReadOuterXml();
                                }
                            }
                        }
                    }
                }
            }
            XmlDocument czkXmlDocument = new XmlDocument();
            czkXmlDocument.LoadXml(CZKXml);
            XmlNode xmlNode = czkXmlDocument.SelectSingleNode("Valute/Value");

            decimal czkValue = Convert.ToDecimal(xmlNode.InnerText);
            return czkValue;
        }
        public static decimal SEKReader()
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            XmlTextReader reader = new XmlTextReader("http://www.cbr.ru/scripts/XML_daily.asp");
            string SEKXml = "";

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
                                if (reader.Value == "R01770")
                                {
                                    reader.MoveToElement();
                                    SEKXml = reader.ReadOuterXml();
                                }
                            }
                        }
                    }
                }
            }
            XmlDocument sekXmlDocument = new XmlDocument();
            sekXmlDocument.LoadXml(SEKXml);
            XmlNode xmlNode = sekXmlDocument.SelectSingleNode("Valute/Value");

            decimal sekValue = Convert.ToDecimal(xmlNode.InnerText);
            return sekValue;
        }
        public static decimal CHFReader()
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            XmlTextReader reader = new XmlTextReader("http://www.cbr.ru/scripts/XML_daily.asp");
            string CHFXml = "";

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
                                if (reader.Value == "R01775")
                                {
                                    reader.MoveToElement();
                                    CHFXml = reader.ReadOuterXml();
                                }
                            }
                        }
                    }
                }
            }
            XmlDocument chfXmlDocument = new XmlDocument();
            chfXmlDocument.LoadXml(CHFXml);
            XmlNode xmlNode = chfXmlDocument.SelectSingleNode("Valute/Value");

            decimal chfValue = Convert.ToDecimal(xmlNode.InnerText);
            return chfValue;
        }
        public static decimal ZARReader()
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            XmlTextReader reader = new XmlTextReader("http://www.cbr.ru/scripts/XML_daily.asp");
            string ZARXml = "";

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
                                if (reader.Value == "R01810")
                                {
                                    reader.MoveToElement();
                                    ZARXml = reader.ReadOuterXml();
                                }
                            }
                        }
                    }
                }
            }
            XmlDocument zarXmlDocument = new XmlDocument();
            zarXmlDocument.LoadXml(ZARXml);
            XmlNode xmlNode = zarXmlDocument.SelectSingleNode("Valute/Value");

            decimal zarValue = Convert.ToDecimal(xmlNode.InnerText);
            return zarValue;
        }
        public static decimal KRWReader()
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            XmlTextReader reader = new XmlTextReader("http://www.cbr.ru/scripts/XML_daily.asp");
            string KRWXml = "";

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
                                if (reader.Value == "R01815")
                                {
                                    reader.MoveToElement();
                                    KRWXml = reader.ReadOuterXml();
                                }
                            }
                        }
                    }
                }
            }
            XmlDocument krwXmlDocument = new XmlDocument();
            krwXmlDocument.LoadXml(KRWXml);
            XmlNode xmlNode = krwXmlDocument.SelectSingleNode("Valute/Value");

            decimal krwValue = Convert.ToDecimal(xmlNode.InnerText);
            return krwValue;
        }
        public static decimal JPYReader()
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            XmlTextReader reader = new XmlTextReader("http://www.cbr.ru/scripts/XML_daily.asp");
            string JPYXml = "";

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
                                if (reader.Value == "R01820")
                                {
                                    reader.MoveToElement();
                                    JPYXml = reader.ReadOuterXml();
                                }
                            }
                        }
                    }
                }
            }
            XmlDocument jpyXmlDocument = new XmlDocument();
            jpyXmlDocument.LoadXml(JPYXml);
            XmlNode xmlNode = jpyXmlDocument.SelectSingleNode("Valute/Value");

            decimal jpyValue = Convert.ToDecimal(xmlNode.InnerText);
            return jpyValue;
        }
    }
}
