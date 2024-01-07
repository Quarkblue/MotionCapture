using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System;

public class UDPRecieve : MonoBehaviour
{
    Thread recieveThread;
    UdpClient client;
    public int port;
    public bool startRecieve = true;
    public bool printToConsole = true;
    public string data;

    // Start is called before the first frame update
    void Start()
    {
        recieveThread = new Thread(new ThreadStart(RecieveData));
        recieveThread.IsBackground = true;
        recieveThread.Start();
        //StartCoroutine(waitAndStart());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator waitAndStart()
    {
        yield return new WaitForSeconds(3);
        startRecieve = true;
    }

    private void RecieveData()
    {
        Debug.Log("started udp recieve");
        client = new UdpClient(port);
        while (startRecieve)
        {
            Debug.Log("while loop started");
            if (GameManager.Instance.StartRecieving)
            {
                Debug.Log("started recieving");
                try
                {
                    IPEndPoint anyIP = new IPEndPoint(IPAddress.Any, 0);
                    byte[] dataByte = client.Receive(ref anyIP);
                    data = Encoding.UTF8.GetString(dataByte);

                    if (printToConsole)
                    {
                        Debug.Log("Recieved data from " + anyIP + ": " + data);
                    }
                }
                catch (Exception e)
                {
                    Debug.Log(e.ToString());
                }
            }
            if (GameManager.Instance.stopRecieving)
            {
                break;
            }
        }
    }

}
