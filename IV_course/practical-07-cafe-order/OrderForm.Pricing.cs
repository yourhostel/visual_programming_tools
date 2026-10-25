using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOrder;

public partial class OrderForm
{
    private decimal CalculateSubtotal()
    {
        decimal subtotal = 0m;

        // Напої
        if (radioTea.Checked)
            subtotal += MenuPrices.Tea;
        else if (radioJuice.Checked)
            subtotal += MenuPrices.OrangeJuice;
        else if (radioCoffee.Checked)
            subtotal += MenuPrices.Coffee;

        // Перші страви
        if (radioChickenSoup.Checked)
            subtotal += MenuPrices.ChickenSoup;
        else if (radioBorscht.Checked)
            subtotal += MenuPrices.Borscht;
        else if (radioSolyanka.Checked)
            subtotal += MenuPrices.Solyanka;

        // Другі страви
        if (radioPizza.Checked)
            subtotal += MenuPrices.Pizza;
        else if (radioSpaghetti.Checked)
            subtotal += MenuPrices.Spaghetti;
        else if (radioBurger.Checked)
            subtotal += MenuPrices.Burger;

        // Додаткові інгредієнти
        if (radioPizza.Checked)
        {
            if (checkIngredient1.Checked) subtotal += 25m;
            if (checkIngredient2.Checked) subtotal += 20m;
            if (checkIngredient3.Checked) subtotal += 35m;
        }
        else if (radioSpaghetti.Checked)
        {
            if (checkIngredient1.Checked) subtotal += 25m;
            if (checkIngredient2.Checked) subtotal += 35m;
            if (checkIngredient3.Checked) subtotal += 20m;
        }
        else if (radioBurger.Checked)
        {
            if (checkIngredient1.Checked) subtotal += 60m;
            if (checkIngredient2.Checked) subtotal += 25m;
            if (checkIngredient3.Checked) subtotal += 35m;
        }

        return subtotal;
    }

    private void UpdateCurrentTotals()
    {
        decimal subtotal = CalculateSubtotal();

        string totalText = $"Поточна сума: {subtotal:F2} грн";

        labelDrinksTotal.Text = totalText;
        labelSoupsTotal.Text = totalText;
        labelMainTotal.Text = totalText;
    }

    private void InitializePriceLabels()
    {
        // Відображення цін на напої
        radioTea.Text = $"Чай — {MenuPrices.Tea:F2} грн";
        radioJuice.Text = $"Апельсиновий сік — {MenuPrices.OrangeJuice:F2} грн";
        radioCoffee.Text = $"Кава — {MenuPrices.Coffee:F2} грн";

        // Відображення цін на перші страви
        radioChickenSoup.Text = $"Курячий суп — {MenuPrices.ChickenSoup:F2} грн";
        radioBorscht.Text = $"Український борщ — {MenuPrices.Borscht:F2} грн";
        radioSolyanka.Text = $"Солянка — {MenuPrices.Solyanka:F2} грн";

        // Відображення цін на другі страви
        radioPizza.Text = $"Піца — {MenuPrices.Pizza:F2} грн";
        radioSpaghetti.Text = $"Спагеті — {MenuPrices.Spaghetti:F2} грн";
        radioBurger.Text = $"Бургер — {MenuPrices.Burger:F2} грн";

        // Перерахунок суми при зміні напою
        radioNoDrink.CheckedChanged += (_, _) => UpdateCurrentTotals();
        radioTea.CheckedChanged += (_, _) => UpdateCurrentTotals();
        radioJuice.CheckedChanged += (_, _) => UpdateCurrentTotals();
        radioCoffee.CheckedChanged += (_, _) => UpdateCurrentTotals();

        // Перерахунок суми при зміні першої страви
        radioNoSoup.CheckedChanged += (_, _) => UpdateCurrentTotals();
        radioChickenSoup.CheckedChanged += (_, _) => UpdateCurrentTotals();
        radioBorscht.CheckedChanged += (_, _) => UpdateCurrentTotals();
        radioSolyanka.CheckedChanged += (_, _) => UpdateCurrentTotals();

        // Перерахунок суми при зміні другої страви
        radioNoMainDish.CheckedChanged += (_, _) => UpdateCurrentTotals();
        radioPizza.CheckedChanged += (_, _) => UpdateCurrentTotals();
        radioSpaghetti.CheckedChanged += (_, _) => UpdateCurrentTotals();
        radioBurger.CheckedChanged += (_, _) => UpdateCurrentTotals();

        // Перерахунок суми при виборі або скасуванні інгредієнтів
        checkIngredient1.CheckedChanged += (_, _) => UpdateCurrentTotals();
        checkIngredient2.CheckedChanged += (_, _) => UpdateCurrentTotals();
        checkIngredient3.CheckedChanged += (_, _) => UpdateCurrentTotals();

        // Початковий розрахунок суми замовлення
        UpdateCurrentTotals();
    }
}
