namespace baithiC_
{
  public class Nguoi
  {
    protected string _ho;
    protected string _ten;
    protected string _maSo;

    public Nguoi() { }

    public string HoDem { get { return _ho; } set { _ho = value; } }
    public string Ten { get { return _ten; } set { _ten = value; } }
    public string MaSo { get { return _maSo; } set { _maSo = value; } }

    public Nguoi(string ho, string ten, string maSo)
    {
      _ho = ho;
      _ten = ten;
      _maSo = maSo;
    }
  }
}