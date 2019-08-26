using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using PatientXamarinApp.Models;

namespace PatientXamarinApp.Services
{
   public class DataServices
   {

       private string GenderUrl = Constants.GenderLink;
       private string BloodGrouperUrl = Constants.BloodGroupsLink;
       private string ExperiencerUrl = Constants.ExperienceLink;
       private string DepartmentsUrl = Constants.DepartmentsLink;
       private string PatientsUrl = Constants.PatientsLink;
       private string DoctorssUrl = Constants.DoctorsLink;


        #region Genders


        public async Task<List<Genders>> GetGenders()
        {

            var HttpClient = new HttpClient();
            var Json= await HttpClient.GetStringAsync(GenderUrl);
            var Genders = JsonConvert.DeserializeObject<List<Genders>>(Json);

            return Genders;
        }




        public async Task PostGenders(Genders genders)

        {

            var httpClient = new HttpClient();
            var jsonObject = JsonConvert.SerializeObject(genders);
            StringContent content =new StringContent(jsonObject);
            content.Headers.ContentType= new MediaTypeHeaderValue("application/json");
            var result=  await httpClient.PostAsync(GenderUrl, content);

            

        }

        public async Task PutGenders(int id,Genders genders)

        {

            var httpClient = new HttpClient();
            var jsonObject = JsonConvert.SerializeObject(genders);
            StringContent content = new StringContent(jsonObject);
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var result = await httpClient.PutAsync(GenderUrl+id, content);



        }


        public async Task DeleteGenders(int id)
        {

            var HttpClient = new HttpClient();
            var responsen = await HttpClient.DeleteAsync(GenderUrl+id);

           // return Genders;
        }

        #endregion




        #region BloodGroup
        public async Task<List<BloodGroups>> GetBloodGroup()
        {

            var BloodClient = new HttpClient();
            var Json = await BloodClient.GetStringAsync(BloodGrouperUrl);
            var TheBloodGroups = JsonConvert.DeserializeObject<List<BloodGroups>>(Json);

            return TheBloodGroups;
        }




        public async Task PostBloodGroup(BloodGroups bloodGroups)

        {

            var httpClient = new HttpClient();
            var jsonObject = JsonConvert.SerializeObject(bloodGroups);
            StringContent content = new StringContent(jsonObject);
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var result = await httpClient.PostAsync(BloodGrouperUrl, content);



        }

        public async Task PutBloodGroup(int id, BloodGroups bloodGroups)

        {

            var httpClient = new HttpClient();
            var jsonObject = JsonConvert.SerializeObject(bloodGroups);
            StringContent content = new StringContent(jsonObject);
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var result = await httpClient.PutAsync(BloodGrouperUrl + id, content);



        }


        public async Task DeleteBloodGroup(int id)
        {

            var HttpClient = new HttpClient();
            var responsen = await HttpClient.DeleteAsync(BloodGrouperUrl + id);

           
        }


        #endregion


        #region Experience


        public async Task<List<Experience>> GetExperience()
        {

            var HttpClient = new HttpClient();
            var Json = await HttpClient.GetStringAsync(ExperiencerUrl);
            var Experiences = JsonConvert.DeserializeObject<List<Experience>>(Json);

            return Experiences;
        }




        public async Task PostExperience(Experience experience)

        {

            var httpClient = new HttpClient();
            var jsonObject = JsonConvert.SerializeObject(experience);
            StringContent content = new StringContent(jsonObject);
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var result = await httpClient.PostAsync(ExperiencerUrl, content);



        }

        public async Task PutExperience(int id, Experience experience)

        {

            var httpClient = new HttpClient();
            var jsonObject = JsonConvert.SerializeObject(experience);
            StringContent content = new StringContent(jsonObject);
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var result = await httpClient.PutAsync(ExperiencerUrl + id, content);



        }


        public async Task DeleteExperience(int id)
        {

            var HttpClient = new HttpClient();
            var responsen = await HttpClient.DeleteAsync(ExperiencerUrl + id);

        }

        #endregion




        #region Departments


        public async Task<List<Departments>> GetDepartments()
        {

            var HttpClient = new HttpClient();
            var Json = await HttpClient.GetStringAsync(DepartmentsUrl);
            var departments = JsonConvert.DeserializeObject<List<Departments>>(Json);

            return departments;
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="departments"></param>
        /// <returns></returns>
        public async Task PostDepartments(Departments departments)

        {

            var httpClient = new HttpClient();
            var jsonObject = JsonConvert.SerializeObject(departments);
            StringContent content = new StringContent(jsonObject);
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var result = await httpClient.PostAsync(DepartmentsUrl, content);



        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="experience"></param>
        /// <returns></returns>
        public async Task PutDepartments(int id, Departments departments)

        {

            var httpClient = new HttpClient();
            var jsonObject = JsonConvert.SerializeObject(departments);
            StringContent content = new StringContent(jsonObject);
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var result = await httpClient.PutAsync(DepartmentsUrl + id, content);



        }

        /// <summary>
        /// Delete Department passing ID in param
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task DeleteDepartments(int id)
        {

            var HttpClient = new HttpClient();
            var responsen = await HttpClient.DeleteAsync(DepartmentsUrl + id);

        }


        #endregion



        #region Patients

        public async Task<List<Patients>> GetPatients()
        {

            var HttpClient = new HttpClient();
            var Json = await HttpClient.GetStringAsync(PatientsUrl);
            var patients = JsonConvert.DeserializeObject<List<Patients>>(Json);

            return patients;
        }



  
        public async Task PostPatients(Patients _patients)

        {

            var httpClient = new HttpClient();
            var jsonObject = JsonConvert.SerializeObject(_patients);
            StringContent content = new StringContent(jsonObject);
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var result = await httpClient.PostAsync(PatientsUrl, content);



        }


   
        public async Task PutPatients(int id, Patients patients)

        {

            var httpClient = new HttpClient();
            var jsonObject = JsonConvert.SerializeObject(patients);
            StringContent content = new StringContent(jsonObject);
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var result = await httpClient.PutAsync(PatientsUrl + id, content);



        }

    
        public async Task DeletePatients(int id)
        {

            var HttpClient = new HttpClient();
            var responsen = await HttpClient.DeleteAsync(PatientsUrl + id);

        }




        #endregion


        #region Doctors

        public async Task<List<Doctors>> GetDoctors()
        {

            var HttpClient = new HttpClient();
            var Json = await HttpClient.GetStringAsync(DoctorssUrl);
            var doctors = JsonConvert.DeserializeObject<List<Doctors>>(Json);

            return doctors;
        }


        public async Task PostDoctors (Doctors _doctors)

        {

            var httpClient = new HttpClient();
            var jsonObject = JsonConvert.SerializeObject(_doctors);
            StringContent content = new StringContent(jsonObject);
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var result = await httpClient.PostAsync(DoctorssUrl, content);


        }




        public async Task PutDoctors(int id, Doctors doctors)

        {

            var httpClient = new HttpClient();
            var jsonObject = JsonConvert.SerializeObject(doctors);
            StringContent content = new StringContent(jsonObject);
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var result = await httpClient.PutAsync(DoctorssUrl + id, content);

        }

        public async Task DeleteDoctor(int id)
        {

            var HttpClient = new HttpClient();
            var responsen = await HttpClient.DeleteAsync(DoctorssUrl + id);

        }


        #endregion






    }
}
