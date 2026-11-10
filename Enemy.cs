namespace InkapslingSerialisering;

public class Enemy
{
  public void Attack(Hero target)
  {
    target.Hp -= 10;
  }
}
