using System.Collections.Generic;

namespace Car_Quiz.Models
{
    public class Question
    {

        public string Intrebare { get; set; }
        public List<string> Optiuni { get; set; }
        public string RaspunsCorect { get; set; }
    }
}
