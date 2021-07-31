
namespace WorldAtlas
{
    partial class WorldAtlasForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.CountryLV = new System.Windows.Forms.ListView();
            this.ContLV = new System.Windows.Forms.ListView();
            this.Cont = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Country = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // CountryLV
            // 
            this.CountryLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Country});
            this.CountryLV.GridLines = true;
            this.CountryLV.HideSelection = false;
            this.CountryLV.Location = new System.Drawing.Point(310, 2);
            this.CountryLV.Name = "CountryLV";
            this.CountryLV.Size = new System.Drawing.Size(327, 398);
            this.CountryLV.TabIndex = 0;
            this.CountryLV.UseCompatibleStateImageBehavior = false;
            this.CountryLV.View = System.Windows.Forms.View.Details;
            // 
            // ContLV
            // 
            this.ContLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Cont});
            this.ContLV.GridLines = true;
            this.ContLV.HideSelection = false;
            this.ContLV.Location = new System.Drawing.Point(90, 2);
            this.ContLV.Name = "ContLV";
            this.ContLV.Size = new System.Drawing.Size(174, 177);
            this.ContLV.TabIndex = 1;
            this.ContLV.UseCompatibleStateImageBehavior = false;
            this.ContLV.View = System.Windows.Forms.View.Details;
            this.ContLV.ItemActivate += new System.EventHandler(this.ContLV_ItemActivate);
            this.ContLV.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.ContLV_ItemSelectionChanged);
            // 
            // Cont
            // 
            this.Cont.Text = "Континент";
            this.Cont.Width = 169;
            // 
            // Country
            // 
            this.Country.Text = "Страна";
            this.Country.Width = 323;
            // 
            // WorldAtlasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ContLV);
            this.Controls.Add(this.CountryLV);
            this.Name = "WorldAtlasForm";
            this.Text = "WorldAtlas";
            this.Load += new System.EventHandler(this.WorldAtlasForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView CountryLV;
        private System.Windows.Forms.ListView ContLV;
        private System.Windows.Forms.ColumnHeader Cont;
        private System.Windows.Forms.ColumnHeader Country;
    }
}

