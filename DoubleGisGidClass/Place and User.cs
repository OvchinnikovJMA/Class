using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleGisGidClasses
{
    /// <summary>
    /// Представитель какой-либо организации может зарегистрировать несколько мест города
    /// Или данный список может выдаваться пользователю при поиске подходящего места города
    /// </summary>
    public class Places
    {
        /// <summary>
        /// Список мест
        /// </summary>
        public List<Place> ListOfPlaces { get; set; }
        /// <summary>
        /// Для представителей мест города регистрация нового места
        /// </summary>
        public RegistrationPlace Registration { get; set; }
    }
    /// <summary>
    /// Данные, вводимые представителем для регистрации места
    /// </summary>
    public class RegistrationPlace
    {
        /// <summary>
        /// Адрес места
        /// </summary>      
        public Address Address { get; set; }
        /// <summary>
        /// Название места
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Описание места
        /// </summary>
        public string Discription { get; set; }
        /// <summary>
        /// Фото
        /// </summary>
        public byte[] MainPhoto { get; set; }
        /// <summary>
        /// Контакты с местом
        /// </summary>
        public Contacts Contacts { get; set; }
    }

    /// <summary>
    /// То из чего состоит информация, представленная пользователю о выбранном месте
    /// </summary>
    public class Place
    {
        /// <summary>
        /// Список ключевых слов, которые пользователи задают месту(например #Вкусно , #Дёшево)
        /// </summary>
        public List<string> KeyWords { get; set; }
        /// <summary>
        /// Название места
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Рейтинг места, составляемый пользователем
        /// </summary>
        public Rating Rating { get; set; }
        /// <summary>
        /// Информация о месте
        /// </summary>
        public Information Information { get; set; }
        /// <summary>
        /// Фото
        /// </summary>
        public byte[] MainPhoto { get; set; }
        /// <summary>
        /// Контакты с местом
        /// </summary>
        public Contacts Contacts { get; set; }
        /// <summary>
        /// Комментарии пользователей о месте
        /// </summary>
        public CommentsOfPlace Comments { get; set; }

    }
    /// <summary>
    /// Комментарии Места
    /// </summary>
    public class CommentsOfPlace
    {
        /// <summary>
        /// Положительный комментарий, набравший большее количество лайков
        /// </summary>
        public string MaxPositiveComment { get; set; }
        /// <summary>
        /// Отрицательный комментарий, набравший большее количество лайков
        /// </summary>
        public string MinNegativeComment { get; set; }
        /// <summary>
        /// Все комментарии в виде списка
        /// </summary>
        public List<Comment> AllComments { get; set; }

    }
    /// <summary>
    /// Комментарий
    /// </summary>
    public class Comment
    {
        /// <summary>
        /// Имя комментирующего
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Фото комментирующего
        /// </summary>
        public byte[] Photo { get; set; }
        /// <summary>
        /// Количество лайков
        /// </summary>
        public int Likes { get; set; }
        /// <summary>
        /// Количество дизлайков
        /// </summary>
        public int Dislikes { get; set; }
        /// <summary>
        /// Текст комментария
        /// </summary>
        public string Text { get; set; }
    }
    /// <summary>
    /// Контакты с представителями места
    /// </summary>
    public class Contacts
    {
        /// <summary>
        /// Номера телефона представителей места(при необходимости)
        /// </summary>
        public List<int> PhoneNumber { get; set; }
        /// <summary>
        /// Ссылки на соц.сети
        /// </summary>
        public List<string> SocialContacts { get; set; }
    }
    /// <summary>
    /// Информация о месте, которую сооставляет представитель
    /// </summary>
    public class Information
    {
        /// <summary>
        /// Имя предсавителя места
        /// </summary>
        public string SpokesmanName { get; set; }
        /// <summary>
        /// Описание, составляемое представителем места
        /// </summary>
        public string Discription { get; set; }
        /// <summary>
        /// Список Адресов места
        /// </summary>
        public List<Address> Addresses { get; set; }
    }
    /// <summary>
    /// Адрес места
    /// </summary>
    public class Address
    {
        /// <summary>
        /// Город, где находится место
        /// </summary>
        public string City { get; set; }
        /// <summary>
        /// Регион места
        /// </summary>
        public string Region { get; set; }
        public Street Street { get; set; }
    }
    /// <summary>
    /// Улица
    /// </summary>
    public class Street
    {
        public double Number { get; set; }
        public string Name { get; set; }
    }
    /// <summary>
    /// Оценка места
    /// </summary>
    public class Rating
    {
        /// <summary>
        /// Оценки, от 1 до 10, поставленные пользователями
        /// </summary>
        public List<int> Evaluations { get; set; }
        /// <summary>
        /// Метод, вычисляющий рейтинг места, принимая оценки пользователей
        /// </summary>
        /// <param name="Список оценок пользователей"></param>
        /// <returns>Рейтинг места</returns>
        public double GetRating(List<int> evaluations)
        {
            var rating = 0;
            foreach (var e in evaluations)
                rating += e;
            rating = rating / evaluations.Count;
            return rating;
        }
    }

    public class User
    {
        /// <summary>
        /// Регистрация пользователя
        /// </summary>
        public RegistrationUser Registration { get; set; }
        /// <summary>
        /// Маршруты пользователя
        /// </summary>
        public List<Rought> Roughts { get; set; }

    }

    public class Rought
    {
        /// <summary>
        /// Маршрут, в виде списка мест, составляемый пользователем 
        /// </summary>
        public List<Place> MyRought { get; set; }
    }

    public class RegistrationUser
    {
        /// <summary>
        /// Логин
        /// </summary>
        public string Login { get; set; }
        /// <summary>
        /// Пароль
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// Тип пользователя
        /// </summary>
        public TypeOfUser TypeOfUser { get; set; }
        /// <summary>
        /// Пол
        /// </summary>
        public GenderType Gender { get; set; }
    }

    public enum TypeOfUser
    {
        /// <summary>
        /// Обычный Пользователь
        /// </summary>
        User,
        /// <summary>
        /// Представитель места
        /// </summary>
        SpokesmanOfPlace,
        /// <summary>
        /// Администратор
        /// </summary>
        Admin
    }

    public enum GenderType
    {
        Man,
        Woman,
        /// <summary>
        /// Защита от проблем с толерантностью
        /// </summary>
        Another
    }
}