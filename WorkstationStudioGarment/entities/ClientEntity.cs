using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkstationStudioGarment.entities
{
    class ClientEntity
    {
        public int id_client;
        string login;
        string password;
        string surname;
        string name;
        string patronymic = null;
        string mail;
        char[] phone_number;
        bool sex;
        int growth;
        int chest;
        int waist;
        int hip;
    }
}
