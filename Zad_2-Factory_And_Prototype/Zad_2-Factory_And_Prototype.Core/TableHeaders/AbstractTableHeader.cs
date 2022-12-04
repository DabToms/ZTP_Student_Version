using Factory.Core.TableDatas;
using Zad_2_Factory_And_Prototype.Core.TableHeaders;

namespace Factory.Core.TableHeaders;

/// <summary>
/// Klasa nagłówka kolumny implementującej metodę fbrykującą.
/// </summary>
public abstract class AbstractTableHeader : ITableHeader
{
    /// <summary>
    /// Nazwa typu.
    /// </summary>
    protected string type;

    /// <summary>
    /// Konstruktor kolumny implementującej metodę fbrykującą.
    /// </summary>
    public AbstractTableHeader()
    {
        type = "null";
    }

    /// <summary>
    /// Pobranie nazwy typu.
    /// </summary>
    /// <returns>Nazwa typu.</returns>
    public override string ToString() => type.Split('.')[1].ToUpper();


    /// <inheritdoc />
    public abstract ITableData CreateData();

    /// <inheritdoc />
    public ITableData Clone()
    {
        throw new NotImplementedException();
    }
}
