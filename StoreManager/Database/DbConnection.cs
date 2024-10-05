﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using StoreObjects;

namespace StoreManager.Database
{
    class DBConnect
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        //Constructor
        public DBConnect()
        {
            server = "localhost";
            database = "store_manager";
            uid = "root";
            password = "bajed";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
            connection.Open();
        }

        //open connection to database
        //private bool OpenConnection()
        //{
        //}

        ////Close connection
        //private bool CloseConnection()
        //{
        //}

        //Insert statement
        public void Insert()
        {
        }

        //Update statement
        public void Update()
        {
        }

        //Delete statement
        public void Delete()
        {
            
        }

        //Select statement
        public List<Item> GetItemList()
        {
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM tbl_products", connection);
            MySqlDataReader reader = cmd.ExecuteReader();

            List<Item> list = new List<Item>();

            while (reader.Read())
            {
                Item item = new Item(int.Parse(reader["id"].ToString()), reader["name"].ToString(), reader["Size"].ToString(), double.Parse(reader["price"].ToString()));
                //Debug.WriteLine(reader["id"] + " " + reader["name"] + " " + reader["price"]);
                list.Add(item);
            }

            reader.Close();

            return list;

        }

        public string[] GetSizesList()
        {

            List<string> sizes = new List<string>();

            MySqlCommand cmd = new MySqlCommand("CALL procGetAllDistinctProdSizes()", connection);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                sizes.Add(reader["size"].ToString());
            }

            reader.Close();

            return sizes.ToArray();
        }

        ////Count statement
        //public int Count()
        //{
        //}

        //Backup
        public void Backup()
        {
        }

        //Restore
        public void Restore()
        {
        }
    }
}