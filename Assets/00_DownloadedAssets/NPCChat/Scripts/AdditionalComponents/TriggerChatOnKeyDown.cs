namespace TurnTheGameOn.NPCChat
{
    using UnityEngine;

    [RequireComponent(typeof(NPCChat))]
    public class TriggerChatOnKeyDown : MonoBehaviour
    {
        public KeyCode keyCode;
        private NPCChat npcChat;

        void Start()
        {
            npcChat = GetComponent<NPCChat>();
        }

        void Update()
        {
            if (Input.GetKeyDown(keyCode))
            {
                if (npcChat.talking)
                {
                    npcChat.FinishPage();
                }
                else
                {
                    npcChat.StartChat();
                }
            }
        }
    }
}