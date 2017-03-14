using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Social_Media_Posts
{
    class Program
    {
        static void Main(string[] args)
        {
            var likes = new Dictionary<string, int>();
            var dislikes = new Dictionary<string, int>();
            var comments = new Dictionary<string, Dictionary<string, string>>();
            var posts = new List<string>();

            string line = Console.ReadLine();

            while (line != "drop the media")
            {
                string[] tokens = line.Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries).ToArray();
                string command = tokens[0];
                string postName = tokens[1];

                if (command == "post" && !posts.Contains(postName))
                {
                    posts.Add(postName);
                }
                else if (command == "like")
                {
                    AddLike(postName, likes);
                }
                else if (command == "dislike")
                {
                    AddDislike(postName, dislikes);
                }
                else if(command == "comment")
                {
                    string commentatorName = tokens[2];
                    var commentToArray = tokens.Skip(3).ToArray();
                    var stringByilder = new StringBuilder();
                  
                    for (int i = 0; i < commentToArray.Length; i++)
                    {
                        stringByilder.Append(commentToArray[i]).Append(" ");
                    }
                    string currentComment = stringByilder.ToString();

                    AddComments(postName, commentatorName, currentComment, comments);
                }

                line = Console.ReadLine();
            }

            for (int i = 0; i < posts.Count; i++)
            {
                if (!likes.ContainsKey(posts[i]))
                {
                    likes[posts[i]] = 0;
                }
                if (!dislikes.ContainsKey(posts[i]))
                {
                    dislikes[posts[i]] = 0;
                }

                Console.WriteLine($"Post: {posts[i]} | Likes: {likes[posts[i]]} | Dislikes: {dislikes[posts[i]]}");
                Console.WriteLine("Comments:");

                if (!comments.ContainsKey(posts[i]))
                {
                    Console.WriteLine("None");
                }
                else
                {
                    var values = comments[posts[i]];

                    foreach (var value in values)
                    {
                        Console.WriteLine($"*  {value.Key}: {value.Value}");
                    }
                }
            }           
        }

        private static void AddComments(string postName, string commentatorName, string currentComment,
            Dictionary<string, Dictionary<string, string>> comments)
        {
            if (!comments.ContainsKey(postName))
            {
                comments[postName] = new Dictionary<string, string>();
            }
            comments[postName][commentatorName] = currentComment;
        }

        static void AddDislike(string postName, Dictionary<string, int> dislikes)
        {
            if (!dislikes.ContainsKey(postName))
            {              
                dislikes[postName] = 0;
            }
            dislikes[postName]++;
        }

       static void AddLike(string postName, Dictionary<string, int> likes)
        {
            if (!likes.ContainsKey(postName))
            {
                likes[postName] = 0;
            }          
            likes[postName]++;
        }
    }
}
