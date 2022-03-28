using System.ComponentModel.DataAnnotations;
namespace razorpagesmovies.models
{
    public class movie
    {public int Id { get; set; }
        public string Title { get; set; }=String.Empty;

        [DataType(DataType.Date)]
        public DateTime RelaeseDate { get; set; }
        public string Genre { get; set; } = string.Empty;
        public decimal Price { get; set; }

    }
}
