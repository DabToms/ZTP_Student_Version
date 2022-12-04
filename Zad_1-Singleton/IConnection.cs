namespace Singleton;

/// <summary>
/// Interfejs połączenia do bazy danych.
/// </summary>
public interface IConnection
{
    /// <summary>
    /// Pobranie znalu zbajdującego się pod podanym indeksem.
    /// </summary>
    /// <param name="indeks">Indeks.</param>
    /// <returns>Znak pod indeksem.</returns>
    char Get(int indeks);

    /// <summary>
    /// Ustawienie znaku pod podanym indeksem.
    /// </summary>
    /// <param name="indeks">Indeks.</param>
    /// <param name="c">Znak.</param>
    void Set(int indeks, char c);

    /// <summary>
    /// Pobranie długości elementów w bazie danych.
    /// </summary>
    /// <returns></returns>
    int Length();
}
