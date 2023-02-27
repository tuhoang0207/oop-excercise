using Models;
using Services.ImplementClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManage
{
    internal class MenuQlgv
    {
        MentorServices mt = new MentorServices();
        Display display = new Display();

        public void menuQlgv()
        {
            System.Console.WriteLine("================Quan ly giao vien=================");
            System.Console.WriteLine("0. Quay lai");
            System.Console.WriteLine("1. Them moi");
            System.Console.WriteLine("2. Cap nhat");
            System.Console.WriteLine("3. Xoa");
            System.Console.WriteLine("4. Hien thi danh sach");
<<<<<<< HEAD
            System.Console.WriteLine("5. Hien thi theo ten");
            System.Console.WriteLine("6. Hien thi theo email");
=======
            System.Console.WriteLine("5. Hien thi các lớp đang dạy");
            System.Console.WriteLine("6. Hien thi theo ten");
            System.Console.WriteLine("7. Hien thi theo email");
>>>>>>> 516197a820526e210814175c4fb17c1691669dfb
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
                    GiangVien result;
                    int tempId;
                    GiangVien gv = new GiangVien();
                    do
                    {
                        System.Console.WriteLine("nhap vao id");
                        tempId = Convert.ToInt32(Console.ReadLine());
                        result = mt.GetById(tempId);
                    } while (result != null);

                    gv.id = tempId;

                    System.Console.WriteLine("nhap vao ten");
                    gv.name = Convert.ToString(Console.ReadLine());

                    System.Console.WriteLine("nhap vao address");
                    gv.address = Convert.ToString(Console.ReadLine());

                    System.Console.WriteLine("nhap vao email");
                    gv.email = Convert.ToString(Console.ReadLine());


                    gv.birthday = DateOnly.FromDateTime(DateTime.Now);

                    System.Console.WriteLine("nhap vao phone");
                    gv.phoneNumber = Console.ReadLine();

                    Console.WriteLine("nhap vao luong");
                    gv.salary = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("nhap vao tien thuong");
                    gv.bonus = Convert.ToInt32(Console.ReadLine());

                    mt.Create(gv);
                    break;
                case 2:
                    System.Console.WriteLine("nhap vao id giao vien can cap nhat");
                    int id = int.Parse(Console.ReadLine());
                    result = mt.GetById(id);

                    if (result != null)
                    {
                        GiangVien gv2 = new GiangVien();
<<<<<<< HEAD
                        gv2.id = id;
=======
>>>>>>> 516197a820526e210814175c4fb17c1691669dfb

                        System.Console.WriteLine("nhap vao ten");
                        gv2.name = Convert.ToString(Console.ReadLine());

                        System.Console.WriteLine("nhap vao address");
                        gv2.address = Convert.ToString(Console.ReadLine());

                        System.Console.WriteLine("nhap vao email");
                        gv2.email = Convert.ToString(Console.ReadLine());

                        System.Console.WriteLine("nhap vao phone");
                        gv2.phoneNumber = Console.ReadLine();
<<<<<<< HEAD

                        gv2.birthday = DateOnly.FromDateTime(DateTime.Now);

                        System.Console.WriteLine("nhap vao luong");
                        gv2.salary = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("nhap vao tien thuong");
                        gv2.bonus= Convert.ToInt32(Console.ReadLine());

                        mt.Update(result, gv2);
=======
                        mt.Update(gv2);
>>>>>>> 516197a820526e210814175c4fb17c1691669dfb
                    }

                    break;
                case 3:
                    System.Console.WriteLine("nhap vao id sinh vien can xoa");
                    id = int.Parse(Console.ReadLine());
                    var result1 = mt.Delete(id);
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
<<<<<<< HEAD
                    var result2 = mt.listAll();
                    display.displayGv(result2);
=======
                    var result2 = sv.listAll();
                    display.displaySV(result2);
>>>>>>> 516197a820526e210814175c4fb17c1691669dfb
                    break;
                case 5:
                    Console.WriteLine("nhap ten can tim");
                    string name = Console.ReadLine();
<<<<<<< HEAD
                    var result3 = mt.getByName(name);
=======
                    var result3 = sv.getByName(name);
>>>>>>> 516197a820526e210814175c4fb17c1691669dfb
                    if (result3 == null)
                    {
                        System.Console.WriteLine("khong co");
                    }
                    else
                    {
<<<<<<< HEAD
                        display.displayGv(result3);
                    }
                    break;
                case 6:
                    Console.WriteLine("nhap email can tim");
                    string email = Console.ReadLine();
                    result = mt.getByEmail(email);
                    display.displayGv(result);

                    break;
                case 7:
                    //Console.WriteLine("nhap email can tim");
                    //string email = Console.ReadLine();
                    //display.displaySV(sv.listByAddress(email));
=======
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
>>>>>>> 516197a820526e210814175c4fb17c1691669dfb
                    break;

                default:
                    break;
            }
        }
    }
}