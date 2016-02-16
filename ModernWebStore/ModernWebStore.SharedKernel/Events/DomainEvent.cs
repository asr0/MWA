using ModernWebStore.SharedKernel.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernWebStore.SharedKernel.Events
{
public   class DomainEvent : IDomainEvent
    {
        public static IContainer Container { get; set; }
        public DateTime DateOccurred { get; private set; }


        public static void Raise<T>(T args) where T : IDomainEvent
        {
            try
            {
                if (Container != null)
                {
                    var obj = Container.GetService(typeof(IHandler<T>));
                    ((IHandler<T>)obj).Handle(args);
                }
            }
            catch
            {
                //throw;
            }
        }
    }
}
