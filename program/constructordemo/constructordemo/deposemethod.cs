using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Sql;

namespace constructordemo
{
    public class deposemethod: IDisposable
    {
        private bool isDisposed = false;
        public void Dispose() 
        {
        Dispose(true);

         GC.SuppressFinalize(this); 
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!isDisposed)
            {
                if (disposing)
                {
                    Console.WriteLine("free manage code");
                    //code to dipose the managed reources
                    //held by the class
                }
            }
             
        //code to dispose the unmanaged resources
            //held by the class
        isDisposed = true;
         this.Dispose(disposing);
    }
    
~deposemethod()
{
    Dispose(false);
}
   
        static void Main(string[] args)
        {
            deposemethod dc = new deposemethod();
            Console.WriteLine("objected dec");
            dc = null;
            
            Console.WriteLine("code");

        }
    }
}