using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using PixelClicker.Interfaces;

namespace PixelClicker
{
    public class Plugins
    {
        public static ICollection<Type> Items = Load();
        private static ICollection<Type> Load()
        {
            if (!Directory.Exists("./Plugins")) return null;

            var dllFileNames = Directory.GetFiles("./Plugins", "*.dll");
 
            ICollection<Assembly> assemblies = new List<Assembly>(dllFileNames.Length);
            foreach (string dllFile in dllFileNames)
            {
                AssemblyName an = AssemblyName.GetAssemblyName(dllFile);
                Assembly assembly = Assembly.Load(an);
                assemblies.Add(assembly);
            }

            Type pluginType = typeof(ITask);
            ICollection<Type> pluginTypes = new List<Type>();
            foreach (Assembly assembly in assemblies)
            {
                if (assembly == null) continue;

                Type[] types = assembly.GetTypes();

                foreach (Type type in types)
                {
                    if (type.IsInterface || type.IsAbstract) continue;
                    Debug.WriteLine(type.FullName);

                    if (type.GetInterface(pluginType.FullName) == null) continue;

                    pluginTypes.Add(type);
                }
            }
            return pluginTypes;
        }
    }
}
