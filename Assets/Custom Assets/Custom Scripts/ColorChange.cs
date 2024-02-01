using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorChange : MonoBehaviour
{
    /// <summary>
    /// <para>
    ///     정적으로 Toggle 들고 와서 사용하는 케이스
    /// </para>
    /// </summary>
    public Toggle toggle;

    /// <summary>
    /// <para>
    ///     토글의 값을 직접 들고 오기
    /// </para>
    /// </summary>
    private void Start ()
    {
        if (toggle != null) Debug.Log(toggle.isOn);
    }

    /// <summary>
    /// <para>
    ///     현 오브젝트 렌더러 가지고 와서 색상을 다르게 대입
    /// </para>
    /// </summary>
    public void ChangeColor (bool isOn)
    {
        if (isOn) this.GetComponent<Renderer>().material.color = Random.ColorHSV();
        else this.GetComponent<Renderer>().material.color = Color.white;
    }
}
