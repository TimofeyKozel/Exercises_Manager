using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace ExercisesManager
{
    public partial class ExerciseForm : Form
    {
        DataBase database = new DataBase();

        public bool isChecked;

        public ExerciseForm()
        {
            InitializeComponent();
        }


        private void ReadSingleRow(DataGridView ExercisesTable, IDataRecord record)
        {
            if (!record.IsDBNull(4))
            {
                DateTime datum = Convert.ToDateTime(record[3]);
                DateTime datum1 = Convert.ToDateTime(record[4]);
                string datum1Formatted = datum1.ToString("dd.MM.yyyy");
                string datumFormatted = datum.ToString("dd.MM.yyyy");

                ExercisesTable.Rows.Add(record.GetInt32(0), Convert.ToBoolean(record[1]), record.GetString(2), datumFormatted, datum1Formatted);
            }
            else
            {
                DateTime datum1 = Convert.ToDateTime(record[3]);
                string datum1Formatted = datum1.ToString("dd.MM.yyyy");
                ExercisesTable.Rows.Add(record.GetInt32(0), Convert.ToBoolean(record[1]), record.GetString(2), datum1Formatted);
            }
        }

        public void RefreshDataGridview(DataGridView ExercisesTable)
        {
            ExercisesTable.Rows.Clear();
            DateTime today = DateTime.Today;

            string queryString = $"select * from Exercise_DB ORDER BY checkbox ASC, CASE WHEN checkbox = 0 THEN till END ASC, CASE WHEN checkbox = 1 THEN done END DESC";

            SqlCommand command = new SqlCommand(queryString, database.getConnection());

            database.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(ExercisesTable, reader);
            }
            foreach (DataGridViewRow row in ExercisesTable.Rows)
            {
                if (row.Cells["till"].Value != null && row.Cells["done"].Value == null)
                {
                    DateTime rowDate;

                    if (DateTime.TryParse(row.Cells["till"].Value.ToString(), out rowDate))
                    {
                        if (rowDate < today)
                        {
                            row.DefaultCellStyle.ForeColor = Color.Red;
                        }
                    }
                }
            }
            reader.Close();
            database.closeConnection();
        }

        private void NewExercise_Click(object sender, EventArgs e)
        {
            AddNewExerciseForm f = new AddNewExerciseForm(this);

            this.Hide();
            f.Show();
        }

        public void ExercisesTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DateTime today = DateTime.Today;

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var column = ExercisesTable.Columns[e.ColumnIndex];

                if (column is DataGridViewCheckBoxColumn)
                {
                    isChecked = (bool)ExercisesTable[e.ColumnIndex, e.RowIndex].EditedFormattedValue;
                    var id = Convert.ToInt32(ExercisesTable.Rows[e.RowIndex].Cells[0].Value);

                    if (isChecked)
                    {
                        database.openConnection();
                        ExercisesTable.Rows[e.RowIndex].Cells[4].Value = today.ToString("dd.MM.yyyy");

                        string dateValue = isChecked ? DateTime.Today.ToString("yyyy-MM-dd") : null;


                        var updateQuery = "UPDATE exercise_db SET checkbox = @isChecked, done = @today WHERE id = @id";

                        var command = new SqlCommand(updateQuery, database.getConnection());

                        command.Parameters.AddWithValue("@isChecked", isChecked);
                        command.Parameters.AddWithValue("@today", dateValue != null ? (object)dateValue : DBNull.Value);
                        command.Parameters.AddWithValue("@id", id);

                        command.ExecuteNonQuery();
                        database.closeConnection();
                        RefreshDataGridview(ExercisesTable);
                    }
                    else
                    {
                        database.openConnection();

                        var updateQuery = "UPDATE exercise_db SET checkbox = @isChecked, done = @today WHERE id = @id";
                        var command = new SqlCommand(updateQuery, database.getConnection());

                        command.Parameters.AddWithValue("@isChecked", isChecked);
                        command.Parameters.AddWithValue("@today", DBNull.Value);
                        command.Parameters.AddWithValue("@id", id);

                        command.ExecuteNonQuery();

                        database.closeConnection();

                        ExercisesTable.Rows[e.RowIndex].Cells[4].Value = "";

                    }
                }
                RefreshDataGridview(ExercisesTable);
            }

            if (e.RowIndex >= 0 && ExercisesTable.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                database.openConnection();
                int rowIndex = e.RowIndex;

                var id = Convert.ToInt32(ExercisesTable.Rows[rowIndex].Cells[0].Value);

                var deleteQuery = $"delete from exercise_db where id = @id";

                var command = new SqlCommand(deleteQuery, database.getConnection());
                command.Parameters.AddWithValue("@id", id);

                command.ExecuteNonQuery();
                database.closeConnection();
                RefreshDataGridview(ExercisesTable);
            }
        }


        public void Exercise_Load(object sender, EventArgs e)
        {
            RefreshDataGridview(ExercisesTable);
        }
    }
}