namespace HomeworkLinqRequests
{
    partial class FormLinqRequests
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonRequestNameOfPlayers = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonRequesNameOfClassAndNameOfSpell = new System.Windows.Forms.Button();
            this.buttonRequestNameOfPlayersAndNameOfClass = new System.Windows.Forms.Button();
            this.buttonRequesNameOfPlayersAndNameOfSpell = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1089, 410);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonRequestNameOfPlayers
            // 
            this.buttonRequestNameOfPlayers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonRequestNameOfPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRequestNameOfPlayers.Location = new System.Drawing.Point(12, 30);
            this.buttonRequestNameOfPlayers.Name = "buttonRequestNameOfPlayers";
            this.buttonRequestNameOfPlayers.Size = new System.Drawing.Size(462, 120);
            this.buttonRequestNameOfPlayers.TabIndex = 1;
            this.buttonRequestNameOfPlayers.Text = "Вывести Имена всех играков";
            this.buttonRequestNameOfPlayers.UseVisualStyleBackColor = true;
            this.buttonRequestNameOfPlayers.Click += new System.EventHandler(this.ButtonRequestNameOfPlayers_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonRequesNameOfClassAndNameOfSpell);
            this.groupBox1.Controls.Add(this.buttonRequestNameOfPlayersAndNameOfClass);
            this.groupBox1.Controls.Add(this.buttonRequestNameOfPlayers);
            this.groupBox1.Controls.Add(this.buttonRequesNameOfPlayersAndNameOfSpell);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 410);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1089, 370);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // buttonRequesNameOfClassAndNameOfSpell
            // 
            this.buttonRequesNameOfClassAndNameOfSpell.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonRequesNameOfClassAndNameOfSpell.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRequesNameOfClassAndNameOfSpell.Location = new System.Drawing.Point(524, 180);
            this.buttonRequesNameOfClassAndNameOfSpell.Name = "buttonRequesNameOfClassAndNameOfSpell";
            this.buttonRequesNameOfClassAndNameOfSpell.Size = new System.Drawing.Size(522, 169);
            this.buttonRequesNameOfClassAndNameOfSpell.TabIndex = 4;
            this.buttonRequesNameOfClassAndNameOfSpell.Text = "Вывести Название всех классов играков и их умения";
            this.buttonRequesNameOfClassAndNameOfSpell.UseVisualStyleBackColor = true;
            this.buttonRequesNameOfClassAndNameOfSpell.Click += new System.EventHandler(this.ButtonRequesNameOfClassAndNameOfSpell_Click);
            // 
            // buttonRequestNameOfPlayersAndNameOfClass
            // 
            this.buttonRequestNameOfPlayersAndNameOfClass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonRequestNameOfPlayersAndNameOfClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRequestNameOfPlayersAndNameOfClass.Location = new System.Drawing.Point(524, 30);
            this.buttonRequestNameOfPlayersAndNameOfClass.Name = "buttonRequestNameOfPlayersAndNameOfClass";
            this.buttonRequestNameOfPlayersAndNameOfClass.Size = new System.Drawing.Size(522, 120);
            this.buttonRequestNameOfPlayersAndNameOfClass.TabIndex = 2;
            this.buttonRequestNameOfPlayersAndNameOfClass.Text = "Вывести Имена всех играков и их классы";
            this.buttonRequestNameOfPlayersAndNameOfClass.UseVisualStyleBackColor = true;
            this.buttonRequestNameOfPlayersAndNameOfClass.Click += new System.EventHandler(this.ButtonRequestNameOfPlayersAndNameOfClass_Click);
            // 
            // buttonRequesNameOfPlayersAndNameOfSpell
            // 
            this.buttonRequesNameOfPlayersAndNameOfSpell.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonRequesNameOfPlayersAndNameOfSpell.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRequesNameOfPlayersAndNameOfSpell.Location = new System.Drawing.Point(12, 180);
            this.buttonRequesNameOfPlayersAndNameOfSpell.Name = "buttonRequesNameOfPlayersAndNameOfSpell";
            this.buttonRequesNameOfPlayersAndNameOfSpell.Size = new System.Drawing.Size(462, 169);
            this.buttonRequesNameOfPlayersAndNameOfSpell.TabIndex = 3;
            this.buttonRequesNameOfPlayersAndNameOfSpell.Text = "Вывести Имена всех играков и их умения";
            this.buttonRequesNameOfPlayersAndNameOfSpell.UseVisualStyleBackColor = true;
            this.buttonRequesNameOfPlayersAndNameOfSpell.Click += new System.EventHandler(this.ButtonRequestNameOfPlayersAndNameOfSpell_Click);
            // 
            // FormLinqRequests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 803);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormLinqRequests";
            this.Text = "LING запросы";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonRequestNameOfPlayers;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonRequestNameOfPlayersAndNameOfClass;
        private System.Windows.Forms.Button buttonRequesNameOfPlayersAndNameOfSpell;
        private System.Windows.Forms.Button buttonRequesNameOfClassAndNameOfSpell;
    }
}

