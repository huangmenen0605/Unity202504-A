using NaughtyAttributes;
using UnityEngine;
using Dialog_1 = Dialog;

public class NPC : MonoBehaviour
{
   [SerializeField]
   private DialogData dialogData;

   [SerializeField]
   private Dialog Dialog;

   [Button("播放對話")]
   public void playdialog()
   {
      Dialog.SetText(dialogData.diglogTexts[0]);
      Dialog.PlayWriter();
   }
}
