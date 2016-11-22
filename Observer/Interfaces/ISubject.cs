using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Interfaces
{
    interface ISubject
    {
        void Adicionar(IObserver observer);
        void Remover(IObserver observer);
        void Notificar(string mensagem);
    }
}
