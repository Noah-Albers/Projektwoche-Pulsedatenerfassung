using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Threading.Tasks;

//
// Noah Albers
// 
// Berufskolleg Rheine
// IA3B
// 25.01.2022
//

namespace WinDatabaseTest
{
    /// <summary>
    /// Config object for the database
    /// 
    /// Example:
    /// <example>
    ///     
    ///     // Creates the config (Except for the Database-Name this would work for a default XAMPP-Installation)
    ///     var cfg = new DatabaseConfig{
    ///         databaseName = "ExampleDatabase",
    ///         passwd = "",
    ///         server = "localhost",
    ///         username = "root"
    ///     }
    /// 
    /// </example>
    /// </summary>
    public struct DatabaseConfig
    {
        // Server-IP or Domain to connect to. For testing this usually is localhost
        public string server;

        // Name of the database
        public string databaseName;

        // Username of the user with how to connect to the database. For XAMPP this is usally 'root'.
        public string username;

        // Password of the given user. For XAMPP this is usually empty.
        public string passwd;
    }

    public class Database : IDisposable
    {

        /// <summary>
        /// Open database connection that is internally used to access the database.
        /// 
        /// This is public-get to make it possible to access the raw connection from the outside, if required.
        /// </summary>
        public MySqlConnection RawConnection { get; private set; }

        // Config to connect to the server
        public DatabaseConfig Config { get; set; }

        public Database(DatabaseConfig config) => Config = config;
        public Database(string server, string databaseName, string username, string passwd)
        => Config = new DatabaseConfig{
            databaseName = databaseName,
            passwd = passwd,
            server = server,
            username = username
        };



        #region General connection methods

        /// <summary>
        /// If the database connection is open or closed/dead
        /// </summary>
        public bool IsConnected => this.RawConnection != null && ConnectionState.Open.Equals(this.RawConnection.State);


        /// <summary>
        /// Handles the dispose event (Awaits until the connection is closed)
        /// </summary>
        public void Dispose() => this.KillConnection();

        #endregion



        #region Connection-Handling (Async)

        /// <summary>
        /// Kills any previously opend connections
        /// </summary>
        public async Task KillConnectionAsync()
        {
            // Checks if the connection exists
            if (this.RawConnection == null)
                return;

            // Kills the connection
            await this.RawConnection.CloseAsync().ConfigureAwait(false);
            this.RawConnection = null;
        }

        /// <summary>
        /// Ensures that a connection to the database is still open.
        /// 
        /// The below example shows why this method returns itself.
        /// <example>
        /// 
        /// using(await Database db = new Database(config...).EnsureConnectionAsync()){
        /// ...
        /// }
        /// 
        /// </example>
        /// </summary>
        /// <returns>The class itself</returns>
        public async Task<Database> EnsureConnectionAsync()
        {
            if (this.IsConnected)
                return this;

            // Ensures a dead connection
            await this.KillConnectionAsync().ConfigureAwait(false);

            // (Re)starts the connection;
            this.RawConnection = new MySqlConnection($"SERVER={this.Config.server}; DATABASE={this.Config.databaseName}; UID={this.Config.username}; PASSWORD={this.Config.passwd}");
            await this.RawConnection.OpenAsync().ConfigureAwait(false);

            return this;
        }

        /// <summary>
        /// Creates a mysql command which can be used to add prepared-statement-parameters to.
        /// </summary>
        /// <param name="query">The query</param>
        /// <returns>The command object</returns>
        public async Task<MySqlCommand> PrepareStatementAsync(string query = null)
        {
            await this.EnsureConnectionAsync().ConfigureAwait(false);

            return new MySqlCommand(query ?? string.Empty, this.RawConnection);
        }

        #endregion

        #region Connection-Handling (Sync)

        /// <summary>
        /// Kills any previously opend connections
        /// </summary>
        public void KillConnection() => this.KillConnectionAsync().Wait();

        /// <summary>
        /// Ensures that a connection to the database is still open.
        /// 
        /// The below example shows why this method returns itself.
        /// <example>
        /// 
        /// using(Database db = new Database(config...).EnsureConnection()){
        /// ...
        /// }
        /// 
        /// </example>
        /// </summary>
        /// <returns>The class itself</returns>
        public Database EnsureConnection() => this.EnsureConnectionAsync().Result;

        /// <summary>
        /// Creates a mysql command which can be used to add prepared-statement-parameters to.
        /// </summary>
        /// <param name="query">The query</param>
        /// <returns>The command object</returns>
        public MySqlCommand PrepareStatement(string query = null) => this.PrepareStatementAsync(query).Result;

