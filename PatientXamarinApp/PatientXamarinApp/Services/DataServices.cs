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
       //private string GenderUrl = "https://192.168.1.9:45457/api/Genders";
       private string GenderUrl = "https://achraf-server.conveyor.cloud/api/genders/";
       private string BloodGrouperUrl = "https://achraf-server.conveyor.cloud/api/BloodGroups/";
       private string ExperiencerUrl = "https://achraf-server.conveyor.cloud/api/experiences/";


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


    }
}
