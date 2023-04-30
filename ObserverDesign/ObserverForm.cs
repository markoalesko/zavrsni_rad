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
    public partial class ObserverForm : Form
    {

        public int ID;
        private IObserver thisobserver;
        string selectedBlog = "blog";
        string BlogText = "Text updates here";
   
        public ObserverForm()
        {
            InitializeComponent();

            for (int i = 0; i < MainForm.AllObservablesListNames.Count(); i++)
                AvailableBlogs_listbox.Items.Add(MainForm.AllObservablesListNames[i]);

            if (SubscribedBlogs_listbox.SelectedItem != null)
            {
                selectedBlog = (SubscribedBlogs_listbox.SelectedIndex).ToString();
                groupBox1.Text = selectedBlog;
            }
        }
        public void Assign(IObserver myObs)
        {
            thisobserver = myObs;
        }
        private IObservable selectedObjectBlog(string Name)
        {

            IObservable obs = MainForm.AllObservableObjects[0]; //avoiding error "use of unassigned local variable

            for (int i = 0; i < MainForm.AllObservableObjects.Count(); i++)
            {
                if (MainForm.AllObservableObjects[i].getName() == Name)
                {
                    obs = MainForm.AllObservableObjects[i];
                    break;
                }
            }
            return obs;
        }
        public void MyNotification(string name, string content)
        {
            mynotiflabel.Text = name + " Has been updated!";
            BlogText = content;

        }
        private void Subscribe_btn_Click(object sender, EventArgs e)
        {

            selectedBlog = (AvailableBlogs_listbox.SelectedItem).ToString();

            try
            {
                SubscribedBlogs_listbox.Items.Add(AvailableBlogs_listbox.SelectedItem);
                thisobserver.Subscribe(selectedObjectBlog(selectedBlog));
                System.Diagnostics.Debug.WriteLine("Subscribed observer " + thisobserver.getID() + " to OBSERVABLE " + selectedObjectBlog(selectedBlog).getName());
                System.Diagnostics.Debug.WriteLine("selectedBlog = " + selectedBlog.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Select a blog");
            }           

        }
       public void _Refresh()
        {
            blogtext_label.Text = BlogText;
        }
    }

   
}
