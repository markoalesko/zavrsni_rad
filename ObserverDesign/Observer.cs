using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesign
{
    public class Observer : IObserver
    {

        public int ID;
        private List<IObservable> SubscribedList = new List<IObservable>();
        private ObserverForm myObserverForm;

        public Observer(int id)
        {
            ID = id;
        }
        
        public int getID()
        {
            return ID;
        }

        public void Subscribe(IObservable obs)
        {
            SubscribedList.Add(obs);
            obs.AddObserver(this);
        }

        public void Update(string name, string content)
        {

            myObserverForm.MyNotification(name, content);
        }
        public void AssignForm(ObserverForm myForm)
        {
            myObserverForm = myForm;
        }

        public void Refresh()
        {
            myObserverForm._Refresh();
        }


    }
}
