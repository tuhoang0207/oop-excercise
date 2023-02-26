﻿using Models;
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

            SinhVien result;
            int tempId;
            SinhVien s = new SinhVien();
            do
            {
                System.Console.WriteLine("nhap vao id");
                tempId = Convert.ToInt32(Console.ReadLine());
                result = sv.GetById(tempId);
            } while (result != null);

            s.id = tempId;

            System.Console.WriteLine("nhap vao ten");
            s.name = Convert.ToString(Console.ReadLine());

            System.Console.WriteLine("nhap vao address");
            s.address = Convert.ToString(Console.ReadLine());

            System.Console.WriteLine("nhap vao email");
            s.email = Convert.ToString(Console.ReadLine());


            s.birthday = DateTime.Now;

            System.Console.WriteLine("nhap vao phone");
            s.phoneNumber = Console.ReadLine();
            sv.Create(s);

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

        case 3:
            System.Console.WriteLine("nhap vao id sinh vien can xoa");
            id = int.Parse(Console.ReadLine());
            var result1 = sv.Delete(id);
            if (result1 == 1)
            {
                System.Console.WriteLine("xoa thanh cong");
            }
            else
            {
                System.Console.WriteLine("khong co id de xoa");
            }

            break;
        case 4:
            var result2 = sv.listAll();
            display.display(result2);
            break;
        case 5:
            Console.WriteLine("nhap ten can tim");
            string name = Console.ReadLine();
            var result3 = sv.getByName(name);
            if (result3 == null)
            {
                System.Console.WriteLine("khong co");
            }
            else
            {
                display.display(result3);
            }
            break;
        case 6:
            Console.WriteLine("nhap dia chi can tim");
            string address = Console.ReadLine();
            display.display(sv.listByAddress(address));
            break;
        case 7:
            Console.WriteLine("nhap email can tim");
            string email = Console.ReadLine();
            display.display(sv.listByAddress(email));
            break;
       
        default:
            break;
    }
>>>>>>> dddeceb88f82fd2db10cb22004d0e8947d1f10b0
} while (chon != null);