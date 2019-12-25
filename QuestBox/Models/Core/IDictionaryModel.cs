using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuestBox.Models.Core
{
    public interface IDictionaryModel
    {
         int Id { get; set; }
         List<string> Names { get;  }
         List<string> RussianNames { get;  }
         
    }
}
