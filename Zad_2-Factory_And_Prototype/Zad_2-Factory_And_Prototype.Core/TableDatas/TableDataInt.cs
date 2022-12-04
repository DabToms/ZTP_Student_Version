namespace Factory.Core.TableDatas;

/// <summary>
/// Obiekt tableli przechowujący dane typu INT.
/// </summary>
public class TableDataInt : AbstractTableData
{
    /// <summary>
    /// Dane.
    /// </summary>
    private int data;

    /// <summary>
    /// Konstruktor inicjalizujący dane.
    /// </summary>
    public TableDataInt()
    {
        data = rnd.Next(0, 100);
    }

    /// <inheritdoc />
    public override ITableData CreateData()
    {
        return this;
    }

    /// <inheritdoc />
    public override string GetDataType()
    {
        return typeof(int).ToString().Split('.')[1].ToUpper();
    }

    /// <summary>
    /// Pobranie danych.
    /// </summary>
    /// <returns>Dane intiger.</returns>
    public override string ToString() => data.ToString();
}
