using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CafeOrder;

public partial class OrderForm
{
    private void InitializeSoups()
    {
        radioNoSoup.CheckedChanged += SoupChanged;
        radioChickenSoup.CheckedChanged += SoupChanged;
        radioBorscht.CheckedChanged += SoupChanged;
        radioSolyanka.CheckedChanged += SoupChanged;
    }

    private void SoupChanged(object? sender, EventArgs e)
    {
        if (sender is not RadioButton { Checked: true })
            return;

        string? imageFile = null;

        if (radioChickenSoup.Checked)
            imageFile = "chicken_soup.png";
        else if (radioBorscht.Checked)
            imageFile = "ukrainian_borscht.png";
        else if (radioSolyanka.Checked)
            imageFile = "solyanka.png";

        string? imagePath = imageFile is null
            ? null
            : Path.Combine(AppContext.BaseDirectory, "assets", "images", imageFile);

        var previousImage = pictureSoup.Image;

        pictureSoup.Image = imagePath is null
            ? null
            : Image.FromFile(imagePath);

        previousImage?.Dispose();
    }
}
