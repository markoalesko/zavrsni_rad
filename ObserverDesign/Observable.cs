using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesign
{
    public class Observable : IObservable
    {

        private List<IObserver> MyObservers = new List<IObserver>();
        
        public string name;
        private string content;

        public List<IObserver> getObservers()
        {
            return this.MyObservers;
        }


        public String getName()
        {
            return name;
           
        }

        public void setName(String name){
            this.name = name;
        }
 
        public string getContent()
        {
            return content;
        }

        public void setContent(string text)
        {
            content = text;
        }

        
        public void NotifyObservers()
        {
          
            for (int i = 0; i<MyObservers.Count(); i++)
            {
                getObservers()[i].Update(name, content);
                getObservers()[i].Refresh();
            }
                
        }

        public void AddObserver(IObserver obs)
        {
            MyObservers.Add(obs);
        }


    }
}
