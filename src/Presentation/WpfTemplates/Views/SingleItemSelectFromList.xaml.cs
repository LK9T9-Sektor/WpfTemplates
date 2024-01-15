using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace WpfTemplates.Views;

public partial class SingleItemSelectFromList : Window
{
    public string RemainingBalance { get; set; }

    public ObservableCollection<Budget> budgets;

    private Budget selectedItem;

    public SingleItemSelectFromList()
    {
        InitializeComponent();

        DataContext = this;

        List<Budget> newBudgets = new()
        {
            new()
            {
                StartDate = DateTime.Now.AddDays(-5),
                EndDate = DateTime.Now.AddDays(1),
                BudgetAmount = 100
            },
            new()
            {
                StartDate = DateTime.Now.AddDays(-10),
                EndDate = DateTime.Now.AddDays(2),
                BudgetAmount = 200
            },
            new()
            {
                StartDate = DateTime.Now.AddDays(-15),
                EndDate = DateTime.Now.AddDays(3),
                BudgetAmount = 300
            }
        };

        budgets = new ObservableCollection<Budget>(newBudgets);

        BudgetListView.ItemsSource = budgets;
    }

    private void NewBudgetButton_Click(object sender, RoutedEventArgs e)
    {
        if (BudgetStackPanel.Visibility == Visibility.Collapsed)
            BudgetStackPanel.Visibility = Visibility.Visible;
    }

    private void CreateBudgetButton_Click(object sender, RoutedEventArgs e)
    {
        //string errorMessage = BudgetValidation.ValidateBudget(TotalBudgetTextBox.Text, StartDatePicker.SelectedDate, EndDatePicker.SelectedDate);
        //if (errorMessage != "")
        //{
        //    ShowError(errorMessage);
        //    return;
        //}

        Budget budget = new Budget
        {
            StartDate = (DateTime)StartDatePicker.SelectedDate,
            EndDate = (DateTime)EndDatePicker.SelectedDate,
            BudgetAmount = double.Parse(TotalBudgetTextBox.Text)
        };

        budgets.Add(budget);

        BudgetListView.ItemsSource = budgets;

        //BudgetData.AddBudgetToDb(budget);

        ShowSuccess();
    }


    private void Button_Click(object sender, RoutedEventArgs e)
    {
        //UpdateFlyout.IsOpen = true;
    }

    private void ShowError(string error)
    {
        //UpdateFlyout.Background = Brushes.Red;

        //FlyoutTextBlock.Text = error;

        //UpdateFlyout.CloseButtonVisibility = Visibility.Hidden;

        //UpdateFlyout.IsOpen = true;
    }

    private void ShowSuccess()
    {
        //UpdateFlyout.Background = Brushes.Green;

        //FlyoutTextBlock.Text = "Successfully Added Budget!";

        //UpdateFlyout.CloseButtonVisibility = Visibility.Hidden;

        BudgetStackPanel.Visibility = Visibility.Collapsed;

        //UpdateFlyout.IsOpen = true;
    }

    private void BudgetListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        selectedItem = (Budget)BudgetListView.SelectedItem;

        RemainingBalance = $"${selectedItem.BudgetAmount}";

        RemainingBudgetTextBlock.Text = RemainingBalance;
    }
}

public class Budget
{
    public int Id { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public double BudgetAmount { get; set; }
}

