using Event_manager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Event_manager.Views
{
    public partial class EventView : Form, IEventView
    {
        public EventView()
        {
            InitializeComponent();

            dateTimePicker_date.MinDate = DateTime.Today;

            // ustawienie kontrolki comboBox
            SetEventTypeComboBox();
            SetEventProComboBox();

            dataGridView.CellFormatting += dataGridView_CellFormatting_byPro;
            dataGridView.CellFormatting += dataGridView_CellFormatting_byType;
            dataGridView.SelectionChanged += DataGridView_SelectionChanged;
            dataGridView.ColumnHeaderMouseClick += DataGridView_ColumnHeaderMouseClick;

            // obsługa zdarzeń
            AssociateAndRaiseViewEvents();
        }

        public Event GetSelectedEvent()
        {
            // Sprawdź, czy coś jest zaznaczone w kontrolce DataGridView
            if (dataGridView.SelectedRows.Count > 0)
            {
                // Pobierz indeks zaznaczonego wiersza
                int selectedIndex = dataGridView.SelectedRows[0].Index;

                // Pobierz zdarzenie związane z zaznaczonym wierszem
                return dataGridView.Rows[selectedIndex].DataBoundItem as Event;
            }

            return null;
        }

        public string GetColumnName()
        {
            if (dataGridView.SelectedCells.Count > 0)
            {
                int columnIndex = dataGridView.SelectedCells[0].ColumnIndex;
                return dataGridView.Columns[columnIndex].HeaderText;
            }

            return null;
        }


        private void dataGridView_CellFormatting_byType(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0) // Sprawdź, czy to komórka danych
            {
                var row = dataGridView.Rows[e.RowIndex];
                var typeCell = row.Cells["Rodzaj"];

                if (typeCell.Value != null)
                {
                    string eventType = typeCell.Value.ToString();

                    // Ustaw kolor tła wiersza na podstawie rodzaju zdarzenia
                    switch (eventType)
                    {
                        case "Praca":
                            row.DefaultCellStyle.BackColor = Color.LightBlue;
                            break;
                        case "Rodzina":
                            row.DefaultCellStyle.BackColor = Color.LightGreen;
                            break;
                        case "Rozrywka":
                            row.DefaultCellStyle.BackColor = Color.LightYellow;
                            break;
                        case "Zdrowie":
                            row.DefaultCellStyle.BackColor = Color.LightPink;
                            break;
                        case "Sport":
                            row.DefaultCellStyle.BackColor = Color.Violet;
                            break;
                        default:
                            row.DefaultCellStyle.BackColor = dataGridView.DefaultCellStyle.BackColor; // Domyślny kolor tła
                            break;
                    }
                }
            }
        }

        private void dataGridView_CellFormatting_byPro(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView.Columns["Priorytet"].Index)
            {
                DataGridViewCell cell = dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];
                string priority = cell.Value.ToString();

                // Ustaw grubość czcionki na podstawie priorytetu
                switch (priority)
                {
                    case "Wysoki":
                        cell.Style.Font = new Font(dataGridView.Font, FontStyle.Bold);
                        break;
                    case "Średni":
                        cell.Style.Font = new Font(dataGridView.Font, FontStyle.Regular);
                        break;
                    case "Niski":
                        cell.Style.Font = new Font(dataGridView.Font, FontStyle.Italic);
                        break;
                    default:
                        // Domyślne ustawienie dla nieznanych priorytetów
                        cell.Style.Font = new Font(dataGridView.Font, FontStyle.Regular);
                        break;
                }
            }
        }

        private void SetEventProComboBox()
        {
            comboBox_priority.Items.AddRange(new string[] { "Wysoki", "Średni", "Niski" });
            comboBox_priority.SelectedIndex = -1;
            comboBox_priority.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void SetEventTypeComboBox()
        {
            comboBox_type.Items.AddRange(new string[] { "Praca", "Rodzina", "Rozrywka", "Zdrowie", "Sport" });
            comboBox_type.SelectedIndex = -1;
            comboBox_type.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        // funkcja pomocnicza przypisująca zdarzeniom kontrolek odpowiednie metody
        private void AssociateAndRaiseViewEvents()
        {
            button_add.Click += (sender, e) =>
            {
                if (setEmptyError(textBox_name) & setEmptyError(comboBox_type) & setEmptyError(comboBox_priority))
                {
                    AddNewEventEvent?.Invoke(this, EventArgs.Empty);
                }
            };

            button_remove.Click += (sender, e) =>
            {
                RemoveEventEvent?.Invoke(this, EventArgs.Empty);
            };

            button_save.Click += (sender, e) =>
            {
                SaveEventEvent?.Invoke(this, EventArgs.Empty);
            };

            button_load.Click += (sender, e) =>
            {
                LoadEventEvent?.Invoke(this, EventArgs.Empty);
            };

        }


        // właściwości
        public string EventName { get => textBox_name.Text; set => textBox_name.Text = value; }
        public string EventDescription { get => textBox_description.Text; set => textBox_description.Text = value; }
        public DateTime EventDate { get => dateTimePicker_date.Value; set => dateTimePicker_date.Value = value; }
        public string EventType { get => comboBox_type.SelectedItem.ToString(); set => comboBox_type.SelectedItem = value; }
        public string EventPriority { get => comboBox_priority.SelectedItem.ToString(); set => comboBox_priority.SelectedItem = value; }

        // zdarzenia
        public event EventHandler AddNewEventEvent;
        public event EventHandler RemoveEventEvent;
        public event EventHandler SaveEventEvent;
        public event EventHandler LoadEventEvent;
        public event EventHandler SortEventEvent;
        public event EventHandler FilterEventEvent;


        public void SetEventListBindingSource(BindingSource eventList)
        {
            dataGridView.DataSource = eventList;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private bool setEmptyError(TextBox t)
        {
            if (t.Text.Length < 2)
            {
                errorProvider1.SetError(t, "Pole musi zawierać przynajmiej 2 znaki");
                return false;
            }
            else
                errorProvider1.SetError(t, "");
            return true;
        }

        private bool setEmptyError(ComboBox t)
        {
            if (t.Text == "")
            {
                errorProvider1.SetError(t, "Pole jest puste");
                return false;
            }
            else
                errorProvider1.SetError(t, "");
            return true;
        }

        private void DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            // Obsługa zmiany zaznaczenia w DataGridView
            if (dataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView.SelectedRows[0];
                Models.Event selectedEvent = selectedRow.DataBoundItem as Models.Event;
                FillFormWithEventData(selectedEvent);
            }
            else
            {
                ClearForm();
            }
        }
        private void FillFormWithEventData(Models.Event selectedEvent)
        {
            // Ustawienie danych zdarzenia w polach formularza
            EventName = selectedEvent.Nazwa;
            EventDescription = selectedEvent.Opis;
            EventType = selectedEvent.Rodzaj;
            EventPriority = selectedEvent.Priorytet;
            EventDate = selectedEvent.Data;
        }

        private string lastSortedColumn = "";
        private SortOrder lastSortOrder = SortOrder.Ascending;

        private void DataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                DataGridViewColumn clickedColumn = dataGridView.Columns[e.ColumnIndex];

                if (clickedColumn.HeaderText == lastSortedColumn)
                {
                    lastSortOrder = lastSortOrder == SortOrder.Ascending ? SortOrder.Descending : SortOrder.Ascending;
                }
                else
                {
                    lastSortOrder = SortOrder.Ascending;
                    lastSortedColumn = clickedColumn.HeaderText;
                }

                lastSortedColumn = clickedColumn.HeaderText;

                SortEventEvent?.Invoke(this, new SortEventArgs(lastSortedColumn, lastSortOrder));
            }
        }

        private void ClearForm()
        {
            // Wyczyszczenie pól formularza
            EventName = "";
            EventDescription = "";
            EventType = "";
            EventPriority = "";
            EventDate = DateTime.Now;
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

