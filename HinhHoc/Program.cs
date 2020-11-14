using System;

namespace C_
{
  class Program
  {
    static void Main(string[] args)
    {
      var hcn = new HCN();
      var TamGiac = new TamGiac();
      var MaTran = new MaTran();
      try
      {
        hcn.SetHCN();
        Console.WriteLine("Tinh chu vi: {0}", hcn.TinhChuVi());
        Console.WriteLine("Tinh dien tich: {0}", hcn.TinhDienTich());
        Console.ReadLine();

        TamGiac.setTamGiac();
        Console.WriteLine("Tinh chu vi tam giac: {0}", TamGiac.TinhChuVi());
        Console.WriteLine("Tinh dien tich : {0}", TamGiac.TinhDienTich());
        Console.ReadLine();

        MaTran.setMaTran();
        MaTran.CongMaTran();
      }
      catch (FormatException ex)
      {
        Console.WriteLine("Vui long nhap so nguyen! {0}", ex);
      }
      catch (Exception ex)
      {
        Console.WriteLine("Co loi xay ra! {0}", ex);
      }
    }
  }

  public class HCN
  {
    protected int _chieuDai;
    protected int _chieuRong;

    public void SetHCN()
    {
      Console.WriteLine("Nhap chieu dai");
      _chieuDai = int.Parse(Console.ReadLine());

      Console.WriteLine("Nhap chieu rong");
      _chieuRong = int.Parse(Console.ReadLine());
    }

    public int TinhChuVi()
    {
      return (_chieuDai + _chieuRong) * 2;
    }

    public int TinhDienTich()
    {
      return (_chieuDai * _chieuRong);
    }
  }

  public class TamGiac
  {
    protected double _canhA;
    protected double _canhB;
    protected double _canhC;

    public void setTamGiac()
    {
      Console.WriteLine("Nhap chieu danh canh 1: ");
      _canhA = double.Parse(Console.ReadLine());
      Console.WriteLine("Nhap chieu dai canh 2: ");
      _canhB = double.Parse(Console.ReadLine());
      Console.WriteLine("Nhap chieu dai canh 3: ");
      _canhC = double.Parse(Console.ReadLine());
    }

    public double TinhChuVi()
    {
      return _canhA + _canhB + _canhC;
    }

    public double TinhDienTich()
    {
      double p = TinhChuVi() / 2;
      return Math.Sqrt(p * (p - _canhA) * (p - _canhB) * (p - _canhC));
    }
  }

  public class MaTran
  {
    protected int _n;
    protected int _m;

    protected int[,] arr;

    public void setMaTran()
    {
      Console.WriteLine("Nhap so hang: ");
      _n = int.Parse(Console.ReadLine());
      Console.WriteLine("Nhap so cot: ");
      _m = int.Parse(Console.ReadLine());
    }

    public int CongMaTran()
    {
      arr = new int[_n, _m];

      for (int i = 0; i < _n; i++)
      {
        for (int j = 0; j < _m; j++)
        {
          Console.WriteLine("Nhap phan tu tai vi tri a[{0},{1}]", i, j);
          arr[i, j] = int.Parse(Console.ReadLine());
        }
      }
      int answer = 0;
      for (int i = 0; i < _n; i++)
      {
        for (int j = 0; j < _m; j++)
        {
          answer += arr[i, j];
        }
      }
      Console.WriteLine("kq cong ma tran = {0}", answer);
      return answer;
    }
  }
}
