using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Collections.Generic;
using MediaClient.Models;
using System.Linq;


namespace MediaClient
{
    class MainClass
    {
        static HttpClient client = new HttpClient();


        static async Task<Uri> CreateMediaAsync(Media media, String url)
        {

            HttpResponseMessage response = await client.PostAsJsonAsync(url, media);

            response.EnsureSuccessStatusCode();
            return response.Headers.Location;

        }

        static async Task<Media> GetMediaAsync(string path){

            Media m = null;
            HttpResponseMessage response = await client.GetAsync(path);

            if (response.IsSuccessStatusCode )
            {
                m = await response.Content.ReadAsAsync<Media>(); 
            }

            return m;
        }

        static async Task<Media> UpdateMediaAsync(Media media, string url){
            HttpResponseMessage  response = await client.PutAsJsonAsync(url,media);
            response.EnsureSuccessStatusCode();
            media = await response.Content.ReadAsAsync<Media>();

            return media;
        }

        static async Task<HttpStatusCode> DeleteMediaAsync(string url){
            HttpResponseMessage response = await client.DeleteAsync(url);

            return response.StatusCode; 

        }
        static async Task<List<Media>> GetAllMediaAsync(string path){
            List<Media> mediaList = null;
            HttpResponseMessage response = await client.GetAsync(path);

            if (response.IsSuccessStatusCode )
            {
                mediaList = await response.Content.ReadAsAsync<List<Media>>(); 
             
            }

            return mediaList;
        }


     

        public static void Main(string[] args)
        {

            RunClientAsync().GetAwaiter().GetResult();  

        }

