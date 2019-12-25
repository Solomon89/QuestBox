using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Threading.Tasks;

namespace QuestBox.Models.Core
{
    public class CrudBase<T> :ICrud where T : class, new()
    {
        private QuestBoxDbContext _questBoxDbContext;
        private DbSet<T> _current;
        private Dictionary<string, string> _HeadersOfTable;



        public CrudBase(QuestBoxDbContext questBoxDbContext, DbSet<T> current,Dictionary<string,string> HeadersOfTable)
        {
            _questBoxDbContext = questBoxDbContext;
            _current = current;
            _HeadersOfTable = HeadersOfTable;
        }

        public IEnumerable<object> GetElements()
        {
            return _current.Select(item=>(object)item).ToList();
        }
        public object GetElement(int Id)
        {
            return _questBoxDbContext.Find(typeof(T), Id);
        }

        public Dictionary<string, string> GetHeadersOfTable()
        {
            return _HeadersOfTable;
        }

        public object NewElement()
        {
            return new T();
        }

        public void EditElement(Dictionary<string, string> Values)
        {
            T current;
            if (Values.ContainsKey("id") && Values["id"] != "0")
            {
                current = (T)GetElement(Convert.ToInt32(Values["id"]));
            }
            else
            {
                current = new T();
            }
            foreach (var item in Values)
            {
                if (current.GetType().GetProperty(item.Key) != null)
                {
                    var currentItem = current.GetType().GetProperty(item.Key);
                    if (currentItem.PropertyType == typeof(int))
                    {
                        int valueToSet;
                        int.TryParse(item.Value, out valueToSet);
                        current.GetType().GetProperty(currentItem.Name).SetValue(current, valueToSet);
                    }
                    else if (currentItem.PropertyType == typeof(double))
                    {
                        double valueToSet;
                        double.TryParse(item.Value, out valueToSet);
                        current.GetType().GetProperty(currentItem.Name).SetValue(current, valueToSet);
                    }
                    else if (currentItem.PropertyType == typeof(string))
                    {
                        current.GetType().GetProperty(currentItem.Name).SetValue(current, item.Value);
                    }
                    _questBoxDbContext.SaveChanges();
                }
            }
         }
    }
}
