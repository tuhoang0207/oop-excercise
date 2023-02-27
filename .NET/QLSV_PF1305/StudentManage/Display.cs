using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Models;
namespace StudentManage
{
    public class Display
    {
        public void displaySV(List<SinhVien> list) {
            System.Console.WriteLine("ID \t ho ten \t ngay sinh \t email \t sdt \t dia chi \t trang thai");
            foreach (var item in list) {
                System.Console.WriteLine("{0} \t {1} \t {2} \t {3} \t {4} \t {5} \t {6}",
                item.id, item.name,item.birthday,item.email,item.phoneNumber,item.address,item.state);
            }
        }

        public void displayGv(List<GiangVien> list)
        {
            System.Console.WriteLine("ID \t ho ten \t ngay sinh \t email \t sdt \t chuyen mon \t luong \t thuong \t trang thai");
            foreach (var item in list)
            {
                System.Console.WriteLine("{0} \t {1} \t {2} \t {3} \t {4} \t {5} \t {6} \t {7} \t {8}",
                item.id, item.name, item.birthday, item.email, item.phoneNumber, item.majors, item.salary, item.bonus, item.state);
            }
        }

        public void displayGv(GiangVien giangVien)
        {
            Console.WriteLine("id " + giangVien.id);
            Console.WriteLine("name " + giangVien.name);
            Console.WriteLine("email " + giangVien.email);
            Console.WriteLine("phone number " + giangVien.phoneNumber);
            Console.WriteLine("chuyen nganh " + giangVien.majors);
            Console.WriteLine("luong " + giangVien.salary);
            Console.WriteLine("tien thuong " + giangVien.bonus);
        }
    }
}