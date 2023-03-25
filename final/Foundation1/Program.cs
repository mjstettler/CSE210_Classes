using System;

class Program
{
    
    static void Main(string[] args)
    {
        List<Video> _videos = new List<Video>();

        Video youtubeCat = new Video("Kittens", "Prrrfection", 3500);
        Video youtubeDogs = new Video("Mans best friend", "BloodHound Media", 5000);
        Video youtubePeople = new Video("This man did what? Watch to see!", "Clickbaiter supreme", 6050);

        _videos.Add(youtubeCat);
        _videos.Add(youtubeDogs);
        _videos.Add(youtubePeople);       

        youtubeCat.SetComment("LonelyGuy19", "I loved this video! Please post more!");
        youtubeCat.SetComment("NotyourMom", "My cat does that all the time!");
        youtubeCat.SetComment("GUY2444", "Thats why I never mow my lawn! Cats scare me.");

        youtubeDogs.SetComment("DogGirl22", "Oh my gosh, that puppy is the Cutest!!!");
        youtubeDogs.SetComment("Frank", "I wish I had a dog, my wife died years ago and I am so lonely!");
        youtubeDogs.SetComment("FranksWife", "Frank, I am not dead you crazy old man, I am sitting next to you!");

        youtubePeople.SetComment("YellowDragon","I wished I had never watched this video");
        youtubePeople.SetComment("LyuC","Click bait! This is just another cat video");
        youtubePeople.SetComment("PapaBear","I did the same thing...Wait is that me? Where did you get this footage?");
        
        foreach (Video video in _videos)
        {
            video.DisplayVideoInfo();
        }
        
        
    }
}