using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Collections;

namespace NETScoreTranscriptionLibrary
{
    public static class PropertyGenerator
    {
        private static int _depth = 0;
        public static int depth { get { return _depth; } private set { _depth = value; } }

        public static String GeneratePropertiesString(Type myType, Object caller)
        {
            String x = "";

            // Get the public properties.
            PropertyInfo[] myPropertyInfo = myType.GetProperties(BindingFlags.Public | BindingFlags.Instance);

            depth++;
            // Display the public properties.
            for (int i = 0; i < myPropertyInfo.Length; i++)
            {
                try
                {
                    PropertyInfo myPropInfo = (PropertyInfo)myPropertyInfo[i];
                    Object o = myPropInfo.GetValue(caller, null);
                    if (o != null)
                    {
                        if (typeof(ICollection).IsAssignableFrom(myPropInfo.PropertyType))
                        {
                            ICollection collection = (ICollection)o;
                            IEnumerator e = collection.GetEnumerator();

                            x += String.Format("{0}{1} - {2}\n", new String('-', depth), myPropInfo.Name, collection.Count);

                            while (e.MoveNext())
                                x += String.Format("{1}\n", e.Current);
                        }
                        else
                        {
                            x += String.Format("{0}{1}: {2}\n", new String('-', depth), myPropInfo.Name, o);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.Error.WriteLine(e.Message);
                }
            }
            depth--;
            return x;
        }
    }
}
