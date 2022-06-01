using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


        public Appointments(int appointmentId, int customerID, int userID, string title, string description, string location, string contact, string type, string url, DateTime startTime, DateTime endTime)
        {
            AppointmentID = appointmentId;
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
    }
}
