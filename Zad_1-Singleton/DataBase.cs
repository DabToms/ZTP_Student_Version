namespace Singleton;

/// <summary>
/// Klasa bazy danych.
/// </summary>
public class DataBase
{
    /// <summary>
    /// Tablica znaków, będąca bazą danych.
    /// </summary>
    public char[] Table = new char[100];

    /// <summary>
    /// Pobranie połączenia do bazy danych.
    /// </summary>
    /// <returns>Połączenia do bazy danych.</returns>
    public static IConnection GetConnection()
    {
        return Connection.GetInstance();
    }

    /// <summary>
    /// Klasa udostępniająca połączenie do bazy danych.
    /// </summary>
    private class Connection : IConnection
    {
        /// <summary>
        /// Baza danych powiązana z połączeniem.
        /// </summary>
        private DataBase Baza;

        /* ... */

        /// <summary>
        /// Pobranie połączenia do bazy danych.
        /// </summary>
        /// <returns>Połączenie.</returns>
        public static IConnection GetInstance()
        {
            /*...*/
        }

        /// <inheritdoc />
        public char Get(int indeks)
        {
            return Baza.Table[indeks];
        }

        /// <inheritdoc />
        public void Set(int indeks, char c)
        {
            Baza.Table[indeks] = c;
        }

        /// <inheritdoc />
        public int Length()
        {
            return Baza.Table.Length;
        }
    }
}
