
namespace Factory.Core.TableDatas;

/// <summary>
/// Interfejs danych tabeli.
/// </summary>
public interface ITableData: ICloneable
{
    /// <summary>
    /// Pobranie typu danych.
    /// </summary>
    /// <returns></returns>
    string GetDataType();

    /// <summary>
    /// Stworzenie danych.
    /// </summary>
    /// <returns></returns>
    ITableData CreateData();
}
