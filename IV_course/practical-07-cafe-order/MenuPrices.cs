using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOrder;

public static class MenuPrices
{
    // Напої
    public const decimal Tea = 40m;
    public const decimal OrangeJuice = 65m;
    public const decimal Coffee = 55m;

    // Перші страви
    public const decimal ChickenSoup = 95m;
    public const decimal Borscht = 110m;
    public const decimal Solyanka = 125m;

    // Другі страви
    public const decimal Pizza = 180m;
    public const decimal Spaghetti = 160m;
    public const decimal Burger = 170m;

    // Додаткові інгредієнти
    public const decimal ExtraCheese = 25m;
    public const decimal Mushrooms = 20m;
    public const decimal Salami = 35m;
    public const decimal Parmesan = 25m;
    public const decimal Bacon = 35m;
    public const decimal ExtraPatty = 50m;
    public const decimal Cheese = 25m;

    // Знижка
    public const decimal StudentDiscount = 0.10m;
}
