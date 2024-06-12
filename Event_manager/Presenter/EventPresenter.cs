using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using Newtonsoft.Json;
using Event_manager.Models;
using System.Xml.Linq;
using Event_manager.Repository;

namespace Event_manager.Presenter
{
    public class EventPresenter
    {
        private Models.IEventRepository _eventRepository;
        private Views.IEventView _view;
        private BindingSource _eventsBindingSource;
        private IEnumerable<Models.Event> _eventList;
        private string _lastSortedColumn = "";
        private SortOrder _lastSortOrder = SortOrder.Ascending;

        public EventPresenter(Views.IEventView view, Models.IEventRepository repository)
        {
            _view = view;
            _eventRepository = repository;
            _eventsBindingSource = new BindingSource();

            // Podpięcie metod obsługujących zdarzenia widoku
            _view.AddNewEventEvent += AddEvent;
            _view.RemoveEventEvent += RemoveEvent;
            _view.SaveEventEvent += SaveEvent;
            _view.LoadEventEvent += LoadEvent;
            _view.SortEventEvent += SortEvent;
            _view.FilterEventEvent += FilterEvent;

            _view.SetEventListBindingSource(_eventsBindingSource);

            LoadAllEventList();
        }

        private void LoadAllEventList()
        {
            _eventList = _eventRepository.GetAll();
            _eventsBindingSource.DataSource = _eventList;
        }

        private void AddEvent(object sender, EventArgs e)
        {
            var newEvent = new Models.Event(
                _view.EventName,
                _view.EventDescription,
                _view.EventType,
                _view.EventPriority,
                _view.EventDate
            );

            _eventRepository.Add(newEvent);
            LoadAllEventList(); // Ponowne załadowanie listy wydarzeń
            _eventsBindingSource.ResetBindings(false);

            // Wyczyszczenie formularza
            ClearForm();
        }

        private void RemoveEvent(object sender, EventArgs e)
        {
            var selectedEvent = _view.GetSelectedEvent();
            if (selectedEvent != null)
            {
                _eventRepository.Remove(selectedEvent);
                LoadAllEventList(); // Ponowne załadowanie listy wydarzeń
                _eventsBindingSource.ResetBindings(false);
                // ClearForm();
            }
            else
            {
                MessageBox.Show("Wybierz zdarzenie do usunięcia.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void SaveEvent(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Pliki JSON (*.json)|*.json|Pliki tekstowe (*.txt)|*.txt|Pliki XML (*.xml)|*.xml";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;

                    try
                    {
                        _eventRepository.Save(filePath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Wystąpił błąd podczas zapisywania danych: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void LoadEvent(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Pliki JSON (*.json)|*.json|Pliki tekstowe (*.txt)|*.txt|Pliki XML (*.xml)|*.xml";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    string fileExtension = Path.GetExtension(filePath);

                    try
                    {
                        if (fileExtension.Equals(".json", StringComparison.OrdinalIgnoreCase) ||
                            fileExtension.Equals(".txt", StringComparison.OrdinalIgnoreCase) ||
                            fileExtension.Equals(".xml", StringComparison.OrdinalIgnoreCase))
                        {
                            _eventRepository.Load(filePath);
                            LoadAllEventList(); // Ponowne załadowanie listy wydarzeń
                            _eventsBindingSource.ResetBindings(false);
                        }
                        else
                        {
                            MessageBox.Show("Niewłaściwe rozszerzenie pliku. Wybierz plik z rozszerzeniem .json, .txt lub .xml.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Wystąpił błąd podczas wczytywania danych: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void SortEvent(object sender, EventArgs e)
        {
            if (e is SortEventArgs sortEventArgs)
            {
                string columnName = sortEventArgs.ColumnName;
                SortOrder sortOrder = sortEventArgs.SortOrder;

                // Tutaj wykonaj logikę sortowania na podstawie nazwy kolumny i kierunku sortowania
                try
                {
                    _eventRepository.Sort(columnName, sortOrder);
                    LoadAllEventList(); // Ponowne załadowanie posortowanej listy wydarzeń
                    _eventsBindingSource.ResetBindings(false);
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FilterEvent(object sender, EventArgs e)
        {
            //DateTime? startDate = _view.FilterStartDate;
            //DateTime? endDate = _view.FilterEndDate;

            //List<Func<Models.Event, bool>> filters = new List<Func<Models.Event, bool>>();

            //if (startDate.HasValue)
            //{
            //    filters.Add(e => e.Data >= startDate.Value.Date);
            //}
            //if (endDate.HasValue)
            //{
            //    filters.Add(e => e.Data <= endDate.Value.Date);
            //}

            //if (_view.FilterHighPriority)
            //{
            //    filters.Add(e => e.Priorytet == "Wysoki");
            //}

            //if (_view.FilterMediumPriority)
            //{
            //    filters.Add(e => e.Priorytet == "Średni");
            //}

            //if (_view.FilterLowPriority)
            //{
            //    filters.Add(e => e.Priorytet == "Niski");
            //}

            //if (_view.FilterFamily)
            //{
            //    filters.Add(e => e.Rodzaj == "Rodzina");
            //}

            //if (_view.FilterEntertainment)
            //{
            //    filters.Add(e => e.Rodzaj == "Rozrywka");
            //}

            //if (_view.FilterSports)
            //{
            //    filters.Add(e => e.Rodzaj == "Sport");
            //}

            //if (_view.FilterHealth)
            //{
            //    filters.Add(e => e.Rodzaj == "Zdrowie");
            //}

            //if (_view.FilterWork)
            //{
            //    filters.Add(e => e.Rodzaj == "Praca");
            //}

            //if (filters.Count == 0)
            //{
            //    _eventsBindingSource.DataSource = _eventList;
            //    return;
            //}

            //var filteredEvents = _eventList.Where(e => filters.All(filter => filter(e)));

            //_eventsBindingSource.DataSource = filteredEvents.ToList();
        }

        private void SortEventHandler(object sender, EventArgs e)
        {
            if (e is SortEventArgs sortEventArgs)
            {
                string columnName = sortEventArgs.ColumnName;
                SortOrder sortOrder = sortEventArgs.SortOrder;

                // Tutaj wykonaj logikę sortowania na podstawie nazwy kolumny i kierunku sortowania
            }
        }

        private void ClearForm()
                {
                    _view.EventName = "";
                    _view.EventDescription = "";
                    _view.EventType = "";
                    _view.EventPriority = "";
                    _view.EventDate = DateTime.Now;
                }

    }
}





