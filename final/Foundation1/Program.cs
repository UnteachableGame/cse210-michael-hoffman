using Foundation1;

internal class Program {
    static List<Video> videos = new ();
    
    private static void Main() {
        Console.Clear();
        
        Video video1 = new Video("Apple Lost the AI Race", "Marques Brownlee", new Duration(7, 04));
        video1.Comments.Add(new Comment("@HajAga-Mehr", "Glad to see Marques supporting small creators like MKBHD"));
        video1.Comments.Add(new Comment("@alphasoundz9850", "Love to see more collabs between Marques and MKBHD"));
        video1.Comments.Add(new Comment("@pozzitivy-show", "-You twins?\n-Nah, we cousins."));
        videos.Add(video1);
        
        Video video2 = new Video("How I wasted $52,000 in my Dream Smart Home", "Mrwhosetheboss", new Duration(19, 48));
        video2.Comments.Add(new Comment("@GONER765", "Bros \"mistakes\" are worth more than my entire life savings and net worth"));
        video2.Comments.Add(new Comment("@Stefanboom", "It was 2 YEARS ago?? Time really flies"));
        video2.Comments.Add(new Comment("@SandvicherTf2", "Happly i won't make those mistakes, cause i don't have money"));
        videos.Add(video2);
        
        Video video3 = new Video("Customer Walked Out Without Paying...Then Came Back?", "Digital Doctor", new Duration(13, 33));
        video3.Comments.Add(new Comment("@azurazdandaridae9158", "It was nice of that guy to come back when he realized his payment had declined."));
        video3.Comments.Add(new Comment("@noahbundonis", "That man who returned will be blessed ten fold. ❤️👏🏻"));
        video3.Comments.Add(new Comment("@ottokarl5427", "Coming back as a customer because YOU notice that there has been an issue with payment is just great tbh.\nI had that with a woman a few years ago. She paid with her card, receipt got out, everything was fine. Only later did I notice that the receipt said \"card not accepted\" or something like that - which our reader has never done before, usually when a receipt is printed it means that the payment got through.\n\nIt was a bit annoying because it was a one-time-transaction and we really didn't have any contact info for that woman. About a month later however she dropped in and asked if something went wrong, because she never was charged for this. After explaining to her that there was an error, she immediately paid the missing sum."));
        videos.Add(video3);
        
        Video video4 = new Video("I moved to France", "Mumbo Jumbo", new Duration(13, 19));
        video4.Comments.Add(new Comment("@Grian", "So that's where you were keeping your diamonds"));
        video4.Comments.Add(new Comment("@jrb5000-gm", "\"First time we visited it rained all the time\" \n\nNo wonder it felt like home for an Englishman"));
        video4.Comments.Add(new Comment("@tuckerpedersen5469", "An Englishman, a Frenchman, and a Minecraft YouTuber walk into a bar. He simply says, \"it's really quite simple,\" and makes his exit, leaving everyone quite jealous of his fabulous mustache"));
        videos.Add(video4);

        foreach (Video video in videos) {
            video.Display();
        }
    }
}