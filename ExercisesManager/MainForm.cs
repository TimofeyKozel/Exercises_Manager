using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace ExercisesManager
{
    public partial class MainForm : Form
    {

        private readonly DataBase _database = new DataBase();

        public MainForm()
        {
            InitializeComponent();
        }


        public void RefreshDataGridview()
        {
            ExercisesTable.Rows.Clear();

            var queryString = $"SELECT * FROM Exercise_DB ORDER BY checkbox ASC, CASE WHEN checkbox = 0 THEN till END ASC," +
                                                                                    $"CASE WHEN checkbox = 1 THEN done END DESC";

            var command = new SqlCommand(queryString, _database.GetConnection());
            _database.OpenConnection();
            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(reader);
            }

            reader.Close();
            _database.CloseConnection();

            CheckExecutionTime();
        }


        private void ReadSingleRow(IDataRecord record)
        {
            if (!record.IsDBNull(4))
            {
                var till = Convert.ToDateTime(record[3]);
                var done = Convert.ToDateTime(record[4]);
                var tillFormatted = till.ToString("dd.MM.yyyy");
                var doneFormatted = done.ToString("dd.MM.yyyy");

                ExercisesTable.Rows.Add(record.GetInt32(0), Convert.ToBoolean(record[1]),
                                        record.GetString(2), tillFormatted, doneFormatted);
            }
            else
            {
                var till = Convert.ToDateTime(record[3]);
                var tillFormatted = till.ToString("dd.MM.yyyy");

                ExercisesTable.Rows.Add(record.GetInt32(0), Convert.ToBoolean(record[1]),
                                                        record.GetString(2), tillFormatted);
            }
        }


        private void CheckExecutionTime()
        {
            var today = DateTime.Today;
            foreach (DataGridViewRow row in ExercisesTable.Rows)
            {
                if (row.Cells["done"].Value == null && DateTime.TryParse(row.Cells["till"].Value.ToString(), out var rowDate) && rowDate < today)
                {
                    row.DefaultCellStyle.ForeColor = Color.Red;
                }
            }
        }


        private void NewExercise_Click(object sender, EventArgs e)
        {
            var f = new AddNewExerciseForm(this);
            this.Hide();
            f.Show();
        }


        public void ExercisesTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var today = DateTime.Today;

            if (e.RowIndex >= 0 && ExercisesTable.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn)
            {

                var isChecked = (bool)ExercisesTable[e.ColumnIndex, e.RowIndex].EditedFormattedValue;
                var idCheckBox = Convert.ToInt32(ExercisesTable.Rows[e.RowIndex].Cells[0].Value);

                if (isChecked)
                {
                    ExercisesTable.Rows[e.RowIndex].Cells[4].Value = today.ToString("dd.MM.yyyy");

                    var dateValue = DateTime.Today.ToString("yyyy-MM-dd");
                    const string updateQuery = "UPDATE exercise_db SET checkbox = @isChecked, done = @today WHERE id = @idCheckBox";
                    var command = new SqlCommand(updateQuery, _database.GetConnection());

                    command.Parameters.AddWithValue("@isChecked", true);
                    command.Parameters.AddWithValue("@today", dateValue);
                    command.Parameters.AddWithValue("@idCheckBox", idCheckBox);

                    _database.OpenConnection();
                    command.ExecuteNonQuery();
                }
                else
                {
                    const string updateQuery = "UPDATE exercise_db SET checkbox = @isChecked, done = @today WHERE id = @idCheckBox";
                    var command = new SqlCommand(updateQuery, _database.GetConnection());

                    command.Parameters.AddWithValue("@isChecked", false);
                    command.Parameters.AddWithValue("@today", DBNull.Value);
                    command.Parameters.AddWithValue("@idCheckBox", idCheckBox);

                    _database.OpenConnection();
                    command.ExecuteNonQuery();
                }
            }

            _database.CloseConnection();
            RefreshDataGridview();

            if (e.RowIndex >= 0 && ExercisesTable.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                var idButton = Convert.ToInt32(ExercisesTable.Rows[e.RowIndex].Cells[0].Value);
                var deleteQuery = $"DELETE FROM exercise_db WHERE id = @idButton";

                var command = new SqlCommand(deleteQuery, _database.GetConnection());
                command.Parameters.AddWithValue("@idButton", idButton);

                _database.OpenConnection();
                command.ExecuteNonQuery();
                _database.CloseConnection();
            }
            RefreshDataGridview();
        }


        public void Exercise_Load(object sender, EventArgs e)
        {
            RefreshDataGridview();
        }
    }
}