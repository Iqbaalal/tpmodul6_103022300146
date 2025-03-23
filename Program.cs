class Program
{
    static void Main(string[] args)
    {
        SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract – [Muhammad Iqbal Al Khaththath]");
        video.IncreasePlayCount(100);
        video.PrintVideoDetails();
    }
}