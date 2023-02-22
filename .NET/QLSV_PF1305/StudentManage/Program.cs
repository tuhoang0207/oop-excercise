using Models;
using Services.ImplementClass;
using StudentManage;

SinhVien s = new SinhVien();
sinhVienServices sv = new sinhVienServices();
Menu m = new Menu();
Display display = new Display();
m.MenuQLSV();
var chon = 0;



do
{
    Console.WriteLine("nhap lua chon");
    chon = Convert.ToInt32(Console.ReadLine());
    switch (chon)
    {
        case 0:
            System.Console.WriteLine("ban da thoat khoi chuong trinh");
            System.Environment.Exit(0);
            break;
        case 1:
            SinhVien result;
            do
            {
                System.Console.WriteLine("nhap vao id");
                s.id = Convert.ToInt32(Console.ReadLine());
                result = sv.GetById(s.id);
            } while (result != null);



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
            System.Console.WriteLine("nhap vao id sinh vien can cap nhat");
            int id = int.Parse(Console.ReadLine());
            result = sv.GetById(id);

            if (result != null)
            {
                SinhVien sv2 = new SinhVien();

                System.Console.WriteLine("nhap vao ten");
                sv2.name = Convert.ToString(Console.ReadLine());

                System.Console.WriteLine("nhap vao address");
                sv2.address = Convert.ToString(Console.ReadLine());

                System.Console.WriteLine("nhap vao email");
                sv2.email = Convert.ToString(Console.ReadLine());

                System.Console.WriteLine("nhap vao phone");
                sv2.phoneNumber = Console.ReadLine();
                sv.Update(sv2);
            }

            break;
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
            break;
        case 6:
            break;
        case 7:
            Console.WriteLine("nhap dia chi can tim");
            string address = Console.ReadLine();
            display.display(sv.listByAddress(address));
            break;
        case 8:
            break;
        default:
            break;
    }
} while (chon != null);