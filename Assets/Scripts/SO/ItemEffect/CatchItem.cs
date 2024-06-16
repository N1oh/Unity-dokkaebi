using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "NewCatchItem", menuName = "Item/Catch")]
public class CatchItem : SOItemBase
{
    public override void ExecuteItemEffect(UnitEntity allyUnit)
    {
        Debug.Log("�� �ָӴ�");
        if(GameManager.Instance.g_GameState == GameManager.GameState.BATTLE)
        {
            BattleManager btm = GameObject.Find("BattleManager").GetComponent<BattleManager>();
            btm.g_isCapture = true;
        }
        else
        {
            Debug.Log("���� ��Ȳ���� ��� ����");
        }
    }
}