         static async Task RunClientAsync(){

            client.BaseAddress = new Uri("http://localhost:5000/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            //var img = new Image
            //{
            //    Id = 2,
            //    Name = "IMAGE002",
            //    Format = ImageFormat.JPG,
            //    Width = 600,
            //    Height = 520,
            //    Path = "/Users/rest/"

            //};


            List<Media> MediaList = new List<Media>();


            MediaList.Add( new Image { Id = 2, Name = "IMAGE002", Format = ImageFormat.JPG, Width = 600, Height = 520, Path = "/Users/rest" }); 
            MediaList.Add( new Video { Id = 1, Name = "VIDEO001", Format = VideoFormat.FLW , Width = 640, Height = 480, Path = "/Users/rest/Documents" }); 
            MediaList.Add( new Image { Id = 3, Name = "IMAGE003", Format = ImageFormat.PNG , Width = 1920, Height = 1080, Path = "/Users/rest" }); 
            MediaList.Add( new Video { Id = 2, Name = "VIDEO002", Format = VideoFormat.AVI , Width = 640, Height = 480, Path = "/Users/rest/Documents" }); 
            MediaList.Add( new Image { Id = 4, Name = "IMAGE004", Format = ImageFormat.PNG , Width = 1920, Height = 1080, Path = "/Users/rest" }); 
            MediaList.Add( new Video { Id = 3, Name = "VIDEO003", Format = VideoFormat.AVI , Width = 640, Height = 480, Path = "/Users/rest/Documents" }); 
            MediaList.Add( new Image { Id = 5, Name = "IMAGE005", Format = ImageFormat.PNG , Width = 1920, Height = 1080, Path = "/Users/rest" }); 
            MediaList.Add( new Video { Id = 4, Name = "VIDEO004", Format = VideoFormat.AVI , Width = 640, Height = 480, Path = "/Users/rest/Documents" }); 
            MediaList.Add( new Image { Id = 6, Name = "IMAGE006", Format = ImageFormat.PNG , Width = 1920, Height = 1080, Path = "/Users/rest" }); 
            MediaList.Add( new Video { Id = 5, Name = "VIDEO005", Format = VideoFormat.AVI , Width = 640, Height = 480, Path = "/Users/rest/Documents" }); 
            MediaList.Add( new Image { Id = 8, Name = "IMAGE008", Format = ImageFormat.PNG , Width = 1920, Height = 1080, Path = "/Users/rest" }); 
            MediaList.Add( new Video { Id = 6, Name = "VIDEO006", Format = VideoFormat.AVI , Width = 640, Height = 480, Path = "/Users/rest/Documents" }); 
            MediaList.Add( new Image { Id = 9, Name = "IMAGE009", Format = ImageFormat.PNG , Width = 1920, Height = 1080, Path = "/Users/rest" }); 
            MediaList.Add( new Video { Id = 7, Name = "VIDEO007", Format = VideoFormat.AVI , Width = 640, Height = 480, Path = "/Users/rest/Documents" }); 
            MediaList.Add( new Image { Id = 10, Name = "IMAGE010", Format = ImageFormat.PNG , Width = 1920, Height = 1080, Path = "/Users/rest" }); 
            MediaList.Add( new Video { Id = 8, Name = "VIDEO008", Format = VideoFormat.AVI , Width = 640, Height = 480, Path = "/Users/rest/Documents" }); 
            MediaList.Add( new Image { Id = 11, Name = "IMAGE011", Format = ImageFormat.PNG , Width = 1920, Height = 1080, Path = "/Users/rest" }); 
            MediaList.Add( new Video { Id = 9, Name = "VIDEO009", Format = VideoFormat.AVI , Width = 640, Height = 480, Path = "/Users/rest/Documents" }); 
            MediaList.Add( new Image { Id = 12, Name = "IMAGE012", Format = ImageFormat.PNG , Width = 1920, Height = 1080, Path = "/Users/rest" }); 
            MediaList.Add( new Video { Id = 10, Name = "VIDEO010", Format = VideoFormat.AVI , Width = 640, Height = 480, Path = "/Users/rest/Documents" }); 
            MediaList.Add( new Image { Id = 13, Name = "IMAGE013", Format = ImageFormat.PNG , Width = 1920, Height = 1080, Path = "/Users/rest" }); 
            MediaList.Add( new Video { Id = 11, Name = "VIDEO011", Format = VideoFormat.AVI , Width = 640, Height = 480, Path = "/Users/rest/Documents" }); 
            MediaList.Add( new Image { Id = 14, Name = "IMAGE014", Format = ImageFormat.PNG , Width = 1920, Height = 1080, Path = "/Users/rest" }); 
            MediaList.Add( new Video { Id = 12, Name = "VIDEO012", Format = VideoFormat.AVI , Width = 640, Height = 480, Path = "/Users/rest/Documents" }); 
            MediaList.Add( new Image { Id = 15, Name = "IMAGE015", Format = ImageFormat.PNG , Width = 1920, Height = 1080, Path = "/Users/rest" }); 
            MediaList.Add( new Video { Id = 13, Name = "VIDEO013", Format = VideoFormat.AVI , Width = 640, Height = 480, Path = "/Users/rest/Documents" }); 
            MediaList.Add( new Image { Id = 16, Name = "IMAGE016", Format = ImageFormat.PNG , Width = 1920, Height = 1080, Path = "/Users/rest" }); 
            MediaList.Add( new Video { Id = 14, Name = "VIDEO014", Format = VideoFormat.AVI , Width = 640, Height = 480, Path = "/Users/rest/Documents" }); 
            MediaList.Add( new Image { Id = 17, Name = "IMAGE017", Format = ImageFormat.PNG , Width = 1920, Height = 1080, Path = "/Users/rest" }); 
            MediaList.Add( new Video { Id = 15, Name = "VIDEO015", Format = VideoFormat.AVI , Width = 640, Height = 480, Path = "/Users/rest/Documents" }); 
            MediaList.Add( new Image { Id = 18, Name = "IMAGE018", Format = ImageFormat.PNG , Width = 1920, Height = 1080, Path = "/Users/rest" }); 
            MediaList.Add( new Video { Id = 16, Name = "VIDEO016", Format = VideoFormat.AVI , Width = 640, Height = 480, Path = "/Users/rest/Documents" }); 
            MediaList.Add( new Image { Id = 19, Name = "IMAGE019", Format = ImageFormat.PNG , Width = 1920, Height = 1080, Path = "/Users/rest" }); 
            MediaList.Add( new Video { Id = 17, Name = "VIDEO017", Format = VideoFormat.AVI , Width = 640, Height = 480, Path = "/Users/rest/Documents" }); 
            MediaList.Add( new Image { Id = 20, Name = "IMAGE020", Format = ImageFormat.PNG , Width = 1920, Height = 1080, Path = "/Users/rest" }); 
            MediaList.Add( new Video { Id = 18, Name = "VIDEO018", Format = VideoFormat.AVI , Width = 640, Height = 480, Path = "/Users/rest/Documents" }); 
            MediaList.Add( new Image { Id = 21, Name = "IMAGE021", Format = ImageFormat.PNG , Width = 1920, Height = 1080, Path = "/Users/rest" }); 
            MediaList.Add( new Video { Id = 19, Name = "VIDEO019", Format = VideoFormat.AVI , Width = 640, Height = 480, Path = "/Users/rest/Documents" }); 
            MediaList.Add( new Image { Id = 22, Name = "IMAGE022", Format = ImageFormat.PNG , Width = 1920, Height = 1080, Path = "/Users/rest" }); 
            MediaList.Add( new Video { Id = 20, Name = "VIDEO020", Format = VideoFormat.AVI , Width = 640, Height = 480, Path = "/Users/rest/Documents" }); 
            MediaList.Add( new Image { Id = 23, Name = "IMAGE023", Format = ImageFormat.PNG , Width = 1920, Height = 1080, Path = "/Users/rest" }); 
            MediaList.Add( new Video { Id = 21, Name = "VIDEO021", Format = VideoFormat.AVI , Width = 640, Height = 480, Path = "/Users/rest/Documents" }); 
            MediaList.Add( new Image { Id = 24, Name = "IMAGE024", Format = ImageFormat.PNG , Width = 1920, Height = 1080, Path = "/Users/rest" }); 
            MediaList.Add( new Video { Id = 22, Name = "VIDEO022", Format = VideoFormat.AVI , Width = 640, Height = 480, Path = "/Users/rest/Documents" }); 
            MediaList.Add( new Image { Id = 25, Name = "IMAGE025", Format = ImageFormat.PNG , Width = 1920, Height = 1080, Path = "/Users/rest" }); 
            MediaList.Add( new Video { Id = 23, Name = "VIDEO023", Format = VideoFormat.AVI , Width = 640, Height = 480, Path = "/Users/rest/Documents" }); 
            MediaList.Add( new Image { Id = 26, Name = "IMAGE026", Format = ImageFormat.PNG , Width = 1920, Height = 1080, Path = "/Users/rest" }); 
            MediaList.Add( new Video { Id = 24, Name = "VIDEO024", Format = VideoFormat.AVI , Width = 640, Height = 480, Path = "/Users/rest/Documents" }); 
            MediaList.Add( new Image { Id = 27, Name = "IMAGE027", Format = ImageFormat.PNG , Width = 1920, Height = 1080, Path = "/Users/rest" }); 
            MediaList.Add( new Video { Id = 25, Name = "VIDEO025", Format = VideoFormat.AVI , Width = 640, Height = 480, Path = "/Users/rest/Documents" }); 
            MediaList.Add( new Image { Id = 28, Name = "IMAGE028", Format = ImageFormat.PNG , Width = 1920, Height = 1080, Path = "/Users/rest" }); 
            MediaList.Add( new Video { Id = 26, Name = "VIDEO026", Format = VideoFormat.AVI , Width = 640, Height = 480, Path = "/Users/rest/Documents" }); 



            foreach (var item in MediaList)
            {

                if(item is Image){

                    var url = await CreateMediaAsync( item , "api/Images");
                    Console.WriteLine($"create image at {url}");
                }else{

                    var url = await CreateMediaAsync(item , "api/Videos");
                    Console.WriteLine($"create video at {url}");

                }

            }





            Console.ReadLine();


            var ml = await GetAllMediaAsync("api/Images");
            //var mlv = await GetAllMediaAsync("api/Videos");  
            ml.AddRange(await GetAllMediaAsync("api/Videos"));


            var mediaquery = from elem in ml where elem.Width < 1920 && elem.Path.Length < 255
                              select elem;
           



            foreach (var item in mediaquery )
            {
                    Console.WriteLine($"Id= {item.Id } Name= {item.Name } - Size {item.Size}");
            }


            Console.ReadLine();

        }



    }
}
