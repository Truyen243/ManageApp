﻿using System;

namespace WindowFrom.Data
{
    public class User:IComparable
    {
        private int iD;
        private string fullName;
        private bool sex;
        private string userName;
        private string passWord;
        private bool remember;
        private int idUserType;

        //Contructor - hàm tạo cho đối tượng User
        public User() { }

        public User(int iD, string userName, string passWord, bool remember, int idUserType)
        {
            this.ID = iD;
            this.UserName = userName;
            this.PassWord = passWord;
            this.Remember = remember;
            this.IdUserType = idUserType;
        }

        public int ID { get => iD; set => iD = value; }
        public string FullName { get => fullName; set => fullName = value; }
        public string UserName { get => userName; set => userName = value; }
        public bool Sex { get => sex; set => sex = value; }
        public string PassWord { get => passWord; set => passWord = value; }
        public bool Remember { get => remember; set => remember = value; }
        public int IdUserType { get => idUserType; set => idUserType = value; }

        public string GetString()
        {
            return string.Format("{0},{1},{2},{3},{4},{5},{6}", ID, FullName, Sex
                ,UserName, PassWord, Remember.ToString(), IdUserType);
        }

        public override bool Equals(object obj)
        {
            if (obj is User)
            {
                return this.iD.Equals(((User)obj).ID);
            }
            return false;
            
        }

        public int CompareTo(object obj)
        {
            if (obj is User)
            {
                return this.iD.CompareTo(((User)obj).ID);
            }
            return -1;
        }
    }
}
