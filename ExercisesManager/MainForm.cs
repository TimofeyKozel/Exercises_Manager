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
    public partial class MainForm : Form
    {
        DataBase database = new DataBase();

        public bool isChecked;

        public MainForm()
        {
            InitializeComponent();
        }


        private void ReadSingleRow(DataGridView ExercisesTable, IDataRecord record)
        {
            if (!record.IsDBNull(4))
            {
                DateTime till = Convert.ToDateTime(record[3]);
                DateTime done = Convert.ToDateTime(record[4]);
                string tillFormatted = till.ToString("dd.MM.yyyy");
                string doneFormatted = done.ToString("dd.MM.yyyy");

                ExercisesTable.Rows.Add(record.GetInt32(0), Convert.ToBoolean(record[1]),
                                        record.GetString(2), tillFormatted, doneFormatted);
            }
            else
            {
                DateTime till = Convert.ToDateTime(record[3]);
                string tillFormatted = till.ToString("dd.MM.yyyy");

                ExercisesTable.Rows.Add(record.GetInt32(0), Convert.ToBoolean(record[1]),
                                                        record.GetString(2), tillFormatted);
            }
        }


        public void RefreshDataGridview(DataGridView ExercisesTable)
        {
            ExercisesTable.Rows.Clear();

            string queryString = $"select * from Exercise_DB ORDER BY checkbox ASC, CASE WHEN checkbox = 0 THEN till END ASC," +
                                                                                    $"CASE WHEN checkbox = 1 THEN done END DESC";

            SqlCommand command = new SqlCommand(queryString, database.getConnection());
            database.openConnection();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(ExercisesTable, reader);
            }

            checkExecutionTime(ExercisesTable);

            reader.Close();
            database.closeConnection();
        }

        private void checkExecutionTime(DataGridView ExercisesTable)
        {
            DateTime today = DateTime.Today;
            foreach (DataGridViewRow row in ExercisesTable.Rows)
            {
                if (row.Cells["done"].Value == null)
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

            if (e.RowIndex >= 0 && ExercisesTable.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn)
            {
                isChecked = (bool)ExercisesTable[e.ColumnIndex, e.RowIndex].EditedFormattedValue;
                int id = Convert.ToInt32(ExercisesTable.Rows[e.RowIndex].Cells[0].Value);

                if (isChecked)
                {
                    ExercisesTable.Rows[e.RowIndex].Cells[4].Value = today.ToString("dd.MM.yyyy");

                    string dateValue = DateTime.Today.ToString("yyyy-MM-dd");
                    string updateQuery = "UPDATE exercise_db SET checkbox = @isChecked, done = @today WHERE id = @id";
                    var command = new SqlCommand(updateQuery, database.getConnection());

                    command.Parameters.AddWithValue("@isChecked", isChecked);
                    command.Parameters.AddWithValue("@today", dateValue);
                    command.Parameters.AddWithValue("@id", id);


                    database.openConnection();
                    command.ExecuteNonQuery();
                    database.closeConnection();

                }
                else
                {
                    string updateQuery = "UPDATE exercise_db SET checkbox = @isChecked, done = @today WHERE id = @id";
                    var command = new SqlCommand(updateQuery, database.getConnection());

                    command.Parameters.AddWithValue("@isChecked", isChecked);
                    command.Parameters.AddWithValue("@today", DBNull.Value);
                    command.Parameters.AddWithValue("@id", id);

                    database.openConnection();
                    command.ExecuteNonQuery();
                    database.closeConnection();
                }
            }
            RefreshDataGridview(ExercisesTable);

                                                                                         
            if (e.RowIndex >= 0 && ExercisesTable.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                int id = Convert.ToInt32(ExercisesTable.Rows[e.RowIndex].Cells[0].Value);
                string deleteQuery = $"delete from exercise_db where id = @id";

                var command = new SqlCommand(deleteQuery, database.getConnection());
                command.Parameters.AddWithValue("@id", id);

                database.openConnection();
                command.ExecuteNonQuery();
                database.closeConnection();
            }
            RefreshDataGridview(ExercisesTable);
        }


        public void Exercise_Load(object sender, EventArgs e)
        {
            RefreshDataGridview(ExercisesTable);
        }
    }
}