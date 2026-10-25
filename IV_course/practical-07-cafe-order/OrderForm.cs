
namespace CafeOrder;

public partial class OrderForm : Form
{
    public OrderForm()
    {
        InitializeComponent();

        InitializeDrinks();
        InitializeSoups();
        InitializeMainDishes();
        InitializePriceLabels();
        InitializeSummary();

        buttonDrinksNext.Click += (_, _) => ShowStep(panelSoups);

        buttonSoupsBack.Click += (_, _) => ShowStep(panelDrinks);
        buttonSoupsNext.Click += (_, _) => ShowStep(panelMainDishes);

        buttonMainBack.Click += (_, _) => ShowStep(panelSoups);
        buttonMainNext.Click += (_, _) =>
        {
            UpdateSummary();
            ShowStep(panelSummary);
        };

        buttonSummaryBack.Click += (_, _) => ShowStep(panelMainDishes);
        buttonNewOrder.Click += (_, _) => ResetOrder();

        ShowStep(panelDrinks);
    }

    private void ShowStep(Panel activePanel)
    {
        panelDrinks.Visible = false;
        panelSoups.Visible = false;
        panelMainDishes.Visible = false;
        panelSummary.Visible = false;

        activePanel.Visible = true;
        activePanel.BringToFront();
    }
}


