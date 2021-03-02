using System.Collections.Generic;

namespace D11.OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Interfacelerde o interfaceyi implement eden classın ramdeki referansını tutabilir.
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(tasitKrediManager, fileLoggerService);

            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager, tasitKrediManager, konutKrediManager };
            
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
            
            

        }
        public void Method<T1,T2>()
        {

        }
    }
}
