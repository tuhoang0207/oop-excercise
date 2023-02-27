using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Models;
using Services.ImplementClass;
using StudentManage;

namespace StudentManage
{
    public class MenuQlsv
    {
        sinhVienServices sv = new sinhVienServices();
        Display display = new Display();

        public void MenuQLSV() {
            System.Console.WriteLine("================Quan ly sinh vien=================");
            System.Console.WriteLine("0. Quay lai");
            System.Console.WriteLine("1. Them moi");
            System.Console.WriteLine("2. Cap nhat");
            System.Console.WriteLine("3. Xoa");
            System.Console.WriteLine("4. Hien thi danh sach");
            System.Console.WriteLine("5. Hien thi theo id");
            System.Console.WriteLine("6. Hien thi theo ten");
            System.Console.WriteLine("7. Hien thi theo dia chi");
            System.Console.WriteLine("8. Hien thi theo email");
            System.Console.WriteLine("==================================================");

        }

        public void choice(int choice)
        {
           
                switch (choice)
                {
                    case 0:
                    mainMenu mainMenu = new mainMenu();
                    mainMenu.menu();
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
                            sv2.id = id;

                            System.Console.WriteLine("nhap vao ten");
                            sv2.name = Convert.ToString(Console.ReadLine());

                            System.Console.WriteLine("nhap vao address");
                            sv2.address = Convert.ToString(Console.ReadLine());

                            System.Console.WriteLine("nhap vao email");
                            sv2.email = Convert.ToString(Console.ReadLine());

                            System.Console.WriteLine("nhap vao phone");
                            sv2.phoneNumber = Console.ReadLine();
                            sv.Update(result,sv2);
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
                        display.displaySV(result2);
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
                            display.displaySV(result3);
                        }
                        break;
                    case 6:
                        Console.WriteLine("nhap dia chi can tim");
                        string address = Console.ReadLine();
                        display.displaySV(sv.listByAddress(address));
                        break;
                    case 7:
                        Console.WriteLine("nhap email can tim");
                        string email = Console.ReadLine();
                        display.displaySV(sv.listByAddress(email));
                        break;

                    default:
                        break;
                }
         
        }
    }
}