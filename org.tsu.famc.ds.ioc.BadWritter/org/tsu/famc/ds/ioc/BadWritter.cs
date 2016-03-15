using System;

namespace org.tsu.famc.ds.ioc
{
/*
    public class Bindings : Ninject.Modules.NinjectModule
    {
        public override void Load()
        {
            Bind<IWritter>().To<BadWritter>();
        }
    }
*/
    public class BadWritter : IWritter
    {
        public void Write(string msg)
        {

            Console.WriteLine("Your f@cking message is \": " + msg + "\"");
        }
    }
}
