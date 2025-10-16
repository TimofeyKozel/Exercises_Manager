namespace ExercisesManager
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ExercisesTable = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkbox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Exercices = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Till = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Done = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RowDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.CmdAddExercise = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ExercisesTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // ExercisesTable
            // 
            this.ExercisesTable.AllowDrop = true;
            this.ExercisesTable.AllowUserToAddRows = false;
            this.ExercisesTable.AllowUserToDeleteRows = false;
            this.ExercisesTable.AllowUserToResizeColumns = false;
            this.ExercisesTable.AllowUserToResizeRows = false;
            this.ExercisesTable.BackgroundColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ExercisesTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ExercisesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ExercisesTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.checkbox,
            this.Exercices,
            this.Till,
            this.Done,
            this.RowDelete});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ExercisesTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.ExercisesTable.EnableHeadersVisualStyles = false;
            this.ExercisesTable.GridColor = System.Drawing.SystemColors.HighlightText;
            this.ExercisesTable.Location = new System.Drawing.Point(252, 144);
            this.ExercisesTable.Name = "ExercisesTable";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ExercisesTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.ExercisesTable.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Menu;
            this.ExercisesTable.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.ExercisesTable.Size = new System.Drawing.Size(749, 371);
            this.ExercisesTable.TabIndex = 1;
            this.ExercisesTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ExercisesTable_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            this.id.Width = 30;
            // 
            // checkbox
            // 
            this.checkbox.HeaderText = "";
            this.checkbox.Name = "checkbox";
            this.checkbox.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.checkbox.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.checkbox.Width = 30;
            // 
            // Exercices
            // 
            this.Exercices.HeaderText = "Aufgaben";
            this.Exercices.Name = "Exercices";
            this.Exercices.Width = 300;
            // 
            // Till
            // 
            this.Till.HeaderText = "Fällig am ";
            this.Till.Name = "Till";
            this.Till.Width = 150;
            // 
            // Done
            // 
            this.Done.HeaderText = "Fertig seit";
            this.Done.Name = "Done";
            this.Done.Width = 150;
            // 
            // RowDelete
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RowDelete.DefaultCellStyle = dataGridViewCellStyle2;
            this.RowDelete.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.RowDelete.HeaderText = "";
            this.RowDelete.Name = "RowDelete";
            this.RowDelete.Text = "Löschen";
            this.RowDelete.UseColumnTextForButtonValue = true;
            // 
            // CmdAddExercise
            // 
            this.CmdAddExercise.BackColor = System.Drawing.SystemColors.GrayText;
            this.CmdAddExercise.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdAddExercise.ForeColor = System.Drawing.SystemColors.Menu;
            this.CmdAddExercise.Location = new System.Drawing.Point(459, 531);
            this.CmdAddExercise.Name = "CmdAddExercise";
            this.CmdAddExercise.Size = new System.Drawing.Size(249, 67);
            this.CmdAddExercise.TabIndex = 2;
            this.CmdAddExercise.Text = "Neue Aufgabe";
            this.CmdAddExercise.UseVisualStyleBackColor = false;
            this.CmdAddExercise.Click += new System.EventHandler(this.NewExercise_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Menu;
            this.label1.Location = new System.Drawing.Point(409, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Meine Aufgaben bei DÜRR DENTAL";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(938, 531);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(245, 133);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1195, 673);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmdAddExercise);
            this.Controls.Add(this.ExercisesTable);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exercise Table";
            this.Load += new System.EventHandler(this.Exercise_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ExercisesTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CmdAddExercise;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView ExercisesTable;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkbox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Exercices;
        private System.Windows.Forms.DataGridViewTextBoxColumn Till;
        private System.Windows.Forms.DataGridViewTextBoxColumn Done;
        private System.Windows.Forms.DataGridViewButtonColumn RowDelete;
    }
}

