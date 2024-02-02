namespace StudyCenter.Domain.Dtos.FoodComment
{
    public class FoodCommentCreateDto
    {
        public string Comment { get; set; }
        public DateTime Date { get; set; }
        public int Food_id { get; set; }
    }
}
