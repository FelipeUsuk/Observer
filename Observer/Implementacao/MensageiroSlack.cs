using Observer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Implementacao
{
    class MensageiroSlack : IObserver
    {
        public void Update(string message)
        {
            Console.WriteLine("NOTIFICACÇÃO SLACK  -- " + message);
        }
    }
}
