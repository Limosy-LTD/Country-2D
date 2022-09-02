using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using Photon.Chat;
using ExitGames.Client.Photon;

public class ChatManeger : MonoBehaviour, IChatClientListener
{
    ChatClient chatClient;
    [SerializeField] string userId;

    [SerializeField] Text chatText;
    [SerializeField] InputField textMessage;
    [SerializeField] InputField textUserName;

    [Header("Login")]
    [SerializeField] InputField inputName;

    [SerializeField] bool devoloper;
    [SerializeField] bool tester;

    public bool connect;

    public void DebugReturn(DebugLevel level, string message)
    {
        Debug.Log($"{level},{message}");
    }

    public void OnChatStateChange(ChatState state)
    {
        Debug.Log(state);
    }

    public void OnConnected()
    {
        chatText.text += "\nВы подключились к чату! ";
        chatClient.Subscribe("globalChat");
    }

    public void OnDisconnected()
    {
        chatText.text += "\nВы отключились от чата! ";
        chatClient.Unsubscribe(new string[] { "globalChat" });
    }

    public void OnGetMessages(string channelName, string[] senders, object[] messages)
    {
        for (int i = 0; i < senders.Length; i++)
        {
            if (!devoloper && !tester)
            {
               chatText.text += $"\n[{channelName}] {senders[i]}: {messages[i]}";
            }
        }
    }

    public void OnPrivateMessage(string sender, object message, string channelName)
    {
        chatText.text += $"\n(Приватное собщение от {sender}): {message}";
    }

    public void OnStatusUpdate(string user, int status, bool gotMessage, object message)
    {
        throw new System.NotImplementedException();
    }

    public void OnSubscribed(string[] channels, bool[] results)
    {
        for (int i = 0; i < channels.Length; i++)
        {
            chatText.text += $"\nВы подключены к {channels[i]}";  
        }
    }

    public void OnUnsubscribed(string[] channels)
    {
        for (int i = 0; i < channels.Length; i++)
        {
            chatText.text += $"\nВы отключины от {channels[i]}";  
        }
    }

    public void OnUserSubscribed(string channel, string user)
    {
        chatText.text += $"\nПользователь {user} подключился к {channel}";
    }

    public void OnUserUnsubscribed(string channel, string user)
    {
        chatText.text += $"\nПользователь {user} отключился от {channel}";
    }

    private void Start()
    {
        chatClient = new ChatClient(this);
    }

    private void Update()
    {
        chatClient.Service();
    }

    public void SendButton()
    {
        if (textUserName.text == "")
        {
            chatClient.PublishMessage("globalChat", textMessage.text);
        }
        else
        {
            chatClient.SendPrivateMessage(textUserName.text, textMessage.text);
        }
    }

    public void LoginButton()
    {
        if (!connect)
        {
            if(inputName.text == "")
            {
                int id = Random.Range(1, 999);
                userId = "user" + id;
            }
            else
            {
                userId = inputName.text;
            }

            chatClient.Connect(PhotonNetwork.PhotonServerSettings.AppSettings.AppIdChat, PhotonNetwork.AppVersion, new AuthenticationValues(userId));
            connect = true;
        }
    }

    public void DisconectButton()
    {
        if (connect)
        {
            chatClient.Disconnect();
            connect = false;
        }
    }
}
