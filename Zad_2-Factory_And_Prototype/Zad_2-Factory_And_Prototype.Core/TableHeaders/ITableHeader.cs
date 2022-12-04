using Factory.Core.TableDatas;

namespace Zad_2_Factory_And_Prototype.Core.TableHeaders;

/// <summary>
/// Interfejs nagłówków kolumn.
/// </summary>
public interface ITableHeader
{
    /// <summary>
    /// Stworzenie danych na podstawie wybranego typu kolumny.
    /// </summary>
    /// <returns>Obiekt danych.</returns>
    ITableData CreateData();

    /// <summary>
    /// Sklonownie obiektu danych na podstawie przekazanego obiektu do konstruktora.
    /// </summary>
    /// <returns>Kopie przekazanego obiektu.</returns>
    ITableData Clone();
}
