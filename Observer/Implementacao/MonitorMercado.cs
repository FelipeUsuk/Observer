using Observer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Implementacao
{
    class MonitorMercado : ISubject
    {
        List<IObserver> observadores;
        string Mensagem;
        string Ativo;
        public MonitorMercado(string ativo)
        {
            Ativo = ativo;
            observadores = new List<IObserver>();
        }

        public void Adicionar(IObserver observer)
        {
            observadores.Add(observer);
        }

        public void Notificar(string mensagem)
        {
            foreach (var observador in observadores)
            {
                observador.Update(string.Format("{0} - {1}", Ativo,mensagem));
            }
        }

        public void Remover(IObserver observer)
        {
            observadores.Remove(observer);
        }

        
    }
}
