using System;
using Ninject;

namespace org.tsu.famc.ds.ioc
{
    class IOCTester
    {
        static void Write(IWritter writter, string msg)
        {
            writter.Write(msg);
        }

        static void Main(string[] args)
        {
            try
            {
                var kernel = new Ninject.StandardKernel();
                kernel.Load("IOCTester.xml");
                IWritter writter = kernel.Get<IWritter>();
                Write(writter, "Hello world!");
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.Message);
            }
        }
    }
}
