using System;

namespace UrlFixer
{
    public class UrlFixer
    {
        public static void Main(string[] args)
        {
            string url = string.Format("https{0}//www.reddit.com/r/nevertellmethebots", ":");

            // Accidentally I got the wrong URL for a funny subreddit. It's probably "odds" and not "bots"
            // Also, the URL is missing a crucial component, find out what it is and insert it too!
            // Try to solve it more than once using different string functions!

            string replacedUrl = url.Replace("bots", "odds");

            Console.WriteLine(replacedUrl);
            Console.ReadKey();
        }
    }
}