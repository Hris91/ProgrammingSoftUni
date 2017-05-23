using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Fish_Statistics
{
    class Fish
    {
        public string FishLooks { get; set; }
        public int TailLength { get; set; }
        public int BodyLength { get; set; }
        public string Status { get; set; }
        public string TailType { get; set; }
        public string BodyType { get; set; }

        public Fish CreateFish(string fishLooks, int tail, int body, string status, string tailType, string bodyType)
        {
            Fish currentFish = new Fish()
            {
                FishLooks = fishLooks,
                TailLength = tail,
                BodyLength = body,
                Status = status,
                TailType = tailType,
                BodyType = bodyType
                          
            };
            return currentFish;
        }
    }
}
