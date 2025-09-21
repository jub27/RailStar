using System;
using System.Collections.Generic;
using UnityEngine;

public class BattleSceneManager : MonoBehaviour
{
    [SerializeField] private Enemy enemyPrefab;
    [SerializeField] private Transform[] enemySpawnTransform;
    private HashSet<Enemy> enemySet;

    private void Awake()
    {
        enemySet = new HashSet<Enemy>();
    }

    private void Start()
    {
        for (int i = 0; i < enemySpawnTransform.Length; i++)
        {
            var enemy = Instantiate(enemyPrefab, enemySpawnTransform[i]);
            enemy.transform.localScale = Vector3.one;
            enemy.transform.localPosition = Vector3.zero;
            enemy.transform.localRotation = Quaternion.identity;
            enemySet.Add(enemy);
        }
    }
}