using SOLID.OCP;
using SOLID.SRP;
using LSPF = SOLID.LSP.FirstExample;
using LSPS = SOLID.LSP.SecondExample;


namespace SOLID
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //RunSRP();
            //RunOCP();
            //RunLSP();


            Console.ReadLine();
        }

        private static void RunLSP()
        {
            LSPF.IShape shape = new LSPF.Rectangle();
            ((LSPF.Rectangle)shape).SetWidth(10);
            ((LSPF.Rectangle)shape).SetHeight(10);
            Console.WriteLine(shape.Area());
            shape = new LSPF.Square();
            ((LSPF.Square)shape).SetSideLength(5);
            Console.WriteLine(shape.Area());
        }

        private static void RunOCP()
        {
            IShape shape = new Rectangle()
            {
                Width = 10,
                Height = 5
            };
            shape.Print();

            Console.WriteLine();

            shape = new Square() { Side = 5 };
            shape.Print();
        }

        private static void RunSRP()
        {
            Book book = new Book("Clean Code", "TempAutherName", 2023, 49.99m, "EEEE");
            Invoice invoice = new Invoice(book, 2, 0.1, 0.2, default);

            InvoicePrinter printer = new InvoicePrinter(invoice);
            printer.Print();

            Console.WriteLine("\n");
            InvoiceCalculator calculator = new InvoiceCalculator(invoice);
            invoice._total = Convert.ToDouble(calculator.Calculate());
            Console.WriteLine($"Total Price : {invoice._total}");
        }
    }
}