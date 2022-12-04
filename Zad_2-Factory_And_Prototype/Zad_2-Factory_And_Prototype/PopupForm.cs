using Factory.Core;
using Factory.Core.TableDatas;
using Factory.Core.TableHeaders;

namespace Factory;

/// <summary>
/// Klasa okienka do dodania kolumny.
/// </summary>
public partial class PopupForm : Form
{
    /// <summary>
    /// Baza danych.
    /// </summary>
    Database DataBase;

    /// <summary>
    /// Flaga czy używamy metody fabrykującej, czy prototypu.
    /// </summary>
    bool usePrototype;

    /// <summary>
    /// Inicjalizacjia klasy.
    /// </summary>
    public PopupForm()
    {
        this.DataBase = new Database();
        InitializeComponent();
        this.InitData();
    }

    /// <summary>
    /// Inicjalizacjia klasy.
    /// </summary>
    public PopupForm(Database db, bool usePrototype)
    {
        this.DataBase = db;
        this.usePrototype = usePrototype;
        InitializeComponent();
        this.InitData();
    }

    /// <summary>
    /// Zakmnięcie okienka.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void Return_Click(object sender, EventArgs e)
    {
        Close();
    }

    /// <summary>
    /// Dodanie kolumny wg. zaznaczonego typu.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void Add_Click(object sender, EventArgs e)
    {
        if (TypeHolder.SelectedItem != null)
        {
            if (usePrototype)
            {
                this.DataBase.addCol((TableHeaderPrototype)TypeHolder.SelectedItem);
            }
            else
            {
                this.DataBase.addCol((AbstractTableHeader)TypeHolder.SelectedItem);
            }
            Close();
        }
    }

    /// <summary>
    /// Inicjalizacjia danych wg. zaznaczonego checkboxu.
    /// </summary>
    private void InitData()
    {
        // użycie prototypu
        if (usePrototype)
        {
            TypeHolder.Items.AddRange(new TableHeaderPrototype[] {
                        new TableHeaderPrototype(new TableDataInt()),
                        new TableHeaderPrototype(new TableDataBool()),
                        new TableHeaderPrototype(new TableDataChar()),
                        new TableHeaderPrototype(new TableDataDouble()),
                    });
        }
        // użycie metody fabrykującej
        else
        {
            TypeHolder.Items.AddRange(new AbstractTableHeader[] {
                        new TableHeaderInt(),
                        new TableHeaderDouble(),
                        new TableHeaderChar(),
                        new TableHeaderBool(),
                    });
        }
    }
}
