using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuestBox.Models.Core
{
    public interface ICrud
    {
        IEnumerable<object> GetElements();
        object GetElement(int Id);
        Dictionary<string, string> GetHeadersOfTable();
        object NewElement();
        void EditElement(Dictionary<string, string> Values);
    }
}
