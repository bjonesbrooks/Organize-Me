using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrganizeMe
{
    public partial class Calendar // :Form
    {
        string name;
        int size;
        string month;

        string defaultName = "calendar";
        int defaultSize = 100;

        public Calendar()
        {
            this.setName(defaultName);
            this.setSize(defaultSize);
            this.setMonth("January");
        }

        //private void Form1_Load(object sender, EventArgs e)
        //{

        //}

        private void clearCalendar()
        {
            //something that clears the calendar
        }

        private void setMonth(string m)
        {
            month = m;
        }

        private void sendMessage(string s)
        {
            print(s);
        }

        void main()
        {
            Calendar NorthHills = new Calendar();
            bob.setName("North Hills");
            bob.setMonth("July");

            bob.sendMessage("Order a building inspection for" + bob.name);
        }
    }
}
