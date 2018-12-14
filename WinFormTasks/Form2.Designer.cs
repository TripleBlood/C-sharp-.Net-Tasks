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
            this.IceLanceDetector = new System.Windows.Forms.Button();
            this.IceLanceGridDelete = new System.Windows.Forms.Button();
            this.delFromDb = new System.Windows.Forms.Button();
            this.reload = new System.Windows.Forms.Button();
            this.colorizeSelected = new System.Windows.Forms.Button();
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
            // IceLanceDetector
            // 
            this.IceLanceDetector.Location = new System.Drawing.Point(496, 111);
            this.IceLanceDetector.Name = "IceLanceDetector";
            this.IceLanceDetector.Size = new System.Drawing.Size(123, 42);
            this.IceLanceDetector.TabIndex = 4;
            this.IceLanceDetector.Text = "Show all \"Ice Lances\"";
            this.IceLanceDetector.UseVisualStyleBackColor = true;
            this.IceLanceDetector.Click += new System.EventHandler(this.button2_Click);
            // 
            // IceLanceGridDelete
            // 
            this.IceLanceGridDelete.Location = new System.Drawing.Point(496, 208);
            this.IceLanceGridDelete.Name = "IceLanceGridDelete";
            this.IceLanceGridDelete.Size = new System.Drawing.Size(122, 42);
            this.IceLanceGridDelete.TabIndex = 5;
            this.IceLanceGridDelete.Text = "Delete colorized rows from Grid";
            this.IceLanceGridDelete.UseVisualStyleBackColor = true;
            this.IceLanceGridDelete.Click += new System.EventHandler(this.IceLanceGridDelete_Click);
            // 
            // delFromDb
            // 
            this.delFromDb.Location = new System.Drawing.Point(496, 256);
            this.delFromDb.Name = "delFromDb";
            this.delFromDb.Size = new System.Drawing.Size(122, 43);
            this.delFromDb.TabIndex = 6;
            this.delFromDb.Text = "Delete colorized rows from db";
            this.delFromDb.UseVisualStyleBackColor = true;
            this.delFromDb.Click += new System.EventHandler(this.delFromDb_Click);
            // 
            // reload
            // 
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
            this.colorizeSelected.Location = new System.Drawing.Point(496, 159);
            this.colorizeSelected.Name = "colorizeSelected";
            this.colorizeSelected.Size = new System.Drawing.Size(122, 43);
            this.colorizeSelected.TabIndex = 8;
            this.colorizeSelected.Text = "Colorize selected rows";
            this.colorizeSelected.UseVisualStyleBackColor = true;
            this.colorizeSelected.Click += new System.EventHandler(this.colorizeSelected_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 450);
            this.Controls.Add(this.colorizeSelected);
            this.Controls.Add(this.reload);
            this.Controls.Add(this.delFromDb);
            this.Controls.Add(this.IceLanceGridDelete);
            this.Controls.Add(this.IceLanceDetector);
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
        private System.Windows.Forms.Button IceLanceDetector;
        private System.Windows.Forms.Button IceLanceGridDelete;
        private System.Windows.Forms.Button delFromDb;
        private System.Windows.Forms.Button reload;
        private System.Windows.Forms.Button colorizeSelected;
    }
}