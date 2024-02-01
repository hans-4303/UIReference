using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorChange : MonoBehaviour
{
    /// <summary>
    /// <para>
    ///     �������� Toggle ��� �ͼ� ����ϴ� ���̽�
    /// </para>
    /// </summary>
    public Toggle toggle;

    /// <summary>
    /// <para>
    ///     ����� ���� ���� ��� ����
    /// </para>
    /// </summary>
    private void Start ()
    {
        if (toggle != null) Debug.Log(toggle.isOn);
    }

    /// <summary>
    /// <para>
    ///     �� ������Ʈ ������ ������ �ͼ� ������ �ٸ��� ����
    /// </para>
    /// </summary>
    public void ChangeColor (bool isOn)
    {
        if (isOn) this.GetComponent<Renderer>().material.color = Random.ColorHSV();
        else this.GetComponent<Renderer>().material.color = Color.white;
    }
}
