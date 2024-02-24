using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicesAvancedProgramming.UrlShortener
{
    public class UrlShorteningService(ApplicationDbContext dbContext)
    {
        private readonly Random _random = new();

        public async Task<string> GenerateUniqueCode()
        {
            var codeChars = new char[ShortLinkSettings.Length];
            int maxValue = ShortLinkSettings.Alphabet.Length;

            while (true)
            {
                Parallel.For(0, ShortLinkSettings.Length, i =>
                {
                    var randomIndex = _random.Next(maxValue);
                    codeChars[i] = ShortLinkSettings.Alphabet[randomIndex];
                });

                var code = new string(codeChars);

                if (!await dbContext.ShortenedUrls.AnyAsync(s => s.Code == code)) return code;
            }
        }
    }
}
