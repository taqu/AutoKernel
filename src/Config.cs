
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.Xsl;

namespace AutoKernels
{
    public class Config
    {
        public const string FileName = "config.xml";
        public string Model { get; set; } = "gpt-3.5-turbo";
        public string Embedding { get; set; } = "text-embedding-ada-002";
        public string EndPoint { get; set; } = string.Empty;
        public string ApiKey { get; set; } = string.Empty;

        public string GoogleAPIKey { get; set; } = string.Empty;
        public string GoogleEngineId { get; set; } = string.Empty;

        public static Config load(string path)
        {
            Config? config = null;
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Config));
                using (FileStream file = File.OpenRead(path))
                using (XmlReader xmlReader = XmlReader.Create(file))
                {
                    config = serializer.Deserialize(xmlReader) as Config;
                    if(null != config)
                    {
                        return config;
                    }
                }
            }
            catch { }

            config = new Config();
            save(path, config);
            return config;
        }

        public static void save(string path, Config config)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Config));
                using (FileStream file = File.OpenWrite(path))
                using (XmlWriter xmlWriter = XmlWriter.Create(file))
                {
                    serializer.Serialize(xmlWriter, config);
                }
            }
            catch
            {
            }
        }
    }
}

