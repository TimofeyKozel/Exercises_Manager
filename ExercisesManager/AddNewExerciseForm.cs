using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ExercisesManager
{
    public partial class AddNewExerciseForm : Form
    {

        private readonly MainForm _parentForm;

        private readonly DataBase _database = new DataBase();


        public AddNewExerciseForm(MainForm parentForm)
        {
            InitializeComponent();
            _parentForm = parentForm;
        }


        private void AddNewExerciseForm_Load(object sender, EventArgs e)
        {
            CheckChangesTextBoxes();
        }


        private void Cancel_Click(object sender, EventArgs e)
        {
            var c = new MainForm();
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


        private void ExerciseTxtBox_TextChanged(object sender, EventArgs e)
        {
            CheckChangesTextBoxes();
        }


        private void DateTxtBox_TextChanged(object sender, EventArgs e)
        {
            CheckChangesTextBoxes();
        }


        private void CheckChangesTextBoxes()
        {
            CmdAddExerciseToTable.Enabled = !string.IsNullOrWhiteSpace(ExerciseTxtBox.Text) &&
                              !string.IsNullOrWhiteSpace(DateTxtBox.Text);
        }


        private void AddExercise_Click(object sender, EventArgs e)
        {
            var exercise = Convert.ToString(ExerciseTxtBox.Text);
            const int boolValue = 0;

            if (exercise.Contains(";") || exercise.Contains("'") || exercise.Contains("\"") || exercise.Contains("-") || exercise.Contains("\\"))
            {
                const string semicolon = ";";
                const string apostrophe = "'";
                const string hyphen = "-";
                const string quotationMark = "\"";
                const string backSlash = "\\";
                const string equalSign = "=";
                const string lessThanSign = "<";
                const string moreThanSign = ">";


                MessageBox.Show($@"Sie können keine Zeichen wie ""{semicolon}""  ""{apostrophe}""  ""{hyphen}""" +
                                $@"  ""{quotationMark}"" ""{backSlash}"" ""{equalSign}"" ""{lessThanSign}"" ""{moreThanSign}"" benutzen!", @"Fehler",
                                                                                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (DateTime.TryParse(DateTxtBox.Text, out var dateFormat))
            {
                var addQuery =
                    $"INSERT INTO exercise_db (checkbox, exercises, till) VALUES ({boolValue}, '{exercise}'," +
                    $"'{dateFormat:yyyy-MM-dd}')";
                var command = new SqlCommand(addQuery, _database.GetConnection());

                _database.OpenConnection();
                command.ExecuteNonQuery();
                _database.CloseConnection();
            }

            else
            {
                MessageBox.Show(@"Falsche Eingabe vom Datum!", @"Fehler", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            _parentForm.RefreshDataGridview();

            var c = new MainForm();
            c.Show();
            this.Hide();
        }
    }
}

