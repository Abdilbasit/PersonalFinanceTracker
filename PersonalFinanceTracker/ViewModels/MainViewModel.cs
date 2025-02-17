using PersonalFinanceTracker.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using System;
using Microsoft.EntityFrameworkCore;
using PersonalFinanceTracker.Data;
using Microsoft.Data.Sqlite;

namespace PersonalFinanceTracker.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private FinanceContext _context;
        
        public ObservableCollection<Transaction> Transactions { get; set; } = new ObservableCollection<Transaction>();

        private string _newTransactionDescription;
        public string NewTransactionDescription
        {
            get => _newTransactionDescription;
            set { _newTransactionDescription = value; OnPropertyChanged(); }
        }

        private string _newTransactionAmount;
        public string NewTransactionAmount
        {
            get => _newTransactionAmount;
            set { _newTransactionAmount = value; OnPropertyChanged(); }
        }

        public ICommand AddTransactionCommand { get; set; }

        public MainViewModel()
        {
            // Setup SQLite in-memory connection (keep connection open to persist data during app lifetime)
            var connection = new SqliteConnection("DataSource=:memory:");
            connection.Open();
            
            var options = new DbContextOptionsBuilder<FinanceContext>()
                .UseSqlite(connection)
                .Options;
            
            _context = new FinanceContext(options);
            _context.Database.EnsureCreated();

            // Load existing transactions (if any)
            foreach (var transaction in _context.Transactions)
                Transactions.Add(transaction);
            
            AddTransactionCommand = new RelayCommand(o => AddTransaction());
        }

        private void AddTransaction()
        {
            if (decimal.TryParse(NewTransactionAmount, out decimal amount))
            {
                var transaction = new Transaction
                {
                    Description = NewTransactionDescription,
                    Amount = amount,
                    Date = DateTime.Now
                };

                _context.Transactions.Add(transaction);
                _context.SaveChanges();

                Transactions.Add(transaction);
                
                // Clear input fields
                NewTransactionDescription = string.Empty;
                NewTransactionAmount = string.Empty;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
