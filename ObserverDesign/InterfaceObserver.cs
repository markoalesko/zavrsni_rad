using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesign
{
    public interface IObserver
    {
        void Subscribe(IObservable obs);
        void Update(string name, string content);
        void AssignForm(ObserverForm myForm);
        void Refresh();
        int getID();
    }
}
