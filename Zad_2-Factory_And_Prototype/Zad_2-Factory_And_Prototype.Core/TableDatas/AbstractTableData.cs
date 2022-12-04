namespace Factory.Core.TableDatas;

/// <summary>
/// Abstrakcyjna klasa dabych tabeli.
/// </summary>
public abstract class AbstractTableData : ITableData
{
    /// <summary>
    /// Generator liczb pseudolosowych.
    /// </summary>
    public Random rnd = new Random();

    /// <inheritdoc />
    public abstract string GetDataType();


    /// <inheritdoc />
    public abstract ITableData CreateData();


    /// <inheritdoc />
    public object Clone()
    {
      return base.MemberwiseClone();
    }
}
