using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Collections;

namespace UserProfileApplication
{
    public class SaveLoad<T>
    {
        static ArrayList SavedFiles = new ArrayList();

        public static void Serialize(string s, T t)
        {
            using (FileStream fs = File.Create(@"..\..\SavedFiles\" + s + ".bin"))
            {
                BinaryFormatter serializer = new BinaryFormatter();
                serializer.Serialize(fs, t);
            }
        }

        public static ArrayList DeserializeMult()
        {
            ArrayList list = new ArrayList();
            foreach(string str in SavedFiles)
            {
                using (FileStream fs = File.OpenRead(str))
                {
                    BinaryFormatter deserializer = new BinaryFormatter();
                    T temp = (T)deserializer.Deserialize(fs);
                    list.Add(temp);
                }
            }
            return list;
        }

        public static T DeserializeSingle(string s)
        {
            T t;
            using (FileStream fs = File.OpenRead(s + ".bin"))
            {
                BinaryFormatter deserializer = new BinaryFormatter();
                t = (T)deserializer.Deserialize(fs);
            }
            return t;
        }

        public static void LocateFiles()
        {
            foreach(string s in Directory.GetFiles(@"..\..\SavedFiles\"))
            {
                SavedFiles.Add(s);
            }
        }
    }
}
