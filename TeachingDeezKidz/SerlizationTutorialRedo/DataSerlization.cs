using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SerlizationTutorialRedo
{
    using System.IO;

    public static class DataSerlization<T>
    {
        public static void Serialize(string fileName, T data)
        {
            XmlSerializer serilaizer = new XmlSerializer(typeof(T));
            TextWriter writter = new StreamWriter(@"..\..\SavedFiles\" + fileName + ".xml");
            serilaizer.Serialize(writter, data);
            writter.Close();
        }

        public static T DeSeralize(string fileName)
        {
            T data;
            XmlSerializer serilaizer = new XmlSerializer(typeof(T));
            TextReader reader = new StreamReader(@"..\..\SavedFiles\" + fileName + ".xml");
            data = (T)serilaizer.Deserialize(reader);
            reader.Close();
            return data;
        }
    }
}
