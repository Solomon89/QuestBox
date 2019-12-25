using Microsoft.AspNetCore.Identity;
using QuestBox.Models.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace QuestBox.Models
{
    public class Users : IdentityUser<int>, IDictionaryModel
    {
        [DisplayName("Имя")]
        public string Name { get; set; }
        [DisplayName("Фамилия")]
        public string Surname { get; set; }
        [DisplayName("Отчество")]
        public string SecondName { get; set; }
        [DisplayName("Дата рождения")]
        public DateTime DateOfBirth { get; set; }
        [DisplayName("Пол")]
        public bool Gender { get; set; }
        [DisplayName("О себе")]
        public string AboutYourself { get; set; }
        [DisplayName("Команда")]
        public virtual Comand Comand { get; set; }
        public List<string> Names => new List<string> { "Name", "Surname", "SecondName", "DateOfBirth", "Gender", "AboutYourself", "Comand" };
        public List<string> RussianNames => new List<string> { "Имя", "Фамилия", "Отчество", "Дата рождения", "Пол", "О себе", "Команда" };
     }
}
