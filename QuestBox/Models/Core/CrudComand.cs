using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuestBox.Models.Core
{
    public class CrudComand : CrudBase<Comand>
    {
        public CrudComand(QuestBoxDbContext questBoxDbContext, DbSet<Comand> current) : base(questBoxDbContext, current, new Dictionary<string, string>()
        {
            {"Name","Название"}
        })
        {

        }
    }
}
