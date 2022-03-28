using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
//using ContactsApp;

namespace ContactsApp
{
    /// <summary>
    /// основа. Класс с основными данными проекта 
    /// </summary>
    public class Project
    {
        /// <summary>
        /// список контактов
        /// </summary>
        public List<Contact> Contacts { get; } = new List<Contact>();

        /// <summary>
        /// сортировка в алфавитном порядке
        /// </summary>
        /// <returns>Возвращает отсортированый по фамилии в алфавитном порядке список контактов</returns>
        public List<Contact> GetSorted() => Contacts.OrderBy(i => i.LastName).ToList();

        /// <summary>
        /// поиск по фамилии
        /// </summary>
        /// <param name="query"></param>
        /// <returns>Возвращает отсортированый по фамилии в алфавитном порядку начиная с заданной строки</returns>
        public List<Contact> FindSorted(string query) => Contacts
        .Where(i => i.LastName.StartsWith(query))
        .OrderBy(j => j.LastName)
        .ToList();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(Project other)
        {
            return Contacts.SequenceEqual(other.Contacts);
        }

    }
}
