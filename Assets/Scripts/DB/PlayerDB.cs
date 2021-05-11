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
    #region X스킬
    public enum XSKILL_ATTACK
    {
        X_2001/*마공*/
      , X_2002/*혈마공*/
      , X_2003/*빙공*/
      , X_2004/*정공*/
      , X_2005/*기본토납공*/
    }
    public XSKILL_ATTACK Xskill_Attack;
    #endregion
    #region C스킬
    public enum CSKILL_ATTACK
    {
        C_2001/*마공*/
      , C_2002/*혈마공*/
      , C_2003/*빙공*/
      , C_2004/*정공*/
      , C_2005/*기본토납공*/
    }
    public CSKILL_ATTACK Cskill_Attack;
    #endregion
    #region V스킬
    public enum VSKILL_ATTACK
    {
        V_2001/*마공*/
      , V_2002/*혈마공*/
      , V_2003/*빙공*/
      , V_2004/*정공*/
      , V_2005/*기본토납공*/
    }
    public VSKILL_ATTACK Vskill_Attack;
    #endregion
}
public class PlayerDB : MonoBehaviour
{
    #region 싱글톤
    private static PlayerDB instance = null;
    void Awake()
    {
        if (null == instance)
        {
            //이 클래스 인스턴스가 탄생했을 때 전역변수 instance에 게임매니저 인스턴스가 담겨있지 않다면, 자신을 넣어준다.
            instance = this;

            //씬 전환이 되더라도 파괴되지 않게 한다.
            //gameObject만으로도 이 스크립트가 컴포넌트로서 붙어있는 Hierarchy상의 게임오브젝트라는 뜻이지만, 
            //나는 헷갈림 방지를 위해 this를 붙여주기도 한다.
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            //만약 씬 이동이 되었는데 그 씬에도 Hierarchy에 GameMgr이 존재할 수도 있다.
            //그럴 경우엔 이전 씬에서 사용하던 인스턴스를 계속 사용해주는 경우가 많은 것 같다.
            //그래서 이미 전역변수인 instance에 인스턴스가 존재한다면 자신(새로운 씬의 GameMgr)을 삭제해준다.
            Destroy(this.gameObject);
        }
    }

    //게임 매니저 인스턴스에 접근할 수 있는 프로퍼티. static이므로 다른 클래스에서 맘껏 호출할 수 있다.
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
