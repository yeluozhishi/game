using mine_game.src.service;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace mine_game.src.utils
{
    class ReflectionUtil
    {
        public static List<T> getInstance<T>()
        {
            var list = new List<Type>();
            var t = typeof(T);
            Assembly assembly = Assembly.GetAssembly(t);
            var types = assembly.GetTypes();
            foreach (var type in types)
            {
                if (!type.IsInterface)
                {
                    Type[] ins = type.GetInterfaces();
                    foreach (var i in ins)
                    {
                        if (i == typeof(T))
                        {
                            list.Add(type);
                        }
                    }
                }
            }

            var instances = new List<T>();
            list.ForEach(c => instances.Add((T)Activator.CreateInstance(c)));
            return instances;
        }

    }
}
