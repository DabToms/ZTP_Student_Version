using Factory.Core.TableDatas;

namespace Factory.Core.TableHeaders;
public class TableHeaderInt : AbstractTableHeader
{
    public TableHeaderInt()
    {
        this.type = typeof(int).ToString();
    }

    /// <inheritdoc />
    public override ITableData CreateData()
    {
        return new TableDataInt();
    }
}
