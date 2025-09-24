using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.InteropServices;

namespace ExercisesManager
{
    public partial class AddNewExerciseForm : Form
    {

        private ExerciseForm _parentForm;

        DataBase database = new DataBase();

        public AddNewExerciseForm(ExerciseForm parentForm)
        {
            InitializeComponent();
            _parentForm = parentForm;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            ExerciseForm c = new ExerciseForm();
            c.Show();
            this.Hide();
        }

        private void CleanExercise_Click(object sender, EventArgs e)
        {
            ExerciseTxtBox.Text = "";
        }

        private void CleanDate_Click(object sender, EventArgs e)
        {
            DateTxtBox.Text = "";
        }

        private void AddExercise_Click(object sender, EventArgs e)
        {
            var exercise = ExerciseTxtBox.Text;
            int boolValue = 0;

            DateTime dateFormat;

            if (DateTime.TryParse(DateTxtBox.Text, out dateFormat))
            {
                database.openConnection();

                var addQuery = $"insert into exercise_db (checkbox, exercises, till) values ({boolValue}, '{exercise}', '{dateFormat.ToString("yyyy-MM-dd")}')";
                var command = new SqlCommand(addQuery, database.getConnection());

                command.ExecuteNonQuery();
                database.closeConnection();
            }
            else
            {
                MessageBox.Show("Falsche eingabe von Datum oder das Feld leer ist!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            _parentForm.RefreshDataGridview(_parentForm.ExercisesTable);

            ExerciseForm c = new ExerciseForm();
            c.Show();
            this.Hide();
        }
    }
}

