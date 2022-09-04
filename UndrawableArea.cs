using UdonSharp;
using UnityEngine;

namespace UndrawableArea
{
    /// <summary>
    /// QvPenで書けないエリア
    /// </summary>
    public class UndrawableArea : UdonSharpBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            //名前を確認
            if (!other.gameObject.name.Equals("InkCollider")) return;

            //親オブジェクトを取得
            var parent = other.gameObject.transform.parent;
            
            //nullチェック
            if (parent == null) return;

            //線を削除
            Destroy(parent.gameObject);
        }
    }
}