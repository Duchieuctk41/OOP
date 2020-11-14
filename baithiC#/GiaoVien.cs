namespace baithiC_
{
  public class GiaoVien : Nguoi
  {
    private string _id;
    private string _boMon;

    public string ID {get { return _id; } set { _id = value; } }
    public string BoMon {get { return _boMon; } set { _boMon = value; } }

    public GiaoVien() { _id = "GV"; }

    public GiaoVien(string ho, string ten, string maSo, string boMon): base (ho, ten, maSo)
    {
      _id = "GV";
      _boMon = BoMon;
    }
  }
}