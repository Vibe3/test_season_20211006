using UnityEngine;    //�ޥ�Unity �����R�W�Ŷ�:�i�H�ϥΦ��Ŷ���API

// ������
// �� 2021
// class ���O:�@�Ӫ����Ź�
//�y�k:���O ���O�W�� {���O���e (���O����) }
//�����O�n�b Unity ���ϥΥ����~�� MonoBehaviour
public class Car : MonoBehaviour
{
    #region
    private void Start()
    {
        Test();
        Drive80();
    }
    #endregion

    #region
    private void Test()
    {
        print("���o�A�U�w");

    }
    private void Drive80()
    {
        print("�}���ɳt:" + 80);
    }
    #endregion
}