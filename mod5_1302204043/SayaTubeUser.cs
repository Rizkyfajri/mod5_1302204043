using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mod5_1302204043
{
    internal class SayaTubeUser
    {
        private string username;
        private int ID;
        List<SayaTubeVideo> UploadedVideos;

        public SayaTubeUser(string username)
        {
            try
            {
                if (this.username != null && username.Length < 200)//contract
                {
                    this.username = username;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("error : cannot be null or exceed 200 character limit");
            }
        }

        public void AddVideo()
        {

        }
        public void GetTotalVideoPlaycount()
        {

        }
        public void PrintAllVideoPlaycount()
        {
            Console.WriteLine("User : "+ username);
            foreach (var data in UploadedVideos)
            {
                int vid = 1;
                Console.WriteLine("Video "+vid+ " : "+UploadedVideos);
                vid = vid + 1;
            }
        }
    }
}
