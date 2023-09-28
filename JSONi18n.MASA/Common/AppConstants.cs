namespace JSONi18n.MASA.Common;

public static class AppConstants
{
    public const string AndroidDatabase = "JSONi18nSQLite.db3";

    public const SQLite.SQLiteOpenFlags Flags =
        // open the database in read/write mode
        SQLite.SQLiteOpenFlags.ReadWrite |
        // create the database if it doesn't exist
        SQLite.SQLiteOpenFlags.Create |
        // enable multi-threaded database access
        SQLite.SQLiteOpenFlags.SharedCache;

    public static string AndroidDatabasePath =>
        Path.Combine(FileSystem.AppDataDirectory , AndroidDatabase);
}
