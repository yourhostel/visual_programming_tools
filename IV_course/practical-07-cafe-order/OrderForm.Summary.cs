using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CafeOrder;

public partial class OrderForm
{
    private void InitializeSummary()
    {
        radioNoDiscount.CheckedChanged += DiscountChanged;
        radioStudent.CheckedChanged += DiscountChanged;
    }

    private void DiscountChanged(object? sender, EventArgs e)
    {
        if (sender is RadioButton { Checked: true })
            UpdateSummary();
    }

    private void UpdateSummary()
    {
        listOrderItems.Items.Clear();

        decimal total = 0;

        void AddItem(string name, decimal price)
        {
            listOrderItems.Items.Add($"{name} — {price:0.00} грн");
            total += price;
        }

        // Напої
        if (radioTea.Checked)
            AddItem("Чай", 40);
        else if (radioJuice.Checked)
            AddItem("Апельсиновий сік", 65);
        else if (radioCoffee.Checked)
            AddItem("Кава", 55);

        // Перші страви
        if (radioChickenSoup.Checked)
            AddItem("Курячий суп", 95);
        else if (radioBorscht.Checked)
            AddItem("Український борщ", 110);
        else if (radioSolyanka.Checked)
            AddItem("Солянка", 125);

        // Другі страви та інгредієнти
        if (radioPizza.Checked)
        {
            AddItem("Піца", 180);

            if (checkIngredient1.Checked)
                AddItem("  Додатковий сир", 25);
            if (checkIngredient2.Checked)
                AddItem("  Гриби", 20);
            if (checkIngredient3.Checked)
                AddItem("  Салямі", 35);
        }
        else if (radioSpaghetti.Checked)
        {
            AddItem("Спагеті", 160);

            if (checkIngredient1.Checked)
                AddItem("  Пармезан", 25);
            if (checkIngredient2.Checked)
                AddItem("  Бекон", 35);
            if (checkIngredient3.Checked)
                AddItem("  Гриби", 20);
        }
        else if (radioBurger.Checked)
        {
            AddItem("Бургер", 170);

            if (checkIngredient1.Checked)
                AddItem("  Додаткова котлета", 50);
            if (checkIngredient2.Checked)
                AddItem("  Сир", 25);
            if (checkIngredient3.Checked)
                AddItem("  Бекон", 35);
        }

        if (listOrderItems.Items.Count == 0)
            listOrderItems.Items.Add("Замовлення порожнє");

        if (radioStudent.Checked)
        {
            decimal discount = total * 0.10m;
            listOrderItems.Items.Add($"Знижка 10%: −{discount:0.00} грн");
            total -= discount;
        }

        labelTotal.Text = $"{total:0.00} грн";
    }

    private void ResetOrder()
    {
        radioNoDrink.Checked = true;
        radioNoSoup.Checked = true;
        radioNoMainDish.Checked = true;
        radioNoDiscount.Checked = true;

        checkIngredient1.Checked = false;
        checkIngredient2.Checked = false;
        checkIngredient3.Checked = false;

        UpdateSummary();
        ShowStep(panelDrinks);
    }
}

