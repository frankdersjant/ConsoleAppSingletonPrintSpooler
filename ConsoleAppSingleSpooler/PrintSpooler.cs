namespace ConsoleAppSingletonPrintSpooler
{
    public sealed class PrintSpooler
    {
        //Static: always only ONE instance no matter how many instances of classes 

        private static PrintSpooler instance = null;

        private PrintSpooler() { }

        //null-coalescing assignment operator ??=
        //assigns the value of its right-hand operand to its left-hand operand only if the left-hand operand evaluates to null.
        public static PrintSpooler Instance => instance ??= new PrintSpooler();
    }
}
