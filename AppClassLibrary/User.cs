using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppClassLibrary
{
    public class User
    {
        #region атрибуты
        private int _id;
        private string _fname;
        private string _sname;
        private string _tname;
        private string _login;
        private string _password;
        private string _type;

        #endregion
        #region свойства
        public string Type { get { return _type; } set { _type = value; } }
        public int Id { get { return _id; } set { _id = value; } }
        public string Fname { get { return _fname; } set { _fname = value; } }
        public string Sname { get { return _sname; } set { _sname = value; } }
        public string Tname { get { return _tname; } set { _tname = value; } }
        public string Login { get { return _login; } set { _login = value; } }
        public string Password { get { return _password; } set { _password = value; } }
        #endregion
        #region конструкторы
        public User()
        {
            this.Id = Id;
        }/*
        public User(DataRow dr)
        {
            Id = Convert.ToInt32(dr.ItemArray[0]);
            Fname = dr.ItemArray[1].ToString();
            Sname = dr.ItemArray[2].ToString();
            Tname = dr.ItemArray[3].ToString();
            SerialPassport = Convert.ToInt32(dr.ItemArray[4]);
            NumberPassport = Convert.ToInt32(dr.ItemArray[5]);
            PhoneNumber = dr.ItemArray[6].ToString();
            Email = dr.ItemArray[7].ToString();
            Country = dr.ItemArray[8].ToString();
            Region = dr.ItemArray[9].ToString();
            Cyti = dr.ItemArray[10].ToString();
            Street = dr.ItemArray[11].ToString();
            House = dr.ItemArray[12].ToString();
            Room = dr.ItemArray[13].ToString();
            BirthDate = Convert.ToDateTime(dr.ItemArray[14]);
            Type = Convert.ToBoolean(dr.ItemArray[15]);
            DB = true;
        }*/
        #endregion
        #region методы
        #endregion
        #region операторы
        /*public static Human[] operator +(Human[] humans, Human human)
        {
            Human[] humans1 = new Human[humans.Length + 1];
            int i = 0;
            foreach (Human human1 in humans)
            {
                humans1[i] = new Human();
                humans1[i] = human1;
                i++;
            }
            humans1[humans.Length] = new Human();
            humans1[humans.Length] = human;
            return humans1;
        }
        public static Human[] operator -(Human[] humans, Human human)
        {
            Human[] humans1 = new Human[humans.Length - 1];
            int i = 0;
            foreach (Human human1 in humans)
            {
                if (human.Id != human1.Id)
                {
                    humans1[i] = new Human();
                    humans1[i] = human1;
                    i++;
                }
            }
            return humans1;
        }
        public static Human operator +(Human human, User user)
        {
            User[] users = new User[human.Users.Length + 1];
            int i = 0;
            foreach (User user1 in human.Users)
            {
                users[i] = new User();
                users[i] = user1;
                i++;
            }
            users[human.Users.Length] = new User();
            users[human.Users.Length] = user;
            human.Users = users;
            return human;
        }
        public static Human operator -(Human human, User user)
        {
            User[] users = new User[human.Users.Length - 1];
            int i = 0;
            foreach (User user1 in human.Users)
            {
                if (user.IdU != user1.IdU)
                {
                    users[i] = new User();
                    users[i] = user1;
                    i++;
                }
            }
            human.Users = users;
            return human;
        }
        public static Human operator +(Human human, User[] users)
        {
            human.Users = new User[users.Length];
            int i = 0;
            foreach (User user in users)
            {
                human.Users[i] = new User();
                human.Users[i] = user;
                i++;
            }
            return human;
        }
        public static Human operator +(Human human, Worker groupsWorker)
        {
            Worker[] groupsWorkers = new Worker[human.Workers.Length + 1];
            int i = 0;
            foreach (Worker groupsWorker1 in human.Workers)
            {
                groupsWorkers[i] = new Worker();
                groupsWorkers[i] = groupsWorker1;
                i++;
            }
            groupsWorkers[human.Workers.Length] = new Worker();
            groupsWorkers[human.Workers.Length] = groupsWorker;
            human.Workers = groupsWorkers;
            return human;
        }
        public static Human operator -(Human human, Worker groupsWorker)
        {
            Worker[] groupsWorkers = new Worker[human.Workers.Length - 1];
            int i = 0;
            foreach (Worker groupsWorker1 in human.Workers)
            {
                if (groupsWorker.Idhuman != groupsWorker1.Id)
                {
                    groupsWorkers[i] = new Worker();
                    groupsWorkers[i] = groupsWorker1;
                    i++;
                }
            }
            human.Workers = groupsWorkers;
            return human;
        }
        public static Human operator +(Human human, Worker[] groupsWorkers)
        {
            human.Workers = new Worker[groupsWorkers.Length];
            int i = 0;
            foreach (Worker groupsWorker in groupsWorkers)
            {
                human.Workers[i] = new Worker();
                human.Workers[i] = groupsWorker;
                i++;
            }
            return human;
        }
        public static Human operator +(Human human, Client client)
        {
            Client[] clients = new Client[human.Clients.Length + 1];
            int i = 0;
            foreach (Client client1 in human.Clients)
            {
                clients[i] = new Client();
                clients[i] = client1;
                i++;
            }
            clients[human.Clients.Length] = new Client();
            clients[human.Clients.Length] = client;
            human.Clients = clients;
            return human;
        }
        public static Human operator -(Human human, Client client)
        {
            Client[] clients = new Client[human.Clients.Length - 1];
            int i = 0;
            foreach (Client client1 in human.Clients)
            {
                if (client.IdC != client1.IdC)
                {
                    clients[i] = new Client();
                    clients[i] = client1;
                    i++;
                }
            }
            human.Clients = clients;
            return human;
        }
        public static Human operator +(Human human, Client[] clients)
        {
            human.Clients = new Client[clients.Length];
            int i = 0;
            foreach (Client client in clients)
            {
                human.Clients[i] = new Client();
                human.Clients[i] = client;
                i++;
            }
            return human;
        }*/
        #endregion

    }
}
