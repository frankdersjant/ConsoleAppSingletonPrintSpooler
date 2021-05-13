namespace ConsoleAppSingleSpooler
{
    public sealed class PrintSpooler
    {
        private static PrintSpooler instance = null;

        private PrintSpooler() { }

        public static PrintSpooler Instance => instance ??= new PrintSpooler();
    }
}
