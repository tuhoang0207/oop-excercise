using Models;
using Services.ImplementClass;
using StudentManage;


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
} while (chon != null);