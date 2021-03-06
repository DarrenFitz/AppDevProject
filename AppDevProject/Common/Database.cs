﻿using SQLite.Net;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDevProject.Common
{
    public class Database
    {
        string path;
        SQLiteConnection conn;

        //setting up the local database path 
        public Database()
        {
            path = Path.Combine(Windows.Storage.ApplicationData.Current.LocalFolder.Path, "MyDatabase.sqlite");
            conn = new SQLiteConnection(new SQLite.Net.Platform.WinRT.SQLitePlatformWinRT(), path);
            
            //Create User Tables
            conn.CreateTable<User>();
        }

        public int Register(User user)
        {   
            int code = 1;//Used to reset 
            try
            {
                conn.Insert(new User()//add info to database
                {
                    UserName = user.UserName,
                    Password = user.Password,
                    Email = user.Email
                });
            }
            catch (SQLiteException ex)
            {
                code = -1;
            }
            return code;
        }

        public bool Login(string user, string password)
        {
            var query = conn.Table<User>().
                Where(t => t.UserName == user && t.Password == password); //Comparing the username and password imput in login page
            if (query.Count() > 0)                                        //to username and password in db.
                return true;
            else
                return false;
        }

    }
}