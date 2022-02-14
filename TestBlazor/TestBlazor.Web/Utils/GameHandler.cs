namespace TestBlazor.Web.Utils
{
    public class GameHandler
    {
        public RspOptions Choose { get; set; }

        public RspOptions WinCondition { get; set; }

        public RspOptions LooseCondition { get; set; }

        public string Image { get; set; }

        public GameState GameResult(GameHandler opponent)
        {
            if (Choose == opponent.Choose)
            {
                return GameState.Draw;
            }

            if (LooseCondition == opponent.Choose)
            {
                return GameState.Loss;
            }

            return GameState.Victory;
        }
    }
}