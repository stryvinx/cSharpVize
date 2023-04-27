Category mainCategoryElektronik = new Category("Elektronik");
Category subCategoryTelefon = new Category("Telefon");
Category subCategoryBilgisayar = new Category("Bilgisayar");
Category subCategoryTelevizyon = new Category("Televizyon");

Category mainCategoryEv = new Category("Ev");
Category subCategoryAydinlatma = new Category("Aydınlatma");
Category subCategoryMobilya = new Category("Mobilya");




mainCategoryElektronik.AddSubcategory(subCategoryTelefon);
mainCategoryElektronik.AddSubcategory(subCategoryBilgisayar);
mainCategoryElektronik.AddSubcategory(subCategoryTelevizyon);
mainCategoryEv.AddSubcategory(subCategoryAydinlatma);
mainCategoryEv.AddSubcategory(subCategoryMobilya);
mainCategoryEv.AddSubcategory(subCategoryTelevizyon);

Category.Print(mainCategoryElektronik);
Category.Print(mainCategoryEv);

public class Category
{
    public string Name { get; set; }
    public List<Category> Subcategories { get; set; }

    public Category(string name)
    {
        Name = name;
        Subcategories = new List<Category>();
    }

    public void AddSubcategory(Category subcategory)
    {
        Subcategories.Add(subcategory);
    }

    public void RemoveSubcategory(Category subcategory)
    {
        Subcategories.Remove(subcategory);
    }


    public static void Print(Category category)
    {
        Console.WriteLine("Kategori: " + category.Name);
        for (int i = 0; i < category.Subcategories.Count; i++)
        {
            Console.WriteLine("  Alt kategori: " + category.Subcategories[i].Name);
            if (category.Subcategories[i].Subcategories.Count > 0)
            {
                Print(category.Subcategories[i]);
            }
        }
    }
}

