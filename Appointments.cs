using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NHolbrook_c969_Software_2
{
    public class Appointments
    {
        public int AppointmentID { get; set; }
        public int CustomerId { get; set; }
        public int UserId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public string Contact { get; set; }
        public string Type { get; set; }
        public string Url { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public DateTime CreateDate { get; set; }
        public String CreatedBy { get; set; }
        public DateTime LastUpdate  {get; set;}
        public String LastUpdatedBy { get; set; }
        public int SelectedIndex { get; }
        public string Text1 { get; }
        public string Text2 { get; }
        public TextBox InputLocation { get; }
        public TextBox InputContact { get; }
        public ComboBox ComboBoxType { get; }
        public string Text3 { get; }
        public string Text4 { get; }
        public string Text5 { get; }
        public string Text6 { get; }
        public DateTime Value { get; }
        public DateTimePicker DateTimePickerEnd { get; }

        public Appointments( int customerID, int userID, string title, string description, string location, string contact, string type, string url, DateTime startTime, DateTime endTime)
        {
            CustomerId = customerID;
            UserId = userID;
            Title = title;
            Description = description;
            Location = location;
            Contact = contact;
            Type = type;
            Url = url;
            StartTime = startTime;
            EndTime = endTime;

        }

        public Appointments() { }

        public Appointments(int selectedIndex, string text1, string text2, TextBox inputLocation, TextBox inputContact, ComboBox comboBoxType)
        {
            SelectedIndex = selectedIndex;
            Text1 = text1;
            Text2 = text2;
            InputLocation = inputLocation;
            InputContact = inputContact;
            ComboBoxType = comboBoxType;
        }

        public Appointments(int selectedIndex, string text1, string text2, string text3, string text4, string text5, string text6, DateTime value, DateTimePicker dateTimePickerEnd, String title)
        {
            SelectedIndex = selectedIndex;
            Text1 = text1;
            Text2 = text2;
            Text3 = text3;
            Text4 = text4;
            Text5 = text5;
            Text6 = text6;
            Value = value;
            Title = title; 
            DateTimePickerEnd = dateTimePickerEnd;
        }
    }
}
