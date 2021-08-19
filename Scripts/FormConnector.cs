using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace RandevuYazılımSistemi
{
    class FormConnector
    {
        private Form myCentralForm;

        private List<Form> myConnectedForms = new List<Form>();

        private Point myMainLocation;

        public FormConnector(Form centralform)
        {
            this.myCentralForm = centralform;
            this.myMainLocation = new Point(this.myCentralForm.Location.X, this.myCentralForm.Location.Y);
            this.myCentralForm.LocationChanged += new EventHandler(CentralForm_LocationChanged);
        }

        public void ConnectForm(Form form)
        {
            if(!this.myConnectedForms.Contains(form))
            {
                this.myConnectedForms.Add(form);
            }
        }

        void CentralForm_LocationChanged(object sender, EventArgs e)
        {
            Point relativeChange = new Point(this.myCentralForm.Location.X - this.myMainLocation.X , this.myCentralForm.Location.Y - this.myMainLocation.Y);
            foreach(Form form in this.myConnectedForms)
            {
                form.Location = new Point(form.Location.X + relativeChange.X, form.Location.Y + relativeChange.Y);
            }

            this.myMainLocation = new Point(this.myCentralForm.Location.X, this.myCentralForm.Location.Y);
        }
    }
}
