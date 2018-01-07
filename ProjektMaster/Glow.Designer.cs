namespace ProjektMaster
{
    partial class Glow
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
            this.Okno_search = new System.Windows.Forms.ListBox();
            this.Pasek_search = new System.Windows.Forms.TextBox();
            this.Etykieta = new System.Windows.Forms.Label();
            this.Search_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Okno_search
            // 
            this.Okno_search.FormattingEnabled = true;
            this.Okno_search.Location = new System.Drawing.Point(32, 127);
            this.Okno_search.Name = "Okno_search";
            this.Okno_search.Size = new System.Drawing.Size(317, 238);
            this.Okno_search.TabIndex = 0;
            // 
            // Pasek_search
            // 
            this.Pasek_search.Location = new System.Drawing.Point(80, 58);
            this.Pasek_search.Name = "Pasek_search";
            this.Pasek_search.Size = new System.Drawing.Size(172, 20);
            this.Pasek_search.TabIndex = 1;
            // 
            // Etykieta
            // 
            this.Etykieta.AutoSize = true;
            this.Etykieta.Location = new System.Drawing.Point(29, 58);
            this.Etykieta.Name = "Etykieta";
            this.Etykieta.Size = new System.Drawing.Size(45, 13);
            this.Etykieta.TabIndex = 2;
            this.Etykieta.Text = "Etykieta";
            // 
            // Search_button
            // 
            this.Search_button.Location = new System.Drawing.Point(274, 58);
            this.Search_button.Name = "Search_button";
            this.Search_button.Size = new System.Drawing.Size(75, 23);
            this.Search_button.TabIndex = 3;
            this.Search_button.Text = "Szukaj";
            this.Search_button.UseVisualStyleBackColor = true;
            this.Search_button.Click += new System.EventHandler(this.Search_button_Click);
            // 
            // Glow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 439);
            this.Controls.Add(this.Search_button);
            this.Controls.Add(this.Etykieta);
            this.Controls.Add(this.Pasek_search);
            this.Controls.Add(this.Okno_search);
            this.Name = "Glow";
            this.Text = "SQL Data Access Graclik/Kromolski";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Okno_search;
        private System.Windows.Forms.TextBox Pasek_search;
        private System.Windows.Forms.Label Etykieta;
        private System.Windows.Forms.Button Search_button;
    }
}

