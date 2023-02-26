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
    }
}