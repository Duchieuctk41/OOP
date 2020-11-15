using System;

namespace baithiC_
{
  class Program
  {
    static void Main(string[] args)
    {
    string path = @"E:\OOP\baithiC#\data.txt";

      QLGV quanly = new QLGV();
      quanly.NhapDSGV();
      quanly.XuatDSGV();
      quanly.Write(path);

      Console.WriteLine("Ghi du lieu thanh cong");

      Console.WriteLine("Nhap ten giao vien can tim: ");
      var ten = Console.ReadLine();
      quanly.TimKiem_Ten(ten);

      Console.WriteLine("Nhap MSGV can tim: ");
      var ms = Console.ReadLine();
      var gv = quanly.TimKiem_MaSo(ms);

      if(gv == null)
        Console.WriteLine("Khong tim thay MSGV {0} can tim:");
      else
        quanly.Xuat_1_GV(gv);

      Console.WriteLine("Tim kiem ho ten giao vien:");
      Console.WriteLine("Nhap ho giao vien can tim: ");
      var ho = Console.ReadLine();
      Console.WriteLine("Nhap ten giao vien can tim: ");
      ten = Console.ReadLine();
      quanly.TimKiem_HoTen(ho, ten);

      Console.ReadLine();


    }
  }
}
