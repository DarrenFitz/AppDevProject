using SQLite.Net;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDevProject.Common
{
    string path;
    SQLiteConnection conn;

    public Database()
    {
        path = Path.Combine(Windows.Storage.ApplicationData.Current.LocalFolder.Path,
            "MyDatabase.sqlite");
        conn = new SQLiteConnection(new SQLite.Net.Platform.WinRT.SQLitePlatformWinRT(), path);
        //Create Table
        conn.CreateTable<User>();
    }
}