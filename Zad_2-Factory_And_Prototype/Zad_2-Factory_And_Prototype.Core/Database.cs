using Factory.Core.TableDatas;
using Factory.Core.TableHeaders;
using Zad_2_Factory_And_Prototype.Core.TableHeaders;

namespace Factory.Core;

/// <summary>
/// Baza danych zarządzająca kolumnami i wierszami przechowujące dane.
/// </summary>
public class Database
{
    /// <summary>
    /// Lista nagłówków.
    /// </summary>
    public List<ITableHeader> headers;

    /// <summary>
    /// Wiersz z danymi(mogą być różnego typów).
    /// </summary>
    public List<List<ITableData>> data;

    /// <summary>
    /// Konstruktor klasy Database.
    /// </summary>
    public Database()
    {
        headers = new List<ITableHeader>();
        data = new List<List<ITableData>>();
    }

    /// <summary>
    /// Dodanie wiersza.
    /// </summary>
    public void addRow()
    {
        List<ITableData> row = new List<ITableData>();
        foreach (var col in headers)
        {
                row.Add(col.CreateData()); // wywołanie metody fabrykującej
            
        }
        data.Add(row);
    }

    /// <summary>
    /// Dodanie kolumny.
    /// </summary>
    /// <param name="type">Nagłówek przechowujący typ.</param>
    public void addCol(AbstractTableHeader type)
    {
        headers.Add(type);
        foreach (var row in data)
        {
            row.Add(type.CreateData()); // wywołanie metody fabrykującej
        }
    }

    /// <summary>
    /// Pobranie ilości wierszy.
    /// </summary>
    /// <returns>Ilość wierszy.</returns>
    public int getRowCount() => data.Count();

    /// <summary>
    /// Pobranie ilości kolumn.
    /// </summary>
    /// <returns>Ilość kolumn.</returns>
    public int getColumnCount() => headers.Count();

    /// <summary>
    /// Pobierz nazwe kolumny.
    /// </summary>
    /// <param name="column">Index kolumny.</param>
    /// <returns>Nazwa kolumny.</returns>
    public string? getColumnName(int column) => column < headers.Count ? headers[column].ToString() : "No_Data";

    /// <summary>
    /// Pobranie wartości przecowywanej wartości w kolumnie i wierszu.
    /// </summary>
    /// <param name="row">Indeks wiersza.</param>
    /// <param name="column">Index kolumny.</param>
    /// <returns>Obiekt danych.</returns>
    public object getValueAt(int row, int column) => data[row][column];
}
