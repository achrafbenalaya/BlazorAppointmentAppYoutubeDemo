using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using PatientXamarinApp.Models;
using PatientXamarinApp.Services;
using Xamarin.Forms;

namespace PatientXamarinApp.ViewModels
{
  public class EditBloodGroupsViewModel
    {


        public BloodGroups TheSelectedBloodGroup { get; set; }
        private DataServices _dataServices = new DataServices();

        public ICommand EditBloodGroupsCommand => new Command(async () =>

        {
            TheSelectedBloodGroup.Urd = System.DateTime.Now.ToShortDateString();
            await _dataServices.PutBloodGroup(TheSelectedBloodGroup.BloodGroupsId, TheSelectedBloodGroup);


        });

        public ICommand DeleteBloodGroupsCommand => new Command(async () =>

        {
            await _dataServices.DeleteBloodGroup(TheSelectedBloodGroup.BloodGroupsId);

        });


    }
}
