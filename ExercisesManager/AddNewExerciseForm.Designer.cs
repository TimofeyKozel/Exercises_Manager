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
            this.CleanExercise = new System.Windows.Forms.Button();
            this.CleanDate = new System.Windows.Forms.Button();
            this.AddExercise = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ExerciseTxtBox
            // 
            this.ExerciseTxtBox.Location = new System.Drawing.Point(197, 98);
            this.ExerciseTxtBox.Name = "ExerciseTxtBox";
            this.ExerciseTxtBox.Size = new System.Drawing.Size(294, 20);
            this.ExerciseTxtBox.TabIndex = 0;
            // 
            // DateTxtBox
            // 
            this.DateTxtBox.Location = new System.Drawing.Point(197, 152);
            this.DateTxtBox.Name = "DateTxtBox";
            this.DateTxtBox.Size = new System.Drawing.Size(294, 20);
            this.DateTxtBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.label2.Location = new System.Drawing.Point(60, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fällig am";
            // 
            // CleanExercise
            // 
            this.CleanExercise.Location = new System.Drawing.Point(530, 98);
            this.CleanExercise.Name = "CleanExercise";
            this.CleanExercise.Size = new System.Drawing.Size(75, 23);
            this.CleanExercise.TabIndex = 4;
            this.CleanExercise.Text = "Löschen";
            this.CleanExercise.UseVisualStyleBackColor = true;
            this.CleanExercise.Click += new System.EventHandler(this.CleanExercise_Click);
            // 
            // CleanDate
            // 
            this.CleanDate.Location = new System.Drawing.Point(530, 154);
            this.CleanDate.Name = "CleanDate";
            this.CleanDate.Size = new System.Drawing.Size(75, 23);
            this.CleanDate.TabIndex = 5;
            this.CleanDate.Text = "Löschen";
            this.CleanDate.UseVisualStyleBackColor = true;
            this.CleanDate.Click += new System.EventHandler(this.CleanDate_Click);
            // 
            // AddExercise
            // 
            this.AddExercise.Location = new System.Drawing.Point(153, 248);
            this.AddExercise.Name = "AddExercise";
            this.AddExercise.Size = new System.Drawing.Size(130, 34);
            this.AddExercise.TabIndex = 6;
            this.AddExercise.Text = "Ablegen";
            this.AddExercise.UseVisualStyleBackColor = true;
            this.AddExercise.Click += new System.EventHandler(this.AddExercise_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(414, 248);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(130, 34);
            this.Cancel.TabIndex = 7;
            this.Cancel.Text = "Abrechen";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // AddNewExerciseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 437);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.AddExercise);
            this.Controls.Add(this.CleanDate);
            this.Controls.Add(this.CleanExercise);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DateTxtBox);
            this.Controls.Add(this.ExerciseTxtBox);
            this.Name = "AddNewExerciseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewExercise";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ExerciseTxtBox;
        private System.Windows.Forms.MaskedTextBox DateTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CleanExercise;
        private System.Windows.Forms.Button CleanDate;
        private System.Windows.Forms.Button AddExercise;
        private System.Windows.Forms.Button Cancel;
    }
}