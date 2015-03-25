    using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverSurgery
{
    public class Database
    {
        // Only possible instance of this class.
        private static Database _instance;

        // Used to open a connection to a database.
        private MySqlConnection _connection;

        // Server were the database is hosted e.g. localhost.
        private string _server;

        // The name of the database that will be used.
        private string _database;

        // MySQL username.
        private string _uid;

        // MySQL password.
        private string _password;

        // Holds all of the database information
        Dictionary<string, string> _properties;

        public String DatabaseName
        {
            get { return _database; }
        }

        // Constructor.
        private Database()
        {
            // Try to initialize the connection
            try
            {
                Initialize();
            }

            // Cannot find the properties file
            catch (FileNotFoundException e)
            {
                Debug.WriteLine("Error file not found" + e.Message);
                _connection = null;
            }

            catch (Exception e)
            {
                Debug.WriteLine("Property file parsing exception thrown : " + e.Message);
                _connection = null;
            }
        }

        // Return the singleton instance if it exists
        // If not, create the instance
        public static Database Instance()
        {
            // Check if the instance already exists
            if (null == _instance)
            {
                // If no instance exists, create one
                _instance = new Database();
            }

            return _instance;
        }

        // Initialize values
        private void Initialize()
        {
            _properties = GetProperties("properties.dat");
            _server = _properties["Server"];
            _database = _properties["Database"];
            _uid = _properties["User"];
            _password = _properties["Password"];

            SetConnection();
        }

        // Load the database settings from a file
        private Dictionary<string, string> GetProperties(string path)
        {
            // Read the file into a string
            string fileData = "";
            using (StreamReader sr = new StreamReader(path))
            {
                fileData = sr.ReadToEnd().Replace("\r", "");
            }

            // Create a new dictionary to hold the properties in
            Dictionary<string, string> properties = new Dictionary<string, string>();
            
            // Key value pair i.e. name=james
            string[] kvp;

            // Holds each seperate line
            string[] records = fileData.Split("\n".ToCharArray());

            // Loop through each record
            foreach (string record in records)
            {
                // Split the record into the key and value
                kvp = record.Split("=".ToCharArray());

                // Add the record to the properties dictionary
                properties.Add(kvp[0], kvp[1]);
            }

            // Return the properties dictionary
            return properties;
        }

        // Set up the MySQL connection based on the properties file
        private void SetConnection()
        {
            string connectionString;

            connectionString = "SERVER=" + _server + ";" + "DATABASE=" +
            _database + ";" + "UID=" + _uid + ";" + "PASSWORD=" + _password + ";";

            _connection = new MySqlConnection(connectionString);
        }

        //open connection to database
        public bool OpenConnection()
        {
            // Attempt to open the SQL Connection
            try
            {
                _connection.Open();
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        Debug.WriteLine("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        Debug.WriteLine("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
            return true;
        }

        //Close connection
        public bool CloseConnection()
        {
            try
            {
                _connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                Debug.WriteLine(ex.Message);
                return false;
            }

        }

        //Select statement
        public DbDataReader Select(String query)
        {
            DbDataReader dr = null;

            if (null != _connection)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, _connection);

                //Create a data reader and Execute the command
                dr = cmd.ExecuteReader();
            }

            return dr;
        }

        //Insert statement
        public int Insert(String query)
        {
            if (null != _connection)
            {
                MySqlCommand cmd = new MySqlCommand(query, _connection);

                // Returns the number of affected rows.
                return cmd.ExecuteNonQuery();
            }

            return -1;
        }

        // Inserts to the database and returns the latest autonumber
        public int InsertScalar(String query)
        {
            if (null != _connection)
            {
                MySqlCommand cmd = new MySqlCommand(query, _connection);

                return int.Parse(cmd.ExecuteScalar().ToString());
            }

            return -1;
        }

        //Update statement
        public int Update(String query)
        {
            if (null != _connection)
            {
                MySqlCommand cmd = new MySqlCommand(query, _connection);

                // Returns the number of affected rows.
                return cmd.ExecuteNonQuery();
            }

            return -1;
        }

        //Delete statement
        public int Delete(String query)
        {
            if (null != _connection)
            {
                MySqlCommand cmd = new MySqlCommand(query, _connection);
                return cmd.ExecuteNonQuery();
            }
            return -1;
        }
        
        //Count statement
        public int Count(String query)
        {
            int count = -1;

            //Create Mysql Command
            MySqlCommand cmd = new MySqlCommand(query, _connection);

            //ExecuteScalar will return one value
            count = int.Parse(cmd.ExecuteScalar().ToString());

            return count;
        }

        // Backup the Database
        public void Backup()
        {
            try
            {
                DateTime Time = DateTime.Now;
                int year = Time.Year;
                int month = Time.Month;
                int day = Time.Day;
                int hour = Time.Hour;
                int minute = Time.Minute;
                int second = Time.Second;
                int millisecond = Time.Millisecond;

                //Save file to C:\ with the current date as a filename
                string path;
                path = "MySqlBackup.sql";
                StreamWriter file = new StreamWriter(path);

                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = @"C:\Program Files\MySQL\MySQL Server 5.6\bin\mysqldump.exe";
                psi.RedirectStandardInput = false;
                psi.RedirectStandardOutput = true;
                psi.Arguments = string.Format(@"-u{0} -p{1} -h{2} {3}",
                    _uid, _password, _server, _database);
                psi.UseShellExecute = false;

                Process process = Process.Start(psi);

                string output;
                output = process.StandardOutput.ReadToEnd();
                file.WriteLine(output);
                process.WaitForExit();
                file.Close();
                process.Close();
            }
            catch (IOException ex)
            {
                Debug.WriteLine("Error , unable to backup!");
            }
        }

        // Restore Database
        public void Restore()
        {
            try
            {
                //Read file from C:\
                string path;
                path = "MySqlBackup.sql";

                StreamReader file = new StreamReader(path);
                string input = file.ReadToEnd();
                file.Close();

                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = @"C:\Program Files\MySQL\MySQL Server 5.6\bin\mysql.exe";
                psi.RedirectStandardInput = true;
                psi.RedirectStandardOutput = false;
                psi.Arguments = string.Format(@"-u{0} -p{1} -h{2} {3}",
                    _uid, _password, _server, _database);
                psi.UseShellExecute = false;

                Process process = Process.Start(psi);
                process.StandardInput.WriteLine(input);
                process.StandardInput.Close();
                process.WaitForExit();
                process.Close();
            }
            catch (IOException ex)
            {
                Debug.WriteLine("Error , unable to Restore!");
            }
        }
    }
}
