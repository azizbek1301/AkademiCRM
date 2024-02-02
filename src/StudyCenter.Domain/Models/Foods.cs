namespace StudyCenter.Domain.Models
{
    public class Foods
    {
        public int Id {  get; set; }
        public string Name { get; set; }
        public decimal Food_Rate {  get; set; }
        public int FoodCategory_id {  get; set; }

        public Food_Category Food_Category { get; set; }
    }
}
