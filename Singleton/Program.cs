using Singleton;

var database = Database.CreateInstance();
Database.ExecuteQuery("SELECT * FROM users;");