using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Xml.Serialization;

namespace IBoodHuntMonitor
{
    public static class ObjectExtentions
    {
        public static void SetValue(this object obj, string propertyName, object value)
        {
            var type = obj.GetType();
            var prop = type.GetProperty(propertyName);
            prop.SetValue(obj, value, null);
        }

        public static object GetValue(this object obj, string propertyName)
        {
            var type = obj.GetType();
            var prop = type.GetProperty(propertyName);
            return prop.GetValue(obj, null);
        }

        public static Type GetPropertyType(this object obj, string propertyName)
        {
            var type = obj.GetType();
            var prop = type.GetProperty(propertyName);
            return prop.PropertyType;
        }

        public static void SaveCache(this object obj, string cacheFilePath)
        {
            //var serializer = new BinaryFormatter();
            var xser = new XmlSerializer(obj.GetType());
            xser.UnknownElement += new XmlElementEventHandler(xser_UnknownElement);
            xser.UnknownAttribute += new XmlAttributeEventHandler(xser_UnknownAttribute);
            xser.UnknownNode += new XmlNodeEventHandler(xser_UnknownNode);
            xser.UnreferencedObject += new UnreferencedObjectEventHandler(xser_UnreferencedObject);
            using (var stream = File.Create(cacheFilePath))
            {
                //serializer.Serialize(stream, obj);
                xser.Serialize(stream,obj);
            }
        }

        static void xser_UnreferencedObject(object sender, UnreferencedObjectEventArgs e)
        {
            throw new NotImplementedException();
        }

        static void xser_UnknownNode(object sender, XmlNodeEventArgs e)
        {
            throw new NotImplementedException();
        }

        static void xser_UnknownAttribute(object sender, XmlAttributeEventArgs e)
        {
            throw new NotImplementedException();
        }

        static void xser_UnknownElement(object sender, XmlElementEventArgs e)
        {
            throw new NotImplementedException();
        }

        public static T LoadCache<T>(string cacheFilePath)
        {
            T obj = default(T);

            try
            {
                //var serializer = new BinaryFormatter();
                var xser = new XmlSerializer(obj.GetType());
            
                using (var stream = File.OpenRead(cacheFilePath))
                {
                    //obj = (T)serializer.Deserialize(stream);
                    obj = (T)xser.Deserialize(stream);
                }
            }
            catch(Exception ex)
            {
                throw new InvalidOperationException("error while loading from cache", ex);
            }
            return obj;
        }
    }
}
