using System.Diagnostics;

namespace UIdsComparer
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var statusComparer = new StatusComparer.StatusComparer();
            statusComparer.Run();
        }
    }
}
