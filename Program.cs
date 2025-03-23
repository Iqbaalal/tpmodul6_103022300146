class Program
{
    static void Main(string[] args)
    {
        try
        {
            SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract – [Muhammad Iqbal Al Khaththath]");
            for (int i = 0; i < 1000; i++)
            {
                video.IncreasePlayCount(1000000);
            }
            video.PrintVideoDetails();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}