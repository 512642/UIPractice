public class SavedData
{

    public static int score = 0;
    public static int highScore;
    public static float musicVolume;
    public static float sfxVolume;
    public static float masterVolume;
    public static string difficulty;
   

   public static string GetScoreText()
   {
       string text = score.ToString();
       return text;
   }
   public static int Getscore()
   {
       return score;
   }
   public static void SetScore(int newScore)
   {
       score = newScore;
   }
       /* int score = SavedData.Getscore();

       SavedData.SetScore(score);*/
        //use to acceess methods from another script/gameObject.
}
