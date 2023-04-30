using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesign
{
    public interface IObservable
    {
        void AddObserver(IObserver obs);
        void NotifyObservers();
        String getName();
        void setName(String name);
        String getContent();
        void setContent(String content);
        List<IObserver> getObservers();


    }
}
