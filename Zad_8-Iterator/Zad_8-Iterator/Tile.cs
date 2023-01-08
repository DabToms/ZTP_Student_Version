namespace Zad_8_Iterator;

/// <summary>
/// Klasa kafelka.
/// </summary>
public class Tile
{
    /// <summary>
    /// Stan kafelka. True - włączony, False - wyłączony.
    /// </summary>
    private bool value = false;

    /// <summary>
    /// Kolory kafelka włączonego i wyłączonego.
    /// </summary>
    private static readonly Color on = Color.Yellow, off = Color.LightBlue;

    /// <summary>
    /// Pobranie koloru w zależności od stanu.
    /// </summary>
    public Color Color => this.value ? on : off;

    /// <summary>
    /// Zmiana stanu kafelka.
    /// </summary>
    public void Flip() => this.value = !this.value;
}