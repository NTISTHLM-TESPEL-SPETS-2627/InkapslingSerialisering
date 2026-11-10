namespace InkapslingSerialisering;

public class Hero
{
  private int _hp;
  private int _maxHp = 100;

  public int Hp
  {
    set {
      _hp = Math.Clamp(value, 0, _maxHp);
    }
    get => _hp;
  }

  public string Name { get; set; }

  // public void SetHp(int value)
  // {
  //   _hp = value;
  //   _hp = Math.Clamp(_hp, 0, _maxHp);
  // }

  // public int GetHp() => _hp;
}
