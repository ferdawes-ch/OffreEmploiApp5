namespace OffreEmploiApp5
{
    partial class AdminAddUserss
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
            this.label1 = new System.Windows.Forms.Label();
            this.AdminAddPasstxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AdminAddNametxt = new System.Windows.Forms.TextBox();
            this.AdminDeletebtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.AdminUpdatebtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.AdminAddEmailtxt = new System.Windows.Forms.TextBox();
            this.btnAddAdmin = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxAdminAddList = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OliveDrab;
            this.label1.Location = new System.Drawing.Point(540, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Users List";
            // 
            // AdminAddPasstxt
            // 
            this.AdminAddPasstxt.Location = new System.Drawing.Point(174, 250);
            this.AdminAddPasstxt.Name = "AdminAddPasstxt";
            this.AdminAddPasstxt.Size = new System.Drawing.Size(175, 22);
            this.AdminAddPasstxt.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(50, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Name";
            // 
            // AdminAddNametxt
            // 
            this.AdminAddNametxt.Location = new System.Drawing.Point(174, 68);
            this.AdminAddNametxt.Name = "AdminAddNametxt";
            this.AdminAddNametxt.Size = new System.Drawing.Size(175, 22);
            this.AdminAddNametxt.TabIndex = 4;
            // 
            // AdminDeletebtn
            // 
            this.AdminDeletebtn.BackColor = System.Drawing.Color.OliveDrab;
            this.AdminDeletebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminDeletebtn.ForeColor = System.Drawing.Color.White;
            this.AdminDeletebtn.Location = new System.Drawing.Point(200, 426);
            this.AdminDeletebtn.Name = "AdminDeletebtn";
            this.AdminDeletebtn.Size = new System.Drawing.Size(95, 37);
            this.AdminDeletebtn.TabIndex = 7;
            this.AdminDeletebtn.Text = "Delete";
            this.AdminDeletebtn.UseVisualStyleBackColor = false;
            this.AdminDeletebtn.Click += new System.EventHandler(this.AdminDeletebtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 15);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(734, 529);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Location = new System.Drawing.Point(512, 103);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(764, 562);
            this.panel4.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1295, 683);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.AdminAddPasstxt);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.AdminAddNametxt);
            this.panel3.Controls.Add(this.AdminDeletebtn);
            this.panel3.Controls.Add(this.AdminUpdatebtn);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.AdminAddEmailtxt);
            this.panel3.Controls.Add(this.btnAddAdmin);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.comboBoxAdminAddList);
            this.panel3.Location = new System.Drawing.Point(15, 103);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(477, 562);
            this.panel3.TabIndex = 15;
            // 
            // AdminUpdatebtn
            // 
            this.AdminUpdatebtn.BackColor = System.Drawing.Color.OliveDrab;
            this.AdminUpdatebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminUpdatebtn.ForeColor = System.Drawing.Color.White;
            this.AdminUpdatebtn.Location = new System.Drawing.Point(320, 426);
            this.AdminUpdatebtn.Name = "AdminUpdatebtn";
            this.AdminUpdatebtn.Size = new System.Drawing.Size(96, 37);
            this.AdminUpdatebtn.TabIndex = 8;
            this.AdminUpdatebtn.Text = "Update";
            this.AdminUpdatebtn.UseVisualStyleBackColor = false;
            this.AdminUpdatebtn.Click += new System.EventHandler(this.AdminUpdatebtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(50, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Email";
            // 
            // AdminAddEmailtxt
            // 
            this.AdminAddEmailtxt.Location = new System.Drawing.Point(174, 159);
            this.AdminAddEmailtxt.Name = "AdminAddEmailtxt";
            this.AdminAddEmailtxt.Size = new System.Drawing.Size(175, 22);
            this.AdminAddEmailtxt.TabIndex = 1;
            // 
            // btnAddAdmin
            // 
            this.btnAddAdmin.BackColor = System.Drawing.Color.OliveDrab;
            this.btnAddAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAdmin.ForeColor = System.Drawing.Color.White;
            this.btnAddAdmin.Location = new System.Drawing.Point(53, 426);
            this.btnAddAdmin.Name = "btnAddAdmin";
            this.btnAddAdmin.Size = new System.Drawing.Size(102, 37);
            this.btnAddAdmin.TabIndex = 6;
            this.btnAddAdmin.Text = "Add";
            this.btnAddAdmin.UseVisualStyleBackColor = false;
            this.btnAddAdmin.Click += new System.EventHandler(this.btnAddAdmin_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(50, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Role";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(50, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Password";
            // 
            // comboBoxAdminAddList
            // 
            this.comboBoxAdminAddList.FormattingEnabled = true;
            this.comboBoxAdminAddList.Items.AddRange(new object[] {
            "Recruteur",
            "Employee"});
            this.comboBoxAdminAddList.Location = new System.Drawing.Point(174, 326);
            this.comboBoxAdminAddList.Name = "comboBoxAdminAddList";
            this.comboBoxAdminAddList.Size = new System.Drawing.Size(175, 24);
            this.comboBoxAdminAddList.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1295, 88);
            this.panel2.TabIndex = 5;
            // 
            // AdminAddUserss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "AdminAddUserss";
            this.Size = new System.Drawing.Size(1295, 683);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AdminAddPasstxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AdminAddNametxt;
        private System.Windows.Forms.Button AdminDeletebtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button AdminUpdatebtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AdminAddEmailtxt;
        private System.Windows.Forms.Button btnAddAdmin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxAdminAddList;
        private System.Windows.Forms.Panel panel2;
    }
}
