using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuestBox.Models.Core
{
    public class UsersCrud : CrudBase<Users>
    {
        public UsersCrud(
            QuestBoxDbContext questBoxDbContext,
            DbSet<Users> current
            
            ) 
            : base(questBoxDbContext, current,
                    new Dictionary<string, string>
                    {
                    {"Name","Имя"},
                    {"Surname", "Фамилия"},
                    {"SecondName", "Отчество"},
                    {"DateOfBirth", "Дата рождения"},
                    {"Gender", "Пол"},
                    {"AboutYourself", "О себе"},
                    {"Comand.tostring", "Команда"}

                    }
                    )
        {
        }
    }
}
