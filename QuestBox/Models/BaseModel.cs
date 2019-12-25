using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace QuestBox.Models
{
    public class BaseModel
    {
        [DisplayName("Идентификационный номер")]
        public int Id { get; set; }
    }
}
