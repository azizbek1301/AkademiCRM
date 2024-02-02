using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyCenter.Domain.Dtos.Foods
{
    public class FoodsUpdateDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Food_Rate { get; set; }
        public int FoodCategory_id { get; set; }
    }
}
