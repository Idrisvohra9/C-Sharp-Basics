using System;
namespace constructordemo
{
    public class CodeFile1 : IDisposable
    {
        private bool disposed = false;
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    Console.WriteLine("clean");
                    //clean up managed objects
                }
                Console.WriteLine("unmanage");
                //clean up unmanaged objects
                disposed = true;
            }
        }
        static void Main(string[] args)
        {
            CodeFile1 c1 = new CodeFile1();
            c1.Dispose();
            
            Console.ReadKey();
        }
    }
}