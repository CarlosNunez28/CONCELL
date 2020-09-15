namespace CONCELL
{
    partial class FMInventario
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
            this.buscarbtn = new System.Windows.Forms.Button();
            this.modificarbtn = new System.Windows.Forms.Button();
            this.agregarbtn = new System.Windows.Forms.Button();
            this.eliminarbtn = new System.Windows.Forms.Button();
            this.homebtn = new System.Windows.Forms.Button();
            this.salirbtn = new System.Windows.Forms.Button();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buscarbtn
            // 
            this.buscarbtn.Location = new System.Drawing.Point(12, 269);
            this.buscarbtn.Name = "buscarbtn";
            this.buscarbtn.Size = new System.Drawing.Size(75, 23);
            this.buscarbtn.TabIndex = 0;
            this.buscarbtn.Text = "Buscar";
            this.buscarbtn.UseVisualStyleBackColor = true;
            // 
            // modificarbtn
            // 
            this.modificarbtn.Location = new System.Drawing.Point(120, 269);
            this.modificarbtn.Name = "modificarbtn";
            this.modificarbtn.Size = new System.Drawing.Size(75, 23);
            this.modificarbtn.TabIndex = 1;
            this.modificarbtn.Text = "Modificar";
            this.modificarbtn.UseVisualStyleBackColor = true;
            // 
            // agregarbtn
            // 
            this.agregarbtn.Location = new System.Drawing.Point(235, 269);
            this.agregarbtn.Name = "agregarbtn";
            this.agregarbtn.Size = new System.Drawing.Size(75, 23);
            this.agregarbtn.TabIndex = 2;
            this.agregarbtn.Text = "Agregar";
            this.agregarbtn.UseVisualStyleBackColor = true;
            // 
            // eliminarbtn
            // 
            this.eliminarbtn.Location = new System.Drawing.Point(348, 269);
            this.eliminarbtn.Name = "eliminarbtn";
            this.eliminarbtn.Size = new System.Drawing.Size(75, 23);
            this.eliminarbtn.TabIndex = 3;
            this.eliminarbtn.Text = "Eliminar";
            this.eliminarbtn.UseVisualStyleBackColor = true;
            // 
            // homebtn
            // 
            this.homebtn.Location = new System.Drawing.Point(28, 395);
            this.homebtn.Name = "homebtn";
            this.homebtn.Size = new System.Drawing.Size(75, 23);
            this.homebtn.TabIndex = 5;
            this.homebtn.Text = "Home";
            this.homebtn.UseVisualStyleBackColor = true;
            // 
            // salirbtn
            // 
            this.salirbtn.Location = new System.Drawing.Point(131, 395);
            this.salirbtn.Name = "salirbtn";
            this.salirbtn.Size = new System.Drawing.Size(75, 23);
            this.salirbtn.TabIndex = 6;
            this.salirbtn.Text = "Salir";
            this.salirbtn.UseVisualStyleBackColor = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Existencias";
            this.Column4.Name = "Column4";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Tipo";
            this.Column3.Name = "Column3";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Producto";
            this.Column2.Name = "Column2";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "N";
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(12, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(442, 234);
            this.dataGridView1.TabIndex = 4;
            // 
            // FMInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 439);
            this.Controls.Add(this.salirbtn);
            this.Controls.Add(this.homebtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.eliminarbtn);
            this.Controls.Add(this.agregarbtn);
            this.Controls.Add(this.modificarbtn);
            this.Controls.Add(this.buscarbtn);
            this.Name = "FMInventario";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FMInventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buscarbtn;
        private System.Windows.Forms.Button modificarbtn;
        private System.Windows.Forms.Button agregarbtn;
        private System.Windows.Forms.Button eliminarbtn;
        private System.Windows.Forms.Button homebtn;
        private System.Windows.Forms.Button salirbtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}