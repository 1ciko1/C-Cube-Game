﻿using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    // 2.kodlama kısmı
    
    public Transform player;
    public Vector3 offset;

    // Update is called once per frame
    void Update()   
    {
        transform.position = player.position + offset;
    }
}
