using System.ComponentModel.DataAnnotations;

namespace Entity
{
    public class Mark
    {
        public int MarksId { get; set; }
        public int StudentId { get; set; }
        public int Science { get; set; }
        public int Maths { get; set; }
        public int English { get; set; }
    }
} 