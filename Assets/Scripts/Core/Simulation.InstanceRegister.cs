namespace Platformer.Core
{
    public static partial class Simulation
    {
        static class InstanceRegister<T> where T : class, new()
        {
            public static T Instance = new T();
        }
    }
}
