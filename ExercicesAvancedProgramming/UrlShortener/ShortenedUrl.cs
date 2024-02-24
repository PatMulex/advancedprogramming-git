using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicesAvancedProgramming.UrlShortener
{
    public class ShortenedUrl
    {
        public Guid Id { get; set; }
        public string LongUrl { get; set; } = string.Empty;
        public string ShortUrl { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;
        public DateTime CreatedOnUtc { get; set; }

    }
}
