using System.Windows.Media;

namespace SingletonTest1
{
    public class Singleton
    {
        private static Singleton _instance;

        public bool IsMcardAvailable { get; set; } = true;
        public Brush Colour { get; set; } = Brushes.AliceBlue;

        public string MyString { get; set; } = "Hello, World";
        public static Singleton Instance => GetInstance();
        public static Singleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Singleton();
            }
            return _instance;
        }
        private Singleton()
        {
            System.Diagnostics.Debug.WriteLine("Create a singleton!");
        }
    }
}
