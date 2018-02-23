using System;
using System.Collections.Generic;
using System.Linq;

namespace FirstHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Do your testing here.
          
            Console.ReadKey();
        }
    }

    public class PhoneBook
    {
        // TODO: Implement phone book without changing method signature. Replace comments with your code to succeed in this task. Good luck!

        Dictionary<string, int> _phoneBook = new Dictionary<string, int>();
        public PhoneBook(PhoneBookEntry[] initialValues)
        {
            // TODO: Remove and implement initial assignment from array (initialValues) to dictionary (_phoneBook).
            foreach (var x in initialValues)
            {
                _phoneBook.Add(x.Name, x.Number);
            }
           //cia reiktu pracekinti ar jau buvo toks key
          
        }

        public void Add(PhoneBookEntry entry)
        {
            // TODO: Add passed value (entry) to dictionary
            _phoneBook.Add(entry.Name, entry.Number);
        }

        public bool Remove(string name)
        {
            // TODO: Remove phone book entry from phone book.
            _phoneBook.Remove(name);
            return true;
        }

        public bool Update(PhoneBookEntry entry)
        {
            // TODO: Update phone book entry information. If entry does not exist, return false, otherwise update and return true;
            if (!_phoneBook.ContainsKey(entry.Name))
            {
                return false;
            }
            else
            {
                _phoneBook[entry.Name] = entry.Number;
                return true;
            }
        }

        public int Dial(string name)
        {
            // TODO: Return phone number for give person. If non existing return -1;
           if (!_phoneBook.ContainsKey(name))
            {
                return -1;
            } else
            {
                return _phoneBook[name];
            }
        }

        public string[] Name(int number)
        {
            // TODO: Return name of people names who's phone number it is.

            List<string> KeyList = new List<string>(_phoneBook.Keys);
            List<string> FoundKeys = new List<string>();
            foreach(string key in KeyList)
            
                if (_phoneBook[key].Equals(number))
                {
                    FoundKeys.Add(key);
                }
                if (FoundKeys.Count > 0)
                {
                    return FoundKeys.ToArray();
                }else
                {
                    throw new KeyNotFoundException();
                
                           }
           
        }

        public Dictionary<string, int> Addresses { get { return _phoneBook; } }
    }
}
