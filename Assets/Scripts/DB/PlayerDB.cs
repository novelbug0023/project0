using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerDataBass
{
    public int Gold = 100;
    public int Dia = 1;
    public string KINDS;
    public int AttackPint = 5;
    public int hp = 100;
    public int maxhp = 100;
    #region X��ų
    public enum XSKILL_ATTACK
    {
        X_2001/*����*/
      , X_2002/*������*/
      , X_2003/*����*/
      , X_2004/*����*/
      , X_2005/*�⺻�䳳��*/
    }
    public XSKILL_ATTACK Xskill_Attack;
    #endregion
    #region C��ų
    public enum CSKILL_ATTACK
    {
        C_2001/*����*/
      , C_2002/*������*/
      , C_2003/*����*/
      , C_2004/*����*/
      , C_2005/*�⺻�䳳��*/
    }
    public CSKILL_ATTACK Cskill_Attack;
    #endregion
    #region V��ų
    public enum VSKILL_ATTACK
    {
        V_2001/*����*/
      , V_2002/*������*/
      , V_2003/*����*/
      , V_2004/*����*/
      , V_2005/*�⺻�䳳��*/
    }
    public VSKILL_ATTACK Vskill_Attack;
    #endregion
}
public class PlayerDB : MonoBehaviour
{
    #region �̱���
    private static PlayerDB instance = null;
    void Awake()
    {
        if (null == instance)
        {
            //�� Ŭ���� �ν��Ͻ��� ź������ �� �������� instance�� ���ӸŴ��� �ν��Ͻ��� ������� �ʴٸ�, �ڽ��� �־��ش�.
            instance = this;

            //�� ��ȯ�� �Ǵ��� �ı����� �ʰ� �Ѵ�.
            //gameObject�����ε� �� ��ũ��Ʈ�� ������Ʈ�μ� �پ��ִ� Hierarchy���� ���ӿ�����Ʈ��� ��������, 
            //���� �򰥸� ������ ���� this�� �ٿ��ֱ⵵ �Ѵ�.
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            //���� �� �̵��� �Ǿ��µ� �� ������ Hierarchy�� GameMgr�� ������ ���� �ִ�.
            //�׷� ��쿣 ���� ������ ����ϴ� �ν��Ͻ��� ��� ������ִ� ��찡 ���� �� ����.
            //�׷��� �̹� ���������� instance�� �ν��Ͻ��� �����Ѵٸ� �ڽ�(���ο� ���� GameMgr)�� �������ش�.
            Destroy(this.gameObject);
        }
    }

    //���� �Ŵ��� �ν��Ͻ��� ������ �� �ִ� ������Ƽ. static�̹Ƿ� �ٸ� Ŭ�������� ���� ȣ���� �� �ִ�.
    public static PlayerDB Instance
    {
        get
        {
            if (null == instance)
            {
                return null;
            }
            return instance;
        }
    }
    #endregion

    public PlayerDataBass DB;
    public void Update()
    {
        if (DB.hp < 0)
        {
            DB.hp = 0;
        }
    }
}
