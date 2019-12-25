using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace QuestBox.Models
{
    public class Comand: BaseModel
    {
        [DisplayName("Название")]
        public string Name { get; set; }
        [DisplayName("Состав команды")]
        public virtual List<Users> Users { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
