using Factory.Core;

namespace Factory;

/// <summary>
/// Klasa g³ównego okienka programu.
/// </summary>
public partial class MainProgram : Form
{
    /// <summary>
    /// Baza danyc hprzecowuj¹ca dane.
    /// </summary>
    private readonly Database database = new Database();
    
    /// <summary>
    /// Konstruktor inicjalizuj¹cy dane.
    /// </summary>
    public MainProgram()
    {
        InitializeComponent();
    }

    /// <summary>
    /// Dodanie wiersza z danymi.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void AddRow_Click(object sender, EventArgs e)
    {
        if (database.headers.Count() != 0)
        {
            database.addRow();
            this.ReloadTable();
        }
    }

    /// <summary>
    /// Dodanie kolumny na dane.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void AddCollumn_Click(object sender, EventArgs e)
    {
        var formPopup = new PopupForm(database,UsePrototype.Checked);
        formPopup.ShowDialog(this);

        this.ReloadTable();
    }

    /// <summary>
    /// Wyczyszczenie danych.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void Clear_Click(object sender, EventArgs e)
    {
        this.ClearTable();
    }

    /// <summary>
    /// Prze³adowanie tabeli.
    /// </summary>
    private void ReloadTable()
    {
        DataBox.Items.Clear();

        string headers = "";
        foreach (var i in database.headers)
        {
            headers += i.ToString() + "\t";
        }
        headers.TrimEnd();
        DataBox.Items.Add(headers);
        foreach (var i in database.data)
        {
            var data = "";
            i.ForEach(x => data += x.ToString() + "\t");
            DataBox.Items.Add(data);
        }
    }

    /// <summary>
    /// Wyczyszczenie danych wyœwietlonych i z bazy danych.
    /// </summary>
    private void ClearTable()
    {
        DataBox.Items.Clear();
        database.headers.Clear();
        database.data.Clear();
    }
}
