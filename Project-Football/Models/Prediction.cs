namespace Project_Football.Models
{
    public class Prediction
    {

        public int Id { get; set; }
        public Game Game { get; set; }
        public GameResult Result { get; set; }

        //TODO прогнозата трябва да има потребител
    }
}
