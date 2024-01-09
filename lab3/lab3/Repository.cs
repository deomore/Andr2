using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using Xamarin.Forms;
using System.Text;
using lab3;

public class Repository
{
    private readonly SQLiteConnection database;

    public Repository(string databasePath)
    {
        database = new SQLiteConnection(databasePath);
        database.CreateTable<Guitar>();
        database.CreateTable<Manufactor>();
    }
    public IEnumerable<Guitar> GetItems()
    {
        return database.Table<Guitar>().ToList();
    }
    public Guitar GetGuitar(int id)
    {
        return database.Get<Guitar>(id);
    }
    public int DeleteGuitar(int id)
    {
        return database.Delete<Guitar>(id);
    }
    public long SaveGuitar(Guitar item)
    {
        if (item.Id != 0)
        {
            database.Update(item);
            return item.Id;
        }
        else
        {
            return database.Insert(item);
        }
    }


}
