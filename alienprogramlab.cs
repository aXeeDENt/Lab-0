using System.Collections.Generic;

namespace Lab_0
{
    public class AlienClass
    {
        public int id { get; set; }
        public bool? isHumanoid { get; set; }
        public string? planet { get; set; }
        public int? age { get; set; }
        public List<string>? traits { get; set; }
    }

    public class AlienData
    {
        public List<AlienClass>? input { get; set; }
    }
}
