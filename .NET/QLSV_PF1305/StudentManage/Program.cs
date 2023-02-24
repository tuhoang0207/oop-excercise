using Models;
using Services.ImplementClass;
using StudentManage;


sinhVienServices sv = new sinhVienServices();
mainMenu m = new mainMenu();
MenuQlsv menuQlsv = new MenuQlsv();
Display display = new Display();
m.menu();
var chon = 0;

do
{
    Console.WriteLine("Nhap lua chon cua ban");
    chon = Convert.ToInt32(Console.ReadLine());

    switch (chon)
    {
        case 0:
            Console.WriteLine("ban da thoat chuong trinh");
            System.Environment.Exit(0);
            break;
        case 1:
            do
            {
                menuQlsv.MenuQLSV();
                chon = Convert.ToInt32(Console.ReadLine());
                menuQlsv.choice(chon);
            }while(chon != 0);
            break;
        case 2:
            MenuQlgv menuQlgv = new MenuQlgv();
            do
            {
                menuQlgv.menuQlgv();
                chon = Convert.ToInt32((Console.ReadLine()));
                menuQlgv.choice(chon);
            }while(chon != 0);
            break;
    }   
} while (chon != null);