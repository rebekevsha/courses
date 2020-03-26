using System;
using System.Text;
using System.Collections.Generic;

namespace LessonSix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            //Given
            var petroBamper = new Vlog()
            {
                Vloger = "Petro Bamper",
                Videos =
                {
                  new Video
                  {
                      Name = "Бампер і Сус ПОПЕРЕДЖАЮТЬ",
                      Url = "https://www.youtube.com/watch?v=R5NTDG0Mg7I",
                      Coments = { new Comment(), new Comment(), new Comment() }
                  },
                  new Video
                  {
                      Name = "Петро Бампер про ремонт",
                      Url = "https://www.youtube.com/watch?v=WtGrzI_MqPI",
                      Coments = { new Comment(), new Comment(), new Comment() }
                  },
                  new Video
                  {
                      Name = "Петро Бампер про Президенство",
                      Url = "https://www.youtube.com/watch?v=5m1w_twUK3Q"
                  }
                }
            };

            //act
            //=======================================================================================================
            petroBamper.Videos.ForEach(i => Console.Write("-- \"{0}\" / {1}\n", i.Name, i.Url));
            Console.WriteLine();
            GetTotalVlogViews(petroBamper);
            Console.WriteLine();
            GetVideoThatHaveMoreLikelyComment(petroBamper);
            Console.WriteLine();
            GetDislikelyVideo(petroBamper);
            Console.ReadLine();

            //Helpers
            //=======================================================================================================
            static void GetVideoThatHaveMoreLikelyComment(Vlog vlog)
            {
                Video videoWithLikelyComment = null;
                Comment likelyComment = null;
                foreach (var video in vlog.Videos)
                {
                    int videoLikes = video.Like;
                    foreach (var coment in video.Coments)
                    {
                        if (videoLikes < coment.Like)
                            videoWithLikelyComment = video;
                            likelyComment = coment;
                    }
                }
                if (videoWithLikelyComment != null && likelyComment != null)
                    Console.WriteLine($"Video: \"{videoWithLikelyComment.Name}\" have a comment: \"{likelyComment.Text}\" that more popular than video.((((");
            }

            static void GetTotalVlogViews(Vlog vlog)
            {
                int totalCount = 0;
                foreach (var item in vlog.Videos)
                {
                    totalCount += item.ViewCounter;
                }
                Console.WriteLine($"Vloger \"{vlog.Vloger}\" has totaly {totalCount} views.");
            }

            static void GetDislikelyVideo(Vlog vlog)
            {
                List<Video> shitVideo = new List<Video>();
                int dislikes = 0;
                foreach (Video video in vlog.Videos)
                {
                    if (dislikes < video.Dislike)
                    {
                        dislikes = video.Dislike;
                        shitVideo.RemoveRange(0, shitVideo.Count);
                        shitVideo.Add(video);
                    }
                    else if (dislikes == video.Dislike)
                    {
                        shitVideo.Add(video);
                    }
                }
                shitVideo.ForEach(i => Console.Write("The shit video is: \"{0}\"\t", i.Name));
            }
            //=======================================================================================================
        }
    }
    class Vlog
    {
        public Vlog() { Videos = new List<Video>(); }
        public string Vloger { get; set; }
        public List<Video> Videos { get; set; }

    }
    class Video : Reaction
    {
        public Video() 
        {
            Coments = new List<Comment>();
            ViewCounter = DataHelper.GetVideoViews();
            Like = DataHelper.GetVideoReactions();
            Dislike = DataHelper.GetVideoReactions();
        }
        public string Name { get; set; }
        public string Url { get; set; }
        public int ViewCounter { get; set; }
        public List<Comment> Coments { get; set; }

        public override string ToString()
        { 
            return $"Video: \"{Name}\" / Views: {ViewCounter} / Likes: {Like} / Dislikes: {Dislike} /";
        }

    }
    class Comment : Reaction
    {
        public Comment() 
        {
            Text = DataHelper.GetRandomSentence(new Random().Next(5,10));
            Like = DataHelper.GetComentReactions();
            Dislike = DataHelper.GetComentReactions();
        }
        public string Text { get; set; }
        public override string ToString()
        {
            return $"Comment: \"{Text}\" / Likes: {Like} / Dislikes: {Dislike}";
        }
    }
    class Reaction
    {
        public int Like { get; set; }
        public int Dislike { get; set; }
    }
    static class DataHelper
    {
        public static int GetVideoReactions() => new Random().Next(200, 2000);
        public static int GetComentReactions() => new Random().Next(200, 1000);
        public static int GetVideoViews() => new Random().Next(2000, 20000);
        public static string GetRandomSentence(int wordCount)
        {
            string[] words = { "an", "automobile", "or", "motor", "car", "is", "a", "wheeled", "motor", "vehicle", "used", "for", "transporting", "passengers", "which", "also", "carries", "its", "own", "engine", "or" };

            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < wordCount; i++)
            {
                // Select a random word from the array
                builder.Append(words[new Random().Next(words.Length)]).Append(" ");
            }

            string sentence = builder.ToString().Trim() + ". ";

            // Set the first letter of the first word in the sentenece to uppercase
            sentence = char.ToUpper(sentence[0]) + sentence.Substring(1);

            builder = new StringBuilder();
            builder.Append(sentence);

            return builder.ToString();
        }
    }
}
