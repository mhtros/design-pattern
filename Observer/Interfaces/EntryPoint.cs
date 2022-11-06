using Observer.Interfaces.Info;
using Observer.Interfaces.Observer;
using Observer.Interfaces.Provider;

namespace Observer.Interfaces;

public static class EntryPoint
{
    public static void Start()
    {
        var magazineCompany = new MagazineCompany();

        var buyer1 = new MagazineBuyer("Michael");
        var buyer2 = new MagazineBuyer("Casandra");

        buyer1.Subscribe(magazineCompany);

        magazineCompany.MagazineRelease(new MagazineInfo("Amazing Programmer", 1, 5.99m, 2));
        magazineCompany.MagazineRelease(new MagazineInfo("Amazing Programmer", 2, 8.99m, 3));

        buyer2.Subscribe(magazineCompany);

        magazineCompany.MagazineRelease(new MagazineInfo("Amazing Programmer", 3, 11.99m, 4));
        magazineCompany.MagazineRelease(new MagazineInfo("Amazing Programmer", 4, 11.99m, 6));

        buyer1.Unsubscribe();

        magazineCompany.MagazineRelease(new MagazineInfo("Amazing Programmer", 5, 11.99m, null));
        magazineCompany.MagazineRelease(new MagazineInfo("Amazing Programmer", 5, 11.99m, 5));
    }
}