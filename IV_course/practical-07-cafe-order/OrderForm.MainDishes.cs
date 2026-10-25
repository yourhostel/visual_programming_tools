using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CafeOrder;

public partial class OrderForm
{
    private void InitializeMainDishes()
    {
        radioNoMainDish.CheckedChanged += MainDishChanged;
        radioPizza.CheckedChanged += MainDishChanged;
        radioSpaghetti.CheckedChanged += MainDishChanged;
        radioBurger.CheckedChanged += MainDishChanged;
    }

    private void MainDishChanged(object? sender, EventArgs e)
    {
        if (sender is not RadioButton { Checked: true })
            return;

        string? imageFile = null;

        if (radioPizza.Checked)
        {
            imageFile = "pizza.png";

            SetIngredients(
                "Додатковий сир", MenuPrices.ExtraCheese,
                "Гриби", MenuPrices.Mushrooms,
                "Салямі", MenuPrices.Salami);
        }
        else if (radioSpaghetti.Checked)
        {
            imageFile = "spaghetti.png";

            SetIngredients(
                "Пармезан", MenuPrices.Parmesan,
                "Бекон", MenuPrices.Bacon,
                "Гриби", MenuPrices.Mushrooms);
        }
        else if (radioBurger.Checked)
        {
            imageFile = "burger.png";

            SetIngredients(
                "Додаткова котлета", MenuPrices.ExtraPatty,
                "Сир", MenuPrices.Cheese,
                "Бекон", MenuPrices.Bacon);
        }

        groupIngredients.Enabled = imageFile is not null;

        if (imageFile is null)
        {
            checkIngredient1.Checked = false;
            checkIngredient2.Checked = false;
            checkIngredient3.Checked = false;

            checkIngredient1.Text = "Інгредієнт 1";
            checkIngredient2.Text = "Інгредієнт 2";
            checkIngredient3.Text = "Інгредієнт 3";
        }

        string? imagePath = imageFile is null
            ? null
            : Path.Combine(AppContext.BaseDirectory, "assets", "images", imageFile);

        var previousImage = pictureMainDish.Image;

        pictureMainDish.Image = imagePath is null
            ? null
            : Image.FromFile(imagePath);

        previousImage?.Dispose();
    }

    private void SetIngredients(
    string first, decimal firstPrice,
    string second, decimal secondPrice,
    string third, decimal thirdPrice)
    {
        checkIngredient1.Checked = false;
        checkIngredient2.Checked = false;
        checkIngredient3.Checked = false;

        checkIngredient1.Text = $"{first} — {firstPrice:F2} грн";
        checkIngredient2.Text = $"{second} — {secondPrice:F2} грн";
        checkIngredient3.Text = $"{third} — {thirdPrice:F2} грн";
    }
}

