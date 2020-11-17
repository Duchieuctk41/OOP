using System;
namespace C_
{
  public class HCN
  {
    public int _rong;
    public int _dai;

    public HCN() { }

    public HCN(int dai, int rong)
    {
      _dai = dai;
      _rong = rong;
    }

    public void SetHCN()
    {
      Console.WriteLine("Nhap dai: ");
      _dai = Int32.Parse(Console.ReadLine());

      Console.WriteLine("Nhap rong: ");
      _dai = Int32.Parse(Console.ReadLine());
    }

    public void TinhDienTich()
    {
      int S;
      Console.WriteLine("Dien tich hinh chu nhat: ");
      S = _dai * _rong;
      Console.WriteLine(S);
    }
  }
}
