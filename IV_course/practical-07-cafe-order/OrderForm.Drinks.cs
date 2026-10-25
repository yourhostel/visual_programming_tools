using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOrder;

public partial class OrderForm
{
    private void InitializeDrinks()
    {
        radioNoDrink.CheckedChanged += DrinkChanged;
        radioTea.CheckedChanged += DrinkChanged;
        radioJuice.CheckedChanged += DrinkChanged;
        radioCoffee.CheckedChanged += DrinkChanged;
    }

    private void DrinkChanged(object? sender, EventArgs e)
    {
        if (sender is not RadioButton { Checked: true })
            return;

        string? imageFile = null;

        if (radioTea.Checked)
            imageFile = "tea.png";
        else if (radioJuice.Checked)
            imageFile = "orange_juice.png";
        else if (radioCoffee.Checked)
            imageFile = "coffee.png";

        string? imagePath = imageFile is null
            ? null
            : Path.Combine(AppContext.BaseDirectory, "assets", "images", imageFile);

        var previousImage = pictureDrink.Image;

        pictureDrink.Image = imagePath is null
            ? null
            : Image.FromFile(imagePath);

        previousImage?.Dispose();
    }
}
