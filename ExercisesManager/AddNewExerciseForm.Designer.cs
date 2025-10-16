namespace ExercisesManager
{
    partial class AddNewExerciseForm
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
            this.ExerciseTxtBox = new System.Windows.Forms.TextBox();
            this.DateTxtBox = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CmdCleanTxtBoxUp = new System.Windows.Forms.Button();
            this.CmdCleanTxtBoxDown = new System.Windows.Forms.Button();
            this.CmdAddExerciseToTable = new System.Windows.Forms.Button();
            this.CmdCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ExerciseTxtBox
            // 
            this.ExerciseTxtBox.BackColor = System.Drawing.SystemColors.Menu;
            this.ExerciseTxtBox.Location = new System.Drawing.Point(197, 98);
            this.ExerciseTxtBox.Name = "ExerciseTxtBox";
            this.ExerciseTxtBox.Size = new System.Drawing.Size(294, 20);
            this.ExerciseTxtBox.TabIndex = 0;
            this.ExerciseTxtBox.TextChanged += new System.EventHandler(this.ExerciseTxtBox_TextChanged);
            // 
            // DateTxtBox
            // 
            this.DateTxtBox.BackColor = System.Drawing.SystemColors.Menu;
            this.DateTxtBox.Location = new System.Drawing.Point(197, 152);
            this.DateTxtBox.Name = "DateTxtBox";
            this.DateTxtBox.Size = new System.Drawing.Size(294, 20);
            this.DateTxtBox.TabIndex = 1;
            this.DateTxtBox.TextChanged += new System.EventHandler(this.DateTxtBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Menu;
            this.label1.Location = new System.Drawing.Point(60, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Neue Aufgabe ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Menu;
            this.label2.Location = new System.Drawing.Point(60, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fällig am";
            // 
            // CmdCleanTxtBoxUp
            // 
            this.CmdCleanTxtBoxUp.BackColor = System.Drawing.SystemColors.GrayText;
            this.CmdCleanTxtBoxUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdCleanTxtBoxUp.ForeColor = System.Drawing.SystemColors.Menu;
            this.CmdCleanTxtBoxUp.Location = new System.Drawing.Point(530, 98);
            this.CmdCleanTxtBoxUp.Name = "CmdCleanTxtBoxUp";
            this.CmdCleanTxtBoxUp.Size = new System.Drawing.Size(75, 23);
            this.CmdCleanTxtBoxUp.TabIndex = 4;
            this.CmdCleanTxtBoxUp.Text = "Löschen";
            this.CmdCleanTxtBoxUp.UseVisualStyleBackColor = false;
            this.CmdCleanTxtBoxUp.Click += new System.EventHandler(this.CleanExercise_Click);
            // 
            // CmdCleanTxtBoxDown
            // 
            this.CmdCleanTxtBoxDown.BackColor = System.Drawing.SystemColors.GrayText;
            this.CmdCleanTxtBoxDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdCleanTxtBoxDown.ForeColor = System.Drawing.SystemColors.Menu;
            this.CmdCleanTxtBoxDown.Location = new System.Drawing.Point(530, 154);
            this.CmdCleanTxtBoxDown.Name = "CmdCleanTxtBoxDown";
            this.CmdCleanTxtBoxDown.Size = new System.Drawing.Size(75, 23);
            this.CmdCleanTxtBoxDown.TabIndex = 5;
            this.CmdCleanTxtBoxDown.Text = "Löschen";
            this.CmdCleanTxtBoxDown.UseVisualStyleBackColor = false;
            this.CmdCleanTxtBoxDown.Click += new System.EventHandler(this.CleanDate_Click);
            // 
            // CmdAddExerciseToTable
            // 
            this.CmdAddExerciseToTable.BackColor = System.Drawing.SystemColors.GrayText;
            this.CmdAddExerciseToTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdAddExerciseToTable.ForeColor = System.Drawing.SystemColors.Menu;
            this.CmdAddExerciseToTable.Location = new System.Drawing.Point(153, 248);
            this.CmdAddExerciseToTable.Name = "CmdAddExerciseToTable";
            this.CmdAddExerciseToTable.Size = new System.Drawing.Size(130, 34);
            this.CmdAddExerciseToTable.TabIndex = 6;
            this.CmdAddExerciseToTable.Text = "Ablegen";
            this.CmdAddExerciseToTable.UseVisualStyleBackColor = false;
            this.CmdAddExerciseToTable.Click += new System.EventHandler(this.AddExercise_Click);
            // 
            // CmdCancel
            // 
            this.CmdCancel.BackColor = System.Drawing.SystemColors.GrayText;
            this.CmdCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdCancel.ForeColor = System.Drawing.SystemColors.Menu;
            this.CmdCancel.Location = new System.Drawing.Point(414, 248);
            this.CmdCancel.Name = "CmdCancel";
            this.CmdCancel.Size = new System.Drawing.Size(130, 34);
            this.CmdCancel.TabIndex = 7;
            this.CmdCancel.Text = "Abrechen";
            this.CmdCancel.UseVisualStyleBackColor = false;
            this.CmdCancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // AddNewExerciseForm
            // 
            this.AcceptButton = this.CmdAddExerciseToTable;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(707, 428);
            this.Controls.Add(this.CmdCancel);
            this.Controls.Add(this.CmdAddExerciseToTable);
            this.Controls.Add(this.CmdCleanTxtBoxDown);
            this.Controls.Add(this.CmdCleanTxtBoxUp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DateTxtBox);
            this.Controls.Add(this.ExerciseTxtBox);
            this.Name = "AddNewExerciseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewExercise";
            this.Load += new System.EventHandler(this.AddNewExerciseForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ExerciseTxtBox;
        private System.Windows.Forms.MaskedTextBox DateTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CmdCleanTxtBoxUp;
        private System.Windows.Forms.Button CmdCleanTxtBoxDown;
        private System.Windows.Forms.Button CmdAddExerciseToTable;
        private System.Windows.Forms.Button CmdCancel;
    }
}