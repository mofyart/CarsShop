using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Site_1.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site_1.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {
           
            if (!content.Category.Any())
                content.Category.AddRange(Categories.Select(c => c.Value));

            if (!content.Car.Any())
            {
                content.AttachRange(


                     new Car
                     {
                         name = "Sumsung 21S Ultra",
                         shortDesc = "Экран: 6.8 3200x1440 Пикс, Процессор: Samsung Exynos 2100 1 x 2.9 + 3 x 2.8 + 4 x 2.2 ГГц, Оперативная память (RAM): 12 ГБ,... ещеВстроенная память (ROM): 128 ГБ, Основная камера МПикс: 108/12/10/10/Лазер AF.",
                         longDesc = "Если вы его купили, то вы просто",
                         img = "/img/21s.jpg",
                         price = 1300,
                         size = 512,
                         color = "white",
                         isFavourite = true,
                         available = true,
                         ob = "12 gb",
                         oper = "Android 11",
                         dis ="6.8, Dynamic AMOLED 2X",
                         raz = "3200x1440",
                         proz = "Exynos 2100, 2900МГц, 8-ми ядерный",
                         Category = Categories["Премиум класса телефоны"]
                        
                     },
                    new Car
                    {
                        name = "Iphone 11 pro ",
                        shortDesc = "Размеры: 71.4 x 144 x 8.1 мм, Вес: 188 г, SoC: Apple A13 Bionic APL1W85, Процессор: 2650 МГц, Оперативная память: 4 ГБ, Экран: 5.8 in, OLED, 1125 x 2436 пикселей, 24 бит, Аккумулятор: 3190 мА·ч, Li-Ion (Литий-ионный), Oперационная система: iOS 13.",
                        longDesc = "Есди вы его купили,то вы хорош",
                        img = "/img/11 pro.jpg",
                        price = 1000,
                        size = 256,
                        ob = "10 gb",
                        oper = " iPhone iOS 13",
                        dis = " 5.8, OLED",
                        raz = "2436x1125",
                        proz = " Apple A13 Bionic",
                        color = "gray",
                        isFavourite = true,
                        available = true,
                        Category = Categories["Премиум класса телефоны"]
                    },
                    new Car
                    {
                        name = "Sumsung A21",
                        shortDesc = "Размеры: 75.3 x 163.7 x 8.9 мм Вес: 192 г SoC: MediaTek Helio P35 (MT6765) Процессор: 4x 2.3 GHz ARM Cortex-A53, 4x 1.8 GHz ARM Cortex-A53, Количество ядер: 8 Графический процессор: PowerVR GE8320, 680 МГц.",
                        longDesc = "Дотойная модель",
                        img = "/img/21.jpg",
                        price = 300,
                        ob = "4 gb",
                        oper = "Android 11",
                        dis = "6.4 Super AMOLEDX",
                        raz = "1600x720",
                        proz = "2000МГц, 8-ми ядерный",
                        size = 32,
                        color = "black",
                        isFavourite = false,
                        available = true,
                        Category = Categories["Бюджетный телефоны"]
                    },
                    new Car
                    {
                        name = "Pixel 3A XL",
                        shortDesc = "Технические характеристики экрана следующие: 6 дюймов, OLED (18.5:9), 2160x1080 точек, плотность пикселей 402 ppi, Always-On display, DragonTrail. Фотографирует Pixel 3A XL отлично, особенно для своей цены , особенно впечатлил ночной режим.",
                        longDesc = "Нечег сказать",
                        img = "/img/xl.jpg",
                        price = 1000,
                        ob = "12 gb",
                        oper = "Android 11",
                        dis = "6.8, Dynamic AMOLED 2X",
                        raz = "3200x1440",
                        proz = "Exynos 2100, 2900МГц, 8-ми ядерный",
                        size = 128,
                        color = "white",
                        isFavourite = false,
                        available = true,
                        Category = Categories["Премиум класса телефоны"]
                    },
                    new Car
                    {
                        name = "Iphone 13 pro",
                        shortDesc = "Грандиозный апгрейд камер Pro. Режим «Киноэффект» делает из видео настоящее кино. Дисплей Super Retina XDR с технологией ProMotion для более быстрого и плавного взаимодействия.",
                        longDesc = "Доcтойная модель",
                        img = "/img/Iphone 13 pro.jpg",
                        price = 1500,
                        ob = "12 gb",
                        oper = "iPhone iOS 15",
                        dis = "6.8, Dynamic AMOLED 2X",
                        raz = "2532x1170",
                        proz = "Apple A15 Bionic",
                        size = 512,
                        color = "white",
                        isFavourite = false,
                        available = true,
                        Category = Categories["Новинки"]
                    },
                    new Car
                    {
                        name = "Xiaomi Mi MIX 3",
                        shortDesc = "SoC Qualcomm Snapdragon 845, 8 ядер (4 × Kryo 385 Gold @2,96 ГГц + 4 × Kryo 385 Silver @1,8 ГГц) GPU Adreno 630 Операционная система Android 9,MIUI 10, Сенсорный дисплей AMOLED 6, 39, 2340×1080",
                        longDesc = "Дотойная модель",
                        img = "/img/wes.jpg",
                        price = 1100,
                        ob = "12 gb",
                        oper = "Android 11",
                        dis = "6.8, Dynamic AMOLED 2X",
                        raz = "3200x1440",
                        proz = "Exynos 2100, 2900МГц, 8-ми ядерный",
                        size = 128,
                        color = "black",
                        isFavourite = false,
                        available = true,
                        Category = Categories["Новинки"]
                    },
                    new Car
                    {
                        name = "One Plus 8 pro",
                        shortDesc = "Оснащён пятью камерами: основной, широкоугольной, телевиком, цветофильтром и фронтальной. В качестве основной тут используется датчик Sony IMX689 с разрешением 48 Мп, размером диафрагмы f/1,78, всенаправленным фазовым и лазерным автофокусами, а также оптической и электронной стабилизациями.",
                        longDesc = "Дотойная модель",
                     
                        img = "/img/wce.jpg",
                        color = "green",
                        price = 900,
                        size = 512,
                        ob = "12 gb",
                        oper = "Android 11",
                        dis = "6.8, Dynamic AMOLED 2X",
                        raz = "3200x1440",
                        proz = "Exynos 2100, 2900МГц, 8-ми ядерный",
                        isFavourite = false,
                        available = true,
                        Category = Categories["Премиум класса телефоны"]
                    },
                    new Car
                    {
                        name = "Xiaomi Redmi 4",
                        shortDesc = "Размеры: 76 x 151 x 8.35 мм, Вес: 175 г, SoC: MediaTek Helio X20 (MT6797), Процессор: 2x 2.1 GHz ARM Cortex-A72, 4x 1.85 GHz ARM Cortex-A53, 4x 1.4 GHz ARM Cortex-A53",
                        longDesc = "Дотойная модель",
                        
                        img = "/img/15.jpg",
                        price = 150,
                        color = "gold",
                        ob = "12 gb",
                        oper = "Android 11",
                        dis = "6.8, Dynamic AMOLED 2X",
                        raz = "3200x1440",
                        proz = "Exynos 2100, 2900МГц, 8-ми ядерный",
                        size = 64,
                        isFavourite = false,
                        available = true,
                        Category = Categories["Бюджетный телефоны"]
                    },
                    new Car
                    {
                        name = "Sumsung A51",
                        shortDesc = "Основные характеристики Samsung Galaxy A51 (модель SM-A515F). SoC Samsung Exynos 9611, 8 ядер (4×Cortex-A73 @2,3 ГГц + 4×Cortex-A53 @1,7 ГГц).",
                        longDesc = "Дотойная модель",
                        img = "/img/3.jpg",
                        price = 500,
                        ob = "12 gb",
                        oper = "Android 11",
                        dis = "6.8, Dynamic AMOLED 2X",
                        raz = "3200x1440",
                        proz = "Exynos 2100, 2900МГц, 8-ми ядерный",
                        color = "blue",
                        
                        size = 512,
                        isFavourite = false,
                        available = true,
                        Category = Categories["Бюджетный телефоны"]
                    },
                    new Car
                    {
                        name = "Iphone 13 mini",
                        shortDesc = "Только у iPhone 12 / 12 mini есть поддержка аксессуаров MagSafe и новейшая SoC Apple A14 Bionic.",
                        longDesc = "Дотойная модель",
                        img = "/img/13.jpg",
                        price = 800,
                        ob = "12 gb",
                        oper = "Android 11",
                        dis = "6.8, Dynamic AMOLED 2X",
                        raz = "3200x1440",
                        proz = "Exynos 2100, 2900МГц, 8-ми ядерный",
                        size = 128,
                        
                        color = "white",
                        isFavourite = false,
                        available = true,
                        Category = Categories["Новинки"]
                    },
                    new Car
                    {
                        name = "Sumsung Note 9",
                        shortDesc = "SoC Samsung Exynos 9810, 8 ядер (4×Exynos M3 @2,7 ГГц + 4×Cortex-A55 @1,8 ГГц), GPU Mali-G72 MP18 (572 МГц), Сенсорный дисплей Super AMOLED 6,4″, 2960×1440 (18,5:9), 516 ppi",
                        longDesc = "Дотойная модель",
                        img = "/img/9.jpg",
                        price = 600,
                        ob = "12 gb",
                        oper = "Android 11",
                        dis = "6.8, Dynamic AMOLED 2X",
                        raz = "3200x1440",
                        proz = "Exynos 2100, 2900МГц, 8-ми ядерный",

                        color = "blue",
                        size = 512,
                        isFavourite = false,
                        available = true,
                        Category = Categories["Премиум класса телефоны"]
                    }

                    );
            }


            content.SaveChanges();

        }

        

        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (category == null)
                {
                    var list = new Category[]
                    {
                          new Category {categoryName ="Премиум класса телефоны", desc = "Стоимость более 300 долларов" },
                    new Category {categoryName ="Бюджетный телефоны", desc = "Стоимость менее 300 долларов "},
                      new Category {categoryName ="Новинки", desc = "Что-то новое"}
                    };

                    category = new Dictionary<string, Category>();
                    foreach (Category el in list)
                        category.Add(el.categoryName, el);
                }
                return category;
            }
        }
    }
}

