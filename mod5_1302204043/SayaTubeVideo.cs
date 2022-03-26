using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mod5_1302204043
{
    internal class SayaTubeVideo
    {

        private string title;
        private int ID, Playcount;

        private int digimin = 10000;
        private int digimax = 99999;

        Random rng = new Random();


        public SayaTubeVideo(string title)
        {
            try
            {
                if(this.title != null && title.Length < 200)
                {
                    this.title = title;
                    ID = rng.Next(digimin, digimax);
                    Playcount = 0;
                }  
            }
            catch (Exception)
            {
                Console.WriteLine("error : cannot be null or exceed 200 character limit");
            }
        }

        public void PrintVideoDetail()
        {
            Console.WriteLine("ID: "+ID+" ,Judul: "+title+" ,Played: "+Playcount)
        }
    }
}
