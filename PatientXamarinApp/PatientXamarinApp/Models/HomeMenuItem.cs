using System;
using System.Collections.Generic;
using System.Text;

namespace PatientXamarinApp.Models
{
    public enum MenuItemType
    {
        Browse,
        Gender,
        Experience,
        Department,
        BloodGroup,
        Patient,
        Doctor,
        Appointment,
        About
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
