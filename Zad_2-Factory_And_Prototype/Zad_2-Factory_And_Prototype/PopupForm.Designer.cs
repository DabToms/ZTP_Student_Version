namespace Factory;

partial class PopupForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.Return = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Description = new System.Windows.Forms.Label();
            this.TypeHolder = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Return
            // 
            this.Return.Location = new System.Drawing.Point(67, 132);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(75, 23);
            this.Return.TabIndex = 0;
            this.Return.Text = "Powróć";
            this.Return.UseVisualStyleBackColor = true;
            this.Return.Click += new System.EventHandler(this.Return_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(169, 132);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 1;
            this.Add.Text = "Dodaj";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Location = new System.Drawing.Point(67, 21);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(177, 15);
            this.Description.TabIndex = 2;
            this.Description.Text = "Wybierz typ kolumnych  danych";
            // 
            // TypeHolder
            // 
            this.TypeHolder.FormattingEnabled = true;
            this.TypeHolder.Location = new System.Drawing.Point(67, 62);
            this.TypeHolder.Name = "TypeHolder";
            this.TypeHolder.Size = new System.Drawing.Size(177, 23);
            this.TypeHolder.TabIndex = 3;
            // 
            // PopupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 186);
            this.Controls.Add(this.TypeHolder);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Return);
            this.Name = "PopupForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private Button Return;
    private Button Add;
    private Label Description;
    private ComboBox TypeHolder;
}