using System.Collections.Generic;
using System.IO;

namespace KioskProject
{
    public class MenuItem
    {
        public string Name { get; set; }
        public string ImageFileName { get; set; }
        public string Category { get; set; }
        public int Price { get; set; }

        public MenuItem(string name, string imageFileName, string category, int price)
        {
            Name = name;
            ImageFileName = imageFileName;
            Category = category;
            Price = price;
        }

        public string GetFullImagePath()
        {
            string basePath = @"C:\Users\ktj02\Desktop\images";
            return Path.Combine(basePath, ImageFileName);
        }
    }

    public static class MenuDatabase
    {
        public static List<MenuItem> MenuItems = new List<MenuItem>
        {
            new MenuItem("짜장면", "jjajang.jpg", "면류", 5000),
            new MenuItem("짬뽕", "jjamppong.jpg", "면류", 6000),
            new MenuItem("볶음밥", "bokkeumbap.jpg", "밥류", 5000),
            new MenuItem("계란볶음밥", "eggfriedrice.jpg", "밥류", 5000),
            new MenuItem("새우볶음밥", "Shrimprice.jpg", "밥류", 6000),
            new MenuItem("탕수육 소", "tangsuyuk.jpg", "사이드", 12000),
            new MenuItem("탕수육 중", "tangsuyuk.jpg", "사이드", 16000),
            new MenuItem("탕수육 대", "tangsuyuk.jpg", "사이드", 20000),
            new MenuItem("군만두 소", "dumpling.jpg", "사이드", 5000),
            new MenuItem("군만두 중", "dumpling.jpg", "사이드", 7000),
            new MenuItem("군만두 대", "dumpling.jpg", "사이드", 9000),
            new MenuItem("좋은데이", "joa.jpg", "주류", 5000),
            new MenuItem("참이슬", "fresh.jpg", "주류", 4000),
            new MenuItem("콜라", "cora.jpg", "음료류", 3000),
            new MenuItem("사이다", "saida.jpg", "음료류", 3000),
            new MenuItem("짜장면", "jjajang.jpg", "추천메뉴", 5000),
            new MenuItem("새우볶음밥", "Shrimprice.jpg", "추천메뉴", 6000),
            new MenuItem("짜장+군만두 소", "1.jpg", "세트메뉴", 8000),
            new MenuItem("짜장+탕수육 소", "2.jpg", "세트메뉴", 15000)
        };
    }
}
