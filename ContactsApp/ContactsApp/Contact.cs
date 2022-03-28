using System;

namespace ContactsApp
{
    /// <summary>
    /// содержит информацию о контакте 
    /// </summary>
    public class Contact :ICloneable, IEquatable<Contact>
    {   
        /// <summary>
        /// минимальная дата рождения
        /// </summary>
        private static readonly DateTime MinDate = new DateTime(1900, 1, 1);

        /// <summary>
        /// макс длина текстовых полей 
        /// </summary>
        private static readonly short MaxTextLenght = 60;

        /// <summary>
        /// Фмилия
        /// </summary>
        private string _lastName = "";

        /// <summary>
        /// Имя
        /// </summary>
        private string _firstName = "";

        /// <summary>
        /// ДАта рождения
        /// </summary>
        private DateTime _birthday = DateTime.Today;

        /// <summary>
        /// Электронная почта
        /// </summary>
        private string _email = "";

        /// <summary>
        /// Вконтакте
        /// </summary>
        private string _vkId = "";

        /// <summary>
        /// Номер телефона
        /// </summary>
        private Phone _phoneNumber = new Phone();

        /// <summary>
        /// Получает и возвращает номер телефона 
        /// </summary>
        public long PhoneNumber
        {
            get => _phoneNumber.Number;
            set => _phoneNumber.Number = value;
        }

        /// <summary>
        /// получает и возвращает дату рождения
        /// </summary>
        /// <exception cref="ArgumentException">
        /// Если дата ранее 1.1.1900</exception>
        public DateTime Birtday
        {
            get => _birthday;
            set
            {
                if(value < MinDate || value > DateTime.Today)
                {
                    throw new ArgumentException("ДАта рождения не должна быть ранее" 
                        + MinDate.ToString("D")
                        +" или позднее сегодняшнего дня");
                    _birthday = value;
                }
            }

        }

        /// <summary>
        /// получает и возфращает фамилию
        /// </summary>
        /// <exception cref="ArgumentException">если слишком длинное </exception>
        public string LastName
        {
            get => _lastName;
            set
            {
                if (!Correct(value))
                {
                    throw new ArgumentException("Фамилия не должна быть длиннее "
                                                + MaxTextLenght
                                                + " символов");
                    _lastName = value;
                }
            }
        }

        /// <summary>
        /// получает и возвращает имя
        /// </summary>
        /// <exception cref="ArgumentException">если слишком длинный</exception>
        public string FirstName
        {
            get => _firstName;
            set
            {
                if (!Correct(value))
                {
                    throw new ArgumentException("Имя не должна быть длиннее "
                                                + MaxTextLenght
                                                + " символов");
                    _firstName = value;
                }
            }
        }

        /// <summary>
        /// Свойство "Email" получает и возвращает E-Mail контакта.
        /// </summary>
        /// <exception cref="ArgumentException">Выбрасывается в случае присвоения слишком длинного E-Mail.</exception>
        public string Email
        {
            get => _email;
            set
            {
                if (!Correct(value))
                    throw new ArgumentException("E-mail не должен быть длиннее "
                                                + MaxTextLenght
                                                + " символов");
                _email = value;
            }
        }

        /// <summary>
        /// Свойство "IdVk" получает и возвращает VK ID контакта.
        /// </summary>
        /// <exception cref="ArgumentException">Выбрасывается в случае присвоения слишком длинного VK ID.</exception>
        public string VkId
        {
            get => _vkId;
            set
            {
                if (!Correct(value))
                    throw new ArgumentException("ID ВКонтакте не должен быть длиннее "
                                                + MaxTextLenght
                                                + " символов");
                _vkId = value;
            }
        }

        private static bool Correct(string text)
        {
            return text != null && text.Length <= MaxTextLenght;
        }

        public bool Equals(Contact other)
        {
            return _lastName.Equals(other._lastName) &&
                   _firstName.Equals(other._firstName) &&
                   _birthday.Equals(other._birthday) &&
                   _email.Equals(other._email) &&
                   _vkId.Equals(other._vkId) &&
                   _phoneNumber.Equals(other._phoneNumber);
        }

        public object Clone()
        {
            return new Contact()
            {
                FirstName = this.FirstName,
                LastName = this.LastName,
                Birtday = this.Birtday,
                PhoneNumber = this.PhoneNumber,
                VkId = this.VkId
            };
        }
    }

}
