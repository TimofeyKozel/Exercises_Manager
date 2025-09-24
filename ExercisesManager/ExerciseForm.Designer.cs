namespace ExercisesManager
{
    partial class ExerciseForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ExercisesTable = new System.Windows.Forms.DataGridView();
            this.NewExercise = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkbox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Exercices = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Till = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Done = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RowDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ExercisesTable)).BeginInit();
            this.SuspendLayout();
            // 
            // ExercisesTable
            // 
            this.ExercisesTable.AllowDrop = true;
            this.ExercisesTable.AllowUserToAddRows = false;
            this.ExercisesTable.AllowUserToDeleteRows = false;
            this.ExercisesTable.AllowUserToResizeColumns = false;
            this.ExercisesTable.AllowUserToResizeRows = false;
            this.ExercisesTable.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ExercisesTable.DefaultCellStyle = dataGridViewCellStyle2;
            this.ExercisesTable.Location = new System.Drawing.Point(212, 125);
            this.ExercisesTable.Name = "ExercisesTable";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ExercisesTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.ExercisesTable.RowHeadersVisible = false;
            this.ExercisesTable.Size = new System.Drawing.Size(783, 371);
            this.ExercisesTable.TabIndex = 1;
            this.ExercisesTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ExercisesTable_CellContentClick);
            // 
            // NewExercise
            // 
            this.NewExercise.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewExercise.Location = new System.Drawing.Point(459, 531);
            this.NewExercise.Name = "NewExercise";
            this.NewExercise.Size = new System.Drawing.Size(249, 67);
            this.NewExercise.TabIndex = 2;
            this.NewExercise.Text = "Neue Aufgabe";
            this.NewExercise.UseVisualStyleBackColor = true;
            this.NewExercise.Click += new System.EventHandler(this.NewExercise_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(490, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Deine Aufgaben ";
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
            this.RowDelete.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.RowDelete.HeaderText = "";
            this.RowDelete.Name = "RowDelete";
            this.RowDelete.Text = "Löschen";
            this.RowDelete.UseColumnTextForButtonValue = true;
            this.RowDelete.Width = 150;
            // 
            // ExerciseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1171, 647);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NewExercise);
            this.Controls.Add(this.ExercisesTable);
            this.Name = "ExerciseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exercise Table";
            this.Load += new System.EventHandler(this.Exercise_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ExercisesTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button NewExercise;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView ExercisesTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkbox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Exercices;
        private System.Windows.Forms.DataGridViewTextBoxColumn Till;
        private System.Windows.Forms.DataGridViewTextBoxColumn Done;
        private System.Windows.Forms.DataGridViewButtonColumn RowDelete;
    }
}

