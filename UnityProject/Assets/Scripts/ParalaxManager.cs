using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParalaxManager : MonoBehaviour
{
    [SerializeField] private Transform _paralaxPivot;
    [SerializeField] private float _speedMultiplier;

    public static ParalaxManager Instance;

    public Transform GetParalaxPivot() => _paralaxPivot;

    public float GetSpeedMultiplier() => _speedMultiplier;
    private void Awake()
    {
        Instance = this;
    }
    private IEnumerator Start()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            _speedMultiplier += 0.2f;
        }
    }

}
