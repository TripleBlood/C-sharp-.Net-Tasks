namespace WinFormTasks
{
    partial class Form2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.task1label = new System.Windows.Forms.Label();
            this.delColorizedFromGrid = new System.Windows.Forms.Button();
            this.delFromDb = new System.Windows.Forms.Button();
            this.reload = new System.Windows.Forms.Button();
            this.colorizeSelected = new System.Windows.Forms.Button();
            this.task2label = new System.Windows.Forms.Label();
            this.spellDamageTextBox = new System.Windows.Forms.Label();
            this.DamageTypeComboBox = new System.Windows.Forms.ComboBox();
            this.damageTextBox = new System.Windows.Forms.TextBox();
            this.spellNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.insertNewSpellInDB = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.sortBySpellName = new System.Windows.Forms.Button();
            this.sortByDamageType = new System.Windows.Forms.Button();
            this.sortByDamage = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.typeSortComboBox = new System.Windows.Forms.ComboBox();
            this.typeSortComboBoxSelect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(44, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(415, 382);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.Location = new System.Drawing.Point(496, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 43);
            this.button1.TabIndex = 1;
            this.button1.Text = "Read Data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(496, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // task1label
            // 
            this.task1label.AutoSize = true;
            this.task1label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.task1label.Location = new System.Drawing.Point(492, 28);
            this.task1label.Name = "task1label";
            this.task1label.Size = new System.Drawing.Size(56, 20);
            this.task1label.TabIndex = 3;
            this.task1label.Text = "Task 1";
            // 
            // delColorizedFromGrid
            // 
            this.delColorizedFromGrid.Enabled = false;
            this.delColorizedFromGrid.Location = new System.Drawing.Point(496, 160);
            this.delColorizedFromGrid.Name = "delColorizedFromGrid";
            this.delColorizedFromGrid.Size = new System.Drawing.Size(122, 42);
            this.delColorizedFromGrid.TabIndex = 5;
            this.delColorizedFromGrid.Text = "Delete colorized rows from Grid";
            this.delColorizedFromGrid.UseVisualStyleBackColor = true;
            this.delColorizedFromGrid.Click += new System.EventHandler(this.delColorizedFromGrid_Click);
            // 
            // delFromDb
            // 
            this.delFromDb.Enabled = false;
            this.delFromDb.Location = new System.Drawing.Point(496, 208);
            this.delFromDb.Name = "delFromDb";
            this.delFromDb.Size = new System.Drawing.Size(122, 43);
            this.delFromDb.TabIndex = 6;
            this.delFromDb.Text = "Delete colorized rows from db";
            this.delFromDb.UseVisualStyleBackColor = true;
            this.delFromDb.Click += new System.EventHandler(this.delFromDb_Click);
            // 
            // reload
            // 
            this.reload.Enabled = false;
            this.reload.Location = new System.Drawing.Point(496, 367);
            this.reload.Name = "reload";
            this.reload.Size = new System.Drawing.Size(122, 43);
            this.reload.TabIndex = 7;
            this.reload.Text = "Reload grid";
            this.reload.UseVisualStyleBackColor = true;
            this.reload.Click += new System.EventHandler(this.reload_Click);
            // 
            // colorizeSelected
            // 
            this.colorizeSelected.Enabled = false;
            this.colorizeSelected.Location = new System.Drawing.Point(496, 111);
            this.colorizeSelected.Name = "colorizeSelected";
            this.colorizeSelected.Size = new System.Drawing.Size(122, 43);
            this.colorizeSelected.TabIndex = 8;
            this.colorizeSelected.Text = "Colorize selected rows";
            this.colorizeSelected.UseVisualStyleBackColor = true;
            this.colorizeSelected.Click += new System.EventHandler(this.colorizeSelected_Click);
            // 
            // task2label
            // 
            this.task2label.AutoSize = true;
            this.task2label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.task2label.Location = new System.Drawing.Point(646, 28);
            this.task2label.Name = "task2label";
            this.task2label.Size = new System.Drawing.Size(56, 20);
            this.task2label.TabIndex = 9;
            this.task2label.Text = "Task 2";
            // 
            // spellDamageTextBox
            // 
            this.spellDamageTextBox.AutoSize = true;
            this.spellDamageTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.spellDamageTextBox.Location = new System.Drawing.Point(647, 110);
            this.spellDamageTextBox.Name = "spellDamageTextBox";
            this.spellDamageTextBox.Size = new System.Drawing.Size(65, 17);
            this.spellDamageTextBox.TabIndex = 10;
            this.spellDamageTextBox.Text = "Damage:";
            // 
            // DamageTypeComboBox
            // 
            this.DamageTypeComboBox.Enabled = false;
            this.DamageTypeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DamageTypeComboBox.Items.AddRange(new object[] {
            "FIRE",
            "ICE",
            "ELECTRICITY",
            "WATER",
            "POISON"});
            this.DamageTypeComboBox.Location = new System.Drawing.Point(721, 130);
            this.DamageTypeComboBox.Name = "DamageTypeComboBox";
            this.DamageTypeComboBox.Size = new System.Drawing.Size(105, 24);
            this.DamageTypeComboBox.TabIndex = 11;
            // 
            // damageTextBox
            // 
            this.damageTextBox.Enabled = false;
            this.damageTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.damageTextBox.Location = new System.Drawing.Point(650, 130);
            this.damageTextBox.Name = "damageTextBox";
            this.damageTextBox.Size = new System.Drawing.Size(62, 23);
            this.damageTextBox.TabIndex = 12;
            // 
            // spellNameTextBox
            // 
            this.spellNameTextBox.Enabled = false;
            this.spellNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.spellNameTextBox.Location = new System.Drawing.Point(650, 82);
            this.spellNameTextBox.Name = "spellNameTextBox";
            this.spellNameTextBox.Size = new System.Drawing.Size(176, 23);
            this.spellNameTextBox.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(647, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Spell name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(718, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Damage type:";
            // 
            // insertNewSpellInDB
            // 
            this.insertNewSpellInDB.Enabled = false;
            this.insertNewSpellInDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.insertNewSpellInDB.Location = new System.Drawing.Point(650, 160);
            this.insertNewSpellInDB.Name = "insertNewSpellInDB";
            this.insertNewSpellInDB.Size = new System.Drawing.Size(123, 43);
            this.insertNewSpellInDB.TabIndex = 16;
            this.insertNewSpellInDB.Text = "Insert into DB";
            this.insertNewSpellInDB.UseVisualStyleBackColor = true;
            this.insertNewSpellInDB.Click += new System.EventHandler(this.insertNewSpellInDB_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(647, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Sort by:";
            // 
            // sortBySpellName
            // 
            this.sortBySpellName.Enabled = false;
            this.sortBySpellName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.sortBySpellName.Location = new System.Drawing.Point(650, 228);
            this.sortBySpellName.Name = "sortBySpellName";
            this.sortBySpellName.Size = new System.Drawing.Size(79, 43);
            this.sortBySpellName.TabIndex = 18;
            this.sortBySpellName.Text = "Spell Name";
            this.sortBySpellName.UseVisualStyleBackColor = true;
            // 
            // sortByDamageType
            // 
            this.sortByDamageType.Enabled = false;
            this.sortByDamageType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.sortByDamageType.Location = new System.Drawing.Point(735, 228);
            this.sortByDamageType.Name = "sortByDamageType";
            this.sortByDamageType.Size = new System.Drawing.Size(79, 43);
            this.sortByDamageType.TabIndex = 19;
            this.sortByDamageType.Text = "Damage Type";
            this.sortByDamageType.UseVisualStyleBackColor = true;
            // 
            // sortByDamage
            // 
            this.sortByDamage.Enabled = false;
            this.sortByDamage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.sortByDamage.Location = new System.Drawing.Point(650, 277);
            this.sortByDamage.Name = "sortByDamage";
            this.sortByDamage.Size = new System.Drawing.Size(79, 43);
            this.sortByDamage.TabIndex = 20;
            this.sortByDamage.Text = "Damage";
            this.sortByDamage.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(647, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 34);
            this.label6.TabIndex = 21;
            this.label6.Text = "Colorize all rows where \r\ndamage type is:";
            // 
            // typeSortComboBox
            // 
            this.typeSortComboBox.Enabled = false;
            this.typeSortComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.typeSortComboBox.FormattingEnabled = true;
            this.typeSortComboBox.Items.AddRange(new object[] {
            "FIRE",
            "ICE",
            "ELECTRICITY",
            "WATER",
            "POISON"});
            this.typeSortComboBox.Location = new System.Drawing.Point(650, 360);
            this.typeSortComboBox.Name = "typeSortComboBox";
            this.typeSortComboBox.Size = new System.Drawing.Size(105, 24);
            this.typeSortComboBox.TabIndex = 22;
            // 
            // typeSortComboBoxSelect
            // 
            this.typeSortComboBoxSelect.Enabled = false;
            this.typeSortComboBoxSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.typeSortComboBoxSelect.Location = new System.Drawing.Point(650, 390);
            this.typeSortComboBoxSelect.Name = "typeSortComboBoxSelect";
            this.typeSortComboBoxSelect.Size = new System.Drawing.Size(79, 43);
            this.typeSortComboBoxSelect.TabIndex = 23;
            this.typeSortComboBoxSelect.Text = "Select";
            this.typeSortComboBoxSelect.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 450);
            this.Controls.Add(this.typeSortComboBoxSelect);
            this.Controls.Add(this.typeSortComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.sortByDamage);
            this.Controls.Add(this.sortByDamageType);
            this.Controls.Add(this.sortBySpellName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.insertNewSpellInDB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.spellNameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.damageTextBox);
            this.Controls.Add(this.DamageTypeComboBox);
            this.Controls.Add(this.spellDamageTextBox);
            this.Controls.Add(this.task2label);
            this.Controls.Add(this.colorizeSelected);
            this.Controls.Add(this.reload);
            this.Controls.Add(this.delFromDb);
            this.Controls.Add(this.delColorizedFromGrid);
            this.Controls.Add(this.task1label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label task1label;
        private System.Windows.Forms.Button delColorizedFromGrid;
        private System.Windows.Forms.Button delFromDb;
        private System.Windows.Forms.Button reload;
        private System.Windows.Forms.Button colorizeSelected;
        private System.Windows.Forms.Label task2label;
        private System.Windows.Forms.Label spellDamageTextBox;
        private System.Windows.Forms.ComboBox DamageTypeComboBox;
        private System.Windows.Forms.TextBox damageTextBox;
        private System.Windows.Forms.TextBox spellNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button insertNewSpellInDB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button sortBySpellName;
        private System.Windows.Forms.Button sortByDamageType;
        private System.Windows.Forms.Button sortByDamage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox typeSortComboBox;
        private System.Windows.Forms.Button typeSortComboBoxSelect;
    }
}