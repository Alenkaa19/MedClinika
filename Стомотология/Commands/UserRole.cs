using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Стомотология.БД;

namespace Стомотология.Roles
{
    public static class UserRole
    {
        //привязываем роль и сообщение подходящее
        public const string Admin = "Вы вошли как Администратор";
        public const string User = "Вы вошли как Пользователь";
        public const string vrach = "Вы вошли как Врач";
        private static readonly string[] myPrivateArray = new string[] { "admin" };//определяем по какому признаку назначать роль

        private static readonly string[] myPrivateArray1 = new string[] { "vrach" }; //определяем по какому признаку назначать роль

        public static Пользователь пользователь { get; set; }

        //Прописываем условия распределения ролей
        public static string GetRole()
        {
            if (myPrivateArray.Contains(пользователь.Логин))
                return Admin;
            if (myPrivateArray1.Contains(пользователь.Логин))
                return vrach;
            else
                return User;
        }


    }

}