        #endregion



        #region Select-Query's (Async)

        /// <summary>
        /// Executes a select-query and returns the result as a data-table
        /// </summary>
        /// <param name="cmd">The SQL-Query-Command object</param>
        /// <returns>A data-table filled with the values</returns>
        public async Task<DataTable> SelectAsTableAsync(MySqlCommand cmd)
        {
            await this.EnsureConnectionAsync().ConfigureAwait(false);

            // Loads the connection
            cmd.Connection = this.RawConnection;

            // Executes the command and receives the data
            using (var rdr = await cmd.ExecuteReaderAsync().ConfigureAwait(false))
            {
                // Data-table to return
                var dt = new DataTable();

                // Loads the data
                dt.Load(rdr);

                return dt;
            }
        }

        /// <summary>
        /// Executes a select-query and returns the result as a data-table
        /// </summary>
        /// <param name="query">The raw SQL-Query</param>
        /// <returns>A data-table filled with the values</returns>
        public async Task<DataTable> SelectAsTableAsync(string query) => await this.SelectAsTableAsync(new MySqlCommand(query)).ConfigureAwait(false);


        /// <summary>
        /// Selects a single value from the database. Ensure that only one column and one row is returned (One cell)
        /// Also ensure that the type you specify <typeparamref name="T"/> is matching up.
        /// 
        /// Here is an use case example
        /// <example>
        /// 
        /// // Note that the return element is called 'value'. This is important
        /// var query = "SELECT MAX(Id) FROM ExampleTable";
        /// 
        /// Database db = ...
        /// 
        /// // This would through the query get the biggest value of the database
        /// int biggestId = await db.SelectSingleValue<int>(new MySqlCommand(query));
        /// 
        /// </example>
        /// </summary>
        /// <typeparam name="T">The datatype of the object which will be returned</typeparam>
        /// <param name="cmd">The command with the query.</param>
        /// <returns>The returned value. If no return value could be found (eg. there are 0 rows in the database), default (For most things (eg. strings) null) is returned</returns>
        public async Task<T> SelectSingleValueAsync<T>(MySqlCommand cmd)
        {
            await this.EnsureConnectionAsync().ConfigureAwait(false);

            // Sets the connection
            cmd.Connection = this.RawConnection;

            // Starts the reader
            using (var rdr = await cmd.ExecuteReaderAsync().ConfigureAwait(false))
            {
                // Checks if the value couldn't be found
                if (!rdr.Read())
                    return default;

                // Gets the raw object
                var obj = rdr[0];

                // Checks if it's null or Database-Null
                if (obj == null || obj == DBNull.Value)
                    return default;

                // Cast's the object
                return (T)obj;
            }
        }

        /// <summary>
        /// Selects a single value from the database. Ensure that only one column and one row is returned (One cell)
        /// Also ensure that the type you specify <typeparamref name="T"/> is matching up.
        /// 
        /// Here is an use case example
        /// <example>
        /// 
        /// // Note that the return element is called 'value'. This is important
        /// var query = "SELECT MAX(Id) FROM ExampleTable";
        /// 
        /// Database db = ...
        /// 
        /// // This would through the query get the biggest value of the database
        /// int biggestId = await db.SelectSingleValue<int>(new MySqlCommand(query));
        /// 
        /// </example>
        /// </summary>
        /// <typeparam name="T">The datatype of the object which will be returned</typeparam>
        /// <param name="query">The query.</param>
        /// <returns>The returned value. If no return value could be found (eg. there are 0 rows in the database), default (For most things (eg. strings) null) is returned</returns>
        public async Task<T> SelectSingleValueAsync<T>(string query) => await SelectSingleValueAsync<T>(new MySqlCommand(query)).ConfigureAwait(false);

        #endregion

        #region Select-Query's (Sync)

        /// <summary>
        /// Executes a select-query and returns the result as a data-table
        /// </summary>
        /// <param name="cmd">The SQL-Query-Command object</param>
        /// <returns>A data-table filled with the values</returns>
        public DataTable SelectAsTable(MySqlCommand cmd) => this.SelectAsTableAsync(cmd).Result;

        /// <summary>
        /// Executes a select-query and returns the result as a data-table
        /// </summary>
        /// <param name="query">The raw SQL-Query</param>
        /// <returns>A data-table filled with the values</returns>
        public DataTable SelectAsTable(string query) => this.SelectAsTableAsync(query).Result;


