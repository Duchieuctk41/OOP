using System;
using System.IO;

namespace baithiC_
{
  public class QLGV : IODatabase, IBaoMat
  {
    private GiaoVien[] dsGiaoVien;
    private int tongSo;
    private int MAX = 100;

    public QLGV()
    {
      tongSo = 0;
      dsGiaoVien = new GiaoVien[MAX];
    }

    public void NhapDSGV()
    {
      while (true)
      {
        Console.Write("Nhap vao so giao vien: ");
        bool isValid = int.TryParse(Console.ReadLine(), out tongSo);
        if (isValid)
          break;
      }
      for (int i = 0; i < tongSo; i++)
      {
        Console.WriteLine("Nhap thong tin giao vien thu {0}", i + 1);
        Console.Write("Nhap vao ma so: "); var maSo = Console.ReadLine();
        Console.Write("Nhap vao ho va ten dem: "); var ho = Console.ReadLine();
        Console.Write("Nhap vao ten: "); var ten = Console.ReadLine();
        Console.Write("Nhap vao bo mon: "); var boMon = Console.ReadLine();

        dsGiaoVien[i] = new GiaoVien(ho, ten, maSo, boMon);
      }
    }

    public void Xuat_1_GV(GiaoVien gv)
    {
      Console.WriteLine(" |{0} | {1} | {2} | {3} | {4} |", gv.ID, gv.MaSo, gv.HoDem, gv.Ten, gv.BoMon);
    }

    public void XuatDSGV()
    {
      Console.WriteLine("Tong so giao vien trong danh sach: {0}", tongSo);
      Console.WriteLine(" |{0} | {1} | {2} | {3} | {4} |", "ID", "MaSo", "HoDem", "Ten", "BoMon");

      for (int i = 0; i < tongSo; i++)
      {
        Xuat_1_GV(dsGiaoVien[i]);
        Console.WriteLine();
      }
    }

    public void TimKiem_HoTen(string ho, string ten)
    {
      int dem = 0;
      for (int i = 0; i < tongSo; i++)
      {
        if (dsGiaoVien[i].HoDem == ho && dsGiaoVien[i].Ten == ten)
        {
          Xuat_1_GV(dsGiaoVien[i]);
          dem++;
        }
      }
      if (dem == 0)
        Console.WriteLine("Khong tim thay giao vien co ho ten: {0} {1}", ho, ten);
    }

    public GiaoVien TimKiem_MaSo(string maSo)
    {

      for (int i = 0; i < tongSo; i++)
      {
        if (dsGiaoVien[i].Ten == maSo)
          return dsGiaoVien[i];
      }
      return null;
    }

    public void Read(string filename)
    {
      FileStream fs = new FileStream(filename, FileMode.Open);
      StreamReader reader = new StreamReader(fs);

      tongSo = int.Parse(GiaiMa(reader.ReadLine()));

      for (int i = 0; i < tongSo; i++)
      {
        var id = GiaiMa(reader.ReadLine());
        var maSo = GiaiMa(reader.ReadLine());
        var ho = GiaiMa(reader.ReadLine());
        var ten = GiaiMa(reader.ReadLine());
        var boMon = GiaiMa(reader.ReadLine());

        dsGiaoVien[i] = new GiaoVien(ho, ten, maSo, boMon);
      }

      reader.Close();
      fs.Close();
    }

    public void Write(string filename)
    {

    }

    public string MaHoa(string data)
    {
      string chuoiMaHoa = "";
      return chuoiMaHoa;
    }

    public string GiaiMa(string data)
    {
      string chuoiGiaiMa = "";
      return chuoiGiaiMa;
    }
  }

}