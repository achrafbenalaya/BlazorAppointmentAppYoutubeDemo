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

    }
}
