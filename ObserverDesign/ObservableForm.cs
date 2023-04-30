using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObserverDesign
{
    public partial class ObservableForm : Form
    {

        public string formname;
        private IObservable thisobservable;
        public ObservableForm()
        {
            InitializeComponent();

        }

        public void Assign(IObservable myObs)
        {
            thisobservable = myObs;
        }

        private void update_btn_Click(object sender, EventArgs e)
        {

            thisobservable.setContent(blogtext_textbox.Text); 
            thisobservable.NotifyObservers();
           
        }

        private void Refresh_btn_Click(object sender, EventArgs e)
        {
            if (thisobservable != null)
            {
                MyObserver_listbox.Items.Clear();
                NumberOfObservers_label.Text = thisobservable.getObservers().Count().ToString();

                for (int i = 0; i < thisobservable.getObservers().Count(); i++)
                    MyObserver_listbox.Items.Add(thisobservable.getObservers()[i].getID());

            }
        }
    }
}