        /// <summary>
        /// Selects a single value from the database. The column name of the value must directly be called 'value'.
        /// Also ensure that the type you specify <typeparamref name="T"/> is matching up.
        /// 
        /// Here is an use case example
        /// <example>
        /// 
        /// // Note that the return element is called 'value'. This is important
        /// var query = "SELECT MAX(Id) AS 'value' FROM ExampleTable";
        /// 
        /// Database db = ...
        /// 
        /// // This would through the query get the biggest value of the database
        /// int biggestId = db.SelectSingleValue<int>(new MySqlCommand(query));
        /// 
        /// </example>
        /// </summary>
        /// <typeparam name="T">The datatype of the object which will be returned</typeparam>
        /// <param name="cmd">The command with the query. Ensure that the column which shall be returned is called 'value'</param>
        /// <returns>The returned value. If no return value could be found (eg. there are 0 rows in the database), default (For most things null) is returned</returns>
        public T SelectSingleValue<T>(MySqlCommand cmd) => this.SelectSingleValueAsync<T>(cmd).Result;

        /// <summary>
        /// Selects a single value from the database. The column name of the value must directly be called 'value'.
        /// Also ensure that the type you specify <typeparamref name="T"/> is matching up.
        /// 
        /// Here is an use case example
        /// <example>
        /// 
        /// // Note that the return element is called 'value'. This is important
        /// var query = "SELECT MAX(Id) AS 'value' FROM ExampleTable";
        /// 
        /// Database db = ...
        /// 
        /// // This would through the query get the biggest value of the database
        /// int biggestId = db.SelectSingleValue<int>(query);
        /// 
        /// </example>
        /// </summary>
        /// <typeparam name="T">The datatype of the object which will be returned</typeparam>
        /// <param name="query">The SQL-query. Ensure that the column which shall be returned is called 'value'</param>
        /// <returns>The returned value. If no return value could be found (eg. there are 0 rows in the database), default (For most things null) is returned</returns>
        public T SelectSingleValue<T>(string query) => this.SelectSingleValueAsync<T>(query).Result;

        #endregion



        #region Insert-Query's (Async)

        /// <summary>
        /// Inserts rows of data into the database.
        /// </summary>
        /// <param name="cmd">The command-object with the insert statement</param>
        /// <returns>The unique id of the newly inserted row (If it exists)</returns>
        public async Task<long> InsertAsync(MySqlCommand cmd)
        {
            await this.EnsureConnectionAsync().ConfigureAwait(false);

            // Sets the connection
            cmd.Connection = this.RawConnection;

            // Executes the query
            await cmd.ExecuteNonQueryAsync().ConfigureAwait(false);

            // Returns the inserted id
            return cmd.LastInsertedId;
        }


        /// <summary>
        /// Inserts rows of data into the database.
        /// </summary>
        /// <param name="query">The query with the insert statement</param>
        /// <returns>The unique id of the newly inserted row (If it exists)</returns>
        public async Task<long> InsertAsync(string query) => await this.InsertAsync(new MySqlCommand(query)).ConfigureAwait(false);

        #endregion

        #region Insert-Query's (Sync)

        /// <summary>
        /// Inserts rows of data into the database.
        /// </summary>
        /// <param name="cmd">The command-object with the insert statement</param>
        /// <returns>The unique id of the newly inserted row (If it exists)</returns>
        public long Insert(MySqlCommand cmd) => this.InsertAsync(cmd).Result;


        /// <summary>
        /// Inserts rows of data into the database.
        /// </summary>
        /// <param name="query">The query with the insert statement</param>
        /// <returns>The unique id of the newly inserted row (If it exists)</returns>
        public long Insert(string query) => this.InsertAsync(new MySqlCommand(query)).Result;

        #endregion



        #region Seperate-Information
        /*
        =========================
        ===Prepared-Statements===
        =========================

        Prepared statements are with this class not only possible but also highly encouraged.
        To use a prepared statement, just follow this example:

        <example>

        // This is the data which could possibly be malicious (Eg. SQL-Injection-attack-data)
        string name = ...;

        // Database connection
        Database db = ...

        // Creates an select command as an example
        string query = "SELECT * FROM ExampleDatabase WHERE Name = @name";

        // Turns that into a command using the database class, which directly passes the connection
        MySqlCommand cmd = db.PrepareStatement(query);

        // Here comes the prepared-statment part
        cmd.Parameters.AddWithValue("@name", name);
        cmd.Prepare();

        // And now just yeet it into the database class (This can be any method, async or sync)
        DataTable result = db.SelectAsTable(cmd);

        </example>
         */
        #endregion
    }
}
