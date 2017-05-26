using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WorkstationStudioGarment_WinForm.tool
{
    public static class Serializer
    {
        public static void SerializeClass(Type classType, object o, string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }

            XmlSerializer x = new XmlSerializer(classType);
            x.Serialize(File.CreateText(filename), o);

        }

        public static object DeserializeClass(Type classType, string filename)
        {
            if (!File.Exists(filename))
                return null;

            XmlSerializer x = new XmlSerializer(classType);
            return x.Deserialize(File.OpenText(filename));
        }
    }
}
