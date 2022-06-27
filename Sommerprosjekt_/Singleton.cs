using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sommerprosjekt_
{
    //thread safe.. inspect further
    //simple thread safe singleton
    //
    public sealed class Singleton
    {
        private static Singleton instance = null; 
        private static readonly  object padlock = new object();

        // Explicit static constructor to tell C# compiler
        // not to mark type as beforefieldinit

        Singleton()
        {
            
        }
        
        public static Singleton Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new Singleton();
                    }
                    return instance;
                }
            }
        }
        
    }
}
