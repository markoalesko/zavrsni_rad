using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ObserverDesign
{
    public partial class MainForm : Form
    {

      
        //Lista samo za provjeru forme
        public static List<string> AllObservablesListNames = new List<string>();
       
        public static List<IObservable> AllObservableObjects = new List<IObservable>();
        //public static List<Observer> AllObserverObjects = new List<Observer>();

        public int ID = 0;
        public MainForm()
        {
            InitializeComponent();
            
        }

        private void AddObservable_btn_Click(object sender, EventArgs e)
        {
            //provjera je li tekstualno polje za ime bloga prazno
            if (blogname_textbox.Text == "")
                MessageBox.Show("Upisite ime bloga");

            //ako nije izvrši sljedeće
            else if (!(AllObservablesListNames.Contains(blogname_textbox.Text)))
            {
                AllObservablesListNames.Add(blogname_textbox.Text);
                IObservable observable = new Observable();
                
                observable.setName(blogname_textbox.Text);
                AllObservableObjects.Add(observable);
                
                ObservableForm observableForm = new ObservableForm();
                observableForm.Show();
                observableForm.formname = blogname_textbox.Text;
                observableForm.Text = blogname_textbox.Text;
                
                observableForm.Assign(observable);

                System.Diagnostics.Debug.WriteLine("Connected Form " + observableForm.formname + " with object " + observable.getName());
                System.Diagnostics.Debug.WriteLine("List count AOB = " + AllObservableObjects.Count());
            }

        }

        private void AddObserver_btn_Click(object sender, EventArgs e)
        {
            IObserver observer = new Observer(ID);
            
            ObserverForm observerForm = new ObserverForm();
            observerForm.Show();
            observerForm.Text = "Observer " + ID;
            //Assign (connect) the form with the observer
            observerForm.Assign(observer);
            observer.AssignForm(observerForm);
            ID++;

            System.Diagnostics.Debug.WriteLine("Connected Form " + observerForm.Name + " with object " + observer.getID());


        }
    }
}
