namespace OffreEmploiApp5
{
    partial class AdminContact
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.AdminDeleteContactbtn = new System.Windows.Forms.Button();
            this.AdminAfficheContactbtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1295, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OliveDrab;
            this.label1.Location = new System.Drawing.Point(540, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Contact List";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Controls.Add(this.AdminDeleteContactbtn);
            this.panel2.Controls.Add(this.AdminAfficheContactbtn);
            this.panel2.Location = new System.Drawing.Point(3, 99);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1289, 581);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(124, 19);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1036, 450);
            this.dataGridView2.TabIndex = 2;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // AdminDeleteContactbtn
            // 
            this.AdminDeleteContactbtn.BackColor = System.Drawing.Color.OliveDrab;
            this.AdminDeleteContactbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminDeleteContactbtn.ForeColor = System.Drawing.Color.White;
            this.AdminDeleteContactbtn.Location = new System.Drawing.Point(727, 475);
            this.AdminDeleteContactbtn.Name = "AdminDeleteContactbtn";
            this.AdminDeleteContactbtn.Size = new System.Drawing.Size(203, 70);
            this.AdminDeleteContactbtn.TabIndex = 1;
            this.AdminDeleteContactbtn.Text = "Delete";
            this.AdminDeleteContactbtn.UseVisualStyleBackColor = false;
            this.AdminDeleteContactbtn.Click += new System.EventHandler(this.AdminDeleteContactbtn_Click);
            // 
            // AdminAfficheContactbtn
            // 
            this.AdminAfficheContactbtn.BackColor = System.Drawing.Color.OliveDrab;
            this.AdminAfficheContactbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminAfficheContactbtn.ForeColor = System.Drawing.Color.White;
            this.AdminAfficheContactbtn.Location = new System.Drawing.Point(313, 475);
            this.AdminAfficheContactbtn.Name = "AdminAfficheContactbtn";
            this.AdminAfficheContactbtn.Size = new System.Drawing.Size(203, 70);
            this.AdminAfficheContactbtn.TabIndex = 0;
            this.AdminAfficheContactbtn.Text = "Display";
            this.AdminAfficheContactbtn.UseVisualStyleBackColor = false;
            this.AdminAfficheContactbtn.Click += new System.EventHandler(this.AdminAfficheContactbtn_Click);
            // 
            // AdminContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AdminContact";
            this.Size = new System.Drawing.Size(1295, 683);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button AdminDeleteContactbtn;
        private System.Windows.Forms.Button AdminAfficheContactbtn;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}
