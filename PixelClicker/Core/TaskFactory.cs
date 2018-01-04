using System;
using PixelClicker.Interfaces;

namespace PixelClicker.Core
{
    public class TaskFactory
    {
        public static ITask Create(Type type, params object[] args)
        {
            return (ITask) Activator.CreateInstance(type, args);
        }
    }
}
